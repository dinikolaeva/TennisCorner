namespace TennisCorner.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using TennisCorner.Common;
    using TennisCorner.Data.Common.Models;

    public class Country : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(GlobalConstants.StringLengthValidations.CountryAbbreviationStringLenght)]
        public string CountryAbbreviation { get; set; }

        [Required]
        [MaxLength(GlobalConstants.StringLengthValidations.CountryNameStringLenght)]
        public string CountryName { get; set; }

        public ICollection<Player> Players { get; set; } = new HashSet<Player>();
    }
}
