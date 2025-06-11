using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookApi.Data;
using BookApi.Models;

namespace BookApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LivresController : ControllerBase
{
    private readonly AppDbContext _context;

    public LivresController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Media>>> GetAll()
    {
        return await _context.Livres.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Media>> GetById(int id)
    {
        var livre = await _context.Livres.FindAsync(id);
        return livre == null ? NotFound() : Ok(livre);
    }

    [HttpPost]
    public async Task<ActionResult<Media>> Create(Media media)
    {
        _context.Livres.Add(media);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetById), new { id = media.Id }, media);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Media media)
    {
        if (id != media.Id) return BadRequest();

        _context.Entry(media).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var media = await _context.Livres.FindAsync(id);
        if (media == null) return NotFound();

        _context.Livres.Remove(media);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
