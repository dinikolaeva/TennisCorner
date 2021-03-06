namespace TennisCorner.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using TennisCorner.Common;
    using TennisCorner.Data.Common.Models;

    public class Tournament : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(GlobalConstants.StringLengthValidations.TournamentNameStringLenght)]
        public string TournamentName { get; set; }

        [Required]
        [MaxLength(GlobalConstants.StringLengthValidations.LocationStringLenght)]
        public string Location { get; set; }

        [Required]
        public string TournamentImageUrl { get; set; }

        [Required]
        public string ManWinnerImageUrl { get; set; }

        [Required]
        public string WomanWinnerImageUrl { get; set; }

        [Required]
        public string FinalsSchemaManImageUrl { get; set; }

        [Required]
        public string FinalsSchemaWomenImageUrl { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int SurfaceId { get; set; }

        public Surface Surface { get; set; }

        public ICollection<TournamentPlayer> TournamentPlayers { get; set; } = new HashSet<TournamentPlayer>();
    }
}
