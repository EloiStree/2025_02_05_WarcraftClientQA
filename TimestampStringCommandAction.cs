public struct TimestampStringCommandAction
{
    public long m_timestampInMilliseconds;
    public string m_command;

    public long GetTimestamp()
    {
        return m_timestampInMilliseconds;
    }
    public string GetCommand()
    {
        return m_command;
    }
}
