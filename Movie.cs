public class Movie
{
    public string Title { get; set; } // Film nomi
    
    public string Director { get; set; } 
    
    public string Genre { get; set; } 
    
    public int ReleaseYear { get; set; } 
    
    public double Duration { get; set; } 
    
    public string Rating { get; set; } 
    
    public string Language { get; set; } 
    
    public int IsOscarWinner { get; set; } 
    
    public string LeadActor { get; set; } 
    
    public string Budget { get; set; } 

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
    }

    public void DisplayBudget()
    {
        Console.WriteLine($"Budget: {Budget}");
    }
}