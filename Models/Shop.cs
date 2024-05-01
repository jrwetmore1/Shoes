using System;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Shop
    {
        public int ShopId {get; set;}
        [Required]
        [StringLength(60, MinimumLength = 1)]
        public string Description {get; set;} = string.Empty;
        public int ShoeId {get; set;}
        public Shoe Shoe {get; set;} = default!;
    }
}