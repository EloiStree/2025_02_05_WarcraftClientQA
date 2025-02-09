



using System.Collections.Concurrent;

public class MessageQueueDelayerTask
{
    private readonly ConcurrentQueue<TimestampStringCommandAction> m_messageQueue;
    private readonly CancellationTokenSource m_cancelToken;
    private readonly Task m_backgroundTask;
    public bool m_useConsoleLog = false;

    public MessageQueueDelayerTask(bool useConsoleLog)
    {
        if (useConsoleLog)
            m_useConsoleLog = true;

        m_messageQueue = new ConcurrentQueue<TimestampStringCommandAction>();
        m_cancelToken = new CancellationTokenSource();
        m_backgroundTask = Task.Run(() => ProcessMessages(m_cancelToken.Token));
    }
    public long GetTimestampInMilliseconds()
    {
        return new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();
    }
    public void Addmessage(string message, int delayInMilliseconds)
    {
        AddMessageTimestamp(message, GetTimestampInMilliseconds() + (long)delayInMilliseconds);
    }
    public void AddMessage(string message, float delayInSeconds) {

        AddMessage(message, GetTimestampInMilliseconds() + (long)(delayInSeconds * 1000));
    }

    public void AddMessage(string command, long timestamp, int milliseconds)
    {
        AddMessageTimestamp(command, timestamp + milliseconds);
    }

    public void AddMessage(string command, long timestamp, float seconds)
    {
        AddMessageTimestamp(command, timestamp + (long)(seconds * 1000));
    }

    // Add a message with a scheduled DateTime
    public void AddMessageTimestamp(string message, long timestamp)
    {
        m_messageQueue.Enqueue(new TimestampStringCommandAction() {
            m_command = message,
            m_timestampInMilliseconds = timestamp
        });
    }

    // Gracefully stop the background task
    public void Stop()
    {
        m_cancelToken.Cancel();
        m_backgroundTask.Wait();
    }

    public List<Action<string>> m_handleReadyCommand= new List<Action<string>>();
    public void AddDequeueListener(Action<string> handleReadyCommand)
    {
        m_handleReadyCommand.Add(handleReadyCommand);
    }
    public void RemoveDequeueListener(Action<string> handleReadyCommand)
    {
        m_handleReadyCommand.Remove(handleReadyCommand);
    }

    public List<Action<ChampionThread, object>> m_handlerReadyChampInfo= new List<Action<ChampionThread, object>>();
    public void AddChampionInfoListener(Action<ChampionThread, object> handleReadyChampInfo)
    {
        m_handlerReadyChampInfo.Add(handleReadyChampInfo);
    }
    public void RemoveChampionInfoListener(Action<ChampionThread, object> handleReadyChampInfo)
    {
        m_handlerReadyChampInfo.Remove(handleReadyChampInfo);
    }


    public void PushToListener(string command)
    {

        foreach (Action<string> handleReadyCommand in m_handleReadyCommand)
        {
            if (handleReadyCommand != null)
                handleReadyCommand(command);
        }
    }

    // Background task to process messages
    private async Task ProcessMessages(CancellationToken token)
    {
        while (!token.IsCancellationRequested)
        {
            long currentTime = GetTimestampInMilliseconds();
            while (m_messageQueue.TryPeek(out TimestampStringCommandAction item))
            {
                if (currentTime>= item.GetTimestamp())
                {
                    // Dequeue and process the message
                    m_messageQueue.TryDequeue(out TimestampStringCommandAction dequeuedItem);
                    Console.WriteLine($"Processed: {dequeuedItem.GetCommand()} at {DateTime.Now}");
                    PushToListener(dequeuedItem.GetCommand());
                }
                else
                {
                    // Wait until the next scheduled message
                    break;
                }
            }

            // Delay to prevent tight looping (adjust as needed)
            await Task.Delay(100, token);
        }
    }

    public void AddMacroAsItemsFromLine(string line)
    {
        long timestamp = GetTimestampInMilliseconds();
        long delay = 0;
        if (line == null)
            return;
        string[] items = line.Split(' ');
        foreach (string item in items)
        {
            if (int.TryParse(item, out int delayInMilliseconds))
            {
                delay += delayInMilliseconds;
            }
            else
            {
                AddMessageTimestamp(item, timestamp+delay);
            }
        }
    }
}
