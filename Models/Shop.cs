using System;

namespace FinalProject.Models
{
    public class Shop
    {
        public int ShopId {get; set;} // Primary Key
        public string Description {get; set;} = string.Empty;
        public int ShoeId {get; set;}
        public Shoe Shoe {get; set;} = default!;
    }
}