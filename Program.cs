using System;

namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            double input,input2,input3,input4,input5 ;

            Console.WriteLine("Input first number");
            input = Convert.ToInt32(Console.ReadLine());
            
            //Second number
            Console.WriteLine("Input second number");
            input2 = Convert.ToInt32(Console.ReadLine());

            //Third number
            Console.WriteLine("Input third number");
            input3 = Convert.ToInt32(Console.ReadLine());

            //Fourth number
            Console.WriteLine("Input fourth number");
            input4 = Convert.ToInt32(Console.ReadLine());

            //LAst number
            Console.WriteLine("Input last number");
            input5 = Convert.ToInt32(Console.ReadLine());

            double result = (input + input2 + input3 + input4 + input5) / 5;
            Console.WriteLine("The average is : "+result);
        }
    }
}
