using System.Text;
using ClientQA.Ninja;
using System.Net.Sockets;

namespace ClientQA.TeacherCode
{
    public class TeacherProgramArchiveMardi
    {
        public static int Addition(int a, int b)
        {

            return a + b;
        }

        public static void SendUdpMessage(string message, string ipv4 = "127.0.0.1", int port = 7073)
        {

            UdpClient udpClient = new UdpClient(ipv4, port);
            Byte[] sendBytes = Encoding.ASCII.GetBytes(message);
            udpClient.Send(sendBytes, sendBytes.Length);
            udpClient.Close();

        }

        public static void Print(int banane = 20)
        {
            Console.WriteLine("Int:" + banane);
        }
        public static void Print(string message = "e")
        {
            Console.WriteLine("String:" + message);
        }

        public static void ComputeEverything(
            int a,
            int b,
            out int sum,
            out int product,
            out int division,
            out int modulo
            )
        {
            sum = a + b;
            product = a * b;
            division = a / b;
            modulo = a % b;
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static void Add(int a, int b, out int resultOfAddition)
        {
            resultOfAddition = a + b;
        }
        public static void Add(int a, int b, out long resultOfAddition)
        {
            resultOfAddition = ((long)a) + ((long)b);
        }
        public static void Add(int a, int b, out float resultOfAddition)
        {
            resultOfAddition = a + b;
        }

        public static void TeacherMain(params string[] args)
        {
            Add(int.MaxValue, int.MaxValue, out long addition);
            Console.WriteLine("Min" + int.MinValue + " Max" + int.MaxValue);
            Console.WriteLine("Min" + uint.MinValue + " Max" + uint.MaxValue);
            Console.WriteLine("Min" + long.MinValue + " Max" + long.MaxValue);
            Console.WriteLine("Min" + float.MinValue + " Max" + float.MaxValue);
            Console.WriteLine("Min" + double.MinValue + " Max" + double.MaxValue);
            Console.WriteLine("Min" + byte.MinValue + " Max" + byte.MaxValue);
            Console.WriteLine("Min" + short.MinValue + " Max" + short.MaxValue);
            Console.WriteLine("Min" + ushort.MinValue + " Max" + ushort.MaxValue);




            Console.WriteLine("Addition:" + addition);

            ComputeEverything(10, 3,
                out int sum, out int product,
                out int division, out int modulo);
            Console.WriteLine("Sum:" + sum);
            Console.WriteLine("Product:" + product);
            Console.WriteLine("Division:" + division);
            Console.WriteLine("Modulo:" + modulo);

            Print(20);
            int resultat = Addition(1, 3);
            Print(resultat);
            Print("Bonjour");

            string macro = " Q 100 q 100 J 500 J 6000";


            string ipv4 = "10.64.22.20";
            int port = 7073;
            int playerIndex = 0;
            ChampionThread wow = new ChampionThread(ipv4, port, playerIndex);
            while (true)
            {

                Console.WriteLine("Enter a macro:");
                string userMacro = Console.ReadLine().Trim();
                Console.WriteLine("Macro:" + userMacro);
                string[] commands = userMacro.Split(' ');
                Console.WriteLine(commands.Length);


                foreach (string command in commands)
                {
                    Console.WriteLine("Instruction:" + command);
                    if (int.TryParse(command, out int waitTime))
                    {
                        Thread.Sleep(waitTime);
                    }
                    else
                    {
                        switch (command)
                        {

                            case "Q":
                                wow.StartRotateLeft();
                                break;
                            case "q":
                                wow.StopRotateLeft();
                                break;
                            case "J":
                            case "Jump":
                            case "j":
                                wow.TapJump();
                                wow.WaitSomeMilliseconds(200);
                                break;

                            default:

                                Console.WriteLine("Command not recognized");
                                break;
                        }
                    }

                }

            }

            //print("Hello World")
            //Console.WriteLine("Hello World");
            //string name = "Ninja Marcelle";
            //Console.WriteLine(name);
            //name = 3.ToString();
            //Console.WriteLine(name);
            //int age = 30;
            //Console.WriteLine(age);

            //string whatToDisplay = "J'aime les frites";
            //for (int i = 0; i < 10; i = i + 2)
            //{
            //    Console.WriteLine((i + ":") + whatToDisplay);


            //}




            //string address = "127.0.0.1";
            //int port = 3615;
            //port = 7073;
            //NinjaThread ninja = new NinjaThread(address, port, 1);

            //while (true)
            //{
            //    ninja.TapRestart();
            //    ninja.WaitOneSeconds();
            //    ninja.TapShuriken();
            //    ninja.WaitOneSeconds();
            //    ninja.TapSword();
            //    ninja.StartMovingRight();
            //    ninja.WaitOneSeconds();
            //    ninja.StopMovingRight();
            //    ninja.WaitOneSeconds();
            //    ninja.StartMovingLeft();
            //    ninja.WaitOneSeconds();
            //    ninja.StopMovingLeft();
            //    ninja.WaitOneSeconds();
            //    ninja.StartJumping();
            //    ninja.WaitOneSeconds();
            //    ninja.StopJumping();

            //    ninja.TapDoubleJumpInMilliseconds(200);

            //    ninja.WaitOneSeconds();

            //}

        }
        public static void Ping(NinjaThread ninja)
        {



            ninja.TapRestart();
            ninja.WaitSomeMilliseconds(500);
            for (int i = 0; i < 3; i = i + 1)
            {
                ninja.TapShuriken();
                ninja.WaitSomeMilliseconds(500);
            }
            ninja.TapRestart();
            ninja.WaitSomeMilliseconds(500);
        }
    }
}
