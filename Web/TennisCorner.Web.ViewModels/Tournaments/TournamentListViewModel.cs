namespace TennisCorner.Web.ViewModels.Tournaments
{
    using System.Collections.Generic;

    public class TournamentListViewModel
    {
        public IEnumerable<TournamentViewModel> Tournaments { get; set; }
    }
}
