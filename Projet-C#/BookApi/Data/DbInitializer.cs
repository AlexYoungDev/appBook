using BookApi.Models;

namespace BookApi.Data;

public static class DbInitializer
{
    public static void Seed(AppDbContext context)
    {
        
        if (context.Livres.Any()) return;

        var livres = new List<Media>
        {
            new Ebook { Title = "C# pour les débutants", Author = "Alice", FileFormat = "PDF" },
            new Ebook { Title = "Apprendre ASP.NET", Author = "Bob", FileFormat = "EPUB" },
            new PaperBook { Title = "Le Seigneur des Anneaux", Author = "Tolkien", NumberOfPages = 1137 },
            new PaperBook { Title = "1984", Author = "George Orwell", NumberOfPages = 328 }
        };

        context.Livres.AddRange(livres);
        context.SaveChanges();
    }
}

