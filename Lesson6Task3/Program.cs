using System;

namespace Lesson6Task3
{
    class Program
    {

        /*
            Задание 3
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Используя циклы и метод:
            Console.Write("*"), Console.Write(" "), Console.Write("\n") (для перехода на новую строку).
        Выведите на экран:
        • прямоугольник
        • прямоугольный треугольник
        • равносторонний треугольник
        • ромб
         */

        static void Main(string[] args)
        {

            int height = 9;
            int width = 9;

            Console.Write(new string('-', 10)+"RECTANGLE"+ new string('-', 10)+ "\n\n");
            #region RECTANGLE
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            #endregion


            Console.Write(new string('-', 10) + "TRIANGLE" + new string('-', 10) + "\n\n");
            #region TRIANGLE
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            #endregion

            Console.Write(new string('-', 10) + "Equilateral triangle" + new string('-', 10) + "\n\n");
            # region Equilateral triangle

            for (int i = 1; i <= height; i++)
            {
                Console.Write(new string(' ', height - i) + new string('*', i * 2 - 1) + "\n");
            }
            Console.Write("\n");
            #endregion


            Console.Write(new string('-', 10) + "RHOMBUS" + new string('-', 10) + "\n\n");
            #region RHOMBUS
            for (int i = 1; i <= height; i++)
            {
                Console.Write(new string(' ', height - i) + new string('*', i * 2 - 1) + "\n");
            }
            for (int i = height; i >= 1; i--)
            {
                Console.Write(new string(' ', height - i) + new string('*', i * 2 - 1) + "\n");
            }
            Console.Write("\n");
            #endregion


            Console.Write("\n");
        }
    }
}


//2x-1


//  *
// ***
//*****   3/5
// ***
//  *


//   *
//  ***
// ***** 
//*******  4/7
// ***** 
//  ***
//   *

//    *
//   ***
//  *****
// *******
//*********   5/9
// *******
//  *****
//   ***
//    *
