namespace TennisCorner.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using TennisCorner.Common;
    using TennisCorner.Data.Common.Models;

    public class FixtureResult : BaseDeletableModel<int>
    {
        public int FixtureId { get; set; }

        public Fixture Fixture { get; set; }

        public int WinnerRegistrationId { get; set; }

        public Registration Registration { get; set; }

        public int NumberOfSetsPlayed { get; set; }

        // when a player is retired from a match, usually due to injury
        [MaxLength(GlobalConstants.StringLengthValidations.IsOpponentRetiredStringLenght)]
        public string IsOpponentRetired { get; set; }
    }
}
