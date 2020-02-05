using System;

namespace lab_one
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] answerKey = {"B", "B", "C", "A", "D", "A", "A", "C", "D", "A"};
            string [] userChoices = [10];
            string userSelection;
            string[] questions = {"1.) blah blah blah", "2.) blah blah blah", "3.) blah blah blah",
                                    "4.) blah blah blah", "5.) blah blah blah", "6.) blah blah blah", "7.) blah blah blah",
                                    "8.) blah blah blah", "9.) blah blah blah", "10.) blah blah blah"};
            
            string [,] optionChoices = { 
                                     { "A.) blah", "B.) bloh", "C.) bleha", "D.) bluh"},
                                     { "A.) blah", "B.) bloh", "C.) bleha", "D.) bluh"},
                                     { "A.) blah", "B.) bloh", "C.) bleha", "D.) bluh"},
                                     { "A.) blah", "B.) bloh", "C.) bleha", "D.) bluh"},
                                     { "A.) blah", "B.) bloh", "C.) bleha", "D.) bluh"},
                                     { "A.) blah", "B.) bloh", "C.) bleha", "D.) bluh"},
                                     { "A.) blah", "B.) bloh", "C.) bleha", "D.) bluh"},
                                     { "A.) blah", "B.) bloh", "C.) bleha", "D.) bluh"},
                                     { "A.) blah", "B.) bloh", "C.) bleha", "D.) bluh"},
                                     { "A.) blah", "B.) bloh", "C.) bleha", "D.) bluh"} 
                                                                                        };
            int primingValue;
            string sentinel;
            int x, y;
            int totalCorrect, totalIncorrect;

            Console.WriteLine("Welcome to the quiz on .NET Core. You will be asked to answer 10 questions.",
                               "you may take the quiz as many times as you'd like, but must achive a score of 7/10 to pass");
            Console.WriteLine("To Exit press x otherwise press anykey to continue");

           sentinel = Convert.ToString(Console.ReadKey().Key);
            while (sentinel != ("x"))
            {
                for (x = 0; x < questions.Length; x++)
                {
                    for (y = 0; y < optionChoices[x,y]; y++)
                    {
                        Console.Write(optionChoices[x,y]);
                    }
                    Console.Write("Plese enter your selection");
                    userSelection = Convert.ToString(Console.ReadKey());

                    totalCorrect = 0;
                    totalIncorrect = 0;

                    if (userSelection == answerKey[x])
                    {
                        totalCorrect++;
                        Console.Write("You got it correct");
                    }
                    else
                    {
                        totalIncorrect++;
                        Console.Write("You got it incorrect");
                    }
                    userChoices[x] = userSelection;
                }

                Console.WriteLine("The quiz has ended, your results are listed below");
                Console.WriteLine($"Total Correct {totalCorrect}");
                Console.WriteLine($"Total Incorrect {totalIncorrect}");

                if(totalCorrect >= 2)
                {
                    Console.WriteLine("You passed the Quiz");
                }
                else
                {
                    Console.WriteLine("You failed. Please retake the quiz");
                }

                Console.WriteLine("To retake please ender 1 or enter 2 to exit");
                sentinel = Convert.ToString(Console.ReadKey().Key);
                }
            Console.WriteLine("Thank you for theaking the .Net Core quiz");
            }


        }
    }
}
