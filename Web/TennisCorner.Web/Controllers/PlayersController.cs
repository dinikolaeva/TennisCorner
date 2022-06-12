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

        public async Task<IActionResult> ManSingle(string input)
        {
            var viewModel = new PlayersListViewModel
            {
                Players = await this.playersService
                                        .GetAllPlayersByGenderAsync<PlayerSimpleViewModel>(input),
            };

            if (!viewModel.Players.Any())
            {
                return new StatusCodeResult(404);
            }

            return this.View(viewModel);
        }
    }
}
