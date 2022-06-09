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

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int SurfaceId { get; set; }

        public Surface Surface { get; set; }
    }
}
