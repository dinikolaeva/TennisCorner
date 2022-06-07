namespace TennisCorner.Data.Seeding.CustomSeeder
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using TennisCorner.Data.Models;

    public class CountrySeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Countries.Any())
            {
                return;
            }

            var countries = new Country[]
            {
                new Country { CountryAbbreviation = "ANH", CountryName = "Netherlands Antilles" },
                new Country { CountryAbbreviation = "ARG", CountryName = "Argentina" },
                new Country { CountryAbbreviation = "AUS", CountryName = "Australia" },
                new Country { CountryAbbreviation = "AUT", CountryName = "Austria" },
                new Country { CountryAbbreviation = "BAH", CountryName = "Bahamas" },
                new Country { CountryAbbreviation = "BAR", CountryName = "Barbados" },
                new Country { CountryAbbreviation = "BEL", CountryName = "Belgium" },
                new Country { CountryAbbreviation = "BIH", CountryName = "BosniaHerzegovina" },
                new Country { CountryAbbreviation = "BLR", CountryName = "Belarus" },
                new Country { CountryAbbreviation = "BOL", CountryName = "Bolivia" },
                new Country { CountryAbbreviation = "BOM", CountryName = "Bohemia Moravia" },
                new Country { CountryAbbreviation = "BRA", CountryName = "Brazil" },
                new Country { CountryAbbreviation = "BRI", CountryName = "British Isles" },
                new Country { CountryAbbreviation = "BUL", CountryName = "Bulgaria" },
                new Country { CountryAbbreviation = "CAN", CountryName = "Canada" },
                new Country { CountryAbbreviation = "CEY", CountryName = "Ceylon" },
                new Country { CountryAbbreviation = "CHI", CountryName = "Chile" },
                new Country { CountryAbbreviation = "CHN", CountryName = "China, People's Republic of" },
                new Country { CountryAbbreviation = "CIS", CountryName = "Commonwealth of Independent States" },
                new Country { CountryAbbreviation = "CMR", CountryName = "Cameroon" },
                new Country { CountryAbbreviation = "COL", CountryName = "Colombia" },
                new Country { CountryAbbreviation = "CRO", CountryName = "Croatia" },
                new Country { CountryAbbreviation = "CUB", CountryName = "Cuba" },
                new Country { CountryAbbreviation = "CYP", CountryName = "Cyprus" },
                new Country { CountryAbbreviation = "CZE", CountryName = "Czech Republic" },
                new Country { CountryAbbreviation = "DEN", CountryName = "Denmark" },
                new Country { CountryAbbreviation = "ECU", CountryName = "Ecuador" },
                new Country { CountryAbbreviation = "ELA", CountryName = "El Salvador" },
                new Country { CountryAbbreviation = "EGY", CountryName = "Egypt" },
                new Country { CountryAbbreviation = "ESP", CountryName = "Spain" },
                new Country { CountryAbbreviation = "EST", CountryName = "Estonia" },
                new Country { CountryAbbreviation = "FIN", CountryName = "Finland" },
                new Country { CountryAbbreviation = "FRA", CountryName = "France" },
                new Country { CountryAbbreviation = "GEO", CountryName = "Georgia" },
                new Country { CountryAbbreviation = "GBR", CountryName = "Great Britain" },
                new Country { CountryAbbreviation = "GER", CountryName = "Germany (incl. Federal Republic 1946-1990)" },
                new Country { CountryAbbreviation = "GRE", CountryName = "Greece" },
                new Country { CountryAbbreviation = "HAI", CountryName = "Haiti" },
                new Country { CountryAbbreviation = "HKG", CountryName = "Hong Kong China" },
                new Country { CountryAbbreviation = "HUN", CountryName = "Hungary" },
                new Country { CountryAbbreviation = "IND", CountryName = "India" },
                new Country { CountryAbbreviation = "INA", CountryName = "Indonesia" },
                new Country { CountryAbbreviation = "IRI", CountryName = "Iran" },
                new Country { CountryAbbreviation = "IRL", CountryName = "Ireland" },
                new Country { CountryAbbreviation = "ISR", CountryName = "Israel" },
                new Country { CountryAbbreviation = "ITA", CountryName = "Italy" },
                new Country { CountryAbbreviation = "JAM", CountryName = "Jamaica" },
                new Country { CountryAbbreviation = "JAP", CountryName = "Japan" },
                new Country { CountryAbbreviation = "KAZ", CountryName = "Kazakhstan" },
                new Country { CountryAbbreviation = "KEN", CountryName = "Kenya" },
                new Country { CountryAbbreviation = "KZG", CountryName = "Kyrgystan" },
                new Country { CountryAbbreviation = "KOR", CountryName = "Republic of Korea, South" },
                new Country { CountryAbbreviation = "LAT", CountryName = "Latvia" },
                new Country { CountryAbbreviation = "LEB", CountryName = "Lebanon" },
                new Country { CountryAbbreviation = "LIT", CountryName = "Lithuania" },
                new Country { CountryAbbreviation = "LUX", CountryName = "Luxembourg" },
                new Country { CountryAbbreviation = "MAD", CountryName = "Madagascar" },
                new Country { CountryAbbreviation = "MEX", CountryName = "Mexico" },
                new Country { CountryAbbreviation = "MKD", CountryName = "Macedonia" },
                new Country { CountryAbbreviation = "MNE", CountryName = "Montenegro" },
                new Country { CountryAbbreviation = "NED", CountryName = "Netherlands" },
                new Country { CountryAbbreviation = "NZL", CountryName = "New Zealand" },
                new Country { CountryAbbreviation = "NOR", CountryName = "Norway" },
                new Country { CountryAbbreviation = "PAK", CountryName = "Pakistan" },
                new Country { CountryAbbreviation = "PHI", CountryName = "Philippines" },
                new Country { CountryAbbreviation = "POL", CountryName = "Poland" },
                new Country { CountryAbbreviation = "POR", CountryName = "Portugal" },
                new Country { CountryAbbreviation = "PUR", CountryName = "Puerto Rico" },
                new Country { CountryAbbreviation = "RHO", CountryName = "Rhodesia" },
                new Country { CountryAbbreviation = "ROM", CountryName = "Romania" },
                new Country { CountryAbbreviation = "RSA", CountryName = "Republic of South Africa" },
                new Country { CountryAbbreviation = "RUS", CountryName = "Russia" },
                new Country { CountryAbbreviation = "SER", CountryName = "Serbia" },
                new Country { CountryAbbreviation = "SLO", CountryName = "Slovenia" },
                new Country { CountryAbbreviation = "SMR", CountryName = "San Marino" },
                new Country { CountryAbbreviation = "SRH", CountryName = "Southern Rhodesia" },
                new Country { CountryAbbreviation = "STA", CountryName = "Stateless" },
                new Country { CountryAbbreviation = "SUI", CountryName = "Switzerland" },
                new Country { CountryAbbreviation = "SVK", CountryName = "Slovak Republic" },
                new Country { CountryAbbreviation = "SWE", CountryName = "Sweden" },
                new Country { CountryAbbreviation = "TCH", CountryName = "Czechoslovakia" },
                new Country { CountryAbbreviation = "THA", CountryName = "Thailand" },
                new Country { CountryAbbreviation = "TPE", CountryName = "Chinese Taipei" },
                new Country { CountryAbbreviation = "TUN", CountryName = "Tunisia" },
                new Country { CountryAbbreviation = "TUR", CountryName = "Turkey" },
                new Country { CountryAbbreviation = "UKR", CountryName = "Ukraine" },
                new Country { CountryAbbreviation = "URS", CountryName = "Union of Soviet Socialist Republics" },
                new Country { CountryAbbreviation = "USA", CountryName = "United States of America" },
                new Country { CountryAbbreviation = "URU", CountryName = "Uruguay" },
                new Country { CountryAbbreviation = "UZB", CountryName = "Uzbekistan" },
                new Country { CountryAbbreviation = "VEN", CountryName = "Venezuela" },
                new Country { CountryAbbreviation = "YUG", CountryName = "Yugoslavia" },
                new Country { CountryAbbreviation = "ZIM", CountryName = "Zimbabwe" },
            };

            foreach (var country in countries)
            {
                await dbContext.Countries.AddAsync(country);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
