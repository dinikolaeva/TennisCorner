namespace TennisCorner.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using TennisCorner.Services.Data.Tournaments;
    using TennisCorner.Web.ViewModels.Tournaments;

    public class TournamentsController : BaseController
    {
        private readonly ITournamentService tournamentService;

        public TournamentsController(ITournamentService tournamentService)
        {
            this.tournamentService = tournamentService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new TournamentListViewModel
            {
                Tournaments = await this.tournamentService.GetAllTournamentsAsync<TournamentViewModel>(),
            };

            return this.View(viewModel);
        }

        // TODO: make view for tournaments and every tournament have button for details
    }
}
