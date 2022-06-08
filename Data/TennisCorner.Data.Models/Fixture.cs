namespace TennisCorner.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using TennisCorner.Common;
    using TennisCorner.Data.Common.Models;

    public class Fixture : BaseDeletableModel<int>
    {
        public int TournamentPlayingCategoryId { get; set; }

        public TournamentPlayingCategory TournamentPlayingCategory { get; set; }

        public int FirstRegistrationId { get; set; }

        public int SecondRegistrationId { get; set; }

        public Registration Registration { get; set; }

        // the tournament round for this match, i.e. first round, second round, quarterfinal, semifinal, etc.
        [Required]
        [MaxLength(GlobalConstants.StringLengthValidations.RoundsStringLenght)]
        public string Round { get; set; }
    }
}
