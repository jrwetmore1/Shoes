using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Pages.Shoes
{
    public class IndexModel : PageModel
    {
        private readonly FinalProject.Models.ShoeDbContext _context;

        public IndexModel(FinalProject.Models.ShoeDbContext context)
        {
            _context = context;
        }

        public IList<Shoe> Shoe { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Shoe = await _context.Shoe.ToListAsync();
        }
    }
}
