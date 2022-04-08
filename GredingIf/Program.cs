using System;

namespace GredingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            // приложение просит пользователя ввести результат его экзаменв
            //результат экзамена это одна буква от A до F
            //A - Oustanding
            //B - Superior
            //C - Good
            //D - Satisfactory
            //E - Low Pass
            //F - Failure
            // в работе приложения испльзуется if-statements
            Console.WriteLine("Enter your exam results");
            char userInput = Convert.ToChar(Console.ReadLine().ToUpper());

            if(userInput == 'A')
            {
                Console.WriteLine("Outstanding");
            }
            else if (userInput == 'B')
            {
                Console.WriteLine(" Superior");
            }
            else if (userInput == 'C')
            {
                Console.WriteLine(" Good");
            }
            else if (userInput == 'D')
            {
                Console.WriteLine(" Satisfactory");
            }
            else if (userInput == 'E')
            {
                Console.WriteLine("Low Pass");
            }
            else if (userInput == 'F')
            {
                Console.WriteLine("Failure");
            }



        }
    }
}
