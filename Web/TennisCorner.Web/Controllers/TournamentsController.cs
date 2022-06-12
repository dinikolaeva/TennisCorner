namespace TennisCorner.Web.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using TennisCorner.Services.Data.Tournaments;
    using TennisCorner.Web.ViewModels.Tournaments;

    public class TournamentsController : BaseController
    {
        private readonly ITournamentsService tournamentService;

        public TournamentsController(ITournamentsService tournamentService)
        {
            this.tournamentService = tournamentService;
        }

        public async Task<IActionResult> Index(int year)
        {
            var viewModel = new TournamentListViewModel
            {
                Tournaments = await this.tournamentService
                                        .GetAllTournamentsByYearAsync<TournamentSimpleViewModel>(year),
            };

            if (!viewModel.Tournaments.Any())
            {
                return new StatusCodeResult(404);
            }

            return this.View(viewModel);
        }

        public async Task<IActionResult> Details(int id)
        {
            var viewModel = await this.tournamentService
                                      .GetTournamentByIdAsync<TournamentViewModel>(id);

            if (viewModel == null)
            {
                return new StatusCodeResult(404);
            }

            return this.View(viewModel);
        }
    }
}
