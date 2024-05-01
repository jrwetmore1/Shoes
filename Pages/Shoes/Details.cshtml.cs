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

        [BindProperty]
        public int ShopIdToDelete {get; set;}

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoe = await _context.Shoe.Include(m => m.Shops).FirstOrDefaultAsync(m => m.ShoeId == id);
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
            public IActionResult OnPostDeleteShop(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            
            Shop Shop = _context.Shop.FirstOrDefault(m => m.ShopId == ShopIdToDelete);
            
            if (Shop != null)
            {
                _context.Remove(Shop);
                _context.SaveChanges();
            }

            Shoe = _context.Shoe.Include(m => m.Shops).FirstOrDefault(m => m.ShoeId == id);

            return Page();
        }
    }
}

