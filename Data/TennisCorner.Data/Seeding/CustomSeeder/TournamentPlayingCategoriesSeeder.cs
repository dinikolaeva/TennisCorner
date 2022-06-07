namespace TennisCorner.Data.Seeding.CustomSeeder
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using TennisCorner.Data.Models;

    public class TournamentPlayingCategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.TournamentPlayingCategories.Any())
            {
                return;
            }

            var tournamentPlayingCategories = new TournamentPlayingCategory[]
            {
                new TournamentPlayingCategory { TournamentId = 1, PlayingCategoryId = 1 },
                new TournamentPlayingCategory { TournamentId = 1, PlayingCategoryId = 2 },
                new TournamentPlayingCategory { TournamentId = 1, PlayingCategoryId = 3 },
                new TournamentPlayingCategory { TournamentId = 1, PlayingCategoryId = 4 },
                new TournamentPlayingCategory { TournamentId = 1, PlayingCategoryId = 5 },

                new TournamentPlayingCategory { TournamentId = 2, PlayingCategoryId = 1 },
                new TournamentPlayingCategory { TournamentId = 2, PlayingCategoryId = 2 },
                new TournamentPlayingCategory { TournamentId = 2, PlayingCategoryId = 3 },
                new TournamentPlayingCategory { TournamentId = 2, PlayingCategoryId = 4 },
                new TournamentPlayingCategory { TournamentId = 2, PlayingCategoryId = 5 },

                new TournamentPlayingCategory { TournamentId = 3, PlayingCategoryId = 1 },
                new TournamentPlayingCategory { TournamentId = 3, PlayingCategoryId = 2 },
                new TournamentPlayingCategory { TournamentId = 3, PlayingCategoryId = 3 },
                new TournamentPlayingCategory { TournamentId = 3, PlayingCategoryId = 4 },
                new TournamentPlayingCategory { TournamentId = 3, PlayingCategoryId = 5 },

                new TournamentPlayingCategory { TournamentId = 4, PlayingCategoryId = 1 },
                new TournamentPlayingCategory { TournamentId = 4, PlayingCategoryId = 2 },
                new TournamentPlayingCategory { TournamentId = 4, PlayingCategoryId = 3 },
                new TournamentPlayingCategory { TournamentId = 4, PlayingCategoryId = 4 },
                new TournamentPlayingCategory { TournamentId = 4, PlayingCategoryId = 5 },

                new TournamentPlayingCategory { TournamentId = 5, PlayingCategoryId = 1 },
                new TournamentPlayingCategory { TournamentId = 5, PlayingCategoryId = 2 },
                new TournamentPlayingCategory { TournamentId = 5, PlayingCategoryId = 3 },
                new TournamentPlayingCategory { TournamentId = 5, PlayingCategoryId = 4 },
                new TournamentPlayingCategory { TournamentId = 5, PlayingCategoryId = 5 },

                new TournamentPlayingCategory { TournamentId = 6, PlayingCategoryId = 1 },
                new TournamentPlayingCategory { TournamentId = 6, PlayingCategoryId = 2 },
                new TournamentPlayingCategory { TournamentId = 6, PlayingCategoryId = 3 },
                new TournamentPlayingCategory { TournamentId = 6, PlayingCategoryId = 4 },
                new TournamentPlayingCategory { TournamentId = 6, PlayingCategoryId = 5 },
            };

            foreach (var tpc in tournamentPlayingCategories)
            {
                await dbContext.TournamentPlayingCategories.AddAsync(tpc);
                await dbContext.SaveChangesAsync();
            };
        }
    }
}
