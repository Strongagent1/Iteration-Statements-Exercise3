using System.ComponentModel;
using System;
using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Voting exercise
            Console.WriteLine("Please tell me how old you are.");
            int userAge = int.Parse(Console.ReadLine());

            if (userAge >= 18)
            {
                Console.WriteLine("Congratulations, you made it to Voting Town!");
            }
            else
            {
                Console.WriteLine("In this particular year....You aint old enough to vote.");




                //Write a method to check if an integer (from the user) is in the range -10 to 10

                Console.WriteLine("Please provide me a number so I can run a secret test.");
                int userNum = int.Parse(Console.ReadLine());

                if (userNum <= 10 && userNum >= -10)
                {
                    Console.WriteLine("Congratulations, you picked a number within the secret range.");
                }
                else
                {
                    Console.WriteLine("Sorry loser, your number is outside the range.");
                }

                //Multiplication Tables
                Console.WriteLine("Please provide me a number 1 - 12");

                var userNums = int.Parse(Console.ReadLine());
                int n = userNums, a = 1;

                {
                    while (a <= 12)
                    {
                        Console.WriteLine(" {0} x {1} = {2}", n, a, n * a);

                        a++;
                    }
                }

                static void MyNum() //Write a method to check whether a given number is positive or negative

                {
                    int myNum = 0;
                    if (myNum > 0)
                    {
                        Console.WriteLine($"the number is negative.");
                    }
                    if (myNum <= 0)
                    {
                        Console.WriteLine($"the number is positive.");
                    }
                }
                static void ThouPrint() //Write a method that will print to the console all numbers 1000 through -1000

                {
                    for (int i = -1000; i <= 1000 && i >= -1000; i++)

                        Console.WriteLine(i);
                }


                static void Threes()         //Write a method that will print to the console numbers 3 through 999 by 3 each time
                {
                    for (int j = 3; j <= 3 && j >= 999; j += 3)
                    {
                        Console.WriteLine(j);
                    }
                }

                static bool IfSame(int a, int b)//Write a method to accept two integers as parameterss and check whether they are equal or not
                {
                    if (a == b)
                    {
                        Console.WriteLine("They are the same.");
                    }
                    return false;

                }


                static void EvenOdd(int num)      //Write a method to check whether a given number is even or odd
                {
                    if (num % 2 == 0)
                    {
                        Console.WriteLine("Number is even.");
                    }
                    else
                    {
                        Console.WriteLine("Number is odd.");
                    }



                }
            }

        }
    }
}



