namespace BookApi.Models;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class MediaRepository : IRepository<Media>
{
    private static List<Media> _medias = new List<Media>
    {
        new Ebook { Id = 1, Title = "C# for Beginners", Author = "John Doe", FileFormat = "PDF" },
        new PaperBook { Id = 2, Title = "ASP.NET Core Guide", Author = "Jane Smith", NumberOfPages = 300 }
    };

    public Task<IEnumerable<Media>> GetAllAsync()
    {
        return Task.FromResult<IEnumerable<Media>>(_medias);
    }

    public Task<Media> GetByIdAsync(int id)
    {
        var media = _medias.FirstOrDefault(m => m.Id == id);
        if (media == null)
            throw new KeyNotFoundException($"Media with Id {id} not found.");
        return Task.FromResult(media);
    }
}
