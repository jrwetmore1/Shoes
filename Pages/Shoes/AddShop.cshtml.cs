using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinalProject.Pages.Shoes
{
    public class AddShopModel : PageModel
    {
        private readonly ILogger<AddShopModel> _logger;
        private readonly ShoeDbContext _context;
        [BindProperty]
        public Shop Shop {get; set;} = default!;
        public SelectList ShoeDropDown {get; set;} = default!;

        public AddShopModel(ShoeDbContext context, ILogger<AddShopModel> logger)
        {
            // Bring in Database context and logger using dependency injection
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            ShoeDropDown = new SelectList(_context.Shoe.ToList(), "ShoeId", "Name");
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Shop.Add(Shop);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}