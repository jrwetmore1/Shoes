using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FinalProject.Models;

namespace FinalProject.Pages.Shoes
{
    public class CreateModel : PageModel
    {
        private readonly FinalProject.Models.ShoeDbContext _context;

        public CreateModel(FinalProject.Models.ShoeDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Shoe Shoe { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Shoe.Add(Shoe);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
