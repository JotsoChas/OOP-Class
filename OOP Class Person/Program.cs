using OOP_Class_Movie;

namespace OOP_Class_Movie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie myMovie = new Movie("Shutter Island", "Thriller", 7, "https://www.imdb.com/title/tt1130884/");
            myMovie.PrintInfo();
            myMovie.OpenImdb();
        }
    }
}
