namespace TennisCorner.Web.ViewModels.Tournaments
{
    using System;

    using TennisCorner.Data.Models;
    using TennisCorner.Services.Mapping;

    public class TournamentViewModel : IMapFrom<Tournament>
    {
        public int Id { get; set; }

        public string TournamentName { get; set; }

        public string Location { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int SurfaceId { get; set; }
    }
}
