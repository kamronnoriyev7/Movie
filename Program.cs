public class Program
{
    public static void Main(string[] args)
    {
        Movie Titanic = new Movie()
        {
           Title = "Titanic",
           Director = "James Cameron",
           Genre = "Romantic drama",
           ReleaseYear = 1997,
           Duration = 3 ,
           Rating = "IMDb – 7.9 / 10",
           Language="English",
           IsOscarWinner = 11,
           LeadActor = "Leonardo DiCaprio",
           Budget = "200 000 000 $",
        };
        Titanic.DisplayInfo();
        Titanic.DisplayBudget();
        Console.WriteLine();
        
        Movie Interstellar = new Movie()
        {
            Title = "Interstellar",
            Director = "Christopher Nolan",
            Genre = "Ilmiy-fantastika, Drama",
            ReleaseYear = 2014,
            Duration = 2.49 ,
            Rating = "IMDb – 8.9 / 10",
            Language="English",
            IsOscarWinner = 1,
            LeadActor = "Matthew McConaughey",
            Budget = "165 000 000 $",
        };
        Interstellar.DisplayInfo();
        Interstellar.DisplayBudget();
        
    }
}