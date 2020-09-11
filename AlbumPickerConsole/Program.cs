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
                    loopTitleNames(1);
                    ContinueQuestion();
                    break;
                case "2":
                    Console.WriteLine("album 2");
                    loopTitleNames(2);
                    ContinueQuestion();
                    break;
                case "3":
                    Console.WriteLine("Album 3");
                    loopTitleNames(3);
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

<<<<<<< HEAD
            if (Console.ReadLine().Equals("Yes", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("From what album would you like to pull?");
                readUserInput();
            }
            else if(Console.ReadLine().Equals("No", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Thanks for checking out our albums!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("That option does not exist please choose another option.");
                ContinueQuestion();
            }

=======
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
>>>>>>> 3d9b306fa2725ea3e75e11f4e61b58f1b0b28c5d
        }

        static void loopTitleNames(int AlbumNumber)
        {
            //String version of JSON
            WebClient client = new WebClient();
            string rawJson = client.DownloadString("https://jsonplaceholder.typicode.com/photos");

<<<<<<< HEAD
           // AlbumCollection albumCollection = JsonConvert.DeserializeObject<AlbumCollection>(rawJson);
           Album album = JsonConvert.DeserializeObject<Album>(rawJson);
           // Console.WriteLine(albumCollection.Alubums.Count);

            foreach(var song in album)
            {
                if(song.albumId.CompareTo(AlbumName))
                Console.WriteLine(song.id + ' ' + song.title);
=======
            List<Album> album = JsonConvert.DeserializeObject<List<Album>>(rawJson);
            foreach(var item in album)
            {
                if(item.AlbumId.Equals(AlbumNumber))
                {
                    Console.WriteLine("["+ item.Id + "]" + item.Title);
                }
>>>>>>> 3d9b306fa2725ea3e75e11f4e61b58f1b0b28c5d
            }

        }
    }
}
