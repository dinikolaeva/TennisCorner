namespace TennisCorner.Data.Seeding.CustomSeeder
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using TennisCorner.Common;
    using TennisCorner.Data.Models;

    public class TournamentsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Tournaments.Any())
            {
                return;
            }

            var tournaments = new Tournament[]
            {
                // 1
                new Tournament
                {
                    TournamentName = "Australian Open",
                    Location = "Melbourne, Australia",
                    TournamentImageUrl = GlobalConstants.Images.AustraliaOpen2022,
                    ManWinnerImageUrl = GlobalConstants.Images.WinnerNadal,
                    WomanWinnerImageUrl = GlobalConstants.Images.WinnerBarty,
                    FinalsSchemaManImageUrl = GlobalConstants.Images.AOSchemaMan2022,
                    FinalsSchemaWomenImageUrl = GlobalConstants.Images.AOSchemaWomen2022,
                    StartDate = new DateTime(2022, 01, 17),
                    EndDate = new DateTime(2022, 01, 30),
                    SurfaceId = 1,
                },

                // 2
                new Tournament
                {
                    TournamentName = "Roland Garros",
                    Location = "Paris, France",
                    TournamentImageUrl = GlobalConstants.Images.RolandGarros2022,
                    ManWinnerImageUrl = GlobalConstants.Images.WinnerNadalRG,
                    WomanWinnerImageUrl = GlobalConstants.Images.WinnerSwiatek,
                    FinalsSchemaManImageUrl = GlobalConstants.Images.RGSchemaMan2022,
                    FinalsSchemaWomenImageUrl = GlobalConstants.Images.RGSchemaWomen2022,
                    StartDate = new DateTime(2022, 05, 23),
                    EndDate = new DateTime(2022, 06, 05),
                    SurfaceId = 2,
                },

                // 3
                new Tournament
                {
                    TournamentName = "Australian Open",
                    Location = "Melbourne, Australia",
                    TournamentImageUrl = GlobalConstants.Images.AustralianOpen2021,
                    ManWinnerImageUrl = GlobalConstants.Images.WinnerDjokovic,
                    WomanWinnerImageUrl = GlobalConstants.Images.WinnerOsaka,
                    FinalsSchemaManImageUrl = GlobalConstants.Images.AOSchemaMan2021,
                    FinalsSchemaWomenImageUrl = GlobalConstants.Images.AOSchemaWomen2021,
                    StartDate = new DateTime(2021, 02, 08),
                    EndDate = new DateTime(2021, 02, 21),
                    SurfaceId = 1,
                },

                // 4
                new Tournament
                {
                    TournamentName = "Roland Garros",
                    Location = "Paris, France",
                    TournamentImageUrl = GlobalConstants.Images.RolandGarros2021,
                    ManWinnerImageUrl = GlobalConstants.Images.WinnerRGDjokovic2021,
                    WomanWinnerImageUrl = GlobalConstants.Images.WinnerKrejcikova,
                    FinalsSchemaManImageUrl = GlobalConstants.Images.RGSchemaMan2021,
                    FinalsSchemaWomenImageUrl = GlobalConstants.Images.RGSchemaWoman2021,
                    StartDate = new DateTime(2021, 05, 31),
                    EndDate = new DateTime(2021, 06, 13),
                    SurfaceId = 2,
                },

                // 5
                new Tournament
                {
                    TournamentName = "Wimbledon",
                    Location = "Great Britain",
                    TournamentImageUrl = GlobalConstants.Images.Wimbledon2021,
                    ManWinnerImageUrl = GlobalConstants.Images.WinnerWimbledonDjokovic,
                    WomanWinnerImageUrl = GlobalConstants.Images.WinnerWimbledonBarty,
                    FinalsSchemaManImageUrl = GlobalConstants.Images.WimbledonSchemaMan2021,
                    FinalsSchemaWomenImageUrl = GlobalConstants.Images.WimbledonSchemaWoman2021,
                    StartDate = new DateTime(2021, 06, 28),
                    EndDate = new DateTime(2021, 07, 11),
                    SurfaceId = 3,
                },

                // 6
                new Tournament
                {
                    TournamentName = "US Open",
                    Location = "New York, USA",
                    TournamentImageUrl = GlobalConstants.Images.USOpen2021,
                    ManWinnerImageUrl = GlobalConstants.Images.WinnerMedvedev,
                    WomanWinnerImageUrl = GlobalConstants.Images.WinnerRadukanu,
                    FinalsSchemaManImageUrl = GlobalConstants.Images.USOpenSchemaMan2021,
                    FinalsSchemaWomenImageUrl = GlobalConstants.Images.USOpenSchemaWoman2021,
                    StartDate = new DateTime(2021, 08, 30),
                    EndDate = new DateTime(2021, 09, 12),
                    SurfaceId = 1,
                },
            };

            foreach (var tournament in tournaments)
            {
                await dbContext.Tournaments.AddAsync(tournament);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
