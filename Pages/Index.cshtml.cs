using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;


namespace Shoes.Pages;

public class IndexModel : PageModel
{
    private readonly ShoeDbContext _context;
    private readonly ILogger<IndexModel> _logger;
    public List<Shoe> Shoes {get; set;} = default!;

    public IndexModel(ShoeDbContext context, ILogger<IndexModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
        Shoes = _context.Shoe.ToList();
    }
}
