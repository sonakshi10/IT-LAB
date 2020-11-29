using System;

namespace q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");
            double num1, num2;
            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();
            double.TryParse(n1, out num1);
            double.TryParse(n2, out num2);
            Console.WriteLine("The result of : \n Addition: {0} + {1} = {2} \n" +
                " Subtraction: {0} - {1} = {3} \n Division: {0} / {1} = {4} \n Multiplication: " +
                "{0} * {1} = {5}", num1, num2, num1+num2, num1-num2, num1/num2, num1*num2);
            Console.ReadLine();

        }
    }
}
