using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)

        {
            int number1, number2;

            Console.Write("Enter the First number:");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Second number:");
            number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            
            Console.WriteLine("{0} is the Greater number than {1}" , number1, number2);

            else
             Console.WriteLine("{0} is the Greater number than {1}", number2, number1);

            Console.ReadLine();


         }
        
    }
}
