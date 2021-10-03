using System;

namespace Lesson6Task5
{
    class Program
    {


        //        Задание 5
        //  Используя Visual Studio, создайте проект по шаблону Console Application.
        //  Реализуйте приложение, которое соответствует следующим требованиям:
        //  • при запуске запрашивает у пользователя ввод высоты и ширины прямоугольника, а также - символа для отрисовки прямоугольника
        //  • после успешного ввода данных, выводит, с помощью указанного пользователем символа, прямоугольник заданных пользователем размеров в левом верхнем углу консоли
        //  • позволяет пользователю перемещать прямоугольник по экрану с помощью клавиш W/A/S/D и символов стрелок
        //  • при нажатии клавиши Escape, выводит сообщение о завершении работы
        //  Для реализации управления прямоугольником используйте цикл "Паук".
        //  Полезные для выполнения задания команды консоли:
        //  Очистка окна консоли
        //  Console.Clear();
        //        Считывание нажатой на клавиатуре клавиши, без вывода символа в консоль
        //        ConsoleKey
        //  keyPressed = ConsoleConsole.ReadKey(true).Key;
        //  if(keyPressed == ConsoleKeyConsoleKey.Escape)
        //  {
        // ...
        //}

        static void Main(string[] args)
        {
            bool isNumberH;
            bool isNumberW;
            int height;
            int width;
            char c;
            bool flag = true;


        #region InputHeight
        InputHeight:
            Console.WriteLine("Input height which is less than 20.");                           // here we are checking and setting the height for drawing
            isNumberH = int.TryParse(Console.ReadLine().Trim(), out height);
            if (!isNumberH)
            {
                Console.WriteLine($"Its not a number. Try again");
                goto InputHeight;
            }
            if (height > 20)
            {
                Console.WriteLine($"Number is bigger than 20. Try again.");
                goto InputHeight;
            }
        #endregion

        #region InputWidth
        InputWidth:
            Console.WriteLine("Input width which is less than 20.");                                // here we are checking and setting the width for drawing
            isNumberW = int.TryParse(Console.ReadLine().Trim(), out width);
            if (!isNumberW)
            {
                Console.WriteLine($"Its not a number. Try again");
                goto InputWidth;
            }
            if (width > 20)
            {
                Console.WriteLine($"Number is bigger than 20. Try again.");
                goto InputWidth;
            }
        #endregion

        #region InputChar
        InputChar:
            Console.WriteLine("Choose some of these characters: *, &, #, @.");                      // here we are choosing the characrter for drawing
            string cStr = Console.ReadLine();
            switch (cStr)
            {
                case "*":
                    {
                        c = char.Parse(cStr);
                        break;
                    }


                case "&":
                    {
                        c = char.Parse(cStr);
                        break;
                    }


                case "#":
                    {
                        c = char.Parse(cStr);
                        break;
                    }


                case "@":
                    {
                        c = char.Parse(cStr);
                        break;
                    }

                default:
                    {
                        Console.WriteLine("It is an incorrect character. Try again.");
                        goto InputChar;
                        break;
                    }
            }
            #endregion


            while (flag)
            {

                Console.Clear();

            Start:
                int x = Console.GetCursorPosition().Left;                       // retrieving previous values of X and Y for next console cleaning (122 row)
                int y = Console.GetCursorPosition().Top;

                Console.Clear();                                                // Console cleaning

                Console.SetCursorPosition(x, y);                                // Seting values which are in rows 119 and 120 

                for (int i = 0; i < height; i++)                                // drawing of the rectangle in depence on its X and Y cursor positions
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write(c);
                    }
                    /*Console.SetCursorPosition(x, y+width)*/;
                    Console.SetCursorPosition(x, y + i + 1);
                }


                ConsoleKey keyPressed = Console.ReadKey(true).Key;                  // key reading

                switch (keyPressed)                                                 // simple dirty switch 
                {
                    //////////////////////////// UP

                    case ConsoleKey.UpArrow:
                        {
                            if (y > 0)
                            {
                                if (y > 0)
                                {
                                    Console.SetCursorPosition(x, --y);
                                    goto Start;
                                }
                                else
                                {
                                    Console.SetCursorPosition(x, y);
                                    goto Start;
                                }
                                break;
                            }
                            else
                            {
                                Console.SetCursorPosition(x, y);
                                goto Start;
                            }
                            break;
                        }

                    case ConsoleKey.W:
                        {
                            if (y > 0)
                            {
                                if (y > 0)
                                {
                                    Console.SetCursorPosition(x, --y);
                                    goto Start;
                                }
                                else
                                {
                                    Console.SetCursorPosition(x, y);
                                    goto Start;
                                }
                                break;
                            }
                            else
                            {
                                Console.SetCursorPosition(x, y);
                                goto Start;
                            }
                            break;
                        }

                    ///////////////////////   DOWN

                    case ConsoleKey.DownArrow:
                        {
                            Console.SetCursorPosition(x, ++y);

                            goto Start;

                            break;

                        }

                    case ConsoleKey.S:
                        {
                            Console.SetCursorPosition(x, ++y);

                            goto Start;

                            break;

                        }

                    //////////////////////// LEFT
                    case ConsoleKey.LeftArrow:
                        {
                            if (x > 0)
                            {
                                Console.SetCursorPosition(--x, y);
                                goto Start;
                            }
                            else
                            {
                                Console.SetCursorPosition(x, y);
                                goto Start;
                            }
                            break;
                        }

                    case ConsoleKey.A:
                        {
                            if (x > 0)
                            {
                                Console.SetCursorPosition(--x, y);
                                goto Start;
                            }
                            else
                            {
                                Console.SetCursorPosition(x, y);
                                goto Start;
                            }
                            break;
                        }


                    ////////////////////////// RIGHT

                    case ConsoleKey.RightArrow:
                        {

                            if (x < 120 - width)
                            {
                                Console.SetCursorPosition(++x, y);
                                goto Start;
                            }
                            else
                            {
                                Console.SetCursorPosition(x, y);
                                goto Start;
                            }
                            break;
                        }

                    case ConsoleKey.D:
                        {
                            Console.SetCursorPosition(++x, y);
                            goto Start;
                            break;
                        }

                    ////////////////////////// Exit

                    case ConsoleKey.Escape:
                        {
                            flag = false;
                            break;
                        }
                }
            }
        }
    }
}
