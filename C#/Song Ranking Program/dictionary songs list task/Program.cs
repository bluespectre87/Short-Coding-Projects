using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary_songs_list_task
{
    class Program
    {
        static string rankOrQuitValidation(string choice)
        {
            while (choice.ToLower() != "rank" && choice.ToLower() != "quit")
            {
                Console.WriteLine("invalid input, please choose to either rank your songs or quit");
                choice = Console.ReadLine();
            }

            return choice;
        }
        static string deleteOrChange(string choice)
        {
            while (choice.ToLower() != "delete" && choice.ToLower() != "change")
            {
                Console.WriteLine("invalid input, please choose to either delete or change a song position");
                choice = Console.ReadLine();
            }

            return choice;
        }
        static string yesOrNovalidation(string choice)
        {
            while (choice.ToLower() != "yes" && choice.ToLower() != "no")
            {
                Console.WriteLine("invalid input, respond either yes or no");
                choice = Console.ReadLine();
            }

            return choice;
        }
        
        static string songAlreadypresent(Dictionary<int, string> songs, string song)
        {
            if (songs.ContainsValue(song))
            {
                Console.WriteLine("this song is already present in your ranking, would you like to replace it?");
                string choice = Console.ReadLine();
                choice = yesOrNovalidation(choice);

                if (choice.ToLower() == "yes")
                {
                    Console.WriteLine("enter your new song");
                    song = Console.ReadLine();
                }
            }            
            

            return song;               
            
        }
        static void Main(string[] args)
        {
            Dictionary<int, string> songs = new Dictionary<int, string>();
            string choice = "";
            string song = "";
            int position;

            Console.WriteLine("welcome to 'your top 10 songs compiler' to start ranking your top 10 songs type 'rank' else type 'quit'");
            choice = Console.ReadLine();
            choice = rankOrQuitValidation(choice);

            while (choice.ToLower() == "rank")
            {
                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine("would you like to see your ranking as it stands?");
                    choice = Console.ReadLine();
                    choice = yesOrNovalidation(choice);
                    if (choice.ToLower() == "yes")
                    {
                        foreach (KeyValuePair<int, string>  pair in songs)
                        {
                            Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
                        }
                    }

                    Console.WriteLine("enter the name of your no: " + i + " song");
                    song = Console.ReadLine();
                    song = songAlreadypresent(songs, song);

                    songs.Add(i, song);

                    Console.WriteLine("so far you have ranked {0} songs", songs.Count);
                }

                Console.WriteLine("having ranked 10 songs, your list looks like this:");
                foreach (KeyValuePair<int, string> pair in songs)
                {
                    Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
                }

                Console.WriteLine("would you like to change a song /  position?");
                choice = Console.ReadLine();
                choice = yesOrNovalidation(choice);

                do
                {
                    Console.WriteLine("would you like to completely delete a song (type delete) position or meerly change the song thats there (type change)");
                    choice = Console.ReadLine();
                    choice = deleteOrChange(choice);
                    Console.WriteLine("enter the position of the song you wish to change");
                    position = Convert.ToInt32(Console.ReadLine());

                    if (choice.ToLower() == "change")
                    {
                        Console.WriteLine("what song would you like to replace it with?");
                        song = Console.ReadLine();
                        song = songAlreadypresent(songs, song);

                        songs[position] = song;
                    }
                    else
                    {
                        songs.Remove(position);
                        Console.WriteLine("your list now appears as follows:");
                        foreach (KeyValuePair<int, string> pair in songs)
                        {
                            Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
                        }
                    }
                    
                    Console.WriteLine("would you like to alter another position?");
                    choice = Console.ReadLine();
                    choice = yesOrNovalidation(choice);
                } while (choice.ToLower() == "yes");    
                
            }

            Console.WriteLine("thank you for using my song ranking program, we will now clear you list so you can start a fresh next time!");
            songs.Clear();

            Console.Read();
        }
    }
}
