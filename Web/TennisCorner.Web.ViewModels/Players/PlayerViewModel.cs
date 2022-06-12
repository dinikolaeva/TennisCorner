namespace TennisCorner.Web.ViewModels.Players
{
    using System;

    using TennisCorner.Data.Models;
    using TennisCorner.Services.Mapping;

    public class PlayerViewModel : IMapFrom<Player>
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public string ImageUrl { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age { get; private set; }

        public int? Height { get; set; }

        public int? Weight { get; set; }

        public int CareerWin { get; set; }

        public int CareerLoss { get; set; }

        public int? TotalPoints { get; set; }

        public string Coach { get; set; }

        public int? CurrentRank { get; set; }

        public double TotalPrizeMoney { get; set; }
    }
}
