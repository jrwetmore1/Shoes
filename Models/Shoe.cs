using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Step 3: Create the data model
namespace FinalProject.Models
{
    public class Shoe
    {
        public int ShoeId {get; set;} // Primary Key
        [Required]
        [StringLength(60, MinimumLength = 1)]
        public string Name {get; set;} = string.Empty;
        [Required]
        [StringLength(60, MinimumLength = 1)]
        public string Color {get; set;} = string.Empty;
        [Required]
        [DataType(DataType.Currency)]
        public string Price {get; set;} = string.Empty;
        public DateTime ReleaseDate {get; set;}
        public List<Shop> Shops {get; set;} = default!;
    }
}