namespace TennisCorner.Web.ViewModels.Players
{
    using TennisCorner.Data.Models;
    using TennisCorner.Services.Mapping;

    public class PlayerSimpleViewModel : IMapFrom<Player>
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ImageUrl { get; set; }

        public int? CurrentRank { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}
