using System;

namespace CursorPositionTesting
{
    class Program
    {
        static void Main(string[] args)
        {
        Strart:

            int x = Console.GetCursorPosition().Left;
            int y = Console.GetCursorPosition().Top;
            Console.Clear();

            Console.SetCursorPosition(x,y);


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("*");
                }

                Console.SetCursorPosition();
            }

            ConsoleKey keyPressed = Console.ReadKey(true).Key;

            switch (keyPressed)
            {
                case ConsoleKey.UpArrow:
                    {
                        if (y > 0)
                        {
                            Console.SetCursorPosition(x, --y);
                            goto Strart;
                        }
                        else
                        {
                            Console.SetCursorPosition(x, y);
                            goto Strart;
                        }
                        break;
                    }

                case ConsoleKey.DownArrow:
                    {
                        Console.SetCursorPosition(x, ++y);
                        
                        goto Strart;

                        break;
                    }

                case ConsoleKey.LeftArrow:
                    {
                        if (x > 0)
                        {
                            Console.SetCursorPosition(--x, y);
                            goto Strart;
                        }
                        else
                        {
                            Console.SetCursorPosition(x, y);
                            goto Strart;
                        }
                        break;
                    }

                case ConsoleKey.RightArrow:
                    {

                        Console.SetCursorPosition(++x, y);
                        goto Strart;

                        break;
                    }
            }

        }
    }
}



//while (flag)
//{

//Strart:

//    int x = Console.GetCursorPosition().Left;
//    int y = Console.GetCursorPosition().Top;

//    for (int i = 0; i < height; i++)
//    {
//        for (int j = 0; j < width; j++)
//        {
//            Console.Write(c);
//        }
//        Console.SetCursorPosition(x, y);
//    }

//    ConsoleKey keyPressed = Console.ReadKey(true).Key;

//    switch (keyPressed)
//    {
//        case ConsoleKey.UpArrow:
//            {
//                if (y > 0)
//                {
//                    Console.SetCursorPosition(x, --y);
//                    goto Strart;
//                }
//                else
//                {
//                    Console.SetCursorPosition(x, y);
//                    goto Strart;
//                }
//                break;
//            }

//        case ConsoleKey.DownArrow:
//            {
//                Console.SetCursorPosition(x, ++y);

//                goto Strart;

//                break;
//            }

//        case ConsoleKey.LeftArrow:
//            {
//                if (x > 0)
//                {
//                    Console.SetCursorPosition(--x, y);
//                    goto Strart;
//                }
//                else
//                {
//                    Console.SetCursorPosition(x, y);
//                    goto Strart;
//                }
//                break;
//            }

//        case ConsoleKey.RightArrow:
//            {

//                Console.SetCursorPosition(++x, y);
//                goto Strart;

//                break;
//            }

//        case ConsoleKey.Escape:
//            {
//                flag = false;
//                break;
//            }
//    }

//}
