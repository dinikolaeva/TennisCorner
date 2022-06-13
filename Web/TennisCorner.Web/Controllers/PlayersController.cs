namespace TennisCorner.Web.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using TennisCorner.Services.Data.Players;
    using TennisCorner.Web.ViewModels.Players;

    public class PlayersController : BaseController
    {
        private readonly IPlayersService playersService;

        public PlayersController(IPlayersService playersService)
        {
            this.playersService = playersService;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        public async Task<IActionResult> MensSingle()
        {
            var viewModel = new PlayersListViewModel
            {
                Players = await this.playersService
                                        .GetAllMalePlayersByGenderAsync<PlayerSimpleViewModel>(),
            };

            if (!viewModel.Players.Any())
            {
                return new StatusCodeResult(404);
            }

            return this.View(viewModel);
        }

        public async Task<IActionResult> MensDetails(int id)
        {
            var viewModel = await this.playersService.GetPlayerByIdAsync<PlayerViewModel>(id);

            if (viewModel == null)
            {
                return new StatusCodeResult(404);
            }

            return this.View(viewModel);
        }

        public async Task<IActionResult> WomensSingle()
        {
            var viewModel = new PlayersListViewModel
            {
                Players = await this.playersService
                                        .GetAllFemalePlayersByGenderAsync<PlayerSimpleViewModel>(),
            };

            if (!viewModel.Players.Any())
            {
                return new StatusCodeResult(404);
            }

            return this.View(viewModel);
        }

        public async Task<IActionResult> WomensDetails(int id)
        {
            var viewModel = await this.playersService.GetPlayerByIdAsync<PlayerViewModel>(id);

            if (viewModel == null)
            {
                return new StatusCodeResult(404);
            }

            return this.View(viewModel);
        }
    }
}
