namespace TennisCorner.Data.Seeding.CustomSeeder
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using TennisCorner.Data.Models;

    public class PlayingCategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.PlayingCategories.Any())
            {
                return;
            }

            var playingCategories = new PlayingCategory[]
            {
                // 1
                new PlayingCategory { CategoryName = "Men's Singles" },

                // 2
                new PlayingCategory { CategoryName = "Women's Singles" },

                // 3
                new PlayingCategory { CategoryName = "Doubles - Men" },

                // 4
                new PlayingCategory { CategoryName = "Doubles - Women" },

                // 5
                new PlayingCategory { CategoryName = "Mixed Doubles" },
            };

            foreach (var playingCategory in playingCategories)
            {
                await dbContext.PlayingCategories.AddAsync(playingCategory);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
