using System;


namespace colleccions
{
    public class Generic
    {
        public static void ShowMessage(string msg) {
            Console.WriteLine(msg);
        }
        public static bool AreEqual<T> (T value1, T value2) { 
            return value1.Equals(value2);
        }

        public static void Display<T>(string msg, T value)
        {
            Console.WriteLine("{0}:{1}", msg, value);
        }
    }
}
