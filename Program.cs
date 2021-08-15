using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace canvasConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangle generator! Made by twokay!");
            Console.WriteLine("It is recommended not to use any triangle sizes above 100!\n");
            Console.WriteLine("To exit the program, say \"exit.\"\nTo clear the console, say \"clear\" or \"clr.\"\n");
            while (true)
            { 
                int maxRowAmount;
                int maxColumnAmount;

                Console.WriteLine("Input your pyramid size!");
                var input = Console.ReadLine();
                try
                {
                    maxRowAmount = Convert.ToInt32(input);
                    maxColumnAmount = (maxRowAmount * 2) - 1;
                }
                catch
                {
                    if ((string) input.ToLower() == "exit")
                        break;
                    else if ((string)input.ToLower() == "clear" || (string)input.ToLower() == "clr")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Invalid value! (Is there a non-number character? Does the number exceed the integer range limit?)\n");
                        continue;
                    }   
                }
                Console.WriteLine($"\nSelected values: \nmaxRowAmount: {maxRowAmount}\nmaxColumnAmount: {maxColumnAmount}\n");
                Console.WriteLine("Displaying triangle: \n");

                for (int row = 0; row < maxRowAmount; row++)
                {
                    for (int spacesAmount = (maxColumnAmount - 1) / 2; spacesAmount > row; spacesAmount--)
                    {
                        Console.Write(" ");
                    }
                    for (double starsAmount = 0.5; starsAmount < row + 1; starsAmount += 0.5)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
