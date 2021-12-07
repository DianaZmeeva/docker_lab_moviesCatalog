﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieCatalog.API.Models.Api.Auth;
using MovieCatalog.API.Models.Data;

namespace MovieCatalog.API.Constants
{
    public class EntityInitialization
    {
        public static List<UserRegisterModel> SystemUsers = new List<UserRegisterModel>()
        {
            new UserRegisterModel
            {
                UserName = "ivanov_ii",
                Name = "Иванов Иван Иванович",
                Password = "QWEasd123!",
                Email = "ivanov@mail.ru",
                BirthDate = new DateTime(1980, 1,12),
                Gender = Gender.Male
            },
            new UserRegisterModel
            {
                UserName = "love_react",
                Name = "Сидорова Мария Ивановна",
                Password = "QWEasd123!",
                Email = "sidorova@mail.ru",
                BirthDate = new DateTime(1990, 4, 8),
                Gender = Gender.Female
            },
        };
        public static List<string> Genres = new List<string>()
        {
            "комедия",
            "мультфильм",
            "ужасы",
            "фантастика",
            "триллер",
            "боевик",
            "мелодрама",
            "детектив",
            "приключения",
            "фэнтези",
            "военный",
            "семейный",
            "аниме",
            "история",
            "драма",
            "документальный",
            "детский",
            "криминал",
            "биография",
            "вестерн",
            "фильм-нуар",
            "спорт",
            "короткометражка",
            "мюзикл"
        };

        public class GenerateMovieModel
        {
            public Movie Movie { get; set; }
            public List<string> Genres { get; set; } = new List<string>();
        }

