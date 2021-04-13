using System;
using System.Threading;

namespace Quiz
{
    class Program
    {
        enum Answers {A=1, B, C, D}

        static void Main(string[] args)
        {
            StartScreen();
            QuizLoop();
        }

        public static void StartScreen()
        {
            Console.WriteLine("Are you ready?");
            Console.ReadLine();
            Console.Clear();
        }

        public static void QuizLoop()
        {
            int score = 0;
            int questionAmount = 3;

            for (int i = 0; i < questionAmount; i++)
            {
                int answer = 0;
                PrintQuestion(i, answer);
                Console.Write("\nWhat is your answer? ");
                answer = ReadAnswer();

                if (CheckCorrectAnswer(i, answer))
                {
                    score += 2;
                    PrintQuestion(i, answer);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nCorrect answer :^) !");
                    Console.ResetColor();
                    Console.ReadLine();
                }
                else
                {
                    score -= 1;
                    PrintQuestion(i, answer);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nWrong answer :'( !");
                    Console.ResetColor();
                    Console.ReadLine();
                }
            }

            ResultScreen(score);
        }

        public static void ResultScreen(int score)
        {
            Console.Clear();
            Console.WriteLine("Your final score is...");
            Thread.Sleep(2000);
            Console.Write($"\n {score} ! ");

            if (score == 6)
            {
                Console.WriteLine("PERFECT SCORE!!!");
            }
            else if (score >= 0)
            {
                Console.WriteLine("Could do better!");
            }
            else
            {
                Console.WriteLine("Uh, are you ok?");
            }

            Console.ReadLine();
        }

        public static void PrintQuestion(int question, int answer)
        {
            string[,] questions = new string[3,5] { { "Which direction is the Brazillian statue Christ the Redeemer facing?", "A) North", "B) South", "C) East", "D) West" },
                                                    { "Which planet has the largest moon?", "A) Earth", "B) Saturn", "C) Uranus", "D) Jupiter"},
                                                    { "Accoring to Freud, what is responsible for your sense of morality?", "A) Ego", "B) Superego", "C) Id", "D) Superid" } };
            
            Console.Clear();
            for(int i = 0; i < 5; i++)
            {
                if(answer != 0)
                {
                    if (CheckCorrectAnswer(question, answer) && i == answer)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (!CheckCorrectAnswer(question, answer) && i == answer)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                }

                Console.WriteLine(questions[question, i]);
                Console.ResetColor();
            }
        }

        public static int ReadAnswer()
        {
            int answer = 0;

            while (answer == 0)
            {
                string input = Console.ReadLine().ToUpper();
                switch (input)
                {
                    case "A":
                        answer = 1;
                        break;
                    case "B":
                        answer = 2;
                        break;
                    case "C":
                        answer = 3;
                        break;
                    case "D":
                        answer = 4;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
            return answer;
        }

        public static bool CheckCorrectAnswer(int question, int answer)
        {
            Answers[] correctA = { Answers.C, Answers.D, Answers.B };
            if(correctA[question] == (Answers)answer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
