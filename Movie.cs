public class Movie
{
    public string Title { get; set; } // Film nomi
    
    public string Director { get; set; } // Rejissor ismi
    
    public string Genre { get; set; } // Janr
    
    public int ReleaseYear { get; set; } // Chiqish yili
    
    public double Duration { get; set; } // Davomiyligi (soatlarda)
    
    public string Rating { get; set; } // Reyting (masalan, IMDb reytingi)
    
    public string Language { get; set; } // Film tili
    
    public int IsOscarWinner { get; set; } // Oscar mukofoti olganmi
    
    public string LeadActor { get; set; } // Bosh rol ijrochisi
    
    public string Budget { get; set; } // Byudjet (million dollar)

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
    }

    public void DisplayBudget()
    {
        Console.WriteLine($"Budget: {Budget}");
    }
}