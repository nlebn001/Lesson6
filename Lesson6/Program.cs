using System;

namespace Lesson6
{
    class Program
    {

        /*
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Создайте две целочисленные переменные и задайте им некоторые значения. Применяя технику вложенных циклов, 
            нарисуйте прямоугольник из звездочек. Используйте значения ранее созданных переменных для указания 
            высоты и ширины прямоугольника.
         */

        static void Main(string[] args)
        {

            int height = 5;
            int width = 30;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
