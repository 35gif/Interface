using System;

namespace Interface
{
    internal class MathematicalSolutions : IHasInfo
    {
        public void ShouInfo()
        {
            Console.WriteLine("This is a class that contains mathematical solutions.");
            long text = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("You entered: " + text * text);
        }
        public void MessageText()
        {
            Console.WriteLine("Скажи банка");
            string text = Console.ReadLine();
            if (text == "банка")
            {
                Console.WriteLine("Твоя бабка уебанка\nАхахахахаххахахахахаххахаха");
            }
            else
            {
                Console.WriteLine("Иди нахуй");
            }
        }
    }
}
