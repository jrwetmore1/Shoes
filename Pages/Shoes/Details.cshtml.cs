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
    public class DetailsModel : PageModel
    {
        private readonly FinalProject.Models.ShoeDbContext _context;

        public DetailsModel(FinalProject.Models.ShoeDbContext context)
        {
            _context = context;
        }

        public Shoe Shoe { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoe = await _context.Shoe.FirstOrDefaultAsync(m => m.ShoeId == id);
            if (shoe == null)
            {
                return NotFound();
            }
            else
            {
                Shoe = shoe;
            }
            return Page();
        }
    }
}
