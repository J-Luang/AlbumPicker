using System;

namespace AlbumPickerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //random change
            Console.WriteLine(runQuestion());
            readUserInput();
            ContinueQuestion();
        }

        static void readUserInput()
        {
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("album 1");
                    ContinueQuestion();
                    break;
                case "2":
                    Console.WriteLine("album 2");
                    ContinueQuestion();
                    break;
                case "3":
                    Console.WriteLine("Album 3");
                    ContinueQuestion();
                    break;
                default:
                    Console.WriteLine("Your album does not exist. Please choose another album name or hit Q to quit.");
                    readUserInput();
                    break;
            }
        }

        static string runQuestion()
        {
            string Question;
            Question = "What album would you like to pull?";
            return Question;
        }

        static void ContinueQuestion()
        {
            Console.WriteLine("Would you like pull another album?");

            switch (Console.ReadLine())
            {
                case "Yes":
                    runQuestion();
                    readUserInput();
                    break;
                case "No":
                    Console.WriteLine("Thanks for checking out our albums!");
                    break;
                default:
                    Console.WriteLine("That option does not exist please choose another option.");
                    ContinueQuestion();
                    break;

            }
        }

        static void loopTitleNames(string AlbumName)
        {

        }
    }
}
