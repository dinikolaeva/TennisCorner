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
            public const int RoundsStringLenght = 30;
        }

        public static class Images
        {
            public const string Loading = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654511540/images/TennisCorner/loading_img_bpnliu.gif";

            public const string Logo = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654511536/images/TennisCorner/logo_olch1f.png";

            public const string Error404 = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654861331/images/TennisCorner/error-404-with-the-cute-tennis-ball-mascot-free-vector_k4knmo.jpg";

            // Tournaments
            public const string AustraliaOpen2022 = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654803529/images/TennisCorner/australianopen-cropped_australianopen_cropped_3s6xqnxg3lf01c650sj2r7yyt_jtkefm.jpg";

            public const string WinnerNadal = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654803696/images/TennisCorner/83hop44s_rafael-nadal-_625x300_30_January_22_jmtcjc.webp";

            public const string WinnerBarty = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654803773/images/TennisCorner/14588764e53f4c3db3710bf9edecaf03_gyr7kq.jpg";

            public const string AOSchemaMan2022 = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654804215/images/TennisCorner/screencapture-itftennis-en-tournament-australian-open-aus-2022-m-sl-aus-01a-2022-draws-and-results-2022-06-09-22_49_08_uuaoet.png";

            public const string AOSchemaWomen2022 = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654804366/images/TennisCorner/screencapture-itftennis-en-tournament-australian-open-aus-2022-w-sl-aus-01a-2022-draws-and-results-2022-06-09-22_51_43_zweapr.png";

            public const string RolandGarros2022 = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654804591/images/TennisCorner/da0a32f0189dd009c132127fbdc577ef_qtwxmq.jpg";

            public const string WinnerNadalRG = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654804681/images/TennisCorner/gettyimages-1401181669_vluzfo.jpg";

            public const string WinnerSwiatek = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654804893/images/TennisCorner/thumbs_b_c_5cd3cef25d2f29f0926bab5d15baf124_f0cxjh.jpg";

            public const string RGSchemaMan2022 = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654805044/images/TennisCorner/screencapture-itftennis-en-tournament-french-open-fra-2022-m-sl-fra-01a-2022-draws-and-results-2022-06-09-23_02_58_liyrjn.png";

            public const string RGSchemaWomen2022 = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654805199/images/TennisCorner/screencapture-itftennis-en-tournament-french-open-fra-2022-w-sl-fra-01a-2022-draws-and-results-2022-06-09-23_05_18_kvxhan.png";

            public const string AustralianOpen2021 = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654805642/images/TennisCorner/a094af390a622b5265f9061fcd47d3ba_prr8zv.jpg";

            public const string WinnerDjokovic = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654805735/images/TennisCorner/Novak-Djokovic-4_ptnyfu.jpg";

            public const string WinnerOsaka = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654805837/images/TennisCorner/hi-res-c5cfe43a2bf270534e575648b6e55bfe_crop_north-1568x1045_avporw.webp";

            public const string AOSchemaMan2021 = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654806090/images/TennisCorner/screencapture-itftennis-en-tournament-australian-open-aus-2021-m-sl-aus-01a-2021-draws-and-results-2022-06-09-23_20_35_gmh4kh.png";

            public const string AOSchemaWomen2021 = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654805989/images/TennisCorner/screencapture-itftennis-en-tournament-australian-open-aus-2021-w-sl-aus-01a-2021-draws-and-results-2022-06-09-23_18_50_qpq9uk.png";

            public const string RolandGarros2021 = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654806392/images/TennisCorner/French-Open-Preview-2021-1_fd5tpe.jpg";

            public const string WinnerRGDjokovic2021 = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654806476/images/TennisCorner/160304-kxoapjbrwi-1623632048_rrpx6t.jpg";

            public const string WinnerKrejcikova = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654806554/images/TennisCorner/121431_m81a9x.jpg";

            public const string RGSchemaMan2021 = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654806777/images/TennisCorner/screencapture-itftennis-en-tournament-french-open-fra-2021-m-sl-fra-01a-2021-draws-and-results-2022-06-09-23_32_21_wuhpsb.png";

            public const string RGSchemaWoman2021 = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654806993/images/TennisCorner/screencapture-itftennis-en-tournament-french-open-fra-2021-w-sl-fra-01a-2021-draws-and-results-2022-06-09-23_35_51_ebkokt.png";

            public const string Wimbledon2021 = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654807079/images/TennisCorner/s_TL107421-76480-1623833362428_mq4hs6.jpg";

            public const string WinnerWimbledonDjokovic = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654807289/images/TennisCorner/djokovic_saj7oc.jpg";

            public const string WinnerWimbledonBarty = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654807360/images/TennisCorner/4D7GY2OMPRLY5GAWL2QGW4KTRE_ly54vv.jpg";

            public const string WimbledonSchemaMan2021 = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654807549/images/TennisCorner/screencapture-itftennis-en-tournament-wimbledon-gbr-2021-m-sl-gbr-01a-2021-draws-and-results-2022-06-09-23_45_10_ztqos3.png";

            public const string WimbledonSchemaWoman2021 = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654807626/images/TennisCorner/screencapture-itftennis-en-tournament-wimbledon-gbr-2021-w-sl-gbr-01a-2021-draws-and-results-2022-06-09-23_46_24_rrpj4d.png";

            public const string USOpen2021 = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654807906/images/TennisCorner/11tennis-usopen-1-videoSixteenByNineJumbo1600_x6eiyl.jpg";

            public const string WinnerMedvedev = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654807995/images/TennisCorner/Vb9T6Dw1tI5n_b0L6ty0Ei2q8_1440x960_xca8cd.jpg";

            public const string WinnerRadukanu = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654808101/images/TennisCorner/emma_pf6pcs.jpg";

            public const string USOpenSchemaMan2021 = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654808230/images/TennisCorner/screencapture-itftennis-en-tournament-us-open-usa-2021-m-sl-usa-01a-2021-draws-and-results-2022-06-09-23_56_27_vsiddf.png";

            public const string USOpenSchemaWoman2021 = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654808387/images/TennisCorner/screencapture-itftennis-en-tournament-us-open-usa-2021-w-sl-usa-01a-2021-draws-and-results-2022-06-09-23_57_52_xr25oe.png";

            // Players
            // Man
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

            public const string Hurkacz = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654629925/images/TennisCorner/display_s9u4jo.jpg";

            public const string Fritz = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654630238/images/TennisCorner/display_todrjs.jpg";

            public const string Schwartzman = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654630463/images/TennisCorner/display_pfemcd.jpg";

            public const string Shapovalov = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654630658/images/TennisCorner/display_inrk5w.jpg";

            public const string Cilic = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654630873/images/TennisCorner/display_qqngwo.jpg";

            public const string Opelka = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654630873/images/TennisCorner/display_qqngwo.jpg";

            public const string Busta = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654631368/images/TennisCorner/display_ipidau.jpg";

            public const string Agut = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654631745/images/TennisCorner/display_cyrdkg.jpg";

            public const string Monfils = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654632456/images/TennisCorner/display_gc63d1.jpg";

            public const string Rune = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654632456/images/TennisCorner/display_gc63d1.jpg";

            public const string Fucsovics = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654633184/images/TennisCorner/display_tniof6.jpg";

            public const string Khachanov = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654633184/images/TennisCorner/display_tniof6.jpg";

            public const string Federer = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654633184/images/TennisCorner/display_tniof6.jpg";

            public const string Harris = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654634520/images/TennisCorner/display_zbhtcy.jpg";

            public const string Zandschulp = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654635004/images/TennisCorner/display_xrnppi.jpg";

            // Women
            public const string Swiatek = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654677902/images/TennisCorner/display_xbauug.jpg";

            public const string Kontaveit = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654678687/images/TennisCorner/display_hdgdsq.jpg";

            public const string Badosa = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654678977/images/TennisCorner/Badosa_RG21__14___51376409698_xjxjha.jpg";

            public const string Jabeur = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654679162/images/TennisCorner/display_tlgubg.jpg";

            public const string Sakkari = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654679405/images/TennisCorner/display_ghbsx4.jpg";

            public const string Sabalenka = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654680338/images/TennisCorner/display_uqmrwr.jpg";

            public const string Pliskova = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654680338/images/TennisCorner/display_uqmrwr.jpg";

            public const string Pegula = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654681543/images/TennisCorner/display_xze9uq.jpg";

            public const string Collins = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654681796/images/TennisCorner/display_dctiry.jpg";

            public const string Muguruza = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654681980/images/TennisCorner/display_lst0tn.jpg";

            public const string Barty = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654682338/images/TennisCorner/display_gygils.jpg";

            public const string Krejcikova = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654683367/images/TennisCorner/display_gtl15d.jpg";

            public const string Keys = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654683554/images/TennisCorner/display_rs74cn.jpg";

            public const string Cornet = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654683788/images/TennisCorner/display_fozij5.jpg";

            public const string Kanepi = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654685688/images/TennisCorner/display_hixhyc.jpg";

            public const string Kudermetova = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654686110/images/TennisCorner/display_m3bw6f.jpg";

            public const string Kasatkina = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654686298/images/TennisCorner/display_svulal.jpg";

            public const string Trevisan = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654686479/images/TennisCorner/display_n55phs.jpg";

            public const string Fernandez = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654686752/images/TennisCorner/display_yj9bfg.jpg";

            public const string Gauff = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654686924/images/TennisCorner/display_dwos8e.jpg";

            public const string Stephens = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654687105/images/TennisCorner/display_mg6zqj.jpg";

            public const string Tomljanovic = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654687332/images/TennisCorner/display_syfjsm.jpg";

            public const string Muchova = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654688029/images/TennisCorner/muchova11_2_xvzdlo.jpg";

            public const string Kerber = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654688226/images/TennisCorner/display_xgst7b.jpg";

            public const string Golubic = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654688437/images/TennisCorner/display_pfhxg1.jpg";

            public const string Raducanu = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654688738/images/TennisCorner/display_s7viq5.jpg";

            public const string Bencic = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654688992/images/TennisCorner/display_vr3byr.jpg";

            public const string Svitolina = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654689332/images/TennisCorner/display_qw5k2q.jpg";

            public const string Kovinic = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654689515/images/TennisCorner/display_fwuvv3.jpg";

            public const string Brady = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654689808/images/TennisCorner/Brady_LIM19__101___49308167497_ef92g7.jpg";

            public const string Hsieh = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654690012/images/TennisCorner/display_gyi1pa.jpg";

            public const string Osaka = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654690232/images/TennisCorner/display_w7mxhi.jpg";

            public const string Williams = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654690453/images/TennisCorner/display_v2kl5w.jpg";

            public const string Halep = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654690642/images/TennisCorner/display_qwnhix.jpg";

            public const string Rybakina = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654690876/images/TennisCorner/display_ytsqib.jpg";

            public const string Pavlyuchenkova = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654691080/images/TennisCorner/display_xhnnbh.jpg";

            public const string Zidansek = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654692034/images/TennisCorner/Tamara_Zidansek__49986143201___cropped_m9whye.jpg";
        }
    }
}
