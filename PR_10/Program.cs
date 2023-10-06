///////////////////////////////
//Погудин Павел              //
//Практическая работа №10    //
///////////////////////////////

using System;

namespace PR_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tЗдраствуйте!");

            uint columns, lines, counter = 1, exit = 1;

            try
            {
                while (true)
                {
                    try
                    {                        
                        Console.Write("Введите количество строк массива ");
                        lines = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("Введите количество столбцов массива ");
                        columns = Convert.ToUInt32(Console.ReadLine());

                        uint[,] A = new uint[lines, columns];

                        for (int i = 0; i < A.GetLength(0); i++)
                        {
                            for (int j = 0; j < A.GetLength(1); j++)
                            {
                                if ((i + j) % 2 == 0)
                                {
                                    A[i, j] = counter;
                                    counter++;
                                }
                                else A[i, j] = 0;
                                Console.Write("\t" + A[i, j]);
                            }
                            Console.WriteLine();
                        }
                        Console.Write("если хотите закончить то нажмите 0, иначе другую цифру ");
                        exit = Convert.ToUInt32(Console.ReadLine());
                    }
                    catch (IndexOutOfRangeException ioore)            //Исключение, возникающее при попытке обращения к элементу массива или коллекции с индексом, который находится вне границ.
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Неправильная индексация массива. Ошибка: " + ioore.Message);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    catch (InvalidCastException ice)                  //InvalidCastException
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Недопустимое исключение приведения. Ошибка: " + ice.Message);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    catch (ArgumentOutOfRangeException aoore)        //Исключение, которое выдается, если значение аргумента не соответствует допустимому диапазону значений, установленному вызванным методом.
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Исключение аргумента вне диапазона. Ошибка: " + aoore.Message);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    catch (FormatException fe)                       //Исключение, которое возникает в случае, если формат аргумента недопустим или строка составного формата построена неправильно.
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Исключение формата. Ошибка: " + fe.Message);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    catch (Exception e)                              //Exception
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Что то пошло не так. Ошибка: " + e.Message);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    counter = 1;
                    Console.WriteLine(" ");
                    if (exit == 0)
                    {
                        Console.WriteLine("\tДосвидания!");
                        break;
                    }                    
                }
                Console.ReadKey();
            }
            catch (FormatException fe)                              //Исключение, которое возникает в случае, если формат аргумента недопустим или строка составного формата построена неправильно.
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Исключение формата. Ошибка: " + fe.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
