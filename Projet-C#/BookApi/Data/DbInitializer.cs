using BookApi.Models;

namespace BookApi.Data;

public static class DbInitializer
{
    public static void Seed(AppDbContext context)
    {
        // Si des livres existent déjà, on ne fait rien
        if (context.Livres.Any()) return;

        var livres = new List<Media>
        {
            new Ebook { Title = "C# pour les débutants", Author = "Alice", Format = "PDF" },
            new Ebook { Title = "Apprendre ASP.NET", Author = "Bob", Format = "EPUB" },
            new PaperBook { Title = "Le Seigneur des Anneaux", Author = "Tolkien", PageCount = 1137 },
            new PaperBook { Title = "1984", Author = "George Orwell", PageCount = 328 }
        };

        context.Livres.AddRange(livres);
        context.SaveChanges();
    }
}
