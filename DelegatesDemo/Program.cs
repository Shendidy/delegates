using System;
using System.Threading;

namespace DelegatesDemo
{
    class Program
    {
        public delegate void Delegate(string txt);
        public delegate void Delegate2(int num);

        static void Main(string[] args)
        {
            //Delegate d1 = new Delegate(Handler1);
            //Delegate d2 = new Delegate(Handler2);
            //d1 += d2;

            //d1(((int)Enum1.item2).ToString());
            //d2("Hi d2!");

            //Console.WriteLine();

            //// The above is equivalent to:
            //Handler1(((int)Enum1.item2).ToString());
            //Handler2(((int)Enum1.item2).ToString());
            //Handler2("Hi d2!");

            Delegate2 delegate1 = new Delegate2(User1.ShowUser1);
            Delegate2 delegate2 = new Delegate2(User2.ShowUser2);
            Delegate2 delegate3 = new Delegate2(User3.ShowUser3);

            delegate1 += delegate3 + delegate2;

            for(int i = 0; i < 5; i++)
            {
                delegate1(i);
                Thread.Sleep(2000);
            }
        }

        public static void Handler1(string txt)
        {
            Console.WriteLine($"Handler1 says: {txt}");
        }

        public static void Handler2(string txt)
        {
            Console.WriteLine($"Handler2 says: {txt}");
        }
    }


    // Try writing a code here that creates a new class and receives a reference to function in the calling class
    public static class User1
    {
        public static void ShowUser1(int num)
        {
            Console.WriteLine($"User 1: {num + 1}");
        }
    }

    public static class User2
    {
        public static void ShowUser2(int num)
        {
            Console.WriteLine($"User 2: {num + 2}");
        }
    }

    public static class User3
    {
        public static void ShowUser3(int num)
        {
            Console.WriteLine($"User 3: {num + 3}");
        }
    }
}
