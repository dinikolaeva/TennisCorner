namespace TennisCorner.Common
{
    public static class GlobalConstants
    {
        public const string SystemName = "TennisCorner";

        public const string AdministratorRoleName = "Administrator";

        // from another app, not good name for cloud with many apps :)
        public const string CloudName = "be-gorgeous";

        public static class StringLengthValidations
        {
            public const int SurfaceTypeStringLenght = 50;
            public const int CategoryNameStringLenght = 30;
            public const int TournamentNameStringLenght = 100;
            public const int LocationStringLenght = 50;
            public const int CountryAbbreviationStringLenght = 3;
            public const int CountryNameStringLenght = 50;
            public const int PlayerFirstNameStringLenght = 30;
            public const int PlayerLastNameStringLenght = 50;
            public const int PlayerGenderStringLenght = 1;
            public const int PlayerCoachStringLenght = 100;
            public const int IsOpponentRetiredStringLenght = 1;
        }

        public static class Images
        {
            public const string Loading = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654511540/images/TennisCorner/loading_img_bpnliu.gif";

            public const string Logo = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654511536/images/TennisCorner/logo_olch1f.png";

            // Players
            public const string Djokovic = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654606304/images/TennisCorner/display_vzoulw.jpg";

            public const string Medvedev = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654604964/images/TennisCorner/display_nhzm5t.jpg";

            public const string Zverev = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654606527/images/TennisCorner/display_rcetpl.jpg";

            public const string Nadal = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654606852/images/TennisCorner/display_uclrzx.jpg";

            public const string Tsitsipas = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654607442/images/TennisCorner/display_cyxcgf.jpg";

            public const string Ruud = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654607667/images/TennisCorner/display_gzbr5j.jpg";

            public const string Alcaraz = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654607846/images/TennisCorner/display_gbcxp3.jpg";

            public const string Rublev = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654608546/images/TennisCorner/display_xesmbp.jpg";

            public const string AugerAliassime = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654610609/images/TennisCorner/display_asjfjo.jpg";

            public const string Berrettini = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654610781/images/TennisCorner/display_k56zmr.jpg";

            public const string Norrie = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654611003/images/TennisCorner/display_yjy3zn.jpg";

            public const string Sinner = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654611157/images/TennisCorner/display_l6ydqm.jpg";
        }
    }
}
