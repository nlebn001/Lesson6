using System;

namespace Lesson6Task4
{
    class Program
    {

//       Имеется N клиентов, которым компания производитель должна доставить товар.Сколько существует возможных маршрутов доставки товара, с учетом того, что товар будет доставлять одна машина?
//       Используя Visual Studio, создайте проект по шаблону Console Application.
//       Напишите программу, которая будет рассчитывать, и выводить на экран количество возможных вариантов доставки товара.Для решения задачи, используйте факториал N!, рассчитываемый с помощью цикла do-while.

        static void Main(string[] args)
        {
            int clients = 5;
            int factorial = 1;
            int counter = 1;
            do
            {
                factorial *= counter++;
            }
            while (counter<=clients);

            Console.WriteLine(factorial);
        }
    }
}


// 1*2*3*4 = 24;
// 1*2*3*4*5 = 120;