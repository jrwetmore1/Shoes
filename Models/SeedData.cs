using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ShoeDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ShoeDbContext>>()))
            {
                if (context == null || context.Shoe == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                if (context.Shoe.Any())
                {
                    return;
                }
                
                context.Shoe.AddRange(
                    new Shoe { 
                        Name = "Air Jordan 4 Military Blue", 
                        Color = "Off-White/Military Blue-Neutral Grey",
                        Price = "$215",
                        ReleaseDate = new DateTime(2024, 05, 04),
                        Shops = new List<Shop> {
                            new Shop {Description = "Nike"}
                        }
                    },
                    new Shoe { 
                        Name = "Air Jordan 11 Low", 
                        Color = "Black/Varsity Royal-White",
                        Price = "$190",
                        ReleaseDate = new DateTime(2024, 05, 18),
                        Shops = new List<Shop> {
                            new Shop {Description = "StockX"}
                        }
                    },
                    new Shoe { 
                        Name = "Air Jordan 12 Red Taxi", 
                        Color = "White/Gym Red-Black",
                        Price = "$200",
                        ReleaseDate = new DateTime(2024, 05, 18),
                        Shops = new List<Shop> {
                            new Shop {Description = "Nike"}
                        }
                    },
                    new Shoe { 
                        Name = "Air Jordan 3 Rio", 
                        Color = "Black/Solar Flare-Total Crimson-Abyss",
                        Price = "$250",
                        ReleaseDate = new DateTime(2024, 05, 22),
                        Shops = new List<Shop> {
                            new Shop {Description = "StockX"}
                        }
                    },
                    new Shoe { 
                        Name = "Air Jordan 17 OG Low Lightning", 
                        Color = "White/Lightning/Black/Chrome",
                        Price = "$300",
                        ReleaseDate = new DateTime(2024, 05, 30),
                        Shops = new List<Shop> {
                            new Shop {Description = "Nike"},
                        }
                    },
                    new Shoe { 
                        Name = "Air Jordan 5 Retro Low GS Hurricanes", 
                        Color = "Football Grey/Brilliant Orange-Pine Green",
                        Price = "$140",
                        ReleaseDate = new DateTime(2024, 06, 01),
                        Shops = new List<Shop> {
                            new Shop {Description = "StockX"},
                        }
                    },
                    new Shoe { 
                        Name = "Air Jordan 6 Reverse Oreo", 
                        Color = "White/Black",
                        Price = "$200",
                        ReleaseDate = new DateTime(2024, 06, 08),
                        Shops = new List<Shop> {
                            new Shop {Description = "Nike"},
                        }
                    },
                    new Shoe { 
                        Name = "Air Jordan 1 Low OG WMNS Gorge Green", 
                        Color = "Black/Gorge Green-Varsity Red-Sail",
                        Price = "$140",
                        ReleaseDate = new DateTime(2024, 06, 12),
                        Shops = new List<Shop> {
                            new Shop {Description = "StockX"},
                        }
                    },
                    new Shoe { 
                        Name = "Air Jordan 3 OG WMNS", 
                        Color = "Bicoastal/Black-Malachite-Fossil",
                        Price = "$225",
                        ReleaseDate = new DateTime(2024, 06, 20),
                        Shops = new List<Shop> {
                            new Shop {Description = "Nike"},
                        }
                    },
                    new Shoe { 
                        Name = "Air Jordan 11 Low WMNS Legend Pink", 
                        Color = "White/Legend Pink",
                        Price = "$190",
                        ReleaseDate = new DateTime(2024, 06, 22),
                        Shops = new List<Shop> {
                            new Shop {Description = "StockX"},
                        }
                    },
                    new Shoe { 
                        Name = "Air Jordan 1 High 85 Metallic Burgundy", 
                        Color = "White/True Red/White",
                        Price = "$200",
                        ReleaseDate = new DateTime(2024, 06, 22),
                        Shops = new List<Shop> {
                            new Shop {Description = "Nike"},
                        }
                    },
                    new Shoe { 
                        Name = "Air Jordan 13 Dune Red", 
                        Color = "Dune Red/Dune Red-Terra Blush-White",
                        Price = "$210",
                        ReleaseDate = new DateTime(2024, 06, 25),
                        Shops = new List<Shop> {
                            new Shop {Description = "StockX"},
                        }
                    },
                    new Shoe { 
                        Name = "Air Jordan 1 High OG WMNS First in Flight", 
                        Color = "University Blue/Midnight Navy-Sail",
                        Price = "$180",
                        ReleaseDate = new DateTime(2024, 07, 06),
                        Shops = new List<Shop> {
                            new Shop {Description = "Nike"},
                        }
                    },
                    new Shoe { 
                        Name = "Air Jordan 4 Oxidized Green", 
                        Color = "White/Oxidized Green-White-Neutral Grey",
                        Price = "$210",
                        ReleaseDate = new DateTime(2024, 07, 13),
                        Shops = new List<Shop> {
                            new Shop {Description = "StockX"},
                        }
                    },
                    new Shoe { 
                        Name = "Air Jordan 1 Low OG Baron", 
                        Color = "White/Black-Wolf Grey",
                        Price = "$140",
                        ReleaseDate = new DateTime(2024, 07, 13),
                        Shops = new List<Shop> {
                            new Shop {Description = "Nike"},
                        }
                    },
                    new Shoe { 
                        Name = "Dunk Low Ultraman", 
                        Color = "Varsity Red/Silver",
                        Price = "$125",
                        ReleaseDate = new DateTime(2024, 05, 03),
                        Shops = new List<Shop> {
                            new Shop {Description = "StockX"},
                        }
                    },
                    new Shoe { 
                        Name = "Dunk Low Pacific Moss", 
                        Color = "White/Pacific Moss",
                        Price = "$115",
                        ReleaseDate = new DateTime(2024, 05, 07),
                        Shops = new List<Shop> {
                            new Shop {Description = "Nike"},
                        }
                    },
                    new Shoe { 
                        Name = "Dunk Low GS Rainbow Swoosh", 
                        Color = "White/Multi-Color-Dark Pony-Light Silver",
                        Price = "$100",
                        ReleaseDate = new DateTime(2024, 05, 17),
                        Shops = new List<Shop> {
                            new Shop {Description = "StockX"},
                        }
                    },
                    new Shoe { 
                        Name = "Dunk Low SB", 
                        Color = "Bleached Aqua/Geode Teal-White",
                        Price = "$135",
                        ReleaseDate = new DateTime(2024, 05, 18),
                        Shops = new List<Shop> {
                            new Shop {Description = "Nike"},
                        }
                    },
                    new Shoe { 
                        Name = "Dunk Low WMNS Tennis Classic", 
                        Color = "White/Photo Blue-Photon Dust-Stadium Green-Summit White",
                        Price = "$125",
                        ReleaseDate = new DateTime(2024, 05, 26),
                        Shops = new List<Shop> {
                            new Shop {Description = "StockX"},
                        }
                    },
                    new Shoe { 
                        Name = "Dunk Low University Red", 
                        Color = "University Red/White-Gum Light Brown-Gym Red",
                        Price = "$135",
                        ReleaseDate = new DateTime(2024, 05, 29),
                        Shops = new List<Shop> {
                            new Shop {Description = "Nike"},
                        }
                    },
                    new Shoe { 
                        Name = "Dunk Low Low Jumbo Chinese New Year", 
                        Color = "Sail/Vapor Green-White-University Red-Bright Crimson",
                        Price = "$130",
                        ReleaseDate = new DateTime(2024, 06, 03),
                        Shops = new List<Shop> {
                            new Shop {Description = "StockX"},
                        }
                    },
                    new Shoe { 
                        Name = "Dunk Low Low Navy Gum", 
                        Color = "Navy/White-Gum Light Brown",
                        Price = "$130",
                        ReleaseDate = new DateTime(2024, 06, 08),
                        Shops = new List<Shop> {
                            new Shop {Description = "Nike"},
                        }
                    },
                    new Shoe { 
                        Name = "Dunk Low Low Visty", 
                        Color = "Blue Gaze/Light Arctic Pink-Bicycle Yellow",
                        Price = "$125",
                        ReleaseDate = new DateTime(2024, 06, 11),
                        Shops = new List<Shop> {
                            new Shop {Description = "StockX"},
                        }
                    },
                    new Shoe { 
                        Name = "Dunk Low Low Safair Olympics", 
                        Color = "Phantom/Black-Monarch-Summit White-Chlorine Blue",
                        Price = "$115",
                        ReleaseDate = new DateTime(2024, 06, 13),
                        Shops = new List<Shop> {
                            new Shop {Description = "Nike"},
                        }
                    }
                );
                context.SaveChanges();
            }
        }
  
    }
}