        public static List<GenerateMovieModel> Movies = new List<GenerateMovieModel>()
        {
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "Зеленая миля",
                    Description = "В тюрьме для смертников появляется заключенный с божественным даром. Мистическая драма по роману Стивена Кинга",
                    Year = 1999,
                    Country = "США",
                    Time = 189,
                    Tagline = "Пол Эджкомб не верил в чудеса. Пока не столкнулся с одним из них",
                    Director = "Фрэнк Дарабонт",
                    Budget = 60000000,
                    Fees = 286801374,
                    AgeLimit = 16,
                    Rating = 9.0,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/2s89R4K04/ae7af5CslCkK/rVSfH-4xE1g5HfOmBLXTnYX760KasO5cqWbK3B1pm2sMSA_4-9cDU2J9hILb0A-BVWpZFsvlsMXPmhSRXeDtKqkRyu7_xKaN2NkDk-GQ5wwgTopTXjWKHXhTH2nvmpnoLt8tmwlVAZV2GaBjrmW65VEvrNKLZBHBGLxltulXGEjeZQyN6LKjW4zc8XW0pBFpNYkpdOlDvJgpZVmeXujK-72Nrhm51yNFF5qQRX7HmmajT54ziwJAkeudULbYRykJ3uRdDiqxUWkt3rKUBATiuic4-Tbr4O6LaRbofZ14aIguX5_oexViJqbqAQfuVmglAs7cIvmCIeKrvXPXWHZq6I6kfAxZ8GF5Ta9SNjXlQ5hGKThGiEOfiRmk6M9uOykYjj7Nurj30UbEeGBl_CeqtgM9DuLrMdPDat0AFGrFSzruxM9c6INBae5_Mva0pZL5BzvahHvDrJiJdkl-DWhqeqw-_Urr9CPnxvtDty20e6bQjF5TWyICgJocwMT7R3rYjObPf5uAwenujHAX9gbCuBU5a1SbUy5pKRVKvJ6oC7t8rHzraVYTF0Xbk6cd97qncl_egKnwgkNLHoDFWqZaesy2Dqw4o1C7zpzQt_W18zuHiYrVC9LfqytnKsxe6gkY_s4t6xhnEyfWC-GFr7f7pwGszTPZIlFg2W4Rdyn3aAgcVg4c-cJTm05tQyXUloCrhUlI9unQT1toROsOPQoYuh_MHSirReIWF0jCt4_2iJVjb3yQ6TLAk8hd4MRrVSqoHEYPrnrhM6pvbNLUt4SDCzQ5GYdIc487aXUqzrx5motcPb8qq5eT9vRok2bvh_uVUqxtEymhsoJZvxAUKpSKqk8VvC9IUyBpbU1Q9_TX8Dg0OZinCGGem2inSb4euGrpTL7MKgpFMkbH--ElXOV6FtMv3CIp8pHga-4S5IsU2Jpshtzc63FBif1eE8XWZLFqVEuZJXvznYhJxLreXNvIu34Ovlhbl0Bm91iTl-yEuzfTDU5yGPPAIgndo0fZBMianXUtXoiQ07itztC3ZkTgqvcqOqbIgD0Km-XKrG1ZS2kOj_7ImNXjxseKQwV9pcj2kRx8EQpQY4Fqf3KGytYbO9yknWwas3B7_rwjxJYVU3lGS3pEmhLvCzlnCl1s65lrfB_tGFunMyXEWvOW3pe4VTJtr1EbYtOQq40iNRh0KXr9Bg0cGDDB6a5-szRlhtG6JknpBsrQn7g7xBufvXp6u19dfSgJZ-Ck5hgAZx_2K3dg3j6xeRIjYsnNQsca13iqjoX-zZgTU1u_nXI0BYfTi5Xam6dp0P96ObUKjcwbi6jv7d9KSmRQdzT4E9Qutasm8t_cEDswMELK33MGe-TIuR60Xp1KgZC4XRxA97Wk4ijlWik1CIHMadhUuv6MeYvpT4z9WrpXQhdlGKO1zDeKpKIO3VE7QiACW51gpzrHaMhdhs9sOGOwC12ccMdExfCpJcn5lXtAbkhYtgrsnip62B3e_irbJ8KX1Dpjdl-WSQezXizB6aDjcXldU5QKNykK_DY8fUgS8AhPHJGXtLehulabeQcqgu-ZKUbqzo7r2puef94LO6RDJ3ZJwTQ8tIg3MxzcsPiwImPLjMLFKDV7Ge9nnIzIIQP4Pd9DZXWX8Os3u1iG2oHfCGkFWVwe2nnKLK5fqQnl0kd2KAPW7sWYFfDsThPpkLLDOA7SNxjkKFmsd7zf-1PieS6vcRd3poC4VBq5FUohLZoLVph-X8hKW6xeXai7BgGlVymAdV60qhbgrf_haRHgkhu-ApX5V2rrH5RsH0gxcCptPtA3t8fRajZbCJTrwBy7W8bZDGxJe5r-Po1LOteDFuZoQGZNtTsHwD5OgwtwwjKpPqEnyTaqSZ4FnF3ZUpC4nt0hhpSF0XkVaxoVy-BMmQhEeO9Me9h5vAxsKJmH4Ja2apHUD7U5hVNN32P54eHC2n3Td1q0-PguVD1sqUHjqj6_4xYld_KLhVlq1-vxv4qJJ1jO3_lbW0_Nn3urNyOGp9ixV65luGQgvQwRe1BSULoPwZXK9Xh4rmStHlnhc6uMv0OUJiXC-GXKGWX6YK_6SrQqTE06C8kcba466wQAB_eZcIZMxFp04h2-sNnzYkKq7eC1aNUrO9z27T57wSC4b1yDh5TE8HtGS2onGVHOCOqUK178-hmZXI3uOgrmczemOrF0zYVK1jEtjGPowVFBWy8DF_rlqBjsVP1-CrDQGz3fIKZWZoDJRDvq1Wnznfg5ZEp8b0h4aZ4tX0jrtgKVBxlzJ94FaPWwDc1Ty0DgElu88SRqdVkYjQcPHfqjkws_L8KnZBcCmmdo-BY5kF4a2qQI3PzpKzsOvq34SlVCh1U4EFdulFq3Y34MgRkSYpPpXgPXGzZ6mn0nvH2LQtHrzZxS52WGEpsmC3omipGMa2r0SB-u21tKf2y_6ytVIZQFiXNFfBaLBeM_P8CI4KCya-wDFWqlaEqsZ828m0BDWI6fIdZmRAKaBbrrlQiADnk4dTkOvguIqu6Mfkp5ZjA2FQoTxe2USEayzk9AuzITQGgPg1SalijYDkf8rEuQ4Lov7KKl1mfziSZL2EaqId5q6Na6rKy5eGsefi_aaPfz5Per8wWedmj04N9tUsiAwAKJXtE3aCbKi9zEDH4Zw-O6HGyxFdbVI0kESPrVCBH_u1kWKo3cu4h63Y-9elpGQqQW-LH3LfVpFSJNPxELQNCDaz_zlzj3WKjs5h1dSrOj-H0OIIR2BbKJ1zoqd-liT2tpFss9r8moaJ4__HkrBZMmt8tz9D4Uu4XjfH4hOTGg8jvdM5bb9ysZ7Pa83crjYft9LjLU1rVDWTV7OjVJ45_LWycKrp8LSMsvzK7qe3WB1wWZghTf1Rj0os9NYqqTYGIKL_D02KRIqayXzq37orBKDpzRNFXUsnj1OXo1yOPv6NrmCN3Oe7jJP5yfuUhlwHXFm0OkbkYphDGvTxNK85Fyc",
                    Reviews = new List<Review>()
                    {
                        new Review
                        {
                            ReviewText = "«'Они помогли ему убить себя и так происходит каждый день во всем мире'... Фильм, который я могу смело назвать шедевром. Фильм, который длится три часа и которые пролетают незаметно. Фильм, который смотрится каждый раз как в первый. Фильм, который нельзя забыть и которым нельзя не проникнуться. Фильм, котрый заставляет задуматься о жизни, которую мы тратим на пустяки, теша себя иллюзией бессмертия, о смерти, которая не щадит никого. Фильм о зле, которое не всегда наказуемо и о добре, которое подчас бессильно что-либо изменить. И тебе остается лишь смотреть на то, как вершится суд, над тем кто не должен сидеть на скамье подсудимых. Фильм, который изменил мое мировоззрение и научил по-другому относиться к жизни.",
                            Rating = 10,
                            IsAnonymous = false,
                            CreateDateTime = new DateTime(2007,6,25),
                            Author = new User()
                            {
                                UserName = "ivanov_ii"
                            }
                        },
                        new Review
                        {
                            ReviewText = "Очень не похоже на Стивена Кинга: нет сильного ужаса, не прошибает холодный пот, но, как обычно, не хватает сил оторваться от экрана телевизора. Этот фильм определенно наполнен добротой. Добротой и верой. Может, будет святотатством то, что я скажу, но персонаж Джона Коффи сродни библейскому Иисусу Христу. Он бескорыстен, бесконечно добр и лишен известной доли притворства. Этим и подкупает. Джон Коффи не лжёт и поэтому уже обретает нимб над головой, который виден каждому из тюремных охранников. Но каждый реагирует на него по-разному. Непревзойденая игра Тома Хэнкса, его герой, пожалуй, последнее, что осталось от мира без ненависти и завистничества. И Майкл Кларк Дункан, хоть и отличается от Иисуса внешностью и цветом кожи, но основа одна, и история заканчивается одинаково. Своих спасителей мы, как и прежде, предпочитаем убивать.",
                            Rating = 5,
                            IsAnonymous = false,
                            CreateDateTime = new DateTime(2010,6,10),
                            Author = new User()
                            {
                                UserName = "love_react"
                            }
                        }
                    }
                },
                Genres = new List<string>()
                {
                    "драма", "криминал"
                },
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "Побег из Шоушенка",
                    Description = "Несправедливо осужденный банкир готовит побег из тюрьмы. Тим Роббинс в выдающейся экранизации Стивена Кинга",
                    Year = 1994,
                    Country = "США",
                    Time = 142,
                    Tagline = "Страх - это кандалы. Надежда - это свобода",
                    Director = "Фрэнк Дарабонт",
                    Budget = 25000000,
                    Fees = 28418687,
                    AgeLimit = 16,
                    Rating = 8.9,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/2s89R4K04/ae7af5CslCkK/rVSfH-4xE1g5HfOmBLXTnYX760KasO5cqWbK3B1pm2sMSA_4-9cDU2J9hILb0A-BVS95Ntv10PVvn9SkbRDtKtkRyu7P9EZd2Hlj1oGFojwQHioTLjWKHXhTH2nvmpnoLt8tmwlVAZV2GaBjrmW65VEvrNKLZBHBGLxltulXGEjeZQyN6LKjW4zc8XW0pBFpNYkpdOlDvJgpZVmeXujK-72Nrhm51yNFF5qQRX7HmmajT54ziwJAkeudULbYRykJ3uRdDiqxUWkt3rKUBATiuic4-Tbr4O6LaRbofZ14aIguX5_oexViJqbqAQfuVmglAs7cIvmCIeKrvXPXWHZq6I6kfAxZ8GF5Ta9SNjXlQ5hGKThGiEOfiRmk6M9uOykYjj7Nurj30UbEeGBl_CeqtgM9DuLrMdPDat0AFGrFSzruxM9c6INBae5_Mva0pZL5BzvahHvDrJiJdkl-DWhqeqw-_Urr9CPnxvtDty20e6bQjF5TWyICgJocwMT7R3rYjObPf5uAwenujHAX9gbCuBU5a1SbUy5pKRVKvJ6oC7t8rHzraVYTF0Xbk6cd97qncl_egKnwgkNLHoDFWqZaesy2Dqw4o1C7zpzQt_W18zuHiYrVC9LfqytnKsxe6gkY_s4t6xhnEyfWC-GFr7f7pwGszTPZIlFg2W4Rdyn3aAgcVg4c-cJTm05tQyXUloCrhUlI9unQT1toROsOPQoYuh_MHSirReIWF0jCt4_2iJVjb3yQ6TLAk8hd4MRrVSqoHEYPrnrhM6pvbNLUt4SDCzQ5GYdIc487aXUqzrx5motcPb8qq5eT9vRok2bvh_uVUqxtEymhsoJZvxAUKpSKqk8VvC9IUyBpbU1Q9_TX8Dg0OZinCGGem2inSb4euGrpTL7MKgpFMkbH--ElXOV6FtMv3CIp8pHga-4S5IsU2Jpshtzc63FBif1eE8XWZLFqVEuZJXvznYhJxLreXNvIu34Ovlhbl0Bm91iTl-yEuzfTDU5yGPPAIgndo0fZBMianXUtXoiQ07itztC3ZkTgqvcqOqbIgD0Km-XKrG1ZS2kOj_7ImNXjxseKQwV9pcj2kRx8EQpQY4Fqf3KGytYbO9yknWwas3B7_rwjxJYVU3lGS3pEmhLvCzlnCl1s65lrfB_tGFunMyXEWvOW3pe4VTJtr1EbYtOQq40iNRh0KXr9Bg0cGDDB6a5-szRlhtG6JknpBsrQn7g7xBufvXp6u19dfSgJZ-Ck5hgAZx_2K3dg3j6xeRIjYsnNQsca13iqjoX-zZgTU1u_nXI0BYfTi5Xam6dp0P96ObUKjcwbi6jv7d9KSmRQdzT4E9Qutasm8t_cEDswMELK33MGe-TIuR60Xp1KgZC4XRxA97Wk4ijlWik1CIHMadhUuv6MeYvpT4z9WrpXQhdlGKO1zDeKpKIO3VE7QiACW51gpzrHaMhdhs9sOGOwC12ccMdExfCpJcn5lXtAbkhYtgrsnip62B3e_irbJ8KX1Dpjdl-WSQezXizB6aDjcXldU5QKNykK_DY8fUgS8AhPHJGXtLehulabeQcqgu-ZKUbqzo7r2puef94LO6RDJ3ZJwTQ8tIg3MxzcsPiwImPLjMLFKDV7Ge9nnIzIIQP4Pd9DZXWX8Os3u1iG2oHfCGkFWVwe2nnKLK5fqQnl0kd2KAPW7sWYFfDsThPpkLLDOA7SNxjkKFmsd7zf-1PieS6vcRd3poC4VBq5FUohLZoLVph-X8hKW6xeXai7BgGlVymAdV60qhbgrf_haRHgkhu-ApX5V2rrH5RsH0gxcCptPtA3t8fRajZbCJTrwBy7W8bZDGxJe5r-Po1LOteDFuZoQGZNtTsHwD5OgwtwwjKpPqEnyTaqSZ4FnF3ZUpC4nt0hhpSF0XkVaxoVy-BMmQhEeO9Me9h5vAxsKJmH4Ja2apHUD7U5hVNN32P54eHC2n3Td1q0-PguVD1sqUHjqj6_4xYld_KLhVlq1-vxv4qJJ1jO3_lbW0_Nn3urNyOGp9ixV65luGQgvQwRe1BSULoPwZXK9Xh4rmStHlnhc6uMv0OUJiXC-GXKGWX6YK_6SrQqTE06C8kcba466wQAB_eZcIZMxFp04h2-sNnzYkKq7eC1aNUrO9z27T57wSC4b1yDh5TE8HtGS2onGVHOCOqUK178-hmZXI3uOgrmczemOrF0zYVK1jEtjGPowVFBWy8DF_rlqBjsVP1-CrDQGz3fIKZWZoDJRDvq1Wnznfg5ZEp8b0h4aZ4tX0jrtgKVBxlzJ94FaPWwDc1Ty0DgElu88SRqdVkYjQcPHfqjkws_L8KnZBcCmmdo-BY5kF4a2qQI3PzpKzsOvq34SlVCh1U4EFdulFq3Y34MgRkSYpPpXgPXGzZ6mn0nvH2LQtHrzZxS52WGEpsmC3omipGMa2r0SB-u21tKf2y_6ytVIZQFiXNFfBaLBeM_P8CI4KCya-wDFWqlaEqsZ828m0BDWI6fIdZmRAKaBbrrlQiADnk4dTkOvguIqu6Mfkp5ZjA2FQoTxe2USEayzk9AuzITQGgPg1SalijYDkf8rEuQ4Lov7KKl1mfziSZL2EaqId5q6Na6rKy5eGsefi_aaPfz5Per8wWedmj04N9tUsiAwAKJXtE3aCbKi9zEDH4Zw-O6HGyxFdbVI0kESPrVCBH_u1kWKo3cu4h63Y-9elpGQqQW-LH3LfVpFSJNPxELQNCDaz_zlzj3WKjs5h1dSrOj-H0OIIR2BbKJ1zoqd-liT2tpFss9r8moaJ4__HkrBZMmt8tz9D4Uu4XjfH4hOTGg8jvdM5bb9ysZ7Pa83crjYft9LjLU1rVDWTV7OjVJ45_LWycKrp8LSMsvzK7qe3WB1wWZghTf1Rj0os9NYqqTYGIKL_D02KRIqayXzq37orBKDpzRNFXUsnj1OXo1yOPv6NrmCN3Oe7jJP5yfuUhlwHXFm0OkbkYphDGvTxNK85Fyc#DSD",
                    Reviews = new List<Review>()
                    {
                        new Review
                        {
                            ReviewText = "«Побег из Шоушенка» - экранизация романа Стивена Кинга. На мой взгляд, это редчайший случай, когда фильм превзошел литературное произведение, по которому он был создан. И, несмотря на то, что ставить картину по книге всегда сложно, это тот пример, когда фильм не только прекрасно передал на экране всю глубину, атмосферу и смысловой стержень замечательной книги Кинга, но и оказался сильнее, превзойдя оригинал.",
                            Rating = 9,
                            IsAnonymous = true,
                            CreateDateTime = new DateTime(2015,5,11)
                        },
                        new Review
                        {
                            ReviewText = "Сразу скажу, что фильм мне понравился. Люблю Фримэна, уважаю Роббинса. Читаю Кинга. Но рецензия красненькая. Объясняю: В списке IMDB (как и на Кинопоиске) часто плавают фильмы, иногда вылезая и на второе место в списке, а потом опускаясь на сто девяносто третье, и т.д. Картина меняется. Но неизменно одно: 'Побег из Шоушенка' на первом месте. На сайте есть практически вся фильмография человечества, но лучшей остается эта история. Да, история неплохая, как и постановка фильма. Но разве это лучшее, что создал мир за более чем столетнюю работу? Это - то, что волнует людей? Самое насущное? Более глубокое, чем 'Форрест Гамп'? Более классическое, чем 'Титаник', негласно объявленный must see?",
                            Rating = 3,
                            IsAnonymous = false,
                            CreateDateTime = new DateTime(2010,6,10),
                            Author = new User()
                            {
                                UserName = "ivanov_ii"
                            }
                        }
                    }
                },
                Genres = new List<string>()
                {
                    "драма"
                }
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "Властелин колец: Возвращение короля",
                    Description = "Арагорн штурмует Мордор, а Фродо устал бороться с чарами кольца. Эффектный финал саги, собравший 11 «Оскаров»",
                    Year = 2003,
                    Country = "Новая Зеландия, США",
                    Time = 201,
                    Tagline = "There can be no triumph without loss. No victory without suffering. No freedom without sacrifice",
                    Director = "Питер Джексон",
                    Budget = 94000000,
                    Fees = 1140682011,
                    AgeLimit = 12,
                    Rating = 8.8,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/2s89R4K04/ae7af5CslCkK/rVSfH-4xE1g5HfOmBLXTnYX760KasO5cqWbK3B1pm2sMSA_4-9cDU2J9RBJLoK-BUE98FvvAkMUvn8ShzWDtLzxxuutKwfYN2Lwj43TglxxAjv-DfjWKHXhTH2nvmpnoLt8tmwlVAZV2GaBjrmW65VEvrNKLZBHBGLxltulXGEjeZQyN6LKjW4zc8XW0pBFpNYkpdOlDvJgpZVmeXujK-72Nrhm51yNFF5qQRX7HmmajT54ziwJAkeudULbYRykJ3uRdDiqxUWkt3rKUBATiuic4-Tbr4O6LaRbofZ14aIguX5_oexViJqbqAQfuVmglAs7cIvmCIeKrvXPXWHZq6I6kfAxZ8GF5Ta9SNjXlQ5hGKThGiEOfiRmk6M9uOykYjj7Nurj30UbEeGBl_CeqtgM9DuLrMdPDat0AFGrFSzruxM9c6INBae5_Mva0pZL5BzvahHvDrJiJdkl-DWhqeqw-_Urr9CPnxvtDty20e6bQjF5TWyICgJocwMT7R3rYjObPf5uAwenujHAX9gbCuBU5a1SbUy5pKRVKvJ6oC7t8rHzraVYTF0Xbk6cd97qncl_egKnwgkNLHoDFWqZaesy2Dqw4o1C7zpzQt_W18zuHiYrVC9LfqytnKsxe6gkY_s4t6xhnEyfWC-GFr7f7pwGszTPZIlFg2W4Rdyn3aAgcVg4c-cJTm05tQyXUloCrhUlI9unQT1toROsOPQoYuh_MHSirReIWF0jCt4_2iJVjb3yQ6TLAk8hd4MRrVSqoHEYPrnrhM6pvbNLUt4SDCzQ5GYdIc487aXUqzrx5motcPb8qq5eT9vRok2bvh_uVUqxtEymhsoJZvxAUKpSKqk8VvC9IUyBpbU1Q9_TX8Dg0OZinCGGem2inSb4euGrpTL7MKgpFMkbH--ElXOV6FtMv3CIp8pHga-4S5IsU2Jpshtzc63FBif1eE8XWZLFqVEuZJXvznYhJxLreXNvIu34Ovlhbl0Bm91iTl-yEuzfTDU5yGPPAIgndo0fZBMianXUtXoiQ07itztC3ZkTgqvcqOqbIgD0Km-XKrG1ZS2kOj_7ImNXjxseKQwV9pcj2kRx8EQpQY4Fqf3KGytYbO9yknWwas3B7_rwjxJYVU3lGS3pEmhLvCzlnCl1s65lrfB_tGFunMyXEWvOW3pe4VTJtr1EbYtOQq40iNRh0KXr9Bg0cGDDB6a5-szRlhtG6JknpBsrQn7g7xBufvXp6u19dfSgJZ-Ck5hgAZx_2K3dg3j6xeRIjYsnNQsca13iqjoX-zZgTU1u_nXI0BYfTi5Xam6dp0P96ObUKjcwbi6jv7d9KSmRQdzT4E9Qutasm8t_cEDswMELK33MGe-TIuR60Xp1KgZC4XRxA97Wk4ijlWik1CIHMadhUuv6MeYvpT4z9WrpXQhdlGKO1zDeKpKIO3VE7QiACW51gpzrHaMhdhs9sOGOwC12ccMdExfCpJcn5lXtAbkhYtgrsnip62B3e_irbJ8KX1Dpjdl-WSQezXizB6aDjcXldU5QKNykK_DY8fUgS8AhPHJGXtLehulabeQcqgu-ZKUbqzo7r2puef94LO6RDJ3ZJwTQ8tIg3MxzcsPiwImPLjMLFKDV7Ge9nnIzIIQP4Pd9DZXWX8Os3u1iG2oHfCGkFWVwe2nnKLK5fqQnl0kd2KAPW7sWYFfDsThPpkLLDOA7SNxjkKFmsd7zf-1PieS6vcRd3poC4VBq5FUohLZoLVph-X8hKW6xeXai7BgGlVymAdV60qhbgrf_haRHgkhu-ApX5V2rrH5RsH0gxcCptPtA3t8fRajZbCJTrwBy7W8bZDGxJe5r-Po1LOteDFuZoQGZNtTsHwD5OgwtwwjKpPqEnyTaqSZ4FnF3ZUpC4nt0hhpSF0XkVaxoVy-BMmQhEeO9Me9h5vAxsKJmH4Ja2apHUD7U5hVNN32P54eHC2n3Td1q0-PguVD1sqUHjqj6_4xYld_KLhVlq1-vxv4qJJ1jO3_lbW0_Nn3urNyOGp9ixV65luGQgvQwRe1BSULoPwZXK9Xh4rmStHlnhc6uMv0OUJiXC-GXKGWX6YK_6SrQqTE06C8kcba466wQAB_eZcIZMxFp04h2-sNnzYkKq7eC1aNUrO9z27T57wSC4b1yDh5TE8HtGS2onGVHOCOqUK178-hmZXI3uOgrmczemOrF0zYVK1jEtjGPowVFBWy8DF_rlqBjsVP1-CrDQGz3fIKZWZoDJRDvq1Wnznfg5ZEp8b0h4aZ4tX0jrtgKVBxlzJ94FaPWwDc1Ty0DgElu88SRqdVkYjQcPHfqjkws_L8KnZBcCmmdo-BY5kF4a2qQI3PzpKzsOvq34SlVCh1U4EFdulFq3Y34MgRkSYpPpXgPXGzZ6mn0nvH2LQtHrzZxS52WGEpsmC3omipGMa2r0SB-u21tKf2y_6ytVIZQFiXNFfBaLBeM_P8CI4KCya-wDFWqlaEqsZ828m0BDWI6fIdZmRAKaBbrrlQiADnk4dTkOvguIqu6Mfkp5ZjA2FQoTxe2USEayzk9AuzITQGgPg1SalijYDkf8rEuQ4Lov7KKl1mfziSZL2EaqId5q6Na6rKy5eGsefi_aaPfz5Per8wWedmj04N9tUsiAwAKJXtE3aCbKi9zEDH4Zw-O6HGyxFdbVI0kESPrVCBH_u1kWKo3cu4h63Y-9elpGQqQW-LH3LfVpFSJNPxELQNCDaz_zlzj3WKjs5h1dSrOj-H0OIIR2BbKJ1zoqd-liT2tpFss9r8moaJ4__HkrBZMmt8tz9D4Uu4XjfH4hOTGg8jvdM5bb9ysZ7Pa83crjYft9LjLU1rVDWTV7OjVJ45_LWycKrp8LSMsvzK7qe3WB1wWZghTf1Rj0os9NYqqTYGIKL_D02KRIqayXzq37orBKDpzRNFXUsnj1OXo1yOPv6NrmCN3Oe7jJP5yfuUhlwHXFm0OkbkYphDGvTxNK85Fyc#DSD",
                    Reviews = new List<Review>()
                    {
                        new Review
                        {
                            ReviewText = "Фильм поражает своей масштабностью, красотой и глубиной образов и самого мира — до сих пор удивляюсь, как мог один человек создать целый мир, целую эпоху со своими мифами, героями, географией, летоисчеслением, прошлым, настояшим и будующим!",
                            Rating = 10,
                            IsAnonymous = true,
                            CreateDateTime = new DateTime(2017,2,17),
                        },
                        new Review
                        {
                            ReviewText = "Увы, третья часть культового 'Властелина Колец' - самая слабая серия из всех трёх. Потому что для фанатов.",
                            Rating = 5,
                            IsAnonymous = true,
                            CreateDateTime = new DateTime(2012,6,17),
                        },
                        new Review
                        {
                            ReviewText = "Увы, третья часть культового 'Властелина Колец' - самая слабая серия из всех трёх. Потому что для фанатов.",
                            Rating = 4,
                            IsAnonymous = true,
                            CreateDateTime = new DateTime(2020,10,10),
                        }
                    }
                },
                Genres = new List<string>()
                {

                    "фэнтези", "приключения", "драма"
                }
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "Властелин колец: Две крепости",
                    Description = "Голлум ведет хоббитов в Мордор, а великие армии готовятся к битве. Вторая часть трилогии, два «Оскара»",
                    Year = 2002,
                    Country = "Новая Зеландия, США",
                    Time = 201,
                    Tagline = "Приключение продолжается",
                    Director = "Питер Джексон",
                    Budget = 94000000,
                    Fees = 936689735,
                    AgeLimit = 12,
                    Rating = 8.8,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/2s89R4K04/ae7af5CslCkK/rVSfH-4xE1g5HfOmBLXTnYX760KasO5cqWbK3B1pm2sMSA_4-9cDU2J9pBILQG9hVX85Ruuw1fVfmqGhfQDtKowkuu765KNN2HwGg5Hw8nlQbppD7jWKHXhTH2nvmpnoLt8tmwlVAZV2GaBjrmW65VEvrNKLZBHBGLxltulXGEjeZQyN6LKjW4zc8XW0pBFpNYkpdOlDvJgpZVmeXujK-72Nrhm51yNFF5qQRX7HmmajT54ziwJAkeudULbYRykJ3uRdDiqxUWkt3rKUBATiuic4-Tbr4O6LaRbofZ14aIguX5_oexViJqbqAQfuVmglAs7cIvmCIeKrvXPXWHZq6I6kfAxZ8GF5Ta9SNjXlQ5hGKThGiEOfiRmk6M9uOykYjj7Nurj30UbEeGBl_CeqtgM9DuLrMdPDat0AFGrFSzruxM9c6INBae5_Mva0pZL5BzvahHvDrJiJdkl-DWhqeqw-_Urr9CPnxvtDty20e6bQjF5TWyICgJocwMT7R3rYjObPf5uAwenujHAX9gbCuBU5a1SbUy5pKRVKvJ6oC7t8rHzraVYTF0Xbk6cd97qncl_egKnwgkNLHoDFWqZaesy2Dqw4o1C7zpzQt_W18zuHiYrVC9LfqytnKsxe6gkY_s4t6xhnEyfWC-GFr7f7pwGszTPZIlFg2W4Rdyn3aAgcVg4c-cJTm05tQyXUloCrhUlI9unQT1toROsOPQoYuh_MHSirReIWF0jCt4_2iJVjb3yQ6TLAk8hd4MRrVSqoHEYPrnrhM6pvbNLUt4SDCzQ5GYdIc487aXUqzrx5motcPb8qq5eT9vRok2bvh_uVUqxtEymhsoJZvxAUKpSKqk8VvC9IUyBpbU1Q9_TX8Dg0OZinCGGem2inSb4euGrpTL7MKgpFMkbH--ElXOV6FtMv3CIp8pHga-4S5IsU2Jpshtzc63FBif1eE8XWZLFqVEuZJXvznYhJxLreXNvIu34Ovlhbl0Bm91iTl-yEuzfTDU5yGPPAIgndo0fZBMianXUtXoiQ07itztC3ZkTgqvcqOqbIgD0Km-XKrG1ZS2kOj_7ImNXjxseKQwV9pcj2kRx8EQpQY4Fqf3KGytYbO9yknWwas3B7_rwjxJYVU3lGS3pEmhLvCzlnCl1s65lrfB_tGFunMyXEWvOW3pe4VTJtr1EbYtOQq40iNRh0KXr9Bg0cGDDB6a5-szRlhtG6JknpBsrQn7g7xBufvXp6u19dfSgJZ-Ck5hgAZx_2K3dg3j6xeRIjYsnNQsca13iqjoX-zZgTU1u_nXI0BYfTi5Xam6dp0P96ObUKjcwbi6jv7d9KSmRQdzT4E9Qutasm8t_cEDswMELK33MGe-TIuR60Xp1KgZC4XRxA97Wk4ijlWik1CIHMadhUuv6MeYvpT4z9WrpXQhdlGKO1zDeKpKIO3VE7QiACW51gpzrHaMhdhs9sOGOwC12ccMdExfCpJcn5lXtAbkhYtgrsnip62B3e_irbJ8KX1Dpjdl-WSQezXizB6aDjcXldU5QKNykK_DY8fUgS8AhPHJGXtLehulabeQcqgu-ZKUbqzo7r2puef94LO6RDJ3ZJwTQ8tIg3MxzcsPiwImPLjMLFKDV7Ge9nnIzIIQP4Pd9DZXWX8Os3u1iG2oHfCGkFWVwe2nnKLK5fqQnl0kd2KAPW7sWYFfDsThPpkLLDOA7SNxjkKFmsd7zf-1PieS6vcRd3poC4VBq5FUohLZoLVph-X8hKW6xeXai7BgGlVymAdV60qhbgrf_haRHgkhu-ApX5V2rrH5RsH0gxcCptPtA3t8fRajZbCJTrwBy7W8bZDGxJe5r-Po1LOteDFuZoQGZNtTsHwD5OgwtwwjKpPqEnyTaqSZ4FnF3ZUpC4nt0hhpSF0XkVaxoVy-BMmQhEeO9Me9h5vAxsKJmH4Ja2apHUD7U5hVNN32P54eHC2n3Td1q0-PguVD1sqUHjqj6_4xYld_KLhVlq1-vxv4qJJ1jO3_lbW0_Nn3urNyOGp9ixV65luGQgvQwRe1BSULoPwZXK9Xh4rmStHlnhc6uMv0OUJiXC-GXKGWX6YK_6SrQqTE06C8kcba466wQAB_eZcIZMxFp04h2-sNnzYkKq7eC1aNUrO9z27T57wSC4b1yDh5TE8HtGS2onGVHOCOqUK178-hmZXI3uOgrmczemOrF0zYVK1jEtjGPowVFBWy8DF_rlqBjsVP1-CrDQGz3fIKZWZoDJRDvq1Wnznfg5ZEp8b0h4aZ4tX0jrtgKVBxlzJ94FaPWwDc1Ty0DgElu88SRqdVkYjQcPHfqjkws_L8KnZBcCmmdo-BY5kF4a2qQI3PzpKzsOvq34SlVCh1U4EFdulFq3Y34MgRkSYpPpXgPXGzZ6mn0nvH2LQtHrzZxS52WGEpsmC3omipGMa2r0SB-u21tKf2y_6ytVIZQFiXNFfBaLBeM_P8CI4KCya-wDFWqlaEqsZ828m0BDWI6fIdZmRAKaBbrrlQiADnk4dTkOvguIqu6Mfkp5ZjA2FQoTxe2USEayzk9AuzITQGgPg1SalijYDkf8rEuQ4Lov7KKl1mfziSZL2EaqId5q6Na6rKy5eGsefi_aaPfz5Per8wWedmj04N9tUsiAwAKJXtE3aCbKi9zEDH4Zw-O6HGyxFdbVI0kESPrVCBH_u1kWKo3cu4h63Y-9elpGQqQW-LH3LfVpFSJNPxELQNCDaz_zlzj3WKjs5h1dSrOj-H0OIIR2BbKJ1zoqd-liT2tpFss9r8moaJ4__HkrBZMmt8tz9D4Uu4XjfH4hOTGg8jvdM5bb9ysZ7Pa83crjYft9LjLU1rVDWTV7OjVJ45_LWycKrp8LSMsvzK7qe3WB1wWZghTf1Rj0os9NYqqTYGIKL_D02KRIqayXzq37orBKDpzRNFXUsnj1OXo1yOPv6NrmCN3Oe7jJP5yfuUhlwHXFm0OkbkYphDGvTxNK85Fyc"
                },
                Genres = new List<string>()
                {

                    "фэнтези", "приключения", "драма"
                }
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "Властелин колец: Братство Кольца",
                    Description = "Фродо Бэггинс отправляется спасать Средиземье. Первая часть культовой фэнтези-трилогии Питера Джексона",
                    Year = 2001,
                    Country = "Новая Зеландия, США",
                    Time = 178,
                    Tagline = "Power can be held in the smallest of things...",
                    Director = "Питер Джексон",
                    Budget = 93000000,
                    Fees = 880839846,
                    AgeLimit = 12,
                    Rating = 8.8,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/2s89R4K04/ae7af5CslCkK/rVSfH-4xE1g5HfOmBLXTnYX760KasO5cqWbK3B1pm2sMSA_4-9cDU2J9tDLb4L8BVT8Zdtv1wIXPmqSBLfDtLzkRmutPtMZ93clWg-Sl0lwAG68DfjWKHXhTH2nvmpnoLt8tmwlVAZV2GaBjrmW65VEvrNKLZBHBGLxltulXGEjeZQyN6LKjW4zc8XW0pBFpNYkpdOlDvJgpZVmeXujK-72Nrhm51yNFF5qQRX7HmmajT54ziwJAkeudULbYRykJ3uRdDiqxUWkt3rKUBATiuic4-Tbr4O6LaRbofZ14aIguX5_oexViJqbqAQfuVmglAs7cIvmCIeKrvXPXWHZq6I6kfAxZ8GF5Ta9SNjXlQ5hGKThGiEOfiRmk6M9uOykYjj7Nurj30UbEeGBl_CeqtgM9DuLrMdPDat0AFGrFSzruxM9c6INBae5_Mva0pZL5BzvahHvDrJiJdkl-DWhqeqw-_Urr9CPnxvtDty20e6bQjF5TWyICgJocwMT7R3rYjObPf5uAwenujHAX9gbCuBU5a1SbUy5pKRVKvJ6oC7t8rHzraVYTF0Xbk6cd97qncl_egKnwgkNLHoDFWqZaesy2Dqw4o1C7zpzQt_W18zuHiYrVC9LfqytnKsxe6gkY_s4t6xhnEyfWC-GFr7f7pwGszTPZIlFg2W4Rdyn3aAgcVg4c-cJTm05tQyXUloCrhUlI9unQT1toROsOPQoYuh_MHSirReIWF0jCt4_2iJVjb3yQ6TLAk8hd4MRrVSqoHEYPrnrhM6pvbNLUt4SDCzQ5GYdIc487aXUqzrx5motcPb8qq5eT9vRok2bvh_uVUqxtEymhsoJZvxAUKpSKqk8VvC9IUyBpbU1Q9_TX8Dg0OZinCGGem2inSb4euGrpTL7MKgpFMkbH--ElXOV6FtMv3CIp8pHga-4S5IsU2Jpshtzc63FBif1eE8XWZLFqVEuZJXvznYhJxLreXNvIu34Ovlhbl0Bm91iTl-yEuzfTDU5yGPPAIgndo0fZBMianXUtXoiQ07itztC3ZkTgqvcqOqbIgD0Km-XKrG1ZS2kOj_7ImNXjxseKQwV9pcj2kRx8EQpQY4Fqf3KGytYbO9yknWwas3B7_rwjxJYVU3lGS3pEmhLvCzlnCl1s65lrfB_tGFunMyXEWvOW3pe4VTJtr1EbYtOQq40iNRh0KXr9Bg0cGDDB6a5-szRlhtG6JknpBsrQn7g7xBufvXp6u19dfSgJZ-Ck5hgAZx_2K3dg3j6xeRIjYsnNQsca13iqjoX-zZgTU1u_nXI0BYfTi5Xam6dp0P96ObUKjcwbi6jv7d9KSmRQdzT4E9Qutasm8t_cEDswMELK33MGe-TIuR60Xp1KgZC4XRxA97Wk4ijlWik1CIHMadhUuv6MeYvpT4z9WrpXQhdlGKO1zDeKpKIO3VE7QiACW51gpzrHaMhdhs9sOGOwC12ccMdExfCpJcn5lXtAbkhYtgrsnip62B3e_irbJ8KX1Dpjdl-WSQezXizB6aDjcXldU5QKNykK_DY8fUgS8AhPHJGXtLehulabeQcqgu-ZKUbqzo7r2puef94LO6RDJ3ZJwTQ8tIg3MxzcsPiwImPLjMLFKDV7Ge9nnIzIIQP4Pd9DZXWX8Os3u1iG2oHfCGkFWVwe2nnKLK5fqQnl0kd2KAPW7sWYFfDsThPpkLLDOA7SNxjkKFmsd7zf-1PieS6vcRd3poC4VBq5FUohLZoLVph-X8hKW6xeXai7BgGlVymAdV60qhbgrf_haRHgkhu-ApX5V2rrH5RsH0gxcCptPtA3t8fRajZbCJTrwBy7W8bZDGxJe5r-Po1LOteDFuZoQGZNtTsHwD5OgwtwwjKpPqEnyTaqSZ4FnF3ZUpC4nt0hhpSF0XkVaxoVy-BMmQhEeO9Me9h5vAxsKJmH4Ja2apHUD7U5hVNN32P54eHC2n3Td1q0-PguVD1sqUHjqj6_4xYld_KLhVlq1-vxv4qJJ1jO3_lbW0_Nn3urNyOGp9ixV65luGQgvQwRe1BSULoPwZXK9Xh4rmStHlnhc6uMv0OUJiXC-GXKGWX6YK_6SrQqTE06C8kcba466wQAB_eZcIZMxFp04h2-sNnzYkKq7eC1aNUrO9z27T57wSC4b1yDh5TE8HtGS2onGVHOCOqUK178-hmZXI3uOgrmczemOrF0zYVK1jEtjGPowVFBWy8DF_rlqBjsVP1-CrDQGz3fIKZWZoDJRDvq1Wnznfg5ZEp8b0h4aZ4tX0jrtgKVBxlzJ94FaPWwDc1Ty0DgElu88SRqdVkYjQcPHfqjkws_L8KnZBcCmmdo-BY5kF4a2qQI3PzpKzsOvq34SlVCh1U4EFdulFq3Y34MgRkSYpPpXgPXGzZ6mn0nvH2LQtHrzZxS52WGEpsmC3omipGMa2r0SB-u21tKf2y_6ytVIZQFiXNFfBaLBeM_P8CI4KCya-wDFWqlaEqsZ828m0BDWI6fIdZmRAKaBbrrlQiADnk4dTkOvguIqu6Mfkp5ZjA2FQoTxe2USEayzk9AuzITQGgPg1SalijYDkf8rEuQ4Lov7KKl1mfziSZL2EaqId5q6Na6rKy5eGsefi_aaPfz5Per8wWedmj04N9tUsiAwAKJXtE3aCbKi9zEDH4Zw-O6HGyxFdbVI0kESPrVCBH_u1kWKo3cu4h63Y-9elpGQqQW-LH3LfVpFSJNPxELQNCDaz_zlzj3WKjs5h1dSrOj-H0OIIR2BbKJ1zoqd-liT2tpFss9r8moaJ4__HkrBZMmt8tz9D4Uu4XjfH4hOTGg8jvdM5bb9ysZ7Pa83crjYft9LjLU1rVDWTV7OjVJ45_LWycKrp8LSMsvzK7qe3WB1wWZghTf1Rj0os9NYqqTYGIKL_D02KRIqayXzq37orBKDpzRNFXUsnj1OXo1yOPv6NrmCN3Oe7jJP5yfuUhlwHXFm0OkbkYphDGvTxNK85Fyc#DSD"

                },
                Genres = new List<string>()
                {

                    "фэнтези", "приключения", "драма"
                }
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "Король Лев",
                    Description = "Львенок Симба бросает вызов дяде-убийце. Величественный саундтрек, рисованная анимация и шекспировский размах",
                    Year = 1994,
                    Country = "США",
                    Time = 88,
                    Tagline = "The Circle of Life",
                    Director = "Роджер Аллерс, Роб Минкофф",
                    Budget = 45000000,
                    Fees = 763455561,
                    AgeLimit = 0,
                    Rating = 8.6,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/2s89R4K04/ae7af5CslCkK/rVSfH-4xE1g5HfOmBLXTnYX760KasO5cqWbK3B1pm2sMSA_4-9cDU2J9pBILQG9hVUpcU67A4MB_n7TBDSDtLzkB-u7KlFMt2PxDhqTgxzwVDq8mTjWKHXhTH2nvmpnoLt8tmwlVAZV2GaBjrmW65VEvrNKLZBHBGLxltulXGEjeZQyN6LKjW4zc8XW0pBFpNYkpdOlDvJgpZVmeXujK-72Nrhm51yNFF5qQRX7HmmajT54ziwJAkeudULbYRykJ3uRdDiqxUWkt3rKUBATiuic4-Tbr4O6LaRbofZ14aIguX5_oexViJqbqAQfuVmglAs7cIvmCIeKrvXPXWHZq6I6kfAxZ8GF5Ta9SNjXlQ5hGKThGiEOfiRmk6M9uOykYjj7Nurj30UbEeGBl_CeqtgM9DuLrMdPDat0AFGrFSzruxM9c6INBae5_Mva0pZL5BzvahHvDrJiJdkl-DWhqeqw-_Urr9CPnxvtDty20e6bQjF5TWyICgJocwMT7R3rYjObPf5uAwenujHAX9gbCuBU5a1SbUy5pKRVKvJ6oC7t8rHzraVYTF0Xbk6cd97qncl_egKnwgkNLHoDFWqZaesy2Dqw4o1C7zpzQt_W18zuHiYrVC9LfqytnKsxe6gkY_s4t6xhnEyfWC-GFr7f7pwGszTPZIlFg2W4Rdyn3aAgcVg4c-cJTm05tQyXUloCrhUlI9unQT1toROsOPQoYuh_MHSirReIWF0jCt4_2iJVjb3yQ6TLAk8hd4MRrVSqoHEYPrnrhM6pvbNLUt4SDCzQ5GYdIc487aXUqzrx5motcPb8qq5eT9vRok2bvh_uVUqxtEymhsoJZvxAUKpSKqk8VvC9IUyBpbU1Q9_TX8Dg0OZinCGGem2inSb4euGrpTL7MKgpFMkbH--ElXOV6FtMv3CIp8pHga-4S5IsU2Jpshtzc63FBif1eE8XWZLFqVEuZJXvznYhJxLreXNvIu34Ovlhbl0Bm91iTl-yEuzfTDU5yGPPAIgndo0fZBMianXUtXoiQ07itztC3ZkTgqvcqOqbIgD0Km-XKrG1ZS2kOj_7ImNXjxseKQwV9pcj2kRx8EQpQY4Fqf3KGytYbO9yknWwas3B7_rwjxJYVU3lGS3pEmhLvCzlnCl1s65lrfB_tGFunMyXEWvOW3pe4VTJtr1EbYtOQq40iNRh0KXr9Bg0cGDDB6a5-szRlhtG6JknpBsrQn7g7xBufvXp6u19dfSgJZ-Ck5hgAZx_2K3dg3j6xeRIjYsnNQsca13iqjoX-zZgTU1u_nXI0BYfTi5Xam6dp0P96ObUKjcwbi6jv7d9KSmRQdzT4E9Qutasm8t_cEDswMELK33MGe-TIuR60Xp1KgZC4XRxA97Wk4ijlWik1CIHMadhUuv6MeYvpT4z9WrpXQhdlGKO1zDeKpKIO3VE7QiACW51gpzrHaMhdhs9sOGOwC12ccMdExfCpJcn5lXtAbkhYtgrsnip62B3e_irbJ8KX1Dpjdl-WSQezXizB6aDjcXldU5QKNykK_DY8fUgS8AhPHJGXtLehulabeQcqgu-ZKUbqzo7r2puef94LO6RDJ3ZJwTQ8tIg3MxzcsPiwImPLjMLFKDV7Ge9nnIzIIQP4Pd9DZXWX8Os3u1iG2oHfCGkFWVwe2nnKLK5fqQnl0kd2KAPW7sWYFfDsThPpkLLDOA7SNxjkKFmsd7zf-1PieS6vcRd3poC4VBq5FUohLZoLVph-X8hKW6xeXai7BgGlVymAdV60qhbgrf_haRHgkhu-ApX5V2rrH5RsH0gxcCptPtA3t8fRajZbCJTrwBy7W8bZDGxJe5r-Po1LOteDFuZoQGZNtTsHwD5OgwtwwjKpPqEnyTaqSZ4FnF3ZUpC4nt0hhpSF0XkVaxoVy-BMmQhEeO9Me9h5vAxsKJmH4Ja2apHUD7U5hVNN32P54eHC2n3Td1q0-PguVD1sqUHjqj6_4xYld_KLhVlq1-vxv4qJJ1jO3_lbW0_Nn3urNyOGp9ixV65luGQgvQwRe1BSULoPwZXK9Xh4rmStHlnhc6uMv0OUJiXC-GXKGWX6YK_6SrQqTE06C8kcba466wQAB_eZcIZMxFp04h2-sNnzYkKq7eC1aNUrO9z27T57wSC4b1yDh5TE8HtGS2onGVHOCOqUK178-hmZXI3uOgrmczemOrF0zYVK1jEtjGPowVFBWy8DF_rlqBjsVP1-CrDQGz3fIKZWZoDJRDvq1Wnznfg5ZEp8b0h4aZ4tX0jrtgKVBxlzJ94FaPWwDc1Ty0DgElu88SRqdVkYjQcPHfqjkws_L8KnZBcCmmdo-BY5kF4a2qQI3PzpKzsOvq34SlVCh1U4EFdulFq3Y34MgRkSYpPpXgPXGzZ6mn0nvH2LQtHrzZxS52WGEpsmC3omipGMa2r0SB-u21tKf2y_6ytVIZQFiXNFfBaLBeM_P8CI4KCya-wDFWqlaEqsZ828m0BDWI6fIdZmRAKaBbrrlQiADnk4dTkOvguIqu6Mfkp5ZjA2FQoTxe2USEayzk9AuzITQGgPg1SalijYDkf8rEuQ4Lov7KKl1mfziSZL2EaqId5q6Na6rKy5eGsefi_aaPfz5Per8wWedmj04N9tUsiAwAKJXtE3aCbKi9zEDH4Zw-O6HGyxFdbVI0kESPrVCBH_u1kWKo3cu4h63Y-9elpGQqQW-LH3LfVpFSJNPxELQNCDaz_zlzj3WKjs5h1dSrOj-H0OIIR2BbKJ1zoqd-liT2tpFss9r8moaJ4__HkrBZMmt8tz9D4Uu4XjfH4hOTGg8jvdM5bb9ysZ7Pa83crjYft9LjLU1rVDWTV7OjVJ45_LWycKrp8LSMsvzK7qe3WB1wWZghTf1Rj0os9NYqqTYGIKL_D02KRIqayXzq37orBKDpzRNFXUsnj1OXo1yOPv6NrmCN3Oe7jJP5yfuUhlwHXFm0OkbkYphDGvTxNK85Fyc#DSD"
                },
                Genres = new List<string>()
                {
                    "мультфильм", "мюзикл", "драма", "приключения", "семейный"
                }
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "Форрест Гамп",
                    Description = "Полувековая история США глазами чудака из Алабамы. Абсолютная классика Роберта Земекиса с Томом Хэнксом",
                    Year = 1994,
                    Country = "США",
                    Time = 88,
                    Tagline = "Мир уже никогда не будет прежним, после того как вы увидите его глазами Форреста Гампа",
                    Director = "Роберт Земекис",
                    Budget = 55000000,
                    Fees = 677387716,
                    AgeLimit = 12,
                    Rating = 8.6,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/2s89R4K04/ae7af5CslCkK/rVSfH-4xE1g5HfOmBLXTnYX760KasO5cqWbK3B1pm2sMSA_4-9cDU2J9hILb0A-BVRoJJrv1hbU_mgGRzTDtL-xEuu7KtEMt2JlGg3GApywQG9-WLjWKHXhTH2nvmpnoLt8tmwlVAZV2GaBjrmW65VEvrNKLZBHBGLxltulXGEjeZQyN6LKjW4zc8XW0pBFpNYkpdOlDvJgpZVmeXujK-72Nrhm51yNFF5qQRX7HmmajT54ziwJAkeudULbYRykJ3uRdDiqxUWkt3rKUBATiuic4-Tbr4O6LaRbofZ14aIguX5_oexViJqbqAQfuVmglAs7cIvmCIeKrvXPXWHZq6I6kfAxZ8GF5Ta9SNjXlQ5hGKThGiEOfiRmk6M9uOykYjj7Nurj30UbEeGBl_CeqtgM9DuLrMdPDat0AFGrFSzruxM9c6INBae5_Mva0pZL5BzvahHvDrJiJdkl-DWhqeqw-_Urr9CPnxvtDty20e6bQjF5TWyICgJocwMT7R3rYjObPf5uAwenujHAX9gbCuBU5a1SbUy5pKRVKvJ6oC7t8rHzraVYTF0Xbk6cd97qncl_egKnwgkNLHoDFWqZaesy2Dqw4o1C7zpzQt_W18zuHiYrVC9LfqytnKsxe6gkY_s4t6xhnEyfWC-GFr7f7pwGszTPZIlFg2W4Rdyn3aAgcVg4c-cJTm05tQyXUloCrhUlI9unQT1toROsOPQoYuh_MHSirReIWF0jCt4_2iJVjb3yQ6TLAk8hd4MRrVSqoHEYPrnrhM6pvbNLUt4SDCzQ5GYdIc487aXUqzrx5motcPb8qq5eT9vRok2bvh_uVUqxtEymhsoJZvxAUKpSKqk8VvC9IUyBpbU1Q9_TX8Dg0OZinCGGem2inSb4euGrpTL7MKgpFMkbH--ElXOV6FtMv3CIp8pHga-4S5IsU2Jpshtzc63FBif1eE8XWZLFqVEuZJXvznYhJxLreXNvIu34Ovlhbl0Bm91iTl-yEuzfTDU5yGPPAIgndo0fZBMianXUtXoiQ07itztC3ZkTgqvcqOqbIgD0Km-XKrG1ZS2kOj_7ImNXjxseKQwV9pcj2kRx8EQpQY4Fqf3KGytYbO9yknWwas3B7_rwjxJYVU3lGS3pEmhLvCzlnCl1s65lrfB_tGFunMyXEWvOW3pe4VTJtr1EbYtOQq40iNRh0KXr9Bg0cGDDB6a5-szRlhtG6JknpBsrQn7g7xBufvXp6u19dfSgJZ-Ck5hgAZx_2K3dg3j6xeRIjYsnNQsca13iqjoX-zZgTU1u_nXI0BYfTi5Xam6dp0P96ObUKjcwbi6jv7d9KSmRQdzT4E9Qutasm8t_cEDswMELK33MGe-TIuR60Xp1KgZC4XRxA97Wk4ijlWik1CIHMadhUuv6MeYvpT4z9WrpXQhdlGKO1zDeKpKIO3VE7QiACW51gpzrHaMhdhs9sOGOwC12ccMdExfCpJcn5lXtAbkhYtgrsnip62B3e_irbJ8KX1Dpjdl-WSQezXizB6aDjcXldU5QKNykK_DY8fUgS8AhPHJGXtLehulabeQcqgu-ZKUbqzo7r2puef94LO6RDJ3ZJwTQ8tIg3MxzcsPiwImPLjMLFKDV7Ge9nnIzIIQP4Pd9DZXWX8Os3u1iG2oHfCGkFWVwe2nnKLK5fqQnl0kd2KAPW7sWYFfDsThPpkLLDOA7SNxjkKFmsd7zf-1PieS6vcRd3poC4VBq5FUohLZoLVph-X8hKW6xeXai7BgGlVymAdV60qhbgrf_haRHgkhu-ApX5V2rrH5RsH0gxcCptPtA3t8fRajZbCJTrwBy7W8bZDGxJe5r-Po1LOteDFuZoQGZNtTsHwD5OgwtwwjKpPqEnyTaqSZ4FnF3ZUpC4nt0hhpSF0XkVaxoVy-BMmQhEeO9Me9h5vAxsKJmH4Ja2apHUD7U5hVNN32P54eHC2n3Td1q0-PguVD1sqUHjqj6_4xYld_KLhVlq1-vxv4qJJ1jO3_lbW0_Nn3urNyOGp9ixV65luGQgvQwRe1BSULoPwZXK9Xh4rmStHlnhc6uMv0OUJiXC-GXKGWX6YK_6SrQqTE06C8kcba466wQAB_eZcIZMxFp04h2-sNnzYkKq7eC1aNUrO9z27T57wSC4b1yDh5TE8HtGS2onGVHOCOqUK178-hmZXI3uOgrmczemOrF0zYVK1jEtjGPowVFBWy8DF_rlqBjsVP1-CrDQGz3fIKZWZoDJRDvq1Wnznfg5ZEp8b0h4aZ4tX0jrtgKVBxlzJ94FaPWwDc1Ty0DgElu88SRqdVkYjQcPHfqjkws_L8KnZBcCmmdo-BY5kF4a2qQI3PzpKzsOvq34SlVCh1U4EFdulFq3Y34MgRkSYpPpXgPXGzZ6mn0nvH2LQtHrzZxS52WGEpsmC3omipGMa2r0SB-u21tKf2y_6ytVIZQFiXNFfBaLBeM_P8CI4KCya-wDFWqlaEqsZ828m0BDWI6fIdZmRAKaBbrrlQiADnk4dTkOvguIqu6Mfkp5ZjA2FQoTxe2USEayzk9AuzITQGgPg1SalijYDkf8rEuQ4Lov7KKl1mfziSZL2EaqId5q6Na6rKy5eGsefi_aaPfz5Per8wWedmj04N9tUsiAwAKJXtE3aCbKi9zEDH4Zw-O6HGyxFdbVI0kESPrVCBH_u1kWKo3cu4h63Y-9elpGQqQW-LH3LfVpFSJNPxELQNCDaz_zlzj3WKjs5h1dSrOj-H0OIIR2BbKJ1zoqd-liT2tpFss9r8moaJ4__HkrBZMmt8tz9D4Uu4XjfH4hOTGg8jvdM5bb9ysZ7Pa83crjYft9LjLU1rVDWTV7OjVJ45_LWycKrp8LSMsvzK7qe3WB1wWZghTf1Rj0os9NYqqTYGIKL_D02KRIqayXzq37orBKDpzRNFXUsnj1OXo1yOPv6NrmCN3Oe7jJP5yfuUhlwHXFm0OkbkYphDGvTxNK85Fyc"
                },
                Genres = new List<string>()
                {
                    "драма", "комедия", "мелодрама", "история", "военный"
                }
            },
        };
    }
}
