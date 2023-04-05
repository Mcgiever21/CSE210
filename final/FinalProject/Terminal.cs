/*********************************
*                                *
*     Thanks for the code        *
*                                *
*********************************/


using System;

namespace Vehicle_Security
{
    public class Terminal
    {
        public float ReadFloat(string message = "")
        {
            Console.Write(message);
            string input = Console.ReadLine();
            return float.Parse(input);
        }

        public int ReadInt(string message = "")
        {
            Console.Write(message);
            string input = Console.ReadLine();
            return int.Parse(input);
        }

        public string ReadString(string message = "")
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public void Write(string message = "")
        {
            Console.Write(message);
        }

        public void WriteLine(string message = "")
        {
            Console.WriteLine(message);
        }
    }
}