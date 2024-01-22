using System;

namespace Interface
{
    internal class Program
    {

        static void Main(string[] args)
        {
            IHasInfo info = new MathematicalSolutions();
            info.ShouInfo();
            info.MessageText();
            Console.ReadLine();
        }
    }
}
