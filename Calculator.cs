using System;
using System.Collections.Generic;
using System.Text;

namespace pracadomowa1
{
    class Calculator
    {
        private double a;
        private double b;
        public Calculator()
        {
           
        }
       
        public void EnterVariables()
        {
            Console.WriteLine("Enter a: ");
            a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        public void Addiction()
        {

            Console.WriteLine(a+b);
        }
        public void Subtraction()
        {

            Console.WriteLine(a - b);
        }
        public void Multiplication()
        {
            Console.WriteLine(a - b);
        }
        public void Division()
        {
            if (b == 0)
            {
               string x="DON'T DIVIDE BY ZERO!!!";
                Console.WriteLine( x);
            }
            else
            {
                Console.WriteLine(a / b);
            }
             
        }
        public void Application()
        {
         
            Console.WriteLine("1.Addiction");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("Enter choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            EnterVariables();
            switch (choice)
            {
                
                case 1:
                    Addiction();
                    break;
                case 2:
                    Subtraction();
                    break;
                case 3:
                    Multiplication();
                    break;
                case 4:
                    Division();
                    break;
                default:
                    Console.WriteLine("EXIT");
                   
                    break;
            }
           
        }
        
    }
}
