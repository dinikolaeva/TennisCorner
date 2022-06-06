namespace TennisCorner.Data.Models
{
    using TennisCorner.Data.Common.Models;

    public class Fixture : BaseDeletableModel<int>
    {
        public int TournamentPlayingCategoryId { get; set; }

        public TournamentPlayingCategory TournamentPlayingCategory { get; set; }

        public int FirstRegistrationId { get; set; }

        public int SecondRegistrationId { get; set; }

        public Registration Registration { get; set; }

        // the tournament round for this match, i.e. first round, second round, quarterfinal, semifinal, etc.
        public int Round { get; set; }
    }
}
