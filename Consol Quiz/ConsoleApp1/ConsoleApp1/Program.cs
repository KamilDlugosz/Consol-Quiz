using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Quiz!");
                string answer = null;

                Console.WriteLine("Question 1. What's 2 + 2? ");
                answer = Console.ReadLine();
                if (answer == "4")
                {

                    Console.WriteLine("Correct!");
                    Console.WriteLine("Question 2. Whats 5 + 5?");
                    answer = Console.ReadLine();
                    if (answer == "10")
                    {

                        Console.WriteLine("Correct!");
                        Console.WriteLine("Question 3. Whats 90-56?");
                        answer = Console.ReadLine();
                        if (answer == "34")
                        {

                            Console.WriteLine("Correct!");
                            Console.WriteLine("Question 4. Whats 50-80?");
                            answer = Console.ReadLine();
                            if (answer == "-30")
                            {

                                Console.WriteLine("Correct!");
                                Console.WriteLine("Question 5. Whats 5*4?");
                                answer = Console.ReadLine();
                                if (answer == "20")
                                {

                                    Console.WriteLine("Correct!");
                                    Console.WriteLine("Question 6. Whats 6*6?");
                                    answer = Console.ReadLine();
                                    if (answer == "36")
                                    {

                                        Console.WriteLine("Correct!");
                                        Console.WriteLine("Question 7. Whats 40/5?");
                                        answer = Console.ReadLine();
                                        if (answer == "8")
                                        {

                                            Console.WriteLine("Correct!");
                                            Console.WriteLine("Question 8. Whats 24/6?");
                                            answer = Console.ReadLine();
                                            if (answer == "4")
                                            {

                                                Console.WriteLine("Are you ready to attemp the second part of the quiz?");
                                                Console.WriteLine("If yes press Enter if no type 'exit'");
                                                answer = Console.ReadLine();
                                                if (answer == "")
                                                {

                                                    Console.WriteLine("What command prints something to the screen?");
                                                    answer = Console.ReadLine();
                                                    if (answer == "print")
                                                        Console.WriteLine("");
                                                    {

                                                        Console.WriteLine("Correct!");
                                                        Console.WriteLine("");
                                                        Console.WriteLine("What punctuation ends most lines of code?");
                                                        Console.WriteLine("1. :");
                                                        Console.WriteLine("2. ,");
                                                        Console.WriteLine("3. ;");
                                                        Console.WriteLine("4. /");
                                                        Console.WriteLine("Pick the correct answer by typing one of the numbers!");
                                                        Console.WriteLine("");
                                                        answer = Console.ReadLine();
                                                        if (answer == "3")
                                                        {

                                                            Console.WriteLine("Correct!");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("Which of the following is NOT a web language?");
                                                            Console.WriteLine("1. HTML");
                                                            Console.WriteLine("2. PHP");
                                                            Console.WriteLine("3. Javascript");
                                                            Console.WriteLine("4. C++");
                                                            Console.WriteLine("Pick the correct answer by typing one of the numbers!");
                                                            Console.WriteLine("");
                                                            answer = Console.ReadLine();
                                                            if (answer == "4")
                                                            {

                                                                Console.WriteLine("Correct!");
                                                                Console.WriteLine("");
                                                                Console.WriteLine("When does the code block following while(x < 100) execute?");
                                                                Console.WriteLine("1. When x is less than one hundred");
                                                                Console.WriteLine("2. When x is greater than one hundred");
                                                                Console.WriteLine("3. When x is equal to one hundred");
                                                                Console.WriteLine("4. While it wishes");
                                                                Console.WriteLine("Pick the correct answer by typing one of the numbers!");
                                                                answer = Console.ReadLine();
                                                                if (answer == "1")
                                                                {

                                                                    Console.WriteLine("Correct!");
                                                                    Console.WriteLine("");
                                                                    Console.WriteLine("What is required to avoid falling through from one case to the next?");
                                                                    Console.WriteLine("1. end;");
                                                                    Console.WriteLine("2. break");
                                                                    Console.WriteLine("3. Stop;");
                                                                    Console.WriteLine("4. A semicolon");
                                                                    Console.WriteLine("Pick the correct answer by typing one of the numbers!");
                                                                    answer = Console.ReadLine();
                                                                    if (answer == "2")
                                                                    {

                                                                        Console.WriteLine("Correct!");
                                                                        Console.WriteLine("You have passed the quiz!");
                                                                        Console.WriteLine("Type 'exit' to exit the quiz");
                                                                        Console.WriteLine("Or press Enter to restart");
                                                                        answer = Console.ReadLine();
                                                                    }

                                                                    else
                                                                    {
                                                                        Console.WriteLine("\nWrong! Press any key to restart...\n");
                                                                        Console.ReadKey();
                                                                    }



                                                                    if (answer == "exit")
                                                                    {
                                                                        Environment.Exit(0);
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("\nWrong! Press any key to restart...\n");
                                                                    Console.ReadKey();
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("\nWrong! Press any key to restart...\n");
                                                                Console.ReadKey();
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("\nWrong! Press any key to restart...\n");
                                                            Console.ReadKey();
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("\nWrong! Press any key to restart...\n");
                                                    Console.ReadKey();
                                                }


                                                    
                                                    if (answer == "exit")
                                                    {
                                                        Environment.Exit(0);
                                                    }


                                                }
                                                else
                                                {
                                                    Console.WriteLine("\nWrong! Press any key to restart...\n");
                                                    Console.ReadKey();
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("\nWrong! Press any key to restart...\n");
                                                Console.ReadKey();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nWrong! Press any key to restart...\n");
                                            Console.ReadKey();
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("\nWrong! Press any key to restart...\n");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nWrong! Press any key to restart...\n");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nWrong! Press any key to restart...\n");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nWrong! Press any key to restart...\n");
                            Console.ReadKey();

                        }
                    }
                   
                    else
                    {
                        Console.WriteLine("\nWrong! Press any key to restart...\n");
                        Console.ReadKey();
                        
                    }




                }

            }
        }
    }


