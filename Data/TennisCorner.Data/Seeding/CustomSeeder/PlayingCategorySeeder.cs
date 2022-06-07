namespace TennisCorner.Data.Seeding.CustomSeeder
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using TennisCorner.Data.Models;

    public class PlayingCategorySeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.PlayingCategories.Any())
            {
                return;
            }

            var playingCategories = new PlayingCategory[]
            {
                new PlayingCategory { CategoryName = "Men's Singles" },
                new PlayingCategory { CategoryName = "Women's Singles" },
                new PlayingCategory { CategoryName = "Doubles - Men" },
                new PlayingCategory { CategoryName = "Doubles - Women" },
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
