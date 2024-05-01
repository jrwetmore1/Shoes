using System;
using System.Collections.Generic;

// Step 3: Create the data model
namespace FinalProject.Models
{
    public class Shoe
    {
        public int ShoeId {get; set;} // Primary Key
        public string Name {get; set;} = string.Empty;
        public string Color {get; set;} = string.Empty;
        public string Price {get; set;} = string.Empty;
        public DateTime ReleaseDate {get; set;}
        public List<Shop> Shops {get; set;} = default!;
    }
}