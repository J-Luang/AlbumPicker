using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AlbumPickerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            runQuestion();
            readUserInput();
        }

        static void runQuestion()
        {
            string Question = "What album would you like to pull? (End with a number)";
            Console.WriteLine(Question);
        }

        static void readUserInput()
        {
            Console.Write(">");
            string userInput = Console.ReadLine();
            string [] words = userInput.Split(" ");
            string albumStringNumber = words[words.Length - 1];

            try
            {
                int albumNumber = Int32.Parse(albumStringNumber);
                loopTitleNames(albumNumber);
                ContinueQuestion();
            }
            catch(FormatException)
            {
                Console.WriteLine("That album does not exist.");
                runQuestion();
                readUserInput();
            }
            catch(OverflowException)
            {
                Console.WriteLine("That album number is too large and doesnt exist.");
                runQuestion();
                readUserInput();
            }
        }

        static void loopTitleNames(int AlbumNumber)
        {
            WebClient client = new WebClient();
            string rawJson = client.DownloadString("https://jsonplaceholder.typicode.com/photos");
 
            List<Album> album = JsonConvert.DeserializeObject<List<Album>>(rawJson);

            if (album.Exists(x => x.AlbumId == AlbumNumber))
            {
                foreach (var item in album)
                {
                    if (item.AlbumId.Equals(AlbumNumber))
                    {
                        Console.WriteLine("[" + item.Id + "]" + item.Title);
                    }
                }
            }
            else
            {
                Console.Write("That album does not exist please choose another album\n");
                readUserInput();
            }
        }

        static void ContinueQuestion()
        {
            Console.WriteLine("Would you like pull another album?");
            
            //Attempted to use if statement to ignore case, lead to bug having to input twice
            switch(Console.ReadLine())
            {
                case "Yes":
                    Console.WriteLine("What album would you like to pull?");
                    readUserInput();
                    break;
                case "yes":
                    Console.WriteLine("What album would you like to pull?");
                    readUserInput();
                    break;
                case "No":
                    Console.WriteLine("Thanks for checking out the albums!");
                    Environment.Exit(0);
                    break;
                case "no":
                    Console.WriteLine("Thanks for checking out the albums!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("That option does not exist");
                    ContinueQuestion();
                    break;
            }            
        }
    }
}
