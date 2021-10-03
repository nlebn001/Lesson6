using System;

namespace Lesson6Task2
{
    class Program
    {

        /*
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Дано два числа A и B (A<B) выведите суму всех чисел расположенных между данными числами на экран.
            Дано два числа A и B (A<B) выведите все нечетные значения, расположенные между данными числами.
         */


        static void Main(string[] args)
        {

            string strA;
            string strB;
            int numA;
            int numB;
            int sum = 0;

            bool flag = true;


            while (flag)
            {
            InputA:
                Console.WriteLine("Input A (first) number");
                strA = Console.ReadLine();
                bool isNumA = int.TryParse(strA, out numA);
                if (!isNumA)
                {
                    Console.WriteLine("It is not a number. Try again.");
                    goto InputA;
                }

            InputB:
                Console.WriteLine("Input B (second) number, which is bigger than A (first) number");
                strB = Console.ReadLine();
                bool isNumB = int.TryParse(strB, out numB);

                if (!isNumB)
                {
                    Console.WriteLine("It is not a number. Try again.");
                    goto InputB;
                }
                if (numB <= numA)
                {
                    Console.WriteLine("Your B (second) number is less than A (first) or equals A. Enter any key for start.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    for (int i = numA + 1; i < numB; i++)
                    {
                        sum += i;
                    }

                    Console.WriteLine($"Sum of all numbers between A and B (not including) is: {sum}");
                    sum = 0;

                    for (int i = numA + 1; i < numB; i++)
                    {
                        if (i % 2 != 0)
                        {
                            if (i == numA || i == numA + 1)
                            {
                                Console.Write($"All odd numbers are: {i}");
                            }
                            else
                            {
                                Console.Write($", {i}");
                            }
                        }
                    }
                    Console.Write(".\n");
                    Console.WriteLine();
                }
            }
        }
    }
}
