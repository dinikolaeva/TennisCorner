namespace TennisCorner.Web.ViewModels.Players
{
    using System.Collections.Generic;

    public class PlayersListViewModel
    {
        public IEnumerable<PlayerSimpleViewModel> Players { get; set; }
    }
}
