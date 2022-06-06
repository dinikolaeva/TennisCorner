namespace TennisCorner.Data.Models
{
    using System.Collections.Generic;

    using TennisCorner.Data.Common.Models;

    public class PlayingIn : BaseDeletableModel<int>
    {
        public int TournamentPlayingCategoryId { get; set; }

        public TournamentPlayingCategory TournamentPlayingCategory { get; set; }

        public int RegistrationId { get; set; }

        public Registration Registration { get; set; }

        // where players are defined by the tournament’s governing body
        public int Seed { get; set; }

        public ICollection<Registration> Registrations { get; set; } = new HashSet<Registration>();
    }
}
