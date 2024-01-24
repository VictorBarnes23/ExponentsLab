using System;
using System.ComponentModel.Design;

class ExponentsLab
{
    static void Main()
    {
        bool runProgram = true;
        while (runProgram)
        {
            Console.WriteLine("Learn your squares and cubes!");
            Console.WriteLine("Please enter an integer:");
            int userInput = int.Parse(Console.ReadLine());

            Console.WriteLine("NUMBER\t\t\tSQUARED\t\t\tCubed");
            for (int num = 1; num <= userInput; num++)
            {
                Console.WriteLine(num + "\t\t\t" + num * num + "\t\t\t" + num * num * num);
            }
            Console.WriteLine("Would you like to run the this program again? Yes/No");
            string answer = Console.ReadLine().ToLower();
            if (answer == "Yes".ToLower())
            {
                runProgram = true;
            }
            else
            {
                break;
            }
        }
            
        }
    }

















