using System;

namespace pracadomowa1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAM 1 ");

            Console.WriteLine("Enter string: ");
            string text = Console.ReadLine();
            Console.WriteLine("Enter char");
            char sign= Console.ReadLine()[0];
            Console.WriteLine("Enter int");
            int number1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter float");
            float number2 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Enter double");
            double number3= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(text);
            Console.WriteLine(sign);
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);

            Console.WriteLine("KALKULATOR");
            Calculator calculator = new Calculator();
            calculator.Application();






        }
    }
}
