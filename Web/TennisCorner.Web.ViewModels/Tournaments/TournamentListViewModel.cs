namespace TennisCorner.Web.ViewModels.Tournaments
{
    using System.Collections.Generic;

    using TennisCorner.Data.Models;
    using TennisCorner.Services.Mapping;

    public class TournamentListViewModel
    {
        public IEnumerable<TournamentViewModel> Tournaments { get; set; }
    }
}
