using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Class_Person
{
    public class Movie
    { 
        public string Title { get; set; }
        public string Genre { get; set; }
        private int rating;
        public int Rating
        {
            get { return rating; }
            set
            {
                rating = value;

                if (rating >= 7)
                {
                    Console.WriteLine("We recommend this movie!".ToUpper());
                }
                else
                {
                    Console.WriteLine("We don´t recommend this move.");
                }

            }

        }

         public string ImdbUrl { get; set; }

        public Movie(string title, string genre, int rating, string imdbUrl)
        {
            Title = title;
            Genre = genre;  
            Rating = rating;
            ImdbUrl = imdbUrl;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Title} is a {Genre} and received a rating of {Rating} on IMDB.\n");
            Console.WriteLine($"Read more about {Title} here! {ImdbUrl}\n");
        }

        public void OpenImdb()      //Got help from AI to make the utl executable.
        {
            if (!string.IsNullOrEmpty(ImdbUrl))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = ImdbUrl,
                    UseShellExecute = true
                });

            }
        }
        
    }

}
