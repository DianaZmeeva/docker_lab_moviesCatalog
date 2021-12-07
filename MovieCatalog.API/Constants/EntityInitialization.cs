using System;
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
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "Интерстеллар",
                    Description = "Фантастический эпос про задыхающуюся Землю, космические полеты и парадоксы времени. «Оскар» за спецэффекты",
                    Year = 2014,
                    Country = "Великобритания, Канада, США",
                    Time = 169,
                    Tagline = "Следующий шаг человечества станет величайшим",
                    Director = "Кристофер Нолан",
                    Budget = 165000000,
                    Fees = 677896797,
                    AgeLimit = 16,
                    Rating = 8.6,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/15D2S2r30/33deda7SK/7htRvK7qLcqB7zW47Pf5ERgu4sxJy-F4M37R8H0rzARd-esRa2vgXRtB0HIAJ443Exjdm4-a9xGcRhAMP4_Q098SNKnLlmTmpL5MhcW2iFBND9-9BZLEWWpupb0IRrC4nVkjtKPzHP2b8FVrBTv3QmZ93Ir-__pt7BpNxNaawXp6CxEMfhagTpHbcKgw1ykRpG_2nH2W_Ug7c03ozQeoeEkFPxhLj-TdV2w1jw32S_ZKUbASRvv2kJjWHYQvjoUC1kf58MqGrL75X3w8ALPFtRxbTiBhonHsa-PRTOEbxIDt5YMYE4f4_RvoyfPp6hc6ki0ATpL37lQwksGIa7Ih6qoTscie5tBG_ft0zOxPUbGYS7qohdJJgJMHyUBVT2DY_eUvAAfnbEWf0MkTYXrX4mah9FpelyLctB7dIBPGYfJyb0HYOhog7tUvxDTMl32FuO-GJEGCRVyvDwE4UaMwzDVN5_QHgzRd3wTZ-zFqV2Ki8UAW4m_-DADqyQif0rXyRqMN5MJG3F6Nv_QYpOcVIYhz8ihJ3kVgt5exyIGrdCBFvffgixfEMVf0PRPJWste4pFwEsbnhqjg3ik8GwZh5uLrSfT6bsg-XTO4tNDn9aU0R7JUeb7F6Df3YTRVg7hc2c2PAL_fwO2rWMn7CUqLZvoR2Koi855UkBohZKeG0R6O7x0MjiqwKqlTZBxYQwUFvG_WMEm-aeBnO6lY0SfgBIWRk2j3cwjJkxDdqwmyw8pmCdSqWnMSKEDisXw3IhHmyl9x_JYCoKJ5w3DQ3Nfdabyf5mT5PuXMK3PpiOE3rOTFZffsU_uweS9IPasFDlf6jhn4ohqzglzQ6r1w9wKV1tbH-VB2tuTKcTMQSGxTjcGUC5KUQaY9KB_7dbhde_jUpTk3FAcDmJlTbOX7cdp3Cup5bEbmlxLkXGKl-L9OgYomf5kIuuIkxgE_2NCkF_mVtEceqH3eDcyHq6HM8T-gwC15G-w3ZxiNo-BRdwk6n65aeSh-fley4GQCeQh78r2S_lfpyPIGgHZVv6isMOsFUcxnHjjZNn1ULxcN5MG_-NBVibscV_dIYTcU2YcZMke6IlWERtqfYiAUFgFc6y4p8q5vEYw6bqSaCR_IQBwTeWHYH2rwtcYR4Ld3uXj1p2Ts5QWD-DcviOEDXN0X3arXDk5ZPOpaw2p8wJaNfIe6qW6---38wua4_vHb4MC81229XC_KxPmCjcy_a4F8SbP4cGXpxxADq5yJk0wpMzGOa2Z66QDeznPmHGTCTZSLhsly7lNlRMIq8M6h73Qo3H_lxQhXkixptpX85x8tCN0HLAwp5X_sOxs8_dcQoVcxTlfO_uFoel7HhiRIAgEQ75Il9u6jRbSCAjBiveuoXAQX9VEUj45QEbqBcI8LxZxFq6gERcmzgJ9bjME7NNmjhepDtk6VuOJad3qclOrVlMOSoda-C3FAhsbk1t3nEDAgI3HVRNsSSJm-WfAHf7kEZfNAzCERz4hTX3QdI9x5L3FyC76OXcQK8svy0NwKxZSzgklWLp81MLaW1N71e_BIDLOVCcjnDuAVQvGgC_u1fJmDlEz12bNkQw9IRTv4cWv5VgeyYvUwolrTHujoXh2wPxbJnsYf-czODsB6jd_YmASrbZlEd96owTadsBNPIdRFM0TIteXPVHN7zElbcNlf3X6TXlLdaB4aY5KI-IqFcMMGoV56X_XIOh6k6pU3HATUq3G9VF_KZDVejcwjh_20eYvUfCVJ__hvw2Rxy-zZC4nuY6ZGAfR6Uh-uIJROFYiX_iG6YtNJYLqGfNqZp6DEAE8hidiHOviJSr1Yt3sNUI0r6HTRPWt8z9vMhSvk3fcVSneKCoEojkpTphTkDhFsr7YFYnrPBWhCRqBaHUugyAz_eQXkf860ZdJxpPPrKWgJt0B0iYkDsAfr5HEv0HlnfT4bMvqJRMbiO2LcmMKFfH9OSer6383cHubszgnLcLzoq3WNzG9uFG02PaRn441UZfPoYAlllwhHe9wJW3hJ84HScz7SXSBWGr-KFOgeHRhPMjGGeiNJ1DICdCKVM9BUyDt9zZT_stC5-oXolxvB_A0rxFSthXusA8fsQSfIqS_lyofKEgFoiuJ7pphYOpVcuzJdujJvbagublzmvatQhEj7TQ0IkxowVRbJvOufXcgZUzRs7bWfcAt7WOUv0C33TXbHenpd9KJy86bMBP5ZWJOSmf5WW2XQuqpkyv0rzByMt9FFZP-CoJme6XQDY0nYfa_IBMEd_zRvQ_hNl8jlD5lSmzp-XYBOcvvyXAAODfznImEa2teJ6IrqXK6dPyiErF9NUTwf-kSRMnXUn3fJcP2LrFwtwaP8O9_oBTtQ8RcZQo--zpWABh7fHuw0-hUYG04hBsJfdXj6CvS24U8cBCBXEcnYj74wkR6FMOsXqcABR7iMLbWLLB__8H0DyFlzEabTPmb9sNoqA_LE_HLxMDsq4SYqFxms_mboEtUvWAyo-4lVaIu-RDmKQXT7GyW0fZ-YDGW9j-Sb14B9F0xhY3XOE672ASQO0keCGESaiZwL0iEqflNtKAYySFaFM1yQNOultRQHQmxJ-nVoIwupcJlDECx9GQfwVwNAZZfkiXdtJgfeAi2w8vpf3lQw6lW0N6pdnu4f6dRqlvxSpTsYkKj7TaUIUx60uQ4JxJePsYwZh_h0KdGjLM9rmEET4EHnEXYTBsZR8FbqHzogXE7xrAu-7ZbCS_X0tjrQYjG3JMiwv-VRvI_6NAWqRcQ382GMOZuQwGVNB6zLn5z1G9zde0Ved9py3bBG9s_SmATmXWQ_CrmW2tf5xPoCqP6N62yEUD9ZEagXCsgRjpU0dzNdvE1D6FzB8ZeUe8vYQS90VfPNNmM-8lE4qsoLamTcOqHgzx6RhuarRfSOaohOFTfowIAj6Q0QG-5g5boRqDsLWUj912BAdWk7hNP7QH1DTLFzZTov2oYdfHZij4L87MK8#DSD"

                },
                Genres = new List<string>()
                {
                    "фантастика", "драма", "приключения"
                }
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "Иван Васильевич меняет профессию",
                    Description = "Иван Грозный отвечает на телефон, пока его тезка-пенсионер сидит на троне. Советский хит о липовом государе",
                    Year = 1973,
                    Country = "СССР",
                    Time = 88,
                    Tagline = "-",
                    Director = "Леонид Гайдай",
                    Budget = null,
                    Fees = null,
                    AgeLimit = 6,
                    Rating = 8.6,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/15D2S2r30/33deda7SK/7htRvK7qLcqB7zW47Pf5ERgu4sxJy-F4M37R8H0rzARd-esRa2vgXRtB0HIEJ54LExzdjsee6wDARhwMO5_I_98SFeHvlmWv4L5N5cz-lGUdGoLhGZ-EWWpupb0IRrC4nVkjtKPzHP2b8FVrBTv3QmZ93Ir-__pt7BpNxNaawXp6CxEMfhagTpHbcKgw1ykRpG_2nH2W_Ug7c03ozQeoeEkFPxhLj-TdV2w1jw32S_ZKUbASRvv2kJjWHYQvjoUC1kf58MqGrL75X3w8ALPFtRxbTiBhonHsa-PRTOEbxIDt5YMYE4f4_RvoyfPp6hc6ki0ATpL37lQwksGIa7Ih6qoTscie5tBG_ft0zOxPUbGYS7qohdJJgJMHyUBVT2DY_eUvAAfnbEWf0MkTYXrX4mah9FpelyLctB7dIBPGYfJyb0HYOhog7tUvxDTMl32FuO-GJEGCRVyvDwE4UaMwzDVN5_QHgzRd3wTZ-zFqV2Ki8UAW4m_-DADqyQif0rXyRqMN5MJG3F6Nv_QYpOcVIYhz8ihJ3kVgt5exyIGrdCBFvffgixfEMVf0PRPJWste4pFwEsbnhqjg3ik8GwZh5uLrSfT6bsg-XTO4tNDn9aU0R7JUeb7F6Df3YTRVg7hc2c2PAL_fwO2rWMn7CUqLZvoR2Koi855UkBohZKeG0R6O7x0MjiqwKqlTZBxYQwUFvG_WMEm-aeBnO6lY0SfgBIWRk2j3cwjJkxDdqwmyw8pmCdSqWnMSKEDisXw3IhHmyl9x_JYCoKJ5w3DQ3Nfdabyf5mT5PuXMK3PpiOE3rOTFZffsU_uweS9IPasFDlf6jhn4ohqzglzQ6r1w9wKV1tbH-VB2tuTKcTMQSGxTjcGUC5KUQaY9KB_7dbhde_jUpTk3FAcDmJlTbOX7cdp3Cup5bEbmlxLkXGKl-L9OgYomf5kIuuIkxgE_2NCkF_mVtEceqH3eDcyHq6HM8T-gwC15G-w3ZxiNo-BRdwk6n65aeSh-fley4GQCeQh78r2S_lfpyPIGgHZVv6isMOsFUcxnHjjZNn1ULxcN5MG_-NBVibscV_dIYTcU2YcZMke6IlWERtqfYiAUFgFc6y4p8q5vEYw6bqSaCR_IQBwTeWHYH2rwtcYR4Ld3uXj1p2Ts5QWD-DcviOEDXN0X3arXDk5ZPOpaw2p8wJaNfIe6qW6---38wua4_vHb4MC81229XC_KxPmCjcy_a4F8SbP4cGXpxxADq5yJk0wpMzGOa2Z66QDeznPmHGTCTZSLhsly7lNlRMIq8M6h73Qo3H_lxQhXkixptpX85x8tCN0HLAwp5X_sOxs8_dcQoVcxTlfO_uFoel7HhiRIAgEQ75Il9u6jRbSCAjBiveuoXAQX9VEUj45QEbqBcI8LxZxFq6gERcmzgJ9bjME7NNmjhepDtk6VuOJad3qclOrVlMOSoda-C3FAhsbk1t3nEDAgI3HVRNsSSJm-WfAHf7kEZfNAzCERz4hTX3QdI9x5L3FyC76OXcQK8svy0NwKxZSzgklWLp81MLaW1N71e_BIDLOVCcjnDuAVQvGgC_u1fJmDlEz12bNkQw9IRTv4cWv5VgeyYvUwolrTHujoXh2wPxbJnsYf-czODsB6jd_YmASrbZlEd96owTadsBNPIdRFM0TIteXPVHN7zElbcNlf3X6TXlLdaB4aY5KI-IqFcMMGoV56X_XIOh6k6pU3HATUq3G9VF_KZDVejcwjh_20eYvUfCVJ__hvw2Rxy-zZC4nuY6ZGAfR6Uh-uIJROFYiX_iG6YtNJYLqGfNqZp6DEAE8hidiHOviJSr1Yt3sNUI0r6HTRPWt8z9vMhSvk3fcVSneKCoEojkpTphTkDhFsr7YFYnrPBWhCRqBaHUugyAz_eQXkf860ZdJxpPPrKWgJt0B0iYkDsAfr5HEv0HlnfT4bMvqJRMbiO2LcmMKFfH9OSer6383cHubszgnLcLzoq3WNzG9uFG02PaRn441UZfPoYAlllwhHe9wJW3hJ84HScz7SXSBWGr-KFOgeHRhPMjGGeiNJ1DICdCKVM9BUyDt9zZT_stC5-oXolxvB_A0rxFSthXusA8fsQSfIqS_lyofKEgFoiuJ7pphYOpVcuzJdujJvbagublzmvatQhEj7TQ0IkxowVRbJvOufXcgZUzRs7bWfcAt7WOUv0C33TXbHenpd9KJy86bMBP5ZWJOSmf5WW2XQuqpkyv0rzByMt9FFZP-CoJme6XQDY0nYfa_IBMEd_zRvQ_hNl8jlD5lSmzp-XYBOcvvyXAAODfznImEa2teJ6IrqXK6dPyiErF9NUTwf-kSRMnXUn3fJcP2LrFwtwaP8O9_oBTtQ8RcZQo--zpWABh7fHuw0-hUYG04hBsJfdXj6CvS24U8cBCBXEcnYj74wkR6FMOsXqcABR7iMLbWLLB__8H0DyFlzEabTPmb9sNoqA_LE_HLxMDsq4SYqFxms_mboEtUvWAyo-4lVaIu-RDmKQXT7GyW0fZ-YDGW9j-Sb14B9F0xhY3XOE672ASQO0keCGESaiZwL0iEqflNtKAYySFaFM1yQNOultRQHQmxJ-nVoIwupcJlDECx9GQfwVwNAZZfkiXdtJgfeAi2w8vpf3lQw6lW0N6pdnu4f6dRqlvxSpTsYkKj7TaUIUx60uQ4JxJePsYwZh_h0KdGjLM9rmEET4EHnEXYTBsZR8FbqHzogXE7xrAu-7ZbCS_X0tjrQYjG3JMiwv-VRvI_6NAWqRcQ382GMOZuQwGVNB6zLn5z1G9zde0Ved9py3bBG9s_SmATmXWQ_CrmW2tf5xPoCqP6N62yEUD9ZEagXCsgRjpU0dzNdvE1D6FzB8ZeUe8vYQS90VfPNNmM-8lE4qsoLamTcOqHgzx6RhuarRfSOaohOFTfowIAj6Q0QG-5g5boRqDsLWUj912BAdWk7hNP7QH1DTLFzZTov2oYdfHZij4L87MK8"
                },
                Genres = new List<string>()
                {
                    "фантастика", "комедия", "приключения"
                }
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "Тайна Коко",
                    Description = "Юный музыкант Мигель попадает в мир мертвых. Трогательная история о любви без границ, получившая два «Оскара»",
                    Year = 2017,
                    Country = "США",
                    Time = 105,
                    Tagline = "The celebration of a lifetime",
                    Director = "Ли Анкрич, Эдриан Молина",
                    Budget = 175000000,
                    Fees = 807082196,
                    AgeLimit = 12,
                    Rating = 8.6,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/15D2S2r30/33deda7SK/7htRvK7qLcqB7zW47Pf5ERgu4sxJy-F4M37R8H0rzARd-esRa2vgXRtB0HI8N5Y_FyDdktee8kWRCgwMJv6c698SMKizlwW37LZNwc2ypGEJE8uUTYu4WWpupb0IRrC4nVkjtKPzHP2b8FVrBTv3QmZ93Ir-__pt7BpNxNaawXp6CxEMfhagTpHbcKgw1ykRpG_2nH2W_Ug7c03ozQeoeEkFPxhLj-TdV2w1jw32S_ZKUbASRvv2kJjWHYQvjoUC1kf58MqGrL75X3w8ALPFtRxbTiBhonHsa-PRTOEbxIDt5YMYE4f4_RvoyfPp6hc6ki0ATpL37lQwksGIa7Ih6qoTscie5tBG_ft0zOxPUbGYS7qohdJJgJMHyUBVT2DY_eUvAAfnbEWf0MkTYXrX4mah9FpelyLctB7dIBPGYfJyb0HYOhog7tUvxDTMl32FuO-GJEGCRVyvDwE4UaMwzDVN5_QHgzRd3wTZ-zFqV2Ki8UAW4m_-DADqyQif0rXyRqMN5MJG3F6Nv_QYpOcVIYhz8ihJ3kVgt5exyIGrdCBFvffgixfEMVf0PRPJWste4pFwEsbnhqjg3ik8GwZh5uLrSfT6bsg-XTO4tNDn9aU0R7JUeb7F6Df3YTRVg7hc2c2PAL_fwO2rWMn7CUqLZvoR2Koi855UkBohZKeG0R6O7x0MjiqwKqlTZBxYQwUFvG_WMEm-aeBnO6lY0SfgBIWRk2j3cwjJkxDdqwmyw8pmCdSqWnMSKEDisXw3IhHmyl9x_JYCoKJ5w3DQ3Nfdabyf5mT5PuXMK3PpiOE3rOTFZffsU_uweS9IPasFDlf6jhn4ohqzglzQ6r1w9wKV1tbH-VB2tuTKcTMQSGxTjcGUC5KUQaY9KB_7dbhde_jUpTk3FAcDmJlTbOX7cdp3Cup5bEbmlxLkXGKl-L9OgYomf5kIuuIkxgE_2NCkF_mVtEceqH3eDcyHq6HM8T-gwC15G-w3ZxiNo-BRdwk6n65aeSh-fley4GQCeQh78r2S_lfpyPIGgHZVv6isMOsFUcxnHjjZNn1ULxcN5MG_-NBVibscV_dIYTcU2YcZMke6IlWERtqfYiAUFgFc6y4p8q5vEYw6bqSaCR_IQBwTeWHYH2rwtcYR4Ld3uXj1p2Ts5QWD-DcviOEDXN0X3arXDk5ZPOpaw2p8wJaNfIe6qW6---38wua4_vHb4MC81229XC_KxPmCjcy_a4F8SbP4cGXpxxADq5yJk0wpMzGOa2Z66QDeznPmHGTCTZSLhsly7lNlRMIq8M6h73Qo3H_lxQhXkixptpX85x8tCN0HLAwp5X_sOxs8_dcQoVcxTlfO_uFoel7HhiRIAgEQ75Il9u6jRbSCAjBiveuoXAQX9VEUj45QEbqBcI8LxZxFq6gERcmzgJ9bjME7NNmjhepDtk6VuOJad3qclOrVlMOSoda-C3FAhsbk1t3nEDAgI3HVRNsSSJm-WfAHf7kEZfNAzCERz4hTX3QdI9x5L3FyC76OXcQK8svy0NwKxZSzgklWLp81MLaW1N71e_BIDLOVCcjnDuAVQvGgC_u1fJmDlEz12bNkQw9IRTv4cWv5VgeyYvUwolrTHujoXh2wPxbJnsYf-czODsB6jd_YmASrbZlEd96owTadsBNPIdRFM0TIteXPVHN7zElbcNlf3X6TXlLdaB4aY5KI-IqFcMMGoV56X_XIOh6k6pU3HATUq3G9VF_KZDVejcwjh_20eYvUfCVJ__hvw2Rxy-zZC4nuY6ZGAfR6Uh-uIJROFYiX_iG6YtNJYLqGfNqZp6DEAE8hidiHOviJSr1Yt3sNUI0r6HTRPWt8z9vMhSvk3fcVSneKCoEojkpTphTkDhFsr7YFYnrPBWhCRqBaHUugyAz_eQXkf860ZdJxpPPrKWgJt0B0iYkDsAfr5HEv0HlnfT4bMvqJRMbiO2LcmMKFfH9OSer6383cHubszgnLcLzoq3WNzG9uFG02PaRn441UZfPoYAlllwhHe9wJW3hJ84HScz7SXSBWGr-KFOgeHRhPMjGGeiNJ1DICdCKVM9BUyDt9zZT_stC5-oXolxvB_A0rxFSthXusA8fsQSfIqS_lyofKEgFoiuJ7pphYOpVcuzJdujJvbagublzmvatQhEj7TQ0IkxowVRbJvOufXcgZUzRs7bWfcAt7WOUv0C33TXbHenpd9KJy86bMBP5ZWJOSmf5WW2XQuqpkyv0rzByMt9FFZP-CoJme6XQDY0nYfa_IBMEd_zRvQ_hNl8jlD5lSmzp-XYBOcvvyXAAODfznImEa2teJ6IrqXK6dPyiErF9NUTwf-kSRMnXUn3fJcP2LrFwtwaP8O9_oBTtQ8RcZQo--zpWABh7fHuw0-hUYG04hBsJfdXj6CvS24U8cBCBXEcnYj74wkR6FMOsXqcABR7iMLbWLLB__8H0DyFlzEabTPmb9sNoqA_LE_HLxMDsq4SYqFxms_mboEtUvWAyo-4lVaIu-RDmKQXT7GyW0fZ-YDGW9j-Sb14B9F0xhY3XOE672ASQO0keCGESaiZwL0iEqflNtKAYySFaFM1yQNOultRQHQmxJ-nVoIwupcJlDECx9GQfwVwNAZZfkiXdtJgfeAi2w8vpf3lQw6lW0N6pdnu4f6dRqlvxSpTsYkKj7TaUIUx60uQ4JxJePsYwZh_h0KdGjLM9rmEET4EHnEXYTBsZR8FbqHzogXE7xrAu-7ZbCS_X0tjrQYjG3JMiwv-VRvI_6NAWqRcQ382GMOZuQwGVNB6zLn5z1G9zde0Ved9py3bBG9s_SmATmXWQ_CrmW2tf5xPoCqP6N62yEUD9ZEagXCsgRjpU0dzNdvE1D6FzB8ZeUe8vYQS90VfPNNmM-8lE4qsoLamTcOqHgzx6RhuarRfSOaohOFTfowIAj6Q0QG-5g5boRqDsLWUj912BAdWk7hNP7QH1DTLFzZTov2oYdfHZij4L87MK8#DSD"
                },
                Genres = new List<string>()
                {
                    "мультфильм", "фэнтези", "детектив", "приключения", "семейный"
                }
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "Криминальное чтиво",
                    Description = "Несколько связанных историй из жизни бандитов. Шедевр Квентина Тарантино, который изменил мировое кино",
                    Year = 1994,
                    Country = "США",
                    Time = 154,
                    Tagline = "Just because you are a character doesn't mean you have character",
                    Director = "Квентин Тарантино",
                    Budget = 8000000,
                    Fees = 213928762,
                    AgeLimit = 18,
                    Rating = 8.6,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/15D2S2r30/33deda7SK/7htRvK7qLcqB7zW47Pf5ERgu4sxJy-F4M37R8H0rzARd-esRa2vgXRtB0HI8J44zIyTdq57S4xmBNggMLt_c098SHKX7lwT6reZMkdz2lRBJDr7xCNbUWWpupb0IRrC4nVkjtKPzHP2b8FVrBTv3QmZ93Ir-__pt7BpNxNaawXp6CxEMfhagTpHbcKgw1ykRpG_2nH2W_Ug7c03ozQeoeEkFPxhLj-TdV2w1jw32S_ZKUbASRvv2kJjWHYQvjoUC1kf58MqGrL75X3w8ALPFtRxbTiBhonHsa-PRTOEbxIDt5YMYE4f4_RvoyfPp6hc6ki0ATpL37lQwksGIa7Ih6qoTscie5tBG_ft0zOxPUbGYS7qohdJJgJMHyUBVT2DY_eUvAAfnbEWf0MkTYXrX4mah9FpelyLctB7dIBPGYfJyb0HYOhog7tUvxDTMl32FuO-GJEGCRVyvDwE4UaMwzDVN5_QHgzRd3wTZ-zFqV2Ki8UAW4m_-DADqyQif0rXyRqMN5MJG3F6Nv_QYpOcVIYhz8ihJ3kVgt5exyIGrdCBFvffgixfEMVf0PRPJWste4pFwEsbnhqjg3ik8GwZh5uLrSfT6bsg-XTO4tNDn9aU0R7JUeb7F6Df3YTRVg7hc2c2PAL_fwO2rWMn7CUqLZvoR2Koi855UkBohZKeG0R6O7x0MjiqwKqlTZBxYQwUFvG_WMEm-aeBnO6lY0SfgBIWRk2j3cwjJkxDdqwmyw8pmCdSqWnMSKEDisXw3IhHmyl9x_JYCoKJ5w3DQ3Nfdabyf5mT5PuXMK3PpiOE3rOTFZffsU_uweS9IPasFDlf6jhn4ohqzglzQ6r1w9wKV1tbH-VB2tuTKcTMQSGxTjcGUC5KUQaY9KB_7dbhde_jUpTk3FAcDmJlTbOX7cdp3Cup5bEbmlxLkXGKl-L9OgYomf5kIuuIkxgE_2NCkF_mVtEceqH3eDcyHq6HM8T-gwC15G-w3ZxiNo-BRdwk6n65aeSh-fley4GQCeQh78r2S_lfpyPIGgHZVv6isMOsFUcxnHjjZNn1ULxcN5MG_-NBVibscV_dIYTcU2YcZMke6IlWERtqfYiAUFgFc6y4p8q5vEYw6bqSaCR_IQBwTeWHYH2rwtcYR4Ld3uXj1p2Ts5QWD-DcviOEDXN0X3arXDk5ZPOpaw2p8wJaNfIe6qW6---38wua4_vHb4MC81229XC_KxPmCjcy_a4F8SbP4cGXpxxADq5yJk0wpMzGOa2Z66QDeznPmHGTCTZSLhsly7lNlRMIq8M6h73Qo3H_lxQhXkixptpX85x8tCN0HLAwp5X_sOxs8_dcQoVcxTlfO_uFoel7HhiRIAgEQ75Il9u6jRbSCAjBiveuoXAQX9VEUj45QEbqBcI8LxZxFq6gERcmzgJ9bjME7NNmjhepDtk6VuOJad3qclOrVlMOSoda-C3FAhsbk1t3nEDAgI3HVRNsSSJm-WfAHf7kEZfNAzCERz4hTX3QdI9x5L3FyC76OXcQK8svy0NwKxZSzgklWLp81MLaW1N71e_BIDLOVCcjnDuAVQvGgC_u1fJmDlEz12bNkQw9IRTv4cWv5VgeyYvUwolrTHujoXh2wPxbJnsYf-czODsB6jd_YmASrbZlEd96owTadsBNPIdRFM0TIteXPVHN7zElbcNlf3X6TXlLdaB4aY5KI-IqFcMMGoV56X_XIOh6k6pU3HATUq3G9VF_KZDVejcwjh_20eYvUfCVJ__hvw2Rxy-zZC4nuY6ZGAfR6Uh-uIJROFYiX_iG6YtNJYLqGfNqZp6DEAE8hidiHOviJSr1Yt3sNUI0r6HTRPWt8z9vMhSvk3fcVSneKCoEojkpTphTkDhFsr7YFYnrPBWhCRqBaHUugyAz_eQXkf860ZdJxpPPrKWgJt0B0iYkDsAfr5HEv0HlnfT4bMvqJRMbiO2LcmMKFfH9OSer6383cHubszgnLcLzoq3WNzG9uFG02PaRn441UZfPoYAlllwhHe9wJW3hJ84HScz7SXSBWGr-KFOgeHRhPMjGGeiNJ1DICdCKVM9BUyDt9zZT_stC5-oXolxvB_A0rxFSthXusA8fsQSfIqS_lyofKEgFoiuJ7pphYOpVcuzJdujJvbagublzmvatQhEj7TQ0IkxowVRbJvOufXcgZUzRs7bWfcAt7WOUv0C33TXbHenpd9KJy86bMBP5ZWJOSmf5WW2XQuqpkyv0rzByMt9FFZP-CoJme6XQDY0nYfa_IBMEd_zRvQ_hNl8jlD5lSmzp-XYBOcvvyXAAODfznImEa2teJ6IrqXK6dPyiErF9NUTwf-kSRMnXUn3fJcP2LrFwtwaP8O9_oBTtQ8RcZQo--zpWABh7fHuw0-hUYG04hBsJfdXj6CvS24U8cBCBXEcnYj74wkR6FMOsXqcABR7iMLbWLLB__8H0DyFlzEabTPmb9sNoqA_LE_HLxMDsq4SYqFxms_mboEtUvWAyo-4lVaIu-RDmKQXT7GyW0fZ-YDGW9j-Sb14B9F0xhY3XOE672ASQO0keCGESaiZwL0iEqflNtKAYySFaFM1yQNOultRQHQmxJ-nVoIwupcJlDECx9GQfwVwNAZZfkiXdtJgfeAi2w8vpf3lQw6lW0N6pdnu4f6dRqlvxSpTsYkKj7TaUIUx60uQ4JxJePsYwZh_h0KdGjLM9rmEET4EHnEXYTBsZR8FbqHzogXE7xrAu-7ZbCS_X0tjrQYjG3JMiwv-VRvI_6NAWqRcQ382GMOZuQwGVNB6zLn5z1G9zde0Ved9py3bBG9s_SmATmXWQ_CrmW2tf5xPoCqP6N62yEUD9ZEagXCsgRjpU0dzNdvE1D6FzB8ZeUe8vYQS90VfPNNmM-8lE4qsoLamTcOqHgzx6RhuarRfSOaohOFTfowIAj6Q0QG-5g5boRqDsLWUj912BAdWk7hNP7QH1DTLFzZTov2oYdfHZij4L87MK8#DSD"
                },
                Genres = new List<string>()
                {
                    "криминал", "драма"
                }
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "1+1",
                    Description = "Аристократ на коляске нанимает в сиделки бывшего заключенного. Искрометная французская комедия с Омаром Си",
                    Year = 2011,
                    Country = "Франция",
                    Time = 112,
                    Tagline = "Sometimes you have to reach into someone else's world to find out what's missing in your own",
                    Director = "Оливье Накаш, Эрик Толедано",
                    Budget = 10690255,
                    Fees = 426588510,
                    AgeLimit = 16,
                    Rating = 8.6,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/15D2S2r30/33deda7SK/7htRvK7qLcqB7zW47Pf5ERgu4sxJy-F4M37R8H0rzARd-esRa2vgXRtB0HI8N5Y_FyDcwtu--kmFC0wNbt_o098SELn_lwTipLpMjIGX2QhYQ9OwVZOIWWpupb0IRrC4nVkjtKPzHP2b8FVrBTv3QmZ93Ir-__pt7BpNxNaawXp6CxEMfhagTpHbcKgw1ykRpG_2nH2W_Ug7c03ozQeoeEkFPxhLj-TdV2w1jw32S_ZKUbASRvv2kJjWHYQvjoUC1kf58MqGrL75X3w8ALPFtRxbTiBhonHsa-PRTOEbxIDt5YMYE4f4_RvoyfPp6hc6ki0ATpL37lQwksGIa7Ih6qoTscie5tBG_ft0zOxPUbGYS7qohdJJgJMHyUBVT2DY_eUvAAfnbEWf0MkTYXrX4mah9FpelyLctB7dIBPGYfJyb0HYOhog7tUvxDTMl32FuO-GJEGCRVyvDwE4UaMwzDVN5_QHgzRd3wTZ-zFqV2Ki8UAW4m_-DADqyQif0rXyRqMN5MJG3F6Nv_QYpOcVIYhz8ihJ3kVgt5exyIGrdCBFvffgixfEMVf0PRPJWste4pFwEsbnhqjg3ik8GwZh5uLrSfT6bsg-XTO4tNDn9aU0R7JUeb7F6Df3YTRVg7hc2c2PAL_fwO2rWMn7CUqLZvoR2Koi855UkBohZKeG0R6O7x0MjiqwKqlTZBxYQwUFvG_WMEm-aeBnO6lY0SfgBIWRk2j3cwjJkxDdqwmyw8pmCdSqWnMSKEDisXw3IhHmyl9x_JYCoKJ5w3DQ3Nfdabyf5mT5PuXMK3PpiOE3rOTFZffsU_uweS9IPasFDlf6jhn4ohqzglzQ6r1w9wKV1tbH-VB2tuTKcTMQSGxTjcGUC5KUQaY9KB_7dbhde_jUpTk3FAcDmJlTbOX7cdp3Cup5bEbmlxLkXGKl-L9OgYomf5kIuuIkxgE_2NCkF_mVtEceqH3eDcyHq6HM8T-gwC15G-w3ZxiNo-BRdwk6n65aeSh-fley4GQCeQh78r2S_lfpyPIGgHZVv6isMOsFUcxnHjjZNn1ULxcN5MG_-NBVibscV_dIYTcU2YcZMke6IlWERtqfYiAUFgFc6y4p8q5vEYw6bqSaCR_IQBwTeWHYH2rwtcYR4Ld3uXj1p2Ts5QWD-DcviOEDXN0X3arXDk5ZPOpaw2p8wJaNfIe6qW6---38wua4_vHb4MC81229XC_KxPmCjcy_a4F8SbP4cGXpxxADq5yJk0wpMzGOa2Z66QDeznPmHGTCTZSLhsly7lNlRMIq8M6h73Qo3H_lxQhXkixptpX85x8tCN0HLAwp5X_sOxs8_dcQoVcxTlfO_uFoel7HhiRIAgEQ75Il9u6jRbSCAjBiveuoXAQX9VEUj45QEbqBcI8LxZxFq6gERcmzgJ9bjME7NNmjhepDtk6VuOJad3qclOrVlMOSoda-C3FAhsbk1t3nEDAgI3HVRNsSSJm-WfAHf7kEZfNAzCERz4hTX3QdI9x5L3FyC76OXcQK8svy0NwKxZSzgklWLp81MLaW1N71e_BIDLOVCcjnDuAVQvGgC_u1fJmDlEz12bNkQw9IRTv4cWv5VgeyYvUwolrTHujoXh2wPxbJnsYf-czODsB6jd_YmASrbZlEd96owTadsBNPIdRFM0TIteXPVHN7zElbcNlf3X6TXlLdaB4aY5KI-IqFcMMGoV56X_XIOh6k6pU3HATUq3G9VF_KZDVejcwjh_20eYvUfCVJ__hvw2Rxy-zZC4nuY6ZGAfR6Uh-uIJROFYiX_iG6YtNJYLqGfNqZp6DEAE8hidiHOviJSr1Yt3sNUI0r6HTRPWt8z9vMhSvk3fcVSneKCoEojkpTphTkDhFsr7YFYnrPBWhCRqBaHUugyAz_eQXkf860ZdJxpPPrKWgJt0B0iYkDsAfr5HEv0HlnfT4bMvqJRMbiO2LcmMKFfH9OSer6383cHubszgnLcLzoq3WNzG9uFG02PaRn441UZfPoYAlllwhHe9wJW3hJ84HScz7SXSBWGr-KFOgeHRhPMjGGeiNJ1DICdCKVM9BUyDt9zZT_stC5-oXolxvB_A0rxFSthXusA8fsQSfIqS_lyofKEgFoiuJ7pphYOpVcuzJdujJvbagublzmvatQhEj7TQ0IkxowVRbJvOufXcgZUzRs7bWfcAt7WOUv0C33TXbHenpd9KJy86bMBP5ZWJOSmf5WW2XQuqpkyv0rzByMt9FFZP-CoJme6XQDY0nYfa_IBMEd_zRvQ_hNl8jlD5lSmzp-XYBOcvvyXAAODfznImEa2teJ6IrqXK6dPyiErF9NUTwf-kSRMnXUn3fJcP2LrFwtwaP8O9_oBTtQ8RcZQo--zpWABh7fHuw0-hUYG04hBsJfdXj6CvS24U8cBCBXEcnYj74wkR6FMOsXqcABR7iMLbWLLB__8H0DyFlzEabTPmb9sNoqA_LE_HLxMDsq4SYqFxms_mboEtUvWAyo-4lVaIu-RDmKQXT7GyW0fZ-YDGW9j-Sb14B9F0xhY3XOE672ASQO0keCGESaiZwL0iEqflNtKAYySFaFM1yQNOultRQHQmxJ-nVoIwupcJlDECx9GQfwVwNAZZfkiXdtJgfeAi2w8vpf3lQw6lW0N6pdnu4f6dRqlvxSpTsYkKj7TaUIUx60uQ4JxJePsYwZh_h0KdGjLM9rmEET4EHnEXYTBsZR8FbqHzogXE7xrAu-7ZbCS_X0tjrQYjG3JMiwv-VRvI_6NAWqRcQ382GMOZuQwGVNB6zLn5z1G9zde0Ved9py3bBG9s_SmATmXWQ_CrmW2tf5xPoCqP6N62yEUD9ZEagXCsgRjpU0dzNdvE1D6FzB8ZeUe8vYQS90VfPNNmM-8lE4qsoLamTcOqHgzx6RhuarRfSOaohOFTfowIAj6Q0QG-5g5boRqDsLWUj912BAdWk7hNP7QH1DTLFzZTov2oYdfHZij4L87MK8"
                },
                Genres = new List<string>()
                {
                    "драма", "комедия", "биография"
                }
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "ВАЛЛ·И",
                    Description = "Люди покинули Землю и оставили робота собирать за ними мусор. Экологический шедевр Pixar",
                    Year = 2008,
                    Country = "США",
                    Time = 98,
                    Tagline = "Любовь - дело техники",
                    Director = "Эндрю Стэнтон",
                    Budget = 180000000,
                    Fees = 521311860,
                    AgeLimit = 0,
                    Rating = 8.6,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/15D2S2r30/33deda7SK/7htRvK7qLcqB7zW47Pf5ERgu4sxJy-F4M37R8H0rzARd-esRa2vgXRtB0HI8N5Y_FyDdj5ODvwTdG1gNZsvVv98TXLSvlwWSuJ5MmJj-iQxRGouRCZbUWWpupb0IRrC4nVkjtKPzHP2b8FVrBTv3QmZ93Ir-__pt7BpNxNaawXp6CxEMfhagTpHbcKgw1ykRpG_2nH2W_Ug7c03ozQeoeEkFPxhLj-TdV2w1jw32S_ZKUbASRvv2kJjWHYQvjoUC1kf58MqGrL75X3w8ALPFtRxbTiBhonHsa-PRTOEbxIDt5YMYE4f4_RvoyfPp6hc6ki0ATpL37lQwksGIa7Ih6qoTscie5tBG_ft0zOxPUbGYS7qohdJJgJMHyUBVT2DY_eUvAAfnbEWf0MkTYXrX4mah9FpelyLctB7dIBPGYfJyb0HYOhog7tUvxDTMl32FuO-GJEGCRVyvDwE4UaMwzDVN5_QHgzRd3wTZ-zFqV2Ki8UAW4m_-DADqyQif0rXyRqMN5MJG3F6Nv_QYpOcVIYhz8ihJ3kVgt5exyIGrdCBFvffgixfEMVf0PRPJWste4pFwEsbnhqjg3ik8GwZh5uLrSfT6bsg-XTO4tNDn9aU0R7JUeb7F6Df3YTRVg7hc2c2PAL_fwO2rWMn7CUqLZvoR2Koi855UkBohZKeG0R6O7x0MjiqwKqlTZBxYQwUFvG_WMEm-aeBnO6lY0SfgBIWRk2j3cwjJkxDdqwmyw8pmCdSqWnMSKEDisXw3IhHmyl9x_JYCoKJ5w3DQ3Nfdabyf5mT5PuXMK3PpiOE3rOTFZffsU_uweS9IPasFDlf6jhn4ohqzglzQ6r1w9wKV1tbH-VB2tuTKcTMQSGxTjcGUC5KUQaY9KB_7dbhde_jUpTk3FAcDmJlTbOX7cdp3Cup5bEbmlxLkXGKl-L9OgYomf5kIuuIkxgE_2NCkF_mVtEceqH3eDcyHq6HM8T-gwC15G-w3ZxiNo-BRdwk6n65aeSh-fley4GQCeQh78r2S_lfpyPIGgHZVv6isMOsFUcxnHjjZNn1ULxcN5MG_-NBVibscV_dIYTcU2YcZMke6IlWERtqfYiAUFgFc6y4p8q5vEYw6bqSaCR_IQBwTeWHYH2rwtcYR4Ld3uXj1p2Ts5QWD-DcviOEDXN0X3arXDk5ZPOpaw2p8wJaNfIe6qW6---38wua4_vHb4MC81229XC_KxPmCjcy_a4F8SbP4cGXpxxADq5yJk0wpMzGOa2Z66QDeznPmHGTCTZSLhsly7lNlRMIq8M6h73Qo3H_lxQhXkixptpX85x8tCN0HLAwp5X_sOxs8_dcQoVcxTlfO_uFoel7HhiRIAgEQ75Il9u6jRbSCAjBiveuoXAQX9VEUj45QEbqBcI8LxZxFq6gERcmzgJ9bjME7NNmjhepDtk6VuOJad3qclOrVlMOSoda-C3FAhsbk1t3nEDAgI3HVRNsSSJm-WfAHf7kEZfNAzCERz4hTX3QdI9x5L3FyC76OXcQK8svy0NwKxZSzgklWLp81MLaW1N71e_BIDLOVCcjnDuAVQvGgC_u1fJmDlEz12bNkQw9IRTv4cWv5VgeyYvUwolrTHujoXh2wPxbJnsYf-czODsB6jd_YmASrbZlEd96owTadsBNPIdRFM0TIteXPVHN7zElbcNlf3X6TXlLdaB4aY5KI-IqFcMMGoV56X_XIOh6k6pU3HATUq3G9VF_KZDVejcwjh_20eYvUfCVJ__hvw2Rxy-zZC4nuY6ZGAfR6Uh-uIJROFYiX_iG6YtNJYLqGfNqZp6DEAE8hidiHOviJSr1Yt3sNUI0r6HTRPWt8z9vMhSvk3fcVSneKCoEojkpTphTkDhFsr7YFYnrPBWhCRqBaHUugyAz_eQXkf860ZdJxpPPrKWgJt0B0iYkDsAfr5HEv0HlnfT4bMvqJRMbiO2LcmMKFfH9OSer6383cHubszgnLcLzoq3WNzG9uFG02PaRn441UZfPoYAlllwhHe9wJW3hJ84HScz7SXSBWGr-KFOgeHRhPMjGGeiNJ1DICdCKVM9BUyDt9zZT_stC5-oXolxvB_A0rxFSthXusA8fsQSfIqS_lyofKEgFoiuJ7pphYOpVcuzJdujJvbagublzmvatQhEj7TQ0IkxowVRbJvOufXcgZUzRs7bWfcAt7WOUv0C33TXbHenpd9KJy86bMBP5ZWJOSmf5WW2XQuqpkyv0rzByMt9FFZP-CoJme6XQDY0nYfa_IBMEd_zRvQ_hNl8jlD5lSmzp-XYBOcvvyXAAODfznImEa2teJ6IrqXK6dPyiErF9NUTwf-kSRMnXUn3fJcP2LrFwtwaP8O9_oBTtQ8RcZQo--zpWABh7fHuw0-hUYG04hBsJfdXj6CvS24U8cBCBXEcnYj74wkR6FMOsXqcABR7iMLbWLLB__8H0DyFlzEabTPmb9sNoqA_LE_HLxMDsq4SYqFxms_mboEtUvWAyo-4lVaIu-RDmKQXT7GyW0fZ-YDGW9j-Sb14B9F0xhY3XOE672ASQO0keCGESaiZwL0iEqflNtKAYySFaFM1yQNOultRQHQmxJ-nVoIwupcJlDECx9GQfwVwNAZZfkiXdtJgfeAi2w8vpf3lQw6lW0N6pdnu4f6dRqlvxSpTsYkKj7TaUIUx60uQ4JxJePsYwZh_h0KdGjLM9rmEET4EHnEXYTBsZR8FbqHzogXE7xrAu-7ZbCS_X0tjrQYjG3JMiwv-VRvI_6NAWqRcQ382GMOZuQwGVNB6zLn5z1G9zde0Ved9py3bBG9s_SmATmXWQ_CrmW2tf5xPoCqP6N62yEUD9ZEagXCsgRjpU0dzNdvE1D6FzB8ZeUe8vYQS90VfPNNmM-8lE4qsoLamTcOqHgzx6RhuarRfSOaohOFTfowIAj6Q0QG-5g5boRqDsLWUj912BAdWk7hNP7QH1DTLFzZTov2oYdfHZij4L87MK8#DSD"
                },
                Genres = new List<string>()
                {
                    "мультфильм", "фантастика", "приключения", "семейный"
                }
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "Список Шиндлера",
                    Description = "История немецкого промышленника, спасшего тысячи жизней во время Холокоста. Драма Стивена Спилберга",
                    Year = 1993,
                    Country = "США",
                    Time = 195,
                    Tagline = "Этот список - жизнь",
                    Director = "Стивен Спилберг",
                    Budget = 22000000,
                    Fees = 321306305,
                    AgeLimit = 16,
                    Rating = 8.6,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/15D2S2r30/33deda7SK/7htRvK7qLcqB7zW47Pf5ERgu4sxJy-F4M37R8H0rzARd-esRa2vgXRtB0HIEO4I3Exzcw4-S6kTEV0QMOsfs998SMei_lwD7_K5NzdWikGRQSpuRPNrQWWpupb0IRrC4nVkjtKPzHP2b8FVrBTv3QmZ93Ir-__pt7BpNxNaawXp6CxEMfhagTpHbcKgw1ykRpG_2nH2W_Ug7c03ozQeoeEkFPxhLj-TdV2w1jw32S_ZKUbASRvv2kJjWHYQvjoUC1kf58MqGrL75X3w8ALPFtRxbTiBhonHsa-PRTOEbxIDt5YMYE4f4_RvoyfPp6hc6ki0ATpL37lQwksGIa7Ih6qoTscie5tBG_ft0zOxPUbGYS7qohdJJgJMHyUBVT2DY_eUvAAfnbEWf0MkTYXrX4mah9FpelyLctB7dIBPGYfJyb0HYOhog7tUvxDTMl32FuO-GJEGCRVyvDwE4UaMwzDVN5_QHgzRd3wTZ-zFqV2Ki8UAW4m_-DADqyQif0rXyRqMN5MJG3F6Nv_QYpOcVIYhz8ihJ3kVgt5exyIGrdCBFvffgixfEMVf0PRPJWste4pFwEsbnhqjg3ik8GwZh5uLrSfT6bsg-XTO4tNDn9aU0R7JUeb7F6Df3YTRVg7hc2c2PAL_fwO2rWMn7CUqLZvoR2Koi855UkBohZKeG0R6O7x0MjiqwKqlTZBxYQwUFvG_WMEm-aeBnO6lY0SfgBIWRk2j3cwjJkxDdqwmyw8pmCdSqWnMSKEDisXw3IhHmyl9x_JYCoKJ5w3DQ3Nfdabyf5mT5PuXMK3PpiOE3rOTFZffsU_uweS9IPasFDlf6jhn4ohqzglzQ6r1w9wKV1tbH-VB2tuTKcTMQSGxTjcGUC5KUQaY9KB_7dbhde_jUpTk3FAcDmJlTbOX7cdp3Cup5bEbmlxLkXGKl-L9OgYomf5kIuuIkxgE_2NCkF_mVtEceqH3eDcyHq6HM8T-gwC15G-w3ZxiNo-BRdwk6n65aeSh-fley4GQCeQh78r2S_lfpyPIGgHZVv6isMOsFUcxnHjjZNn1ULxcN5MG_-NBVibscV_dIYTcU2YcZMke6IlWERtqfYiAUFgFc6y4p8q5vEYw6bqSaCR_IQBwTeWHYH2rwtcYR4Ld3uXj1p2Ts5QWD-DcviOEDXN0X3arXDk5ZPOpaw2p8wJaNfIe6qW6---38wua4_vHb4MC81229XC_KxPmCjcy_a4F8SbP4cGXpxxADq5yJk0wpMzGOa2Z66QDeznPmHGTCTZSLhsly7lNlRMIq8M6h73Qo3H_lxQhXkixptpX85x8tCN0HLAwp5X_sOxs8_dcQoVcxTlfO_uFoel7HhiRIAgEQ75Il9u6jRbSCAjBiveuoXAQX9VEUj45QEbqBcI8LxZxFq6gERcmzgJ9bjME7NNmjhepDtk6VuOJad3qclOrVlMOSoda-C3FAhsbk1t3nEDAgI3HVRNsSSJm-WfAHf7kEZfNAzCERz4hTX3QdI9x5L3FyC76OXcQK8svy0NwKxZSzgklWLp81MLaW1N71e_BIDLOVCcjnDuAVQvGgC_u1fJmDlEz12bNkQw9IRTv4cWv5VgeyYvUwolrTHujoXh2wPxbJnsYf-czODsB6jd_YmASrbZlEd96owTadsBNPIdRFM0TIteXPVHN7zElbcNlf3X6TXlLdaB4aY5KI-IqFcMMGoV56X_XIOh6k6pU3HATUq3G9VF_KZDVejcwjh_20eYvUfCVJ__hvw2Rxy-zZC4nuY6ZGAfR6Uh-uIJROFYiX_iG6YtNJYLqGfNqZp6DEAE8hidiHOviJSr1Yt3sNUI0r6HTRPWt8z9vMhSvk3fcVSneKCoEojkpTphTkDhFsr7YFYnrPBWhCRqBaHUugyAz_eQXkf860ZdJxpPPrKWgJt0B0iYkDsAfr5HEv0HlnfT4bMvqJRMbiO2LcmMKFfH9OSer6383cHubszgnLcLzoq3WNzG9uFG02PaRn441UZfPoYAlllwhHe9wJW3hJ84HScz7SXSBWGr-KFOgeHRhPMjGGeiNJ1DICdCKVM9BUyDt9zZT_stC5-oXolxvB_A0rxFSthXusA8fsQSfIqS_lyofKEgFoiuJ7pphYOpVcuzJdujJvbagublzmvatQhEj7TQ0IkxowVRbJvOufXcgZUzRs7bWfcAt7WOUv0C33TXbHenpd9KJy86bMBP5ZWJOSmf5WW2XQuqpkyv0rzByMt9FFZP-CoJme6XQDY0nYfa_IBMEd_zRvQ_hNl8jlD5lSmzp-XYBOcvvyXAAODfznImEa2teJ6IrqXK6dPyiErF9NUTwf-kSRMnXUn3fJcP2LrFwtwaP8O9_oBTtQ8RcZQo--zpWABh7fHuw0-hUYG04hBsJfdXj6CvS24U8cBCBXEcnYj74wkR6FMOsXqcABR7iMLbWLLB__8H0DyFlzEabTPmb9sNoqA_LE_HLxMDsq4SYqFxms_mboEtUvWAyo-4lVaIu-RDmKQXT7GyW0fZ-YDGW9j-Sb14B9F0xhY3XOE672ASQO0keCGESaiZwL0iEqflNtKAYySFaFM1yQNOultRQHQmxJ-nVoIwupcJlDECx9GQfwVwNAZZfkiXdtJgfeAi2w8vpf3lQw6lW0N6pdnu4f6dRqlvxSpTsYkKj7TaUIUx60uQ4JxJePsYwZh_h0KdGjLM9rmEET4EHnEXYTBsZR8FbqHzogXE7xrAu-7ZbCS_X0tjrQYjG3JMiwv-VRvI_6NAWqRcQ382GMOZuQwGVNB6zLn5z1G9zde0Ved9py3bBG9s_SmATmXWQ_CrmW2tf5xPoCqP6N62yEUD9ZEagXCsgRjpU0dzNdvE1D6FzB8ZeUe8vYQS90VfPNNmM-8lE4qsoLamTcOqHgzx6RhuarRfSOaohOFTfowIAj6Q0QG-5g5boRqDsLWUj912BAdWk7hNP7QH1DTLFzZTov2oYdfHZij4L87MK8#DSD"
                },
                Genres = new List<string>()
                {
                    "драма", "биография", "история", "военный"
                }
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "Начало",
                    Description = "Профессиональные воры внедряются в сон наследника огромной империи. Фантастический боевик Кристофера Нолана",
                    Year = 2010,
                    Country = "США, Великобритания",
                    Time = 148,
                    Tagline = "Твой разум - место преступления",
                    Director = "Кристофер Нолан",
                    Budget = 160000000,
                    Fees = 828322032,
                    AgeLimit = 12,
                    Rating = 8.6,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/15D2S2r30/33deda7SK/7htRvK7qLcqB7zW47Pf5ERgu4sxJy-F4M37R8H0rzARd-esRa2vgXRtB0HIAL6ojJwTdqsbS0kWRF3wMO4vU598SBfXrlmj2ofJNwdG6pFxpEouVEYuAWWpupb0IRrC4nVkjtKPzHP2b8FVrBTv3QmZ93Ir-__pt7BpNxNaawXp6CxEMfhagTpHbcKgw1ykRpG_2nH2W_Ug7c03ozQeoeEkFPxhLj-TdV2w1jw32S_ZKUbASRvv2kJjWHYQvjoUC1kf58MqGrL75X3w8ALPFtRxbTiBhonHsa-PRTOEbxIDt5YMYE4f4_RvoyfPp6hc6ki0ATpL37lQwksGIa7Ih6qoTscie5tBG_ft0zOxPUbGYS7qohdJJgJMHyUBVT2DY_eUvAAfnbEWf0MkTYXrX4mah9FpelyLctB7dIBPGYfJyb0HYOhog7tUvxDTMl32FuO-GJEGCRVyvDwE4UaMwzDVN5_QHgzRd3wTZ-zFqV2Ki8UAW4m_-DADqyQif0rXyRqMN5MJG3F6Nv_QYpOcVIYhz8ihJ3kVgt5exyIGrdCBFvffgixfEMVf0PRPJWste4pFwEsbnhqjg3ik8GwZh5uLrSfT6bsg-XTO4tNDn9aU0R7JUeb7F6Df3YTRVg7hc2c2PAL_fwO2rWMn7CUqLZvoR2Koi855UkBohZKeG0R6O7x0MjiqwKqlTZBxYQwUFvG_WMEm-aeBnO6lY0SfgBIWRk2j3cwjJkxDdqwmyw8pmCdSqWnMSKEDisXw3IhHmyl9x_JYCoKJ5w3DQ3Nfdabyf5mT5PuXMK3PpiOE3rOTFZffsU_uweS9IPasFDlf6jhn4ohqzglzQ6r1w9wKV1tbH-VB2tuTKcTMQSGxTjcGUC5KUQaY9KB_7dbhde_jUpTk3FAcDmJlTbOX7cdp3Cup5bEbmlxLkXGKl-L9OgYomf5kIuuIkxgE_2NCkF_mVtEceqH3eDcyHq6HM8T-gwC15G-w3ZxiNo-BRdwk6n65aeSh-fley4GQCeQh78r2S_lfpyPIGgHZVv6isMOsFUcxnHjjZNn1ULxcN5MG_-NBVibscV_dIYTcU2YcZMke6IlWERtqfYiAUFgFc6y4p8q5vEYw6bqSaCR_IQBwTeWHYH2rwtcYR4Ld3uXj1p2Ts5QWD-DcviOEDXN0X3arXDk5ZPOpaw2p8wJaNfIe6qW6---38wua4_vHb4MC81229XC_KxPmCjcy_a4F8SbP4cGXpxxADq5yJk0wpMzGOa2Z66QDeznPmHGTCTZSLhsly7lNlRMIq8M6h73Qo3H_lxQhXkixptpX85x8tCN0HLAwp5X_sOxs8_dcQoVcxTlfO_uFoel7HhiRIAgEQ75Il9u6jRbSCAjBiveuoXAQX9VEUj45QEbqBcI8LxZxFq6gERcmzgJ9bjME7NNmjhepDtk6VuOJad3qclOrVlMOSoda-C3FAhsbk1t3nEDAgI3HVRNsSSJm-WfAHf7kEZfNAzCERz4hTX3QdI9x5L3FyC76OXcQK8svy0NwKxZSzgklWLp81MLaW1N71e_BIDLOVCcjnDuAVQvGgC_u1fJmDlEz12bNkQw9IRTv4cWv5VgeyYvUwolrTHujoXh2wPxbJnsYf-czODsB6jd_YmASrbZlEd96owTadsBNPIdRFM0TIteXPVHN7zElbcNlf3X6TXlLdaB4aY5KI-IqFcMMGoV56X_XIOh6k6pU3HATUq3G9VF_KZDVejcwjh_20eYvUfCVJ__hvw2Rxy-zZC4nuY6ZGAfR6Uh-uIJROFYiX_iG6YtNJYLqGfNqZp6DEAE8hidiHOviJSr1Yt3sNUI0r6HTRPWt8z9vMhSvk3fcVSneKCoEojkpTphTkDhFsr7YFYnrPBWhCRqBaHUugyAz_eQXkf860ZdJxpPPrKWgJt0B0iYkDsAfr5HEv0HlnfT4bMvqJRMbiO2LcmMKFfH9OSer6383cHubszgnLcLzoq3WNzG9uFG02PaRn441UZfPoYAlllwhHe9wJW3hJ84HScz7SXSBWGr-KFOgeHRhPMjGGeiNJ1DICdCKVM9BUyDt9zZT_stC5-oXolxvB_A0rxFSthXusA8fsQSfIqS_lyofKEgFoiuJ7pphYOpVcuzJdujJvbagublzmvatQhEj7TQ0IkxowVRbJvOufXcgZUzRs7bWfcAt7WOUv0C33TXbHenpd9KJy86bMBP5ZWJOSmf5WW2XQuqpkyv0rzByMt9FFZP-CoJme6XQDY0nYfa_IBMEd_zRvQ_hNl8jlD5lSmzp-XYBOcvvyXAAODfznImEa2teJ6IrqXK6dPyiErF9NUTwf-kSRMnXUn3fJcP2LrFwtwaP8O9_oBTtQ8RcZQo--zpWABh7fHuw0-hUYG04hBsJfdXj6CvS24U8cBCBXEcnYj74wkR6FMOsXqcABR7iMLbWLLB__8H0DyFlzEabTPmb9sNoqA_LE_HLxMDsq4SYqFxms_mboEtUvWAyo-4lVaIu-RDmKQXT7GyW0fZ-YDGW9j-Sb14B9F0xhY3XOE672ASQO0keCGESaiZwL0iEqflNtKAYySFaFM1yQNOultRQHQmxJ-nVoIwupcJlDECx9GQfwVwNAZZfkiXdtJgfeAi2w8vpf3lQw6lW0N6pdnu4f6dRqlvxSpTsYkKj7TaUIUx60uQ4JxJePsYwZh_h0KdGjLM9rmEET4EHnEXYTBsZR8FbqHzogXE7xrAu-7ZbCS_X0tjrQYjG3JMiwv-VRvI_6NAWqRcQ382GMOZuQwGVNB6zLn5z1G9zde0Ved9py3bBG9s_SmATmXWQ_CrmW2tf5xPoCqP6N62yEUD9ZEagXCsgRjpU0dzNdvE1D6FzB8ZeUe8vYQS90VfPNNmM-8lE4qsoLamTcOqHgzx6RhuarRfSOaohOFTfowIAj6Q0QG-5g5boRqDsLWUj912BAdWk7hNP7QH1DTLFzZTov2oYdfHZij4L87MK8"

                },
                Genres = new List<string>()
                {
                    "фантастика", "боевик", "триллер", "драма", "детектив"
                }
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "Карты, деньги, два ствола",
                    Description = "Четверке друзей из Лондона нужно где-то найти 500 000 фунтов. Культовая черная комедия, дебют Гая Ричи",
                    Year = 1998,
                    Country = "Великобритания",
                    Time = 107,
                    Tagline = "They lost half a million at cards but they've still got a few tricks up their sleeve",
                    Director = "Гай Ричи",
                    Budget = 1271356,
                    Fees = null,
                    AgeLimit = 18,
                    Rating = 8.6,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/15D2S2r30/33deda7SK/7htRvK7qLcqB7zW47Pf5ERgu4sxJy-F4M37R8H0rzARd-esRa2vgXRtB0HIMA6ovCyTdk5O-_xmBHgANbt6Y498SFI33lmW2pLZMlIWvxFxcVp-tGYuQWWpupb0IRrC4nVkjtKPzHP2b8FVrBTv3QmZ93Ir-__pt7BpNxNaawXp6CxEMfhagTpHbcKgw1ykRpG_2nH2W_Ug7c03ozQeoeEkFPxhLj-TdV2w1jw32S_ZKUbASRvv2kJjWHYQvjoUC1kf58MqGrL75X3w8ALPFtRxbTiBhonHsa-PRTOEbxIDt5YMYE4f4_RvoyfPp6hc6ki0ATpL37lQwksGIa7Ih6qoTscie5tBG_ft0zOxPUbGYS7qohdJJgJMHyUBVT2DY_eUvAAfnbEWf0MkTYXrX4mah9FpelyLctB7dIBPGYfJyb0HYOhog7tUvxDTMl32FuO-GJEGCRVyvDwE4UaMwzDVN5_QHgzRd3wTZ-zFqV2Ki8UAW4m_-DADqyQif0rXyRqMN5MJG3F6Nv_QYpOcVIYhz8ihJ3kVgt5exyIGrdCBFvffgixfEMVf0PRPJWste4pFwEsbnhqjg3ik8GwZh5uLrSfT6bsg-XTO4tNDn9aU0R7JUeb7F6Df3YTRVg7hc2c2PAL_fwO2rWMn7CUqLZvoR2Koi855UkBohZKeG0R6O7x0MjiqwKqlTZBxYQwUFvG_WMEm-aeBnO6lY0SfgBIWRk2j3cwjJkxDdqwmyw8pmCdSqWnMSKEDisXw3IhHmyl9x_JYCoKJ5w3DQ3Nfdabyf5mT5PuXMK3PpiOE3rOTFZffsU_uweS9IPasFDlf6jhn4ohqzglzQ6r1w9wKV1tbH-VB2tuTKcTMQSGxTjcGUC5KUQaY9KB_7dbhde_jUpTk3FAcDmJlTbOX7cdp3Cup5bEbmlxLkXGKl-L9OgYomf5kIuuIkxgE_2NCkF_mVtEceqH3eDcyHq6HM8T-gwC15G-w3ZxiNo-BRdwk6n65aeSh-fley4GQCeQh78r2S_lfpyPIGgHZVv6isMOsFUcxnHjjZNn1ULxcN5MG_-NBVibscV_dIYTcU2YcZMke6IlWERtqfYiAUFgFc6y4p8q5vEYw6bqSaCR_IQBwTeWHYH2rwtcYR4Ld3uXj1p2Ts5QWD-DcviOEDXN0X3arXDk5ZPOpaw2p8wJaNfIe6qW6---38wua4_vHb4MC81229XC_KxPmCjcy_a4F8SbP4cGXpxxADq5yJk0wpMzGOa2Z66QDeznPmHGTCTZSLhsly7lNlRMIq8M6h73Qo3H_lxQhXkixptpX85x8tCN0HLAwp5X_sOxs8_dcQoVcxTlfO_uFoel7HhiRIAgEQ75Il9u6jRbSCAjBiveuoXAQX9VEUj45QEbqBcI8LxZxFq6gERcmzgJ9bjME7NNmjhepDtk6VuOJad3qclOrVlMOSoda-C3FAhsbk1t3nEDAgI3HVRNsSSJm-WfAHf7kEZfNAzCERz4hTX3QdI9x5L3FyC76OXcQK8svy0NwKxZSzgklWLp81MLaW1N71e_BIDLOVCcjnDuAVQvGgC_u1fJmDlEz12bNkQw9IRTv4cWv5VgeyYvUwolrTHujoXh2wPxbJnsYf-czODsB6jd_YmASrbZlEd96owTadsBNPIdRFM0TIteXPVHN7zElbcNlf3X6TXlLdaB4aY5KI-IqFcMMGoV56X_XIOh6k6pU3HATUq3G9VF_KZDVejcwjh_20eYvUfCVJ__hvw2Rxy-zZC4nuY6ZGAfR6Uh-uIJROFYiX_iG6YtNJYLqGfNqZp6DEAE8hidiHOviJSr1Yt3sNUI0r6HTRPWt8z9vMhSvk3fcVSneKCoEojkpTphTkDhFsr7YFYnrPBWhCRqBaHUugyAz_eQXkf860ZdJxpPPrKWgJt0B0iYkDsAfr5HEv0HlnfT4bMvqJRMbiO2LcmMKFfH9OSer6383cHubszgnLcLzoq3WNzG9uFG02PaRn441UZfPoYAlllwhHe9wJW3hJ84HScz7SXSBWGr-KFOgeHRhPMjGGeiNJ1DICdCKVM9BUyDt9zZT_stC5-oXolxvB_A0rxFSthXusA8fsQSfIqS_lyofKEgFoiuJ7pphYOpVcuzJdujJvbagublzmvatQhEj7TQ0IkxowVRbJvOufXcgZUzRs7bWfcAt7WOUv0C33TXbHenpd9KJy86bMBP5ZWJOSmf5WW2XQuqpkyv0rzByMt9FFZP-CoJme6XQDY0nYfa_IBMEd_zRvQ_hNl8jlD5lSmzp-XYBOcvvyXAAODfznImEa2teJ6IrqXK6dPyiErF9NUTwf-kSRMnXUn3fJcP2LrFwtwaP8O9_oBTtQ8RcZQo--zpWABh7fHuw0-hUYG04hBsJfdXj6CvS24U8cBCBXEcnYj74wkR6FMOsXqcABR7iMLbWLLB__8H0DyFlzEabTPmb9sNoqA_LE_HLxMDsq4SYqFxms_mboEtUvWAyo-4lVaIu-RDmKQXT7GyW0fZ-YDGW9j-Sb14B9F0xhY3XOE672ASQO0keCGESaiZwL0iEqflNtKAYySFaFM1yQNOultRQHQmxJ-nVoIwupcJlDECx9GQfwVwNAZZfkiXdtJgfeAi2w8vpf3lQw6lW0N6pdnu4f6dRqlvxSpTsYkKj7TaUIUx60uQ4JxJePsYwZh_h0KdGjLM9rmEET4EHnEXYTBsZR8FbqHzogXE7xrAu-7ZbCS_X0tjrQYjG3JMiwv-VRvI_6NAWqRcQ382GMOZuQwGVNB6zLn5z1G9zde0Ved9py3bBG9s_SmATmXWQ_CrmW2tf5xPoCqP6N62yEUD9ZEagXCsgRjpU0dzNdvE1D6FzB8ZeUe8vYQS90VfPNNmM-8lE4qsoLamTcOqHgzx6RhuarRfSOaohOFTfowIAj6Q0QG-5g5boRqDsLWUj912BAdWk7hNP7QH1DTLFzZTov2oYdfHZij4L87MK8"

                },
                Genres = new List<string>()
                {
                     "боевик", "комедия", "криминал"
                }
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "Матрица",
                    Description = "Хакер Нео узнает, что его мир — виртуальный. Выдающийся экшен, доказавший, что зрелищное кино может быть умным",
                    Year = 1999,
                    Country = "США, Австралия",
                    Time = 136,
                    Tagline = "Добро пожаловать в реальный мир",
                    Director = "Лана Вачовски, Лилли Вачовски",
                    Budget = 63000000,
                    Fees = 463517383,
                    AgeLimit = 16,
                    Rating = 8.6,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/15D2S2r30/33deda7SK/7htRvK7qLcqB7zW47Pf5ERgu4sxJy-F4M37R8H0rzARd-esRa2vgXRtB0HIEJ54LExzc3tbK8lDBHhwNfsvI998SGeXnlwG_0epNycGipEBBLr78RM-MWWpupb0IRrC4nVkjtKPzHP2b8FVrBTv3QmZ93Ir-__pt7BpNxNaawXp6CxEMfhagTpHbcKgw1ykRpG_2nH2W_Ug7c03ozQeoeEkFPxhLj-TdV2w1jw32S_ZKUbASRvv2kJjWHYQvjoUC1kf58MqGrL75X3w8ALPFtRxbTiBhonHsa-PRTOEbxIDt5YMYE4f4_RvoyfPp6hc6ki0ATpL37lQwksGIa7Ih6qoTscie5tBG_ft0zOxPUbGYS7qohdJJgJMHyUBVT2DY_eUvAAfnbEWf0MkTYXrX4mah9FpelyLctB7dIBPGYfJyb0HYOhog7tUvxDTMl32FuO-GJEGCRVyvDwE4UaMwzDVN5_QHgzRd3wTZ-zFqV2Ki8UAW4m_-DADqyQif0rXyRqMN5MJG3F6Nv_QYpOcVIYhz8ihJ3kVgt5exyIGrdCBFvffgixfEMVf0PRPJWste4pFwEsbnhqjg3ik8GwZh5uLrSfT6bsg-XTO4tNDn9aU0R7JUeb7F6Df3YTRVg7hc2c2PAL_fwO2rWMn7CUqLZvoR2Koi855UkBohZKeG0R6O7x0MjiqwKqlTZBxYQwUFvG_WMEm-aeBnO6lY0SfgBIWRk2j3cwjJkxDdqwmyw8pmCdSqWnMSKEDisXw3IhHmyl9x_JYCoKJ5w3DQ3Nfdabyf5mT5PuXMK3PpiOE3rOTFZffsU_uweS9IPasFDlf6jhn4ohqzglzQ6r1w9wKV1tbH-VB2tuTKcTMQSGxTjcGUC5KUQaY9KB_7dbhde_jUpTk3FAcDmJlTbOX7cdp3Cup5bEbmlxLkXGKl-L9OgYomf5kIuuIkxgE_2NCkF_mVtEceqH3eDcyHq6HM8T-gwC15G-w3ZxiNo-BRdwk6n65aeSh-fley4GQCeQh78r2S_lfpyPIGgHZVv6isMOsFUcxnHjjZNn1ULxcN5MG_-NBVibscV_dIYTcU2YcZMke6IlWERtqfYiAUFgFc6y4p8q5vEYw6bqSaCR_IQBwTeWHYH2rwtcYR4Ld3uXj1p2Ts5QWD-DcviOEDXN0X3arXDk5ZPOpaw2p8wJaNfIe6qW6---38wua4_vHb4MC81229XC_KxPmCjcy_a4F8SbP4cGXpxxADq5yJk0wpMzGOa2Z66QDeznPmHGTCTZSLhsly7lNlRMIq8M6h73Qo3H_lxQhXkixptpX85x8tCN0HLAwp5X_sOxs8_dcQoVcxTlfO_uFoel7HhiRIAgEQ75Il9u6jRbSCAjBiveuoXAQX9VEUj45QEbqBcI8LxZxFq6gERcmzgJ9bjME7NNmjhepDtk6VuOJad3qclOrVlMOSoda-C3FAhsbk1t3nEDAgI3HVRNsSSJm-WfAHf7kEZfNAzCERz4hTX3QdI9x5L3FyC76OXcQK8svy0NwKxZSzgklWLp81MLaW1N71e_BIDLOVCcjnDuAVQvGgC_u1fJmDlEz12bNkQw9IRTv4cWv5VgeyYvUwolrTHujoXh2wPxbJnsYf-czODsB6jd_YmASrbZlEd96owTadsBNPIdRFM0TIteXPVHN7zElbcNlf3X6TXlLdaB4aY5KI-IqFcMMGoV56X_XIOh6k6pU3HATUq3G9VF_KZDVejcwjh_20eYvUfCVJ__hvw2Rxy-zZC4nuY6ZGAfR6Uh-uIJROFYiX_iG6YtNJYLqGfNqZp6DEAE8hidiHOviJSr1Yt3sNUI0r6HTRPWt8z9vMhSvk3fcVSneKCoEojkpTphTkDhFsr7YFYnrPBWhCRqBaHUugyAz_eQXkf860ZdJxpPPrKWgJt0B0iYkDsAfr5HEv0HlnfT4bMvqJRMbiO2LcmMKFfH9OSer6383cHubszgnLcLzoq3WNzG9uFG02PaRn441UZfPoYAlllwhHe9wJW3hJ84HScz7SXSBWGr-KFOgeHRhPMjGGeiNJ1DICdCKVM9BUyDt9zZT_stC5-oXolxvB_A0rxFSthXusA8fsQSfIqS_lyofKEgFoiuJ7pphYOpVcuzJdujJvbagublzmvatQhEj7TQ0IkxowVRbJvOufXcgZUzRs7bWfcAt7WOUv0C33TXbHenpd9KJy86bMBP5ZWJOSmf5WW2XQuqpkyv0rzByMt9FFZP-CoJme6XQDY0nYfa_IBMEd_zRvQ_hNl8jlD5lSmzp-XYBOcvvyXAAODfznImEa2teJ6IrqXK6dPyiErF9NUTwf-kSRMnXUn3fJcP2LrFwtwaP8O9_oBTtQ8RcZQo--zpWABh7fHuw0-hUYG04hBsJfdXj6CvS24U8cBCBXEcnYj74wkR6FMOsXqcABR7iMLbWLLB__8H0DyFlzEabTPmb9sNoqA_LE_HLxMDsq4SYqFxms_mboEtUvWAyo-4lVaIu-RDmKQXT7GyW0fZ-YDGW9j-Sb14B9F0xhY3XOE672ASQO0keCGESaiZwL0iEqflNtKAYySFaFM1yQNOultRQHQmxJ-nVoIwupcJlDECx9GQfwVwNAZZfkiXdtJgfeAi2w8vpf3lQw6lW0N6pdnu4f6dRqlvxSpTsYkKj7TaUIUx60uQ4JxJePsYwZh_h0KdGjLM9rmEET4EHnEXYTBsZR8FbqHzogXE7xrAu-7ZbCS_X0tjrQYjG3JMiwv-VRvI_6NAWqRcQ382GMOZuQwGVNB6zLn5z1G9zde0Ved9py3bBG9s_SmATmXWQ_CrmW2tf5xPoCqP6N62yEUD9ZEagXCsgRjpU0dzNdvE1D6FzB8ZeUe8vYQS90VfPNNmM-8lE4qsoLamTcOqHgzx6RhuarRfSOaohOFTfowIAj6Q0QG-5g5boRqDsLWUj912BAdWk7hNP7QH1DTLFzZTov2oYdfHZij4L87MK8#DSD"
                },
                Genres = new List<string>()
                {
                     "боевик", "фантастика"
                }
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "Клаус",
                    Description = "-",
                    Year = 2019,
                    Country = "Испания, Великобритания, США",
                    Time = 96,
                    Tagline = "Discover the friendship that launched a legend",
                    Director = "Серхио Паблос, Карлос Мартинес Лопес",
                    Budget = 40000000,
                    Fees = null,
                    AgeLimit = 6,
                    Rating = 8.6,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/15D2S2r30/33deda7SK/7htRvK7qLcqB7zW47Pf5ERgu4sxJy-F4M37R8H0rzARd-esRa2vgXRtB0HIEO4I3Exzdg5-_ryTNF3wNc5_A098TTei_lwW_4epN1djj0RhtD9etCNbUWWpupb0IRrC4nVkjtKPzHP2b8FVrBTv3QmZ93Ir-__pt7BpNxNaawXp6CxEMfhagTpHbcKgw1ykRpG_2nH2W_Ug7c03ozQeoeEkFPxhLj-TdV2w1jw32S_ZKUbASRvv2kJjWHYQvjoUC1kf58MqGrL75X3w8ALPFtRxbTiBhonHsa-PRTOEbxIDt5YMYE4f4_RvoyfPp6hc6ki0ATpL37lQwksGIa7Ih6qoTscie5tBG_ft0zOxPUbGYS7qohdJJgJMHyUBVT2DY_eUvAAfnbEWf0MkTYXrX4mah9FpelyLctB7dIBPGYfJyb0HYOhog7tUvxDTMl32FuO-GJEGCRVyvDwE4UaMwzDVN5_QHgzRd3wTZ-zFqV2Ki8UAW4m_-DADqyQif0rXyRqMN5MJG3F6Nv_QYpOcVIYhz8ihJ3kVgt5exyIGrdCBFvffgixfEMVf0PRPJWste4pFwEsbnhqjg3ik8GwZh5uLrSfT6bsg-XTO4tNDn9aU0R7JUeb7F6Df3YTRVg7hc2c2PAL_fwO2rWMn7CUqLZvoR2Koi855UkBohZKeG0R6O7x0MjiqwKqlTZBxYQwUFvG_WMEm-aeBnO6lY0SfgBIWRk2j3cwjJkxDdqwmyw8pmCdSqWnMSKEDisXw3IhHmyl9x_JYCoKJ5w3DQ3Nfdabyf5mT5PuXMK3PpiOE3rOTFZffsU_uweS9IPasFDlf6jhn4ohqzglzQ6r1w9wKV1tbH-VB2tuTKcTMQSGxTjcGUC5KUQaY9KB_7dbhde_jUpTk3FAcDmJlTbOX7cdp3Cup5bEbmlxLkXGKl-L9OgYomf5kIuuIkxgE_2NCkF_mVtEceqH3eDcyHq6HM8T-gwC15G-w3ZxiNo-BRdwk6n65aeSh-fley4GQCeQh78r2S_lfpyPIGgHZVv6isMOsFUcxnHjjZNn1ULxcN5MG_-NBVibscV_dIYTcU2YcZMke6IlWERtqfYiAUFgFc6y4p8q5vEYw6bqSaCR_IQBwTeWHYH2rwtcYR4Ld3uXj1p2Ts5QWD-DcviOEDXN0X3arXDk5ZPOpaw2p8wJaNfIe6qW6---38wua4_vHb4MC81229XC_KxPmCjcy_a4F8SbP4cGXpxxADq5yJk0wpMzGOa2Z66QDeznPmHGTCTZSLhsly7lNlRMIq8M6h73Qo3H_lxQhXkixptpX85x8tCN0HLAwp5X_sOxs8_dcQoVcxTlfO_uFoel7HhiRIAgEQ75Il9u6jRbSCAjBiveuoXAQX9VEUj45QEbqBcI8LxZxFq6gERcmzgJ9bjME7NNmjhepDtk6VuOJad3qclOrVlMOSoda-C3FAhsbk1t3nEDAgI3HVRNsSSJm-WfAHf7kEZfNAzCERz4hTX3QdI9x5L3FyC76OXcQK8svy0NwKxZSzgklWLp81MLaW1N71e_BIDLOVCcjnDuAVQvGgC_u1fJmDlEz12bNkQw9IRTv4cWv5VgeyYvUwolrTHujoXh2wPxbJnsYf-czODsB6jd_YmASrbZlEd96owTadsBNPIdRFM0TIteXPVHN7zElbcNlf3X6TXlLdaB4aY5KI-IqFcMMGoV56X_XIOh6k6pU3HATUq3G9VF_KZDVejcwjh_20eYvUfCVJ__hvw2Rxy-zZC4nuY6ZGAfR6Uh-uIJROFYiX_iG6YtNJYLqGfNqZp6DEAE8hidiHOviJSr1Yt3sNUI0r6HTRPWt8z9vMhSvk3fcVSneKCoEojkpTphTkDhFsr7YFYnrPBWhCRqBaHUugyAz_eQXkf860ZdJxpPPrKWgJt0B0iYkDsAfr5HEv0HlnfT4bMvqJRMbiO2LcmMKFfH9OSer6383cHubszgnLcLzoq3WNzG9uFG02PaRn441UZfPoYAlllwhHe9wJW3hJ84HScz7SXSBWGr-KFOgeHRhPMjGGeiNJ1DICdCKVM9BUyDt9zZT_stC5-oXolxvB_A0rxFSthXusA8fsQSfIqS_lyofKEgFoiuJ7pphYOpVcuzJdujJvbagublzmvatQhEj7TQ0IkxowVRbJvOufXcgZUzRs7bWfcAt7WOUv0C33TXbHenpd9KJy86bMBP5ZWJOSmf5WW2XQuqpkyv0rzByMt9FFZP-CoJme6XQDY0nYfa_IBMEd_zRvQ_hNl8jlD5lSmzp-XYBOcvvyXAAODfznImEa2teJ6IrqXK6dPyiErF9NUTwf-kSRMnXUn3fJcP2LrFwtwaP8O9_oBTtQ8RcZQo--zpWABh7fHuw0-hUYG04hBsJfdXj6CvS24U8cBCBXEcnYj74wkR6FMOsXqcABR7iMLbWLLB__8H0DyFlzEabTPmb9sNoqA_LE_HLxMDsq4SYqFxms_mboEtUvWAyo-4lVaIu-RDmKQXT7GyW0fZ-YDGW9j-Sb14B9F0xhY3XOE672ASQO0keCGESaiZwL0iEqflNtKAYySFaFM1yQNOultRQHQmxJ-nVoIwupcJlDECx9GQfwVwNAZZfkiXdtJgfeAi2w8vpf3lQw6lW0N6pdnu4f6dRqlvxSpTsYkKj7TaUIUx60uQ4JxJePsYwZh_h0KdGjLM9rmEET4EHnEXYTBsZR8FbqHzogXE7xrAu-7ZbCS_X0tjrQYjG3JMiwv-VRvI_6NAWqRcQ382GMOZuQwGVNB6zLn5z1G9zde0Ved9py3bBG9s_SmATmXWQ_CrmW2tf5xPoCqP6N62yEUD9ZEagXCsgRjpU0dzNdvE1D6FzB8ZeUe8vYQS90VfPNNmM-8lE4qsoLamTcOqHgzx6RhuarRfSOaohOFTfowIAj6Q0QG-5g5boRqDsLWUj912BAdWk7hNP7QH1DTLFzZTov2oYdfHZij4L87MK8"
                },
                Genres = new List<string>()
                {
                    "мультфильм", "семейный", "комедия", "приключения"
                }
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "Унесённые призраками",
                    Description = "Девочка должна спасти своих родителей в мире духов. Шедевр Хаяо Миядзаки, фаворит анимационных рейтингов мира",
                    Year = 2001,
                    Country = "Япония",
                    Time = 125,
                    Tagline = "The tunnel led Chihiro to a mysterious town...",
                    Director = "Хаяо Миядзаки",
                    Budget = 19000000,
                    Fees = 355467076,
                    AgeLimit = 12,
                    Rating = 8.5,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/15D2S2r30/33deda7SK/7htRvK7qLcqB7zW47Pf5ERgu4sxJy-F4M37R8H0rzARd-esRa2vgXRtB0HIAL6ojJwTdk5LTokzdBggMPsaA098TULnzlwD_6LpN1cmyoEhpH9-VCMrYWWpupb0IRrC4nVkjtKPzHP2b8FVrBTv3QmZ93Ir-__pt7BpNxNaawXp6CxEMfhagTpHbcKgw1ykRpG_2nH2W_Ug7c03ozQeoeEkFPxhLj-TdV2w1jw32S_ZKUbASRvv2kJjWHYQvjoUC1kf58MqGrL75X3w8ALPFtRxbTiBhonHsa-PRTOEbxIDt5YMYE4f4_RvoyfPp6hc6ki0ATpL37lQwksGIa7Ih6qoTscie5tBG_ft0zOxPUbGYS7qohdJJgJMHyUBVT2DY_eUvAAfnbEWf0MkTYXrX4mah9FpelyLctB7dIBPGYfJyb0HYOhog7tUvxDTMl32FuO-GJEGCRVyvDwE4UaMwzDVN5_QHgzRd3wTZ-zFqV2Ki8UAW4m_-DADqyQif0rXyRqMN5MJG3F6Nv_QYpOcVIYhz8ihJ3kVgt5exyIGrdCBFvffgixfEMVf0PRPJWste4pFwEsbnhqjg3ik8GwZh5uLrSfT6bsg-XTO4tNDn9aU0R7JUeb7F6Df3YTRVg7hc2c2PAL_fwO2rWMn7CUqLZvoR2Koi855UkBohZKeG0R6O7x0MjiqwKqlTZBxYQwUFvG_WMEm-aeBnO6lY0SfgBIWRk2j3cwjJkxDdqwmyw8pmCdSqWnMSKEDisXw3IhHmyl9x_JYCoKJ5w3DQ3Nfdabyf5mT5PuXMK3PpiOE3rOTFZffsU_uweS9IPasFDlf6jhn4ohqzglzQ6r1w9wKV1tbH-VB2tuTKcTMQSGxTjcGUC5KUQaY9KB_7dbhde_jUpTk3FAcDmJlTbOX7cdp3Cup5bEbmlxLkXGKl-L9OgYomf5kIuuIkxgE_2NCkF_mVtEceqH3eDcyHq6HM8T-gwC15G-w3ZxiNo-BRdwk6n65aeSh-fley4GQCeQh78r2S_lfpyPIGgHZVv6isMOsFUcxnHjjZNn1ULxcN5MG_-NBVibscV_dIYTcU2YcZMke6IlWERtqfYiAUFgFc6y4p8q5vEYw6bqSaCR_IQBwTeWHYH2rwtcYR4Ld3uXj1p2Ts5QWD-DcviOEDXN0X3arXDk5ZPOpaw2p8wJaNfIe6qW6---38wua4_vHb4MC81229XC_KxPmCjcy_a4F8SbP4cGXpxxADq5yJk0wpMzGOa2Z66QDeznPmHGTCTZSLhsly7lNlRMIq8M6h73Qo3H_lxQhXkixptpX85x8tCN0HLAwp5X_sOxs8_dcQoVcxTlfO_uFoel7HhiRIAgEQ75Il9u6jRbSCAjBiveuoXAQX9VEUj45QEbqBcI8LxZxFq6gERcmzgJ9bjME7NNmjhepDtk6VuOJad3qclOrVlMOSoda-C3FAhsbk1t3nEDAgI3HVRNsSSJm-WfAHf7kEZfNAzCERz4hTX3QdI9x5L3FyC76OXcQK8svy0NwKxZSzgklWLp81MLaW1N71e_BIDLOVCcjnDuAVQvGgC_u1fJmDlEz12bNkQw9IRTv4cWv5VgeyYvUwolrTHujoXh2wPxbJnsYf-czODsB6jd_YmASrbZlEd96owTadsBNPIdRFM0TIteXPVHN7zElbcNlf3X6TXlLdaB4aY5KI-IqFcMMGoV56X_XIOh6k6pU3HATUq3G9VF_KZDVejcwjh_20eYvUfCVJ__hvw2Rxy-zZC4nuY6ZGAfR6Uh-uIJROFYiX_iG6YtNJYLqGfNqZp6DEAE8hidiHOviJSr1Yt3sNUI0r6HTRPWt8z9vMhSvk3fcVSneKCoEojkpTphTkDhFsr7YFYnrPBWhCRqBaHUugyAz_eQXkf860ZdJxpPPrKWgJt0B0iYkDsAfr5HEv0HlnfT4bMvqJRMbiO2LcmMKFfH9OSer6383cHubszgnLcLzoq3WNzG9uFG02PaRn441UZfPoYAlllwhHe9wJW3hJ84HScz7SXSBWGr-KFOgeHRhPMjGGeiNJ1DICdCKVM9BUyDt9zZT_stC5-oXolxvB_A0rxFSthXusA8fsQSfIqS_lyofKEgFoiuJ7pphYOpVcuzJdujJvbagublzmvatQhEj7TQ0IkxowVRbJvOufXcgZUzRs7bWfcAt7WOUv0C33TXbHenpd9KJy86bMBP5ZWJOSmf5WW2XQuqpkyv0rzByMt9FFZP-CoJme6XQDY0nYfa_IBMEd_zRvQ_hNl8jlD5lSmzp-XYBOcvvyXAAODfznImEa2teJ6IrqXK6dPyiErF9NUTwf-kSRMnXUn3fJcP2LrFwtwaP8O9_oBTtQ8RcZQo--zpWABh7fHuw0-hUYG04hBsJfdXj6CvS24U8cBCBXEcnYj74wkR6FMOsXqcABR7iMLbWLLB__8H0DyFlzEabTPmb9sNoqA_LE_HLxMDsq4SYqFxms_mboEtUvWAyo-4lVaIu-RDmKQXT7GyW0fZ-YDGW9j-Sb14B9F0xhY3XOE672ASQO0keCGESaiZwL0iEqflNtKAYySFaFM1yQNOultRQHQmxJ-nVoIwupcJlDECx9GQfwVwNAZZfkiXdtJgfeAi2w8vpf3lQw6lW0N6pdnu4f6dRqlvxSpTsYkKj7TaUIUx60uQ4JxJePsYwZh_h0KdGjLM9rmEET4EHnEXYTBsZR8FbqHzogXE7xrAu-7ZbCS_X0tjrQYjG3JMiwv-VRvI_6NAWqRcQ382GMOZuQwGVNB6zLn5z1G9zde0Ved9py3bBG9s_SmATmXWQ_CrmW2tf5xPoCqP6N62yEUD9ZEagXCsgRjpU0dzNdvE1D6FzB8ZeUe8vYQS90VfPNNmM-8lE4qsoLamTcOqHgzx6RhuarRfSOaohOFTfowIAj6Q0QG-5g5boRqDsLWUj912BAdWk7hNP7QH1DTLFzZTov2oYdfHZij4L87MK8#DSD"
                },
                Genres = new List<string>()
                {
                    "аниме", "мультфильм", "фэнтези", "приключения", "семейный"
                }
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "Назад в будущее",
                    Description = "Безумный ученый и 17-летний оболтус тестируют машину времени и наводят шороху в 1950-х. Классика кинофантастики",
                    Year = 1985,
                    Country = "США",
                    Time = 116,
                    Tagline = "Семнадцатилетний Марти МакФлай пришел вчера домой пораньше. На 30 лет раньше",
                    Director = "Роберт Земекис",
                    Budget = 19000000,
                    Fees = 381109762,
                    AgeLimit = 12,
                    Rating = 8.5,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/15D2S2r30/33deda7SK/7htRvK7qLcqB7zW47Pf5ERgu4sxJy-F4M37R8H0rzARd-esRa2vgXRtB0HIMA6ovCyTdl47XrwjAQ1gMM4vc_98SCenjlwTn_KZN3dm2gFBBFpupPMLYWWpupb0IRrC4nVkjtKPzHP2b8FVrBTv3QmZ93Ir-__pt7BpNxNaawXp6CxEMfhagTpHbcKgw1ykRpG_2nH2W_Ug7c03ozQeoeEkFPxhLj-TdV2w1jw32S_ZKUbASRvv2kJjWHYQvjoUC1kf58MqGrL75X3w8ALPFtRxbTiBhonHsa-PRTOEbxIDt5YMYE4f4_RvoyfPp6hc6ki0ATpL37lQwksGIa7Ih6qoTscie5tBG_ft0zOxPUbGYS7qohdJJgJMHyUBVT2DY_eUvAAfnbEWf0MkTYXrX4mah9FpelyLctB7dIBPGYfJyb0HYOhog7tUvxDTMl32FuO-GJEGCRVyvDwE4UaMwzDVN5_QHgzRd3wTZ-zFqV2Ki8UAW4m_-DADqyQif0rXyRqMN5MJG3F6Nv_QYpOcVIYhz8ihJ3kVgt5exyIGrdCBFvffgixfEMVf0PRPJWste4pFwEsbnhqjg3ik8GwZh5uLrSfT6bsg-XTO4tNDn9aU0R7JUeb7F6Df3YTRVg7hc2c2PAL_fwO2rWMn7CUqLZvoR2Koi855UkBohZKeG0R6O7x0MjiqwKqlTZBxYQwUFvG_WMEm-aeBnO6lY0SfgBIWRk2j3cwjJkxDdqwmyw8pmCdSqWnMSKEDisXw3IhHmyl9x_JYCoKJ5w3DQ3Nfdabyf5mT5PuXMK3PpiOE3rOTFZffsU_uweS9IPasFDlf6jhn4ohqzglzQ6r1w9wKV1tbH-VB2tuTKcTMQSGxTjcGUC5KUQaY9KB_7dbhde_jUpTk3FAcDmJlTbOX7cdp3Cup5bEbmlxLkXGKl-L9OgYomf5kIuuIkxgE_2NCkF_mVtEceqH3eDcyHq6HM8T-gwC15G-w3ZxiNo-BRdwk6n65aeSh-fley4GQCeQh78r2S_lfpyPIGgHZVv6isMOsFUcxnHjjZNn1ULxcN5MG_-NBVibscV_dIYTcU2YcZMke6IlWERtqfYiAUFgFc6y4p8q5vEYw6bqSaCR_IQBwTeWHYH2rwtcYR4Ld3uXj1p2Ts5QWD-DcviOEDXN0X3arXDk5ZPOpaw2p8wJaNfIe6qW6---38wua4_vHb4MC81229XC_KxPmCjcy_a4F8SbP4cGXpxxADq5yJk0wpMzGOa2Z66QDeznPmHGTCTZSLhsly7lNlRMIq8M6h73Qo3H_lxQhXkixptpX85x8tCN0HLAwp5X_sOxs8_dcQoVcxTlfO_uFoel7HhiRIAgEQ75Il9u6jRbSCAjBiveuoXAQX9VEUj45QEbqBcI8LxZxFq6gERcmzgJ9bjME7NNmjhepDtk6VuOJad3qclOrVlMOSoda-C3FAhsbk1t3nEDAgI3HVRNsSSJm-WfAHf7kEZfNAzCERz4hTX3QdI9x5L3FyC76OXcQK8svy0NwKxZSzgklWLp81MLaW1N71e_BIDLOVCcjnDuAVQvGgC_u1fJmDlEz12bNkQw9IRTv4cWv5VgeyYvUwolrTHujoXh2wPxbJnsYf-czODsB6jd_YmASrbZlEd96owTadsBNPIdRFM0TIteXPVHN7zElbcNlf3X6TXlLdaB4aY5KI-IqFcMMGoV56X_XIOh6k6pU3HATUq3G9VF_KZDVejcwjh_20eYvUfCVJ__hvw2Rxy-zZC4nuY6ZGAfR6Uh-uIJROFYiX_iG6YtNJYLqGfNqZp6DEAE8hidiHOviJSr1Yt3sNUI0r6HTRPWt8z9vMhSvk3fcVSneKCoEojkpTphTkDhFsr7YFYnrPBWhCRqBaHUugyAz_eQXkf860ZdJxpPPrKWgJt0B0iYkDsAfr5HEv0HlnfT4bMvqJRMbiO2LcmMKFfH9OSer6383cHubszgnLcLzoq3WNzG9uFG02PaRn441UZfPoYAlllwhHe9wJW3hJ84HScz7SXSBWGr-KFOgeHRhPMjGGeiNJ1DICdCKVM9BUyDt9zZT_stC5-oXolxvB_A0rxFSthXusA8fsQSfIqS_lyofKEgFoiuJ7pphYOpVcuzJdujJvbagublzmvatQhEj7TQ0IkxowVRbJvOufXcgZUzRs7bWfcAt7WOUv0C33TXbHenpd9KJy86bMBP5ZWJOSmf5WW2XQuqpkyv0rzByMt9FFZP-CoJme6XQDY0nYfa_IBMEd_zRvQ_hNl8jlD5lSmzp-XYBOcvvyXAAODfznImEa2teJ6IrqXK6dPyiErF9NUTwf-kSRMnXUn3fJcP2LrFwtwaP8O9_oBTtQ8RcZQo--zpWABh7fHuw0-hUYG04hBsJfdXj6CvS24U8cBCBXEcnYj74wkR6FMOsXqcABR7iMLbWLLB__8H0DyFlzEabTPmb9sNoqA_LE_HLxMDsq4SYqFxms_mboEtUvWAyo-4lVaIu-RDmKQXT7GyW0fZ-YDGW9j-Sb14B9F0xhY3XOE672ASQO0keCGESaiZwL0iEqflNtKAYySFaFM1yQNOultRQHQmxJ-nVoIwupcJlDECx9GQfwVwNAZZfkiXdtJgfeAi2w8vpf3lQw6lW0N6pdnu4f6dRqlvxSpTsYkKj7TaUIUx60uQ4JxJePsYwZh_h0KdGjLM9rmEET4EHnEXYTBsZR8FbqHzogXE7xrAu-7ZbCS_X0tjrQYjG3JMiwv-VRvI_6NAWqRcQ382GMOZuQwGVNB6zLn5z1G9zde0Ved9py3bBG9s_SmATmXWQ_CrmW2tf5xPoCqP6N62yEUD9ZEagXCsgRjpU0dzNdvE1D6FzB8ZeUe8vYQS90VfPNNmM-8lE4qsoLamTcOqHgzx6RhuarRfSOaohOFTfowIAj6Q0QG-5g5boRqDsLWUj912BAdWk7hNP7QH1DTLFzZTov2oYdfHZij4L87MK8#DSD"
                },
                Genres = new List<string>()
                {
                    "фантастика", "комедия", "приключения"
                }
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "Джентльмены удачи",
                    Description = "Воспитатель детсада внедряется в банду матерых рецидивистов. Евгений Леонов в разошедшейся на цитаты комедии",
                    Year = 1971,
                    Country = "СССР",
                    Time = 84,
                    Tagline = "-",
                    Director = "Александр Серый",
                    Budget = null,
                    Fees = 10560943,
                    AgeLimit = 6,
                    Rating = 8.5,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/15D2S2r30/33deda7SK/7htRvK7qLcqB7zW47Pf5ERgu4sxJy-F4M37R8H0rzARd-esRa2vgXRtB0HI8N5Y_FyDdg4e68wGcV0QNTsKBo98TRLC_lwGz_JpN4c2n0RRMVpeoUYLYWWpupb0IRrC4nVkjtKPzHP2b8FVrBTv3QmZ93Ir-__pt7BpNxNaawXp6CxEMfhagTpHbcKgw1ykRpG_2nH2W_Ug7c03ozQeoeEkFPxhLj-TdV2w1jw32S_ZKUbASRvv2kJjWHYQvjoUC1kf58MqGrL75X3w8ALPFtRxbTiBhonHsa-PRTOEbxIDt5YMYE4f4_RvoyfPp6hc6ki0ATpL37lQwksGIa7Ih6qoTscie5tBG_ft0zOxPUbGYS7qohdJJgJMHyUBVT2DY_eUvAAfnbEWf0MkTYXrX4mah9FpelyLctB7dIBPGYfJyb0HYOhog7tUvxDTMl32FuO-GJEGCRVyvDwE4UaMwzDVN5_QHgzRd3wTZ-zFqV2Ki8UAW4m_-DADqyQif0rXyRqMN5MJG3F6Nv_QYpOcVIYhz8ihJ3kVgt5exyIGrdCBFvffgixfEMVf0PRPJWste4pFwEsbnhqjg3ik8GwZh5uLrSfT6bsg-XTO4tNDn9aU0R7JUeb7F6Df3YTRVg7hc2c2PAL_fwO2rWMn7CUqLZvoR2Koi855UkBohZKeG0R6O7x0MjiqwKqlTZBxYQwUFvG_WMEm-aeBnO6lY0SfgBIWRk2j3cwjJkxDdqwmyw8pmCdSqWnMSKEDisXw3IhHmyl9x_JYCoKJ5w3DQ3Nfdabyf5mT5PuXMK3PpiOE3rOTFZffsU_uweS9IPasFDlf6jhn4ohqzglzQ6r1w9wKV1tbH-VB2tuTKcTMQSGxTjcGUC5KUQaY9KB_7dbhde_jUpTk3FAcDmJlTbOX7cdp3Cup5bEbmlxLkXGKl-L9OgYomf5kIuuIkxgE_2NCkF_mVtEceqH3eDcyHq6HM8T-gwC15G-w3ZxiNo-BRdwk6n65aeSh-fley4GQCeQh78r2S_lfpyPIGgHZVv6isMOsFUcxnHjjZNn1ULxcN5MG_-NBVibscV_dIYTcU2YcZMke6IlWERtqfYiAUFgFc6y4p8q5vEYw6bqSaCR_IQBwTeWHYH2rwtcYR4Ld3uXj1p2Ts5QWD-DcviOEDXN0X3arXDk5ZPOpaw2p8wJaNfIe6qW6---38wua4_vHb4MC81229XC_KxPmCjcy_a4F8SbP4cGXpxxADq5yJk0wpMzGOa2Z66QDeznPmHGTCTZSLhsly7lNlRMIq8M6h73Qo3H_lxQhXkixptpX85x8tCN0HLAwp5X_sOxs8_dcQoVcxTlfO_uFoel7HhiRIAgEQ75Il9u6jRbSCAjBiveuoXAQX9VEUj45QEbqBcI8LxZxFq6gERcmzgJ9bjME7NNmjhepDtk6VuOJad3qclOrVlMOSoda-C3FAhsbk1t3nEDAgI3HVRNsSSJm-WfAHf7kEZfNAzCERz4hTX3QdI9x5L3FyC76OXcQK8svy0NwKxZSzgklWLp81MLaW1N71e_BIDLOVCcjnDuAVQvGgC_u1fJmDlEz12bNkQw9IRTv4cWv5VgeyYvUwolrTHujoXh2wPxbJnsYf-czODsB6jd_YmASrbZlEd96owTadsBNPIdRFM0TIteXPVHN7zElbcNlf3X6TXlLdaB4aY5KI-IqFcMMGoV56X_XIOh6k6pU3HATUq3G9VF_KZDVejcwjh_20eYvUfCVJ__hvw2Rxy-zZC4nuY6ZGAfR6Uh-uIJROFYiX_iG6YtNJYLqGfNqZp6DEAE8hidiHOviJSr1Yt3sNUI0r6HTRPWt8z9vMhSvk3fcVSneKCoEojkpTphTkDhFsr7YFYnrPBWhCRqBaHUugyAz_eQXkf860ZdJxpPPrKWgJt0B0iYkDsAfr5HEv0HlnfT4bMvqJRMbiO2LcmMKFfH9OSer6383cHubszgnLcLzoq3WNzG9uFG02PaRn441UZfPoYAlllwhHe9wJW3hJ84HScz7SXSBWGr-KFOgeHRhPMjGGeiNJ1DICdCKVM9BUyDt9zZT_stC5-oXolxvB_A0rxFSthXusA8fsQSfIqS_lyofKEgFoiuJ7pphYOpVcuzJdujJvbagublzmvatQhEj7TQ0IkxowVRbJvOufXcgZUzRs7bWfcAt7WOUv0C33TXbHenpd9KJy86bMBP5ZWJOSmf5WW2XQuqpkyv0rzByMt9FFZP-CoJme6XQDY0nYfa_IBMEd_zRvQ_hNl8jlD5lSmzp-XYBOcvvyXAAODfznImEa2teJ6IrqXK6dPyiErF9NUTwf-kSRMnXUn3fJcP2LrFwtwaP8O9_oBTtQ8RcZQo--zpWABh7fHuw0-hUYG04hBsJfdXj6CvS24U8cBCBXEcnYj74wkR6FMOsXqcABR7iMLbWLLB__8H0DyFlzEabTPmb9sNoqA_LE_HLxMDsq4SYqFxms_mboEtUvWAyo-4lVaIu-RDmKQXT7GyW0fZ-YDGW9j-Sb14B9F0xhY3XOE672ASQO0keCGESaiZwL0iEqflNtKAYySFaFM1yQNOultRQHQmxJ-nVoIwupcJlDECx9GQfwVwNAZZfkiXdtJgfeAi2w8vpf3lQw6lW0N6pdnu4f6dRqlvxSpTsYkKj7TaUIUx60uQ4JxJePsYwZh_h0KdGjLM9rmEET4EHnEXYTBsZR8FbqHzogXE7xrAu-7ZbCS_X0tjrQYjG3JMiwv-VRvI_6NAWqRcQ382GMOZuQwGVNB6zLn5z1G9zde0Ved9py3bBG9s_SmATmXWQ_CrmW2tf5xPoCqP6N62yEUD9ZEagXCsgRjpU0dzNdvE1D6FzB8ZeUe8vYQS90VfPNNmM-8lE4qsoLamTcOqHgzx6RhuarRfSOaohOFTfowIAj6Q0QG-5g5boRqDsLWUj912BAdWk7hNP7QH1DTLFzZTov2oYdfHZij4L87MK8#DSD"
                },
                Genres = new List<string>()
                {
                    "комедия", "драма", "криминал", "детектив"
                }
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "Приключения Шерлока Холмса и доктора Ватсона: Собака Баскервилей",
                    Description = "Ватсон вынужден жить с эксцентричным клиентом в доме на болотах. Блестящая советская экранизация Конан Дойла",
                    Year = 1981,
                    Country = "СССР",
                    Time = 154,
                    Tagline = "-",
                    Director = "Игорь Масленников",
                    Budget = null,
                    Fees = null,
                    AgeLimit = 6,
                    Rating = 8.5,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/15D2S2r30/33deda7SK/7htRvK7qLcqB7zW47Pf5ERgu4sxJy-F4M37R8H0rzARd-esRa2vgXRtB0HIMA6ovCyTc04O7vkWxG1wNatKZp98TRKnPlwT_8KpN3d2v1EBdDpe5CYuEWWpupb0IRrC4nVkjtKPzHP2b8FVrBTv3QmZ93Ir-__pt7BpNxNaawXp6CxEMfhagTpHbcKgw1ykRpG_2nH2W_Ug7c03ozQeoeEkFPxhLj-TdV2w1jw32S_ZKUbASRvv2kJjWHYQvjoUC1kf58MqGrL75X3w8ALPFtRxbTiBhonHsa-PRTOEbxIDt5YMYE4f4_RvoyfPp6hc6ki0ATpL37lQwksGIa7Ih6qoTscie5tBG_ft0zOxPUbGYS7qohdJJgJMHyUBVT2DY_eUvAAfnbEWf0MkTYXrX4mah9FpelyLctB7dIBPGYfJyb0HYOhog7tUvxDTMl32FuO-GJEGCRVyvDwE4UaMwzDVN5_QHgzRd3wTZ-zFqV2Ki8UAW4m_-DADqyQif0rXyRqMN5MJG3F6Nv_QYpOcVIYhz8ihJ3kVgt5exyIGrdCBFvffgixfEMVf0PRPJWste4pFwEsbnhqjg3ik8GwZh5uLrSfT6bsg-XTO4tNDn9aU0R7JUeb7F6Df3YTRVg7hc2c2PAL_fwO2rWMn7CUqLZvoR2Koi855UkBohZKeG0R6O7x0MjiqwKqlTZBxYQwUFvG_WMEm-aeBnO6lY0SfgBIWRk2j3cwjJkxDdqwmyw8pmCdSqWnMSKEDisXw3IhHmyl9x_JYCoKJ5w3DQ3Nfdabyf5mT5PuXMK3PpiOE3rOTFZffsU_uweS9IPasFDlf6jhn4ohqzglzQ6r1w9wKV1tbH-VB2tuTKcTMQSGxTjcGUC5KUQaY9KB_7dbhde_jUpTk3FAcDmJlTbOX7cdp3Cup5bEbmlxLkXGKl-L9OgYomf5kIuuIkxgE_2NCkF_mVtEceqH3eDcyHq6HM8T-gwC15G-w3ZxiNo-BRdwk6n65aeSh-fley4GQCeQh78r2S_lfpyPIGgHZVv6isMOsFUcxnHjjZNn1ULxcN5MG_-NBVibscV_dIYTcU2YcZMke6IlWERtqfYiAUFgFc6y4p8q5vEYw6bqSaCR_IQBwTeWHYH2rwtcYR4Ld3uXj1p2Ts5QWD-DcviOEDXN0X3arXDk5ZPOpaw2p8wJaNfIe6qW6---38wua4_vHb4MC81229XC_KxPmCjcy_a4F8SbP4cGXpxxADq5yJk0wpMzGOa2Z66QDeznPmHGTCTZSLhsly7lNlRMIq8M6h73Qo3H_lxQhXkixptpX85x8tCN0HLAwp5X_sOxs8_dcQoVcxTlfO_uFoel7HhiRIAgEQ75Il9u6jRbSCAjBiveuoXAQX9VEUj45QEbqBcI8LxZxFq6gERcmzgJ9bjME7NNmjhepDtk6VuOJad3qclOrVlMOSoda-C3FAhsbk1t3nEDAgI3HVRNsSSJm-WfAHf7kEZfNAzCERz4hTX3QdI9x5L3FyC76OXcQK8svy0NwKxZSzgklWLp81MLaW1N71e_BIDLOVCcjnDuAVQvGgC_u1fJmDlEz12bNkQw9IRTv4cWv5VgeyYvUwolrTHujoXh2wPxbJnsYf-czODsB6jd_YmASrbZlEd96owTadsBNPIdRFM0TIteXPVHN7zElbcNlf3X6TXlLdaB4aY5KI-IqFcMMGoV56X_XIOh6k6pU3HATUq3G9VF_KZDVejcwjh_20eYvUfCVJ__hvw2Rxy-zZC4nuY6ZGAfR6Uh-uIJROFYiX_iG6YtNJYLqGfNqZp6DEAE8hidiHOviJSr1Yt3sNUI0r6HTRPWt8z9vMhSvk3fcVSneKCoEojkpTphTkDhFsr7YFYnrPBWhCRqBaHUugyAz_eQXkf860ZdJxpPPrKWgJt0B0iYkDsAfr5HEv0HlnfT4bMvqJRMbiO2LcmMKFfH9OSer6383cHubszgnLcLzoq3WNzG9uFG02PaRn441UZfPoYAlllwhHe9wJW3hJ84HScz7SXSBWGr-KFOgeHRhPMjGGeiNJ1DICdCKVM9BUyDt9zZT_stC5-oXolxvB_A0rxFSthXusA8fsQSfIqS_lyofKEgFoiuJ7pphYOpVcuzJdujJvbagublzmvatQhEj7TQ0IkxowVRbJvOufXcgZUzRs7bWfcAt7WOUv0C33TXbHenpd9KJy86bMBP5ZWJOSmf5WW2XQuqpkyv0rzByMt9FFZP-CoJme6XQDY0nYfa_IBMEd_zRvQ_hNl8jlD5lSmzp-XYBOcvvyXAAODfznImEa2teJ6IrqXK6dPyiErF9NUTwf-kSRMnXUn3fJcP2LrFwtwaP8O9_oBTtQ8RcZQo--zpWABh7fHuw0-hUYG04hBsJfdXj6CvS24U8cBCBXEcnYj74wkR6FMOsXqcABR7iMLbWLLB__8H0DyFlzEabTPmb9sNoqA_LE_HLxMDsq4SYqFxms_mboEtUvWAyo-4lVaIu-RDmKQXT7GyW0fZ-YDGW9j-Sb14B9F0xhY3XOE672ASQO0keCGESaiZwL0iEqflNtKAYySFaFM1yQNOultRQHQmxJ-nVoIwupcJlDECx9GQfwVwNAZZfkiXdtJgfeAi2w8vpf3lQw6lW0N6pdnu4f6dRqlvxSpTsYkKj7TaUIUx60uQ4JxJePsYwZh_h0KdGjLM9rmEET4EHnEXYTBsZR8FbqHzogXE7xrAu-7ZbCS_X0tjrQYjG3JMiwv-VRvI_6NAWqRcQ382GMOZuQwGVNB6zLn5z1G9zde0Ved9py3bBG9s_SmATmXWQ_CrmW2tf5xPoCqP6N62yEUD9ZEagXCsgRjpU0dzNdvE1D6FzB8ZeUe8vYQS90VfPNNmM-8lE4qsoLamTcOqHgzx6RhuarRfSOaohOFTfowIAj6Q0QG-5g5boRqDsLWUj912BAdWk7hNP7QH1DTLFzZTov2oYdfHZij4L87MK8#DSD"
                },
                Genres = new List<string>()
                {
                    "приключения", "криминал", "детектив"
                }
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "Москва слезам не верит",
                    Description = "Три девушки переезжают в Москву в поисках любви, дружбы и успеха. Советский хит, отмеченный «Оскаром»",
                    Year = 1979,
                    Country = "СССР",
                    Time = 150,
                    Tagline = "The Funniest, Tenderest Love Story of the Year",
                    Director = "Владимир Меньшов",
                    Budget = 900000,
                    Fees = 2516245,
                    AgeLimit = 16,
                    Rating = 8.5,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/15D2S2r30/33deda7SK/7htRvK7qLcqB7zW47Pf5ERgu4sxJy-F4M37R8H0rzARd-esRa2vgXRtB0HIMA6ovCyTdhtufrkzZMgANdtfFv98TRKynlwGv5KZN3IWn1EREWpL8SZLEWWpupb0IRrC4nVkjtKPzHP2b8FVrBTv3QmZ93Ir-__pt7BpNxNaawXp6CxEMfhagTpHbcKgw1ykRpG_2nH2W_Ug7c03ozQeoeEkFPxhLj-TdV2w1jw32S_ZKUbASRvv2kJjWHYQvjoUC1kf58MqGrL75X3w8ALPFtRxbTiBhonHsa-PRTOEbxIDt5YMYE4f4_RvoyfPp6hc6ki0ATpL37lQwksGIa7Ih6qoTscie5tBG_ft0zOxPUbGYS7qohdJJgJMHyUBVT2DY_eUvAAfnbEWf0MkTYXrX4mah9FpelyLctB7dIBPGYfJyb0HYOhog7tUvxDTMl32FuO-GJEGCRVyvDwE4UaMwzDVN5_QHgzRd3wTZ-zFqV2Ki8UAW4m_-DADqyQif0rXyRqMN5MJG3F6Nv_QYpOcVIYhz8ihJ3kVgt5exyIGrdCBFvffgixfEMVf0PRPJWste4pFwEsbnhqjg3ik8GwZh5uLrSfT6bsg-XTO4tNDn9aU0R7JUeb7F6Df3YTRVg7hc2c2PAL_fwO2rWMn7CUqLZvoR2Koi855UkBohZKeG0R6O7x0MjiqwKqlTZBxYQwUFvG_WMEm-aeBnO6lY0SfgBIWRk2j3cwjJkxDdqwmyw8pmCdSqWnMSKEDisXw3IhHmyl9x_JYCoKJ5w3DQ3Nfdabyf5mT5PuXMK3PpiOE3rOTFZffsU_uweS9IPasFDlf6jhn4ohqzglzQ6r1w9wKV1tbH-VB2tuTKcTMQSGxTjcGUC5KUQaY9KB_7dbhde_jUpTk3FAcDmJlTbOX7cdp3Cup5bEbmlxLkXGKl-L9OgYomf5kIuuIkxgE_2NCkF_mVtEceqH3eDcyHq6HM8T-gwC15G-w3ZxiNo-BRdwk6n65aeSh-fley4GQCeQh78r2S_lfpyPIGgHZVv6isMOsFUcxnHjjZNn1ULxcN5MG_-NBVibscV_dIYTcU2YcZMke6IlWERtqfYiAUFgFc6y4p8q5vEYw6bqSaCR_IQBwTeWHYH2rwtcYR4Ld3uXj1p2Ts5QWD-DcviOEDXN0X3arXDk5ZPOpaw2p8wJaNfIe6qW6---38wua4_vHb4MC81229XC_KxPmCjcy_a4F8SbP4cGXpxxADq5yJk0wpMzGOa2Z66QDeznPmHGTCTZSLhsly7lNlRMIq8M6h73Qo3H_lxQhXkixptpX85x8tCN0HLAwp5X_sOxs8_dcQoVcxTlfO_uFoel7HhiRIAgEQ75Il9u6jRbSCAjBiveuoXAQX9VEUj45QEbqBcI8LxZxFq6gERcmzgJ9bjME7NNmjhepDtk6VuOJad3qclOrVlMOSoda-C3FAhsbk1t3nEDAgI3HVRNsSSJm-WfAHf7kEZfNAzCERz4hTX3QdI9x5L3FyC76OXcQK8svy0NwKxZSzgklWLp81MLaW1N71e_BIDLOVCcjnDuAVQvGgC_u1fJmDlEz12bNkQw9IRTv4cWv5VgeyYvUwolrTHujoXh2wPxbJnsYf-czODsB6jd_YmASrbZlEd96owTadsBNPIdRFM0TIteXPVHN7zElbcNlf3X6TXlLdaB4aY5KI-IqFcMMGoV56X_XIOh6k6pU3HATUq3G9VF_KZDVejcwjh_20eYvUfCVJ__hvw2Rxy-zZC4nuY6ZGAfR6Uh-uIJROFYiX_iG6YtNJYLqGfNqZp6DEAE8hidiHOviJSr1Yt3sNUI0r6HTRPWt8z9vMhSvk3fcVSneKCoEojkpTphTkDhFsr7YFYnrPBWhCRqBaHUugyAz_eQXkf860ZdJxpPPrKWgJt0B0iYkDsAfr5HEv0HlnfT4bMvqJRMbiO2LcmMKFfH9OSer6383cHubszgnLcLzoq3WNzG9uFG02PaRn441UZfPoYAlllwhHe9wJW3hJ84HScz7SXSBWGr-KFOgeHRhPMjGGeiNJ1DICdCKVM9BUyDt9zZT_stC5-oXolxvB_A0rxFSthXusA8fsQSfIqS_lyofKEgFoiuJ7pphYOpVcuzJdujJvbagublzmvatQhEj7TQ0IkxowVRbJvOufXcgZUzRs7bWfcAt7WOUv0C33TXbHenpd9KJy86bMBP5ZWJOSmf5WW2XQuqpkyv0rzByMt9FFZP-CoJme6XQDY0nYfa_IBMEd_zRvQ_hNl8jlD5lSmzp-XYBOcvvyXAAODfznImEa2teJ6IrqXK6dPyiErF9NUTwf-kSRMnXUn3fJcP2LrFwtwaP8O9_oBTtQ8RcZQo--zpWABh7fHuw0-hUYG04hBsJfdXj6CvS24U8cBCBXEcnYj74wkR6FMOsXqcABR7iMLbWLLB__8H0DyFlzEabTPmb9sNoqA_LE_HLxMDsq4SYqFxms_mboEtUvWAyo-4lVaIu-RDmKQXT7GyW0fZ-YDGW9j-Sb14B9F0xhY3XOE672ASQO0keCGESaiZwL0iEqflNtKAYySFaFM1yQNOultRQHQmxJ-nVoIwupcJlDECx9GQfwVwNAZZfkiXdtJgfeAi2w8vpf3lQw6lW0N6pdnu4f6dRqlvxSpTsYkKj7TaUIUx60uQ4JxJePsYwZh_h0KdGjLM9rmEET4EHnEXYTBsZR8FbqHzogXE7xrAu-7ZbCS_X0tjrQYjG3JMiwv-VRvI_6NAWqRcQ382GMOZuQwGVNB6zLn5z1G9zde0Ved9py3bBG9s_SmATmXWQ_CrmW2tf5xPoCqP6N62yEUD9ZEagXCsgRjpU0dzNdvE1D6FzB8ZeUe8vYQS90VfPNNmM-8lE4qsoLamTcOqHgzx6RhuarRfSOaohOFTfowIAj6Q0QG-5g5boRqDsLWUj912BAdWk7hNP7QH1DTLFzZTov2oYdfHZij4L87MK8"
                },
                Genres = new List<string>()
                {
                    "мелодрама", "драма", "комедия"
                }
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "Бойцовский клуб",
                    Description = "Страховой работник разрушает рутину своей благополучной жизни. Культовая драма по книге Чака Паланика",
                    Year = 1999,
                    Country = "США, Германия",
                    Time = 139,
                    Tagline = "Интриги. Хаос. Мыло",
                    Director = "Дэвид Финчер",
                    Budget = 63000000,
                    Fees = 100853753,
                    AgeLimit = 18,
                    Rating = 8.5,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/15D2S2r30/33deda7SK/7htRvK7qLcqB7zW47Pf5ERgu4sxJy-F4M37R8H0rzARd-esRa2vgXRtB0HI4A64PJyDdqtbC9x2UX3wNYs_U998SAL3rlwT71LJMkdT_1FxZK9e1APuYWWpupb0IRrC4nVkjtKPzHP2b8FVrBTv3QmZ93Ir-__pt7BpNxNaawXp6CxEMfhagTpHbcKgw1ykRpG_2nH2W_Ug7c03ozQeoeEkFPxhLj-TdV2w1jw32S_ZKUbASRvv2kJjWHYQvjoUC1kf58MqGrL75X3w8ALPFtRxbTiBhonHsa-PRTOEbxIDt5YMYE4f4_RvoyfPp6hc6ki0ATpL37lQwksGIa7Ih6qoTscie5tBG_ft0zOxPUbGYS7qohdJJgJMHyUBVT2DY_eUvAAfnbEWf0MkTYXrX4mah9FpelyLctB7dIBPGYfJyb0HYOhog7tUvxDTMl32FuO-GJEGCRVyvDwE4UaMwzDVN5_QHgzRd3wTZ-zFqV2Ki8UAW4m_-DADqyQif0rXyRqMN5MJG3F6Nv_QYpOcVIYhz8ihJ3kVgt5exyIGrdCBFvffgixfEMVf0PRPJWste4pFwEsbnhqjg3ik8GwZh5uLrSfT6bsg-XTO4tNDn9aU0R7JUeb7F6Df3YTRVg7hc2c2PAL_fwO2rWMn7CUqLZvoR2Koi855UkBohZKeG0R6O7x0MjiqwKqlTZBxYQwUFvG_WMEm-aeBnO6lY0SfgBIWRk2j3cwjJkxDdqwmyw8pmCdSqWnMSKEDisXw3IhHmyl9x_JYCoKJ5w3DQ3Nfdabyf5mT5PuXMK3PpiOE3rOTFZffsU_uweS9IPasFDlf6jhn4ohqzglzQ6r1w9wKV1tbH-VB2tuTKcTMQSGxTjcGUC5KUQaY9KB_7dbhde_jUpTk3FAcDmJlTbOX7cdp3Cup5bEbmlxLkXGKl-L9OgYomf5kIuuIkxgE_2NCkF_mVtEceqH3eDcyHq6HM8T-gwC15G-w3ZxiNo-BRdwk6n65aeSh-fley4GQCeQh78r2S_lfpyPIGgHZVv6isMOsFUcxnHjjZNn1ULxcN5MG_-NBVibscV_dIYTcU2YcZMke6IlWERtqfYiAUFgFc6y4p8q5vEYw6bqSaCR_IQBwTeWHYH2rwtcYR4Ld3uXj1p2Ts5QWD-DcviOEDXN0X3arXDk5ZPOpaw2p8wJaNfIe6qW6---38wua4_vHb4MC81229XC_KxPmCjcy_a4F8SbP4cGXpxxADq5yJk0wpMzGOa2Z66QDeznPmHGTCTZSLhsly7lNlRMIq8M6h73Qo3H_lxQhXkixptpX85x8tCN0HLAwp5X_sOxs8_dcQoVcxTlfO_uFoel7HhiRIAgEQ75Il9u6jRbSCAjBiveuoXAQX9VEUj45QEbqBcI8LxZxFq6gERcmzgJ9bjME7NNmjhepDtk6VuOJad3qclOrVlMOSoda-C3FAhsbk1t3nEDAgI3HVRNsSSJm-WfAHf7kEZfNAzCERz4hTX3QdI9x5L3FyC76OXcQK8svy0NwKxZSzgklWLp81MLaW1N71e_BIDLOVCcjnDuAVQvGgC_u1fJmDlEz12bNkQw9IRTv4cWv5VgeyYvUwolrTHujoXh2wPxbJnsYf-czODsB6jd_YmASrbZlEd96owTadsBNPIdRFM0TIteXPVHN7zElbcNlf3X6TXlLdaB4aY5KI-IqFcMMGoV56X_XIOh6k6pU3HATUq3G9VF_KZDVejcwjh_20eYvUfCVJ__hvw2Rxy-zZC4nuY6ZGAfR6Uh-uIJROFYiX_iG6YtNJYLqGfNqZp6DEAE8hidiHOviJSr1Yt3sNUI0r6HTRPWt8z9vMhSvk3fcVSneKCoEojkpTphTkDhFsr7YFYnrPBWhCRqBaHUugyAz_eQXkf860ZdJxpPPrKWgJt0B0iYkDsAfr5HEv0HlnfT4bMvqJRMbiO2LcmMKFfH9OSer6383cHubszgnLcLzoq3WNzG9uFG02PaRn441UZfPoYAlllwhHe9wJW3hJ84HScz7SXSBWGr-KFOgeHRhPMjGGeiNJ1DICdCKVM9BUyDt9zZT_stC5-oXolxvB_A0rxFSthXusA8fsQSfIqS_lyofKEgFoiuJ7pphYOpVcuzJdujJvbagublzmvatQhEj7TQ0IkxowVRbJvOufXcgZUzRs7bWfcAt7WOUv0C33TXbHenpd9KJy86bMBP5ZWJOSmf5WW2XQuqpkyv0rzByMt9FFZP-CoJme6XQDY0nYfa_IBMEd_zRvQ_hNl8jlD5lSmzp-XYBOcvvyXAAODfznImEa2teJ6IrqXK6dPyiErF9NUTwf-kSRMnXUn3fJcP2LrFwtwaP8O9_oBTtQ8RcZQo--zpWABh7fHuw0-hUYG04hBsJfdXj6CvS24U8cBCBXEcnYj74wkR6FMOsXqcABR7iMLbWLLB__8H0DyFlzEabTPmb9sNoqA_LE_HLxMDsq4SYqFxms_mboEtUvWAyo-4lVaIu-RDmKQXT7GyW0fZ-YDGW9j-Sb14B9F0xhY3XOE672ASQO0keCGESaiZwL0iEqflNtKAYySFaFM1yQNOultRQHQmxJ-nVoIwupcJlDECx9GQfwVwNAZZfkiXdtJgfeAi2w8vpf3lQw6lW0N6pdnu4f6dRqlvxSpTsYkKj7TaUIUx60uQ4JxJePsYwZh_h0KdGjLM9rmEET4EHnEXYTBsZR8FbqHzogXE7xrAu-7ZbCS_X0tjrQYjG3JMiwv-VRvI_6NAWqRcQ382GMOZuQwGVNB6zLn5z1G9zde0Ved9py3bBG9s_SmATmXWQ_CrmW2tf5xPoCqP6N62yEUD9ZEagXCsgRjpU0dzNdvE1D6FzB8ZeUe8vYQS90VfPNNmM-8lE4qsoLamTcOqHgzx6RhuarRfSOaohOFTfowIAj6Q0QG-5g5boRqDsLWUj912BAdWk7hNP7QH1DTLFzZTov2oYdfHZij4L87MK8#DSD"
                },
                Genres = new List<string>()
                {
                    "мелодрама", "драма", "комедия"
                }
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "Пираты Карибского моря: Проклятие Черной жемчужины",
                    Description = "Пират нападает на армию мертвецов, чтобы вернуть свой корабль. Боевик о первых приключениях Джека Воробья",
                    Year = 2003,
                    Country = "США",
                    Time = 143,
                    Tagline = "Over 3000 islands of paradise. For some it’s a blessing. For others… It’s A Curse",
                    Director = "Гор Вербински",
                    Budget = 140000000,
                    Fees = 654264015,
                    AgeLimit = 12,
                    Rating = 8.5,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/15D2S2r30/33deda7SK/7htRvK7qLcqB7zW47Pf5ERgu4sxJy-F4M37R8H0rzARd-esRa2vgXRtB0HIEO4I3Exzc257O-lDcQ0AMPsqM098SBI3_lmmv4LpMkcm72FBpLpOhGMOEWWpupb0IRrC4nVkjtKPzHP2b8FVrBTv3QmZ93Ir-__pt7BpNxNaawXp6CxEMfhagTpHbcKgw1ykRpG_2nH2W_Ug7c03ozQeoeEkFPxhLj-TdV2w1jw32S_ZKUbASRvv2kJjWHYQvjoUC1kf58MqGrL75X3w8ALPFtRxbTiBhonHsa-PRTOEbxIDt5YMYE4f4_RvoyfPp6hc6ki0ATpL37lQwksGIa7Ih6qoTscie5tBG_ft0zOxPUbGYS7qohdJJgJMHyUBVT2DY_eUvAAfnbEWf0MkTYXrX4mah9FpelyLctB7dIBPGYfJyb0HYOhog7tUvxDTMl32FuO-GJEGCRVyvDwE4UaMwzDVN5_QHgzRd3wTZ-zFqV2Ki8UAW4m_-DADqyQif0rXyRqMN5MJG3F6Nv_QYpOcVIYhz8ihJ3kVgt5exyIGrdCBFvffgixfEMVf0PRPJWste4pFwEsbnhqjg3ik8GwZh5uLrSfT6bsg-XTO4tNDn9aU0R7JUeb7F6Df3YTRVg7hc2c2PAL_fwO2rWMn7CUqLZvoR2Koi855UkBohZKeG0R6O7x0MjiqwKqlTZBxYQwUFvG_WMEm-aeBnO6lY0SfgBIWRk2j3cwjJkxDdqwmyw8pmCdSqWnMSKEDisXw3IhHmyl9x_JYCoKJ5w3DQ3Nfdabyf5mT5PuXMK3PpiOE3rOTFZffsU_uweS9IPasFDlf6jhn4ohqzglzQ6r1w9wKV1tbH-VB2tuTKcTMQSGxTjcGUC5KUQaY9KB_7dbhde_jUpTk3FAcDmJlTbOX7cdp3Cup5bEbmlxLkXGKl-L9OgYomf5kIuuIkxgE_2NCkF_mVtEceqH3eDcyHq6HM8T-gwC15G-w3ZxiNo-BRdwk6n65aeSh-fley4GQCeQh78r2S_lfpyPIGgHZVv6isMOsFUcxnHjjZNn1ULxcN5MG_-NBVibscV_dIYTcU2YcZMke6IlWERtqfYiAUFgFc6y4p8q5vEYw6bqSaCR_IQBwTeWHYH2rwtcYR4Ld3uXj1p2Ts5QWD-DcviOEDXN0X3arXDk5ZPOpaw2p8wJaNfIe6qW6---38wua4_vHb4MC81229XC_KxPmCjcy_a4F8SbP4cGXpxxADq5yJk0wpMzGOa2Z66QDeznPmHGTCTZSLhsly7lNlRMIq8M6h73Qo3H_lxQhXkixptpX85x8tCN0HLAwp5X_sOxs8_dcQoVcxTlfO_uFoel7HhiRIAgEQ75Il9u6jRbSCAjBiveuoXAQX9VEUj45QEbqBcI8LxZxFq6gERcmzgJ9bjME7NNmjhepDtk6VuOJad3qclOrVlMOSoda-C3FAhsbk1t3nEDAgI3HVRNsSSJm-WfAHf7kEZfNAzCERz4hTX3QdI9x5L3FyC76OXcQK8svy0NwKxZSzgklWLp81MLaW1N71e_BIDLOVCcjnDuAVQvGgC_u1fJmDlEz12bNkQw9IRTv4cWv5VgeyYvUwolrTHujoXh2wPxbJnsYf-czODsB6jd_YmASrbZlEd96owTadsBNPIdRFM0TIteXPVHN7zElbcNlf3X6TXlLdaB4aY5KI-IqFcMMGoV56X_XIOh6k6pU3HATUq3G9VF_KZDVejcwjh_20eYvUfCVJ__hvw2Rxy-zZC4nuY6ZGAfR6Uh-uIJROFYiX_iG6YtNJYLqGfNqZp6DEAE8hidiHOviJSr1Yt3sNUI0r6HTRPWt8z9vMhSvk3fcVSneKCoEojkpTphTkDhFsr7YFYnrPBWhCRqBaHUugyAz_eQXkf860ZdJxpPPrKWgJt0B0iYkDsAfr5HEv0HlnfT4bMvqJRMbiO2LcmMKFfH9OSer6383cHubszgnLcLzoq3WNzG9uFG02PaRn441UZfPoYAlllwhHe9wJW3hJ84HScz7SXSBWGr-KFOgeHRhPMjGGeiNJ1DICdCKVM9BUyDt9zZT_stC5-oXolxvB_A0rxFSthXusA8fsQSfIqS_lyofKEgFoiuJ7pphYOpVcuzJdujJvbagublzmvatQhEj7TQ0IkxowVRbJvOufXcgZUzRs7bWfcAt7WOUv0C33TXbHenpd9KJy86bMBP5ZWJOSmf5WW2XQuqpkyv0rzByMt9FFZP-CoJme6XQDY0nYfa_IBMEd_zRvQ_hNl8jlD5lSmzp-XYBOcvvyXAAODfznImEa2teJ6IrqXK6dPyiErF9NUTwf-kSRMnXUn3fJcP2LrFwtwaP8O9_oBTtQ8RcZQo--zpWABh7fHuw0-hUYG04hBsJfdXj6CvS24U8cBCBXEcnYj74wkR6FMOsXqcABR7iMLbWLLB__8H0DyFlzEabTPmb9sNoqA_LE_HLxMDsq4SYqFxms_mboEtUvWAyo-4lVaIu-RDmKQXT7GyW0fZ-YDGW9j-Sb14B9F0xhY3XOE672ASQO0keCGESaiZwL0iEqflNtKAYySFaFM1yQNOultRQHQmxJ-nVoIwupcJlDECx9GQfwVwNAZZfkiXdtJgfeAi2w8vpf3lQw6lW0N6pdnu4f6dRqlvxSpTsYkKj7TaUIUx60uQ4JxJePsYwZh_h0KdGjLM9rmEET4EHnEXYTBsZR8FbqHzogXE7xrAu-7ZbCS_X0tjrQYjG3JMiwv-VRvI_6NAWqRcQ382GMOZuQwGVNB6zLn5z1G9zde0Ved9py3bBG9s_SmATmXWQ_CrmW2tf5xPoCqP6N62yEUD9ZEagXCsgRjpU0dzNdvE1D6FzB8ZeUe8vYQS90VfPNNmM-8lE4qsoLamTcOqHgzx6RhuarRfSOaohOFTfowIAj6Q0QG-5g5boRqDsLWUj912BAdWk7hNP7QH1DTLFzZTov2oYdfHZij4L87MK8#DSD"
                },
                Genres = new List<string>()
                {
                    "фэнтези", "боевик", "приключения"
                }
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "Операция «Ы» и другие приключения Шурика",
                    Description = "Похождения хронически оптимистичного очкарика. Блистательная комедия Леонида Гайдая",
                    Year = 1965,
                    Country = "СССР",
                    Time = 95,
                    Tagline = "-",
                    Director = "Леонид Гайдай",
                    Budget = null,
                    Fees = null,
                    AgeLimit = 6,
                    Rating = 8.5,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/15D2S2r30/33deda7SK/7htRvK7qLcqB7zW47Pf5ERgu4sxJy-F4M37R8H0rzARd-esRa2vgXRtB0HI8N5Y_FyDdjtrS5yGIW3wNdsvZr98TRKS_lwDr1JpNzJ22gFBoS9b5CZOcWWpupb0IRrC4nVkjtKPzHP2b8FVrBTv3QmZ93Ir-__pt7BpNxNaawXp6CxEMfhagTpHbcKgw1ykRpG_2nH2W_Ug7c03ozQeoeEkFPxhLj-TdV2w1jw32S_ZKUbASRvv2kJjWHYQvjoUC1kf58MqGrL75X3w8ALPFtRxbTiBhonHsa-PRTOEbxIDt5YMYE4f4_RvoyfPp6hc6ki0ATpL37lQwksGIa7Ih6qoTscie5tBG_ft0zOxPUbGYS7qohdJJgJMHyUBVT2DY_eUvAAfnbEWf0MkTYXrX4mah9FpelyLctB7dIBPGYfJyb0HYOhog7tUvxDTMl32FuO-GJEGCRVyvDwE4UaMwzDVN5_QHgzRd3wTZ-zFqV2Ki8UAW4m_-DADqyQif0rXyRqMN5MJG3F6Nv_QYpOcVIYhz8ihJ3kVgt5exyIGrdCBFvffgixfEMVf0PRPJWste4pFwEsbnhqjg3ik8GwZh5uLrSfT6bsg-XTO4tNDn9aU0R7JUeb7F6Df3YTRVg7hc2c2PAL_fwO2rWMn7CUqLZvoR2Koi855UkBohZKeG0R6O7x0MjiqwKqlTZBxYQwUFvG_WMEm-aeBnO6lY0SfgBIWRk2j3cwjJkxDdqwmyw8pmCdSqWnMSKEDisXw3IhHmyl9x_JYCoKJ5w3DQ3Nfdabyf5mT5PuXMK3PpiOE3rOTFZffsU_uweS9IPasFDlf6jhn4ohqzglzQ6r1w9wKV1tbH-VB2tuTKcTMQSGxTjcGUC5KUQaY9KB_7dbhde_jUpTk3FAcDmJlTbOX7cdp3Cup5bEbmlxLkXGKl-L9OgYomf5kIuuIkxgE_2NCkF_mVtEceqH3eDcyHq6HM8T-gwC15G-w3ZxiNo-BRdwk6n65aeSh-fley4GQCeQh78r2S_lfpyPIGgHZVv6isMOsFUcxnHjjZNn1ULxcN5MG_-NBVibscV_dIYTcU2YcZMke6IlWERtqfYiAUFgFc6y4p8q5vEYw6bqSaCR_IQBwTeWHYH2rwtcYR4Ld3uXj1p2Ts5QWD-DcviOEDXN0X3arXDk5ZPOpaw2p8wJaNfIe6qW6---38wua4_vHb4MC81229XC_KxPmCjcy_a4F8SbP4cGXpxxADq5yJk0wpMzGOa2Z66QDeznPmHGTCTZSLhsly7lNlRMIq8M6h73Qo3H_lxQhXkixptpX85x8tCN0HLAwp5X_sOxs8_dcQoVcxTlfO_uFoel7HhiRIAgEQ75Il9u6jRbSCAjBiveuoXAQX9VEUj45QEbqBcI8LxZxFq6gERcmzgJ9bjME7NNmjhepDtk6VuOJad3qclOrVlMOSoda-C3FAhsbk1t3nEDAgI3HVRNsSSJm-WfAHf7kEZfNAzCERz4hTX3QdI9x5L3FyC76OXcQK8svy0NwKxZSzgklWLp81MLaW1N71e_BIDLOVCcjnDuAVQvGgC_u1fJmDlEz12bNkQw9IRTv4cWv5VgeyYvUwolrTHujoXh2wPxbJnsYf-czODsB6jd_YmASrbZlEd96owTadsBNPIdRFM0TIteXPVHN7zElbcNlf3X6TXlLdaB4aY5KI-IqFcMMGoV56X_XIOh6k6pU3HATUq3G9VF_KZDVejcwjh_20eYvUfCVJ__hvw2Rxy-zZC4nuY6ZGAfR6Uh-uIJROFYiX_iG6YtNJYLqGfNqZp6DEAE8hidiHOviJSr1Yt3sNUI0r6HTRPWt8z9vMhSvk3fcVSneKCoEojkpTphTkDhFsr7YFYnrPBWhCRqBaHUugyAz_eQXkf860ZdJxpPPrKWgJt0B0iYkDsAfr5HEv0HlnfT4bMvqJRMbiO2LcmMKFfH9OSer6383cHubszgnLcLzoq3WNzG9uFG02PaRn441UZfPoYAlllwhHe9wJW3hJ84HScz7SXSBWGr-KFOgeHRhPMjGGeiNJ1DICdCKVM9BUyDt9zZT_stC5-oXolxvB_A0rxFSthXusA8fsQSfIqS_lyofKEgFoiuJ7pphYOpVcuzJdujJvbagublzmvatQhEj7TQ0IkxowVRbJvOufXcgZUzRs7bWfcAt7WOUv0C33TXbHenpd9KJy86bMBP5ZWJOSmf5WW2XQuqpkyv0rzByMt9FFZP-CoJme6XQDY0nYfa_IBMEd_zRvQ_hNl8jlD5lSmzp-XYBOcvvyXAAODfznImEa2teJ6IrqXK6dPyiErF9NUTwf-kSRMnXUn3fJcP2LrFwtwaP8O9_oBTtQ8RcZQo--zpWABh7fHuw0-hUYG04hBsJfdXj6CvS24U8cBCBXEcnYj74wkR6FMOsXqcABR7iMLbWLLB__8H0DyFlzEabTPmb9sNoqA_LE_HLxMDsq4SYqFxms_mboEtUvWAyo-4lVaIu-RDmKQXT7GyW0fZ-YDGW9j-Sb14B9F0xhY3XOE672ASQO0keCGESaiZwL0iEqflNtKAYySFaFM1yQNOultRQHQmxJ-nVoIwupcJlDECx9GQfwVwNAZZfkiXdtJgfeAi2w8vpf3lQw6lW0N6pdnu4f6dRqlvxSpTsYkKj7TaUIUx60uQ4JxJePsYwZh_h0KdGjLM9rmEET4EHnEXYTBsZR8FbqHzogXE7xrAu-7ZbCS_X0tjrQYjG3JMiwv-VRvI_6NAWqRcQ382GMOZuQwGVNB6zLn5z1G9zde0Ved9py3bBG9s_SmATmXWQ_CrmW2tf5xPoCqP6N62yEUD9ZEagXCsgRjpU0dzNdvE1D6FzB8ZeUe8vYQS90VfPNNmM-8lE4qsoLamTcOqHgzx6RhuarRfSOaohOFTfowIAj6Q0QG-5g5boRqDsLWUj912BAdWk7hNP7QH1DTLFzZTov2oYdfHZij4L87MK8"
                },
                Genres = new List<string>()
                {
                    "комедия", "мелодрама", "криминал"
                }
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "В бой идут одни «старики»",
                    Description = "-",
                    Year = 1973,
                    Country = "СССР",
                    Time = 87,
                    Tagline = "-",
                    Director = "Леонид Быков",
                    Budget = 500000,
                    Fees = null,
                    AgeLimit = 12,
                    Rating = 8.5,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/15D2S2r30/33deda7SK/7htRvK7qLcqB7zW47Pf5ERgu4sxJy-F4M37R8H0rzARd-esRa2vgXRtB0HIEJ54LExzdi4-S7xWBC1gMJ56Fv98SHIivlwD-ue5N1cmigE0VB8r9CM-UWWpupb0IRrC4nVkjtKPzHP2b8FVrBTv3QmZ93Ir-__pt7BpNxNaawXp6CxEMfhagTpHbcKgw1ykRpG_2nH2W_Ug7c03ozQeoeEkFPxhLj-TdV2w1jw32S_ZKUbASRvv2kJjWHYQvjoUC1kf58MqGrL75X3w8ALPFtRxbTiBhonHsa-PRTOEbxIDt5YMYE4f4_RvoyfPp6hc6ki0ATpL37lQwksGIa7Ih6qoTscie5tBG_ft0zOxPUbGYS7qohdJJgJMHyUBVT2DY_eUvAAfnbEWf0MkTYXrX4mah9FpelyLctB7dIBPGYfJyb0HYOhog7tUvxDTMl32FuO-GJEGCRVyvDwE4UaMwzDVN5_QHgzRd3wTZ-zFqV2Ki8UAW4m_-DADqyQif0rXyRqMN5MJG3F6Nv_QYpOcVIYhz8ihJ3kVgt5exyIGrdCBFvffgixfEMVf0PRPJWste4pFwEsbnhqjg3ik8GwZh5uLrSfT6bsg-XTO4tNDn9aU0R7JUeb7F6Df3YTRVg7hc2c2PAL_fwO2rWMn7CUqLZvoR2Koi855UkBohZKeG0R6O7x0MjiqwKqlTZBxYQwUFvG_WMEm-aeBnO6lY0SfgBIWRk2j3cwjJkxDdqwmyw8pmCdSqWnMSKEDisXw3IhHmyl9x_JYCoKJ5w3DQ3Nfdabyf5mT5PuXMK3PpiOE3rOTFZffsU_uweS9IPasFDlf6jhn4ohqzglzQ6r1w9wKV1tbH-VB2tuTKcTMQSGxTjcGUC5KUQaY9KB_7dbhde_jUpTk3FAcDmJlTbOX7cdp3Cup5bEbmlxLkXGKl-L9OgYomf5kIuuIkxgE_2NCkF_mVtEceqH3eDcyHq6HM8T-gwC15G-w3ZxiNo-BRdwk6n65aeSh-fley4GQCeQh78r2S_lfpyPIGgHZVv6isMOsFUcxnHjjZNn1ULxcN5MG_-NBVibscV_dIYTcU2YcZMke6IlWERtqfYiAUFgFc6y4p8q5vEYw6bqSaCR_IQBwTeWHYH2rwtcYR4Ld3uXj1p2Ts5QWD-DcviOEDXN0X3arXDk5ZPOpaw2p8wJaNfIe6qW6---38wua4_vHb4MC81229XC_KxPmCjcy_a4F8SbP4cGXpxxADq5yJk0wpMzGOa2Z66QDeznPmHGTCTZSLhsly7lNlRMIq8M6h73Qo3H_lxQhXkixptpX85x8tCN0HLAwp5X_sOxs8_dcQoVcxTlfO_uFoel7HhiRIAgEQ75Il9u6jRbSCAjBiveuoXAQX9VEUj45QEbqBcI8LxZxFq6gERcmzgJ9bjME7NNmjhepDtk6VuOJad3qclOrVlMOSoda-C3FAhsbk1t3nEDAgI3HVRNsSSJm-WfAHf7kEZfNAzCERz4hTX3QdI9x5L3FyC76OXcQK8svy0NwKxZSzgklWLp81MLaW1N71e_BIDLOVCcjnDuAVQvGgC_u1fJmDlEz12bNkQw9IRTv4cWv5VgeyYvUwolrTHujoXh2wPxbJnsYf-czODsB6jd_YmASrbZlEd96owTadsBNPIdRFM0TIteXPVHN7zElbcNlf3X6TXlLdaB4aY5KI-IqFcMMGoV56X_XIOh6k6pU3HATUq3G9VF_KZDVejcwjh_20eYvUfCVJ__hvw2Rxy-zZC4nuY6ZGAfR6Uh-uIJROFYiX_iG6YtNJYLqGfNqZp6DEAE8hidiHOviJSr1Yt3sNUI0r6HTRPWt8z9vMhSvk3fcVSneKCoEojkpTphTkDhFsr7YFYnrPBWhCRqBaHUugyAz_eQXkf860ZdJxpPPrKWgJt0B0iYkDsAfr5HEv0HlnfT4bMvqJRMbiO2LcmMKFfH9OSer6383cHubszgnLcLzoq3WNzG9uFG02PaRn441UZfPoYAlllwhHe9wJW3hJ84HScz7SXSBWGr-KFOgeHRhPMjGGeiNJ1DICdCKVM9BUyDt9zZT_stC5-oXolxvB_A0rxFSthXusA8fsQSfIqS_lyofKEgFoiuJ7pphYOpVcuzJdujJvbagublzmvatQhEj7TQ0IkxowVRbJvOufXcgZUzRs7bWfcAt7WOUv0C33TXbHenpd9KJy86bMBP5ZWJOSmf5WW2XQuqpkyv0rzByMt9FFZP-CoJme6XQDY0nYfa_IBMEd_zRvQ_hNl8jlD5lSmzp-XYBOcvvyXAAODfznImEa2teJ6IrqXK6dPyiErF9NUTwf-kSRMnXUn3fJcP2LrFwtwaP8O9_oBTtQ8RcZQo--zpWABh7fHuw0-hUYG04hBsJfdXj6CvS24U8cBCBXEcnYj74wkR6FMOsXqcABR7iMLbWLLB__8H0DyFlzEabTPmb9sNoqA_LE_HLxMDsq4SYqFxms_mboEtUvWAyo-4lVaIu-RDmKQXT7GyW0fZ-YDGW9j-Sb14B9F0xhY3XOE672ASQO0keCGESaiZwL0iEqflNtKAYySFaFM1yQNOultRQHQmxJ-nVoIwupcJlDECx9GQfwVwNAZZfkiXdtJgfeAi2w8vpf3lQw6lW0N6pdnu4f6dRqlvxSpTsYkKj7TaUIUx60uQ4JxJePsYwZh_h0KdGjLM9rmEET4EHnEXYTBsZR8FbqHzogXE7xrAu-7ZbCS_X0tjrQYjG3JMiwv-VRvI_6NAWqRcQ382GMOZuQwGVNB6zLn5z1G9zde0Ved9py3bBG9s_SmATmXWQ_CrmW2tf5xPoCqP6N62yEUD9ZEagXCsgRjpU0dzNdvE1D6FzB8ZeUe8vYQS90VfPNNmM-8lE4qsoLamTcOqHgzx6RhuarRfSOaohOFTfowIAj6Q0QG-5g5boRqDsLWUj912BAdWk7hNP7QH1DTLFzZTov2oYdfHZij4L87MK8"

                },
                Genres = new List<string>()
                {
                    "военный", "драма", "комедия"
                }
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "Остров проклятых",
                    Description = "Пристав оказывается заложником клиники для умалишенных. Сложносочиненный детектив с Леонардо ДиКаприо",
                    Year = 2009,
                    Country = "США",
                    Time = 138,
                    Tagline = "Some places never let you go",
                    Director = "Мартин Скорсезе",
                    Budget = 80000000,
                    Fees = 294804195,
                    AgeLimit = 18,
                    Rating = 8.5,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/15D2S2r30/33deda7SK/7htRvK7qLcqB7zW47Pf5ERgu4sxJy-F4M37R8H0rzARd-esRa2vgXRtB0GYUJ4I3AwDdnseC4lWBGgwNas6c598SNfyjlmWSpJ5NxIWv0QRtCpr5EPrQWWpupb0IRrC4nVkjtKPzHP2b8FVrBTv3QmZ93Ir-__pt7BpNxNaawXp6CxEMfhagTpHbcKgw1ykRpG_2nH2W_Ug7c03ozQeoeEkFPxhLj-TdV2w1jw32S_ZKUbASRvv2kJjWHYQvjoUC1kf58MqGrL75X3w8ALPFtRxbTiBhonHsa-PRTOEbxIDt5YMYE4f4_RvoyfPp6hc6ki0ATpL37lQwksGIa7Ih6qoTscie5tBG_ft0zOxPUbGYS7qohdJJgJMHyUBVT2DY_eUvAAfnbEWf0MkTYXrX4mah9FpelyLctB7dIBPGYfJyb0HYOhog7tUvxDTMl32FuO-GJEGCRVyvDwE4UaMwzDVN5_QHgzRd3wTZ-zFqV2Ki8UAW4m_-DADqyQif0rXyRqMN5MJG3F6Nv_QYpOcVIYhz8ihJ3kVgt5exyIGrdCBFvffgixfEMVf0PRPJWste4pFwEsbnhqjg3ik8GwZh5uLrSfT6bsg-XTO4tNDn9aU0R7JUeb7F6Df3YTRVg7hc2c2PAL_fwO2rWMn7CUqLZvoR2Koi855UkBohZKeG0R6O7x0MjiqwKqlTZBxYQwUFvG_WMEm-aeBnO6lY0SfgBIWRk2j3cwjJkxDdqwmyw8pmCdSqWnMSKEDisXw3IhHmyl9x_JYCoKJ5w3DQ3Nfdabyf5mT5PuXMK3PpiOE3rOTFZffsU_uweS9IPasFDlf6jhn4ohqzglzQ6r1w9wKV1tbH-VB2tuTKcTMQSGxTjcGUC5KUQaY9KB_7dbhde_jUpTk3FAcDmJlTbOX7cdp3Cup5bEbmlxLkXGKl-L9OgYomf5kIuuIkxgE_2NCkF_mVtEceqH3eDcyHq6HM8T-gwC15G-w3ZxiNo-BRdwk6n65aeSh-fley4GQCeQh78r2S_lfpyPIGgHZVv6isMOsFUcxnHjjZNn1ULxcN5MG_-NBVibscV_dIYTcU2YcZMke6IlWERtqfYiAUFgFc6y4p8q5vEYw6bqSaCR_IQBwTeWHYH2rwtcYR4Ld3uXj1p2Ts5QWD-DcviOEDXN0X3arXDk5ZPOpaw2p8wJaNfIe6qW6---38wua4_vHb4MC81229XC_KxPmCjcy_a4F8SbP4cGXpxxADq5yJk0wpMzGOa2Z66QDeznPmHGTCTZSLhsly7lNlRMIq8M6h73Qo3H_lxQhXkixptpX85x8tCN0HLAwp5X_sOxs8_dcQoVcxTlfO_uFoel7HhiRIAgEQ75Il9u6jRbSCAjBiveuoXAQX9VEUj45QEbqBcI8LxZxFq6gERcmzgJ9bjME7NNmjhepDtk6VuOJad3qclOrVlMOSoda-C3FAhsbk1t3nEDAgI3HVRNsSSJm-WfAHf7kEZfNAzCERz4hTX3QdI9x5L3FyC76OXcQK8svy0NwKxZSzgklWLp81MLaW1N71e_BIDLOVCcjnDuAVQvGgC_u1fJmDlEz12bNkQw9IRTv4cWv5VgeyYvUwolrTHujoXh2wPxbJnsYf-czODsB6jd_YmASrbZlEd96owTadsBNPIdRFM0TIteXPVHN7zElbcNlf3X6TXlLdaB4aY5KI-IqFcMMGoV56X_XIOh6k6pU3HATUq3G9VF_KZDVejcwjh_20eYvUfCVJ__hvw2Rxy-zZC4nuY6ZGAfR6Uh-uIJROFYiX_iG6YtNJYLqGfNqZp6DEAE8hidiHOviJSr1Yt3sNUI0r6HTRPWt8z9vMhSvk3fcVSneKCoEojkpTphTkDhFsr7YFYnrPBWhCRqBaHUugyAz_eQXkf860ZdJxpPPrKWgJt0B0iYkDsAfr5HEv0HlnfT4bMvqJRMbiO2LcmMKFfH9OSer6383cHubszgnLcLzoq3WNzG9uFG02PaRn441UZfPoYAlllwhHe9wJW3hJ84HScz7SXSBWGr-KFOgeHRhPMjGGeiNJ1DICdCKVM9BUyDt9zZT_stC5-oXolxvB_A0rxFSthXusA8fsQSfIqS_lyofKEgFoiuJ7pphYOpVcuzJdujJvbagublzmvatQhEj7TQ0IkxowVRbJvOufXcgZUzRs7bWfcAt7WOUv0C33TXbHenpd9KJy86bMBP5ZWJOSmf5WW2XQuqpkyv0rzByMt9FFZP-CoJme6XQDY0nYfa_IBMEd_zRvQ_hNl8jlD5lSmzp-XYBOcvvyXAAODfznImEa2teJ6IrqXK6dPyiErF9NUTwf-kSRMnXUn3fJcP2LrFwtwaP8O9_oBTtQ8RcZQo--zpWABh7fHuw0-hUYG04hBsJfdXj6CvS24U8cBCBXEcnYj74wkR6FMOsXqcABR7iMLbWLLB__8H0DyFlzEabTPmb9sNoqA_LE_HLxMDsq4SYqFxms_mboEtUvWAyo-4lVaIu-RDmKQXT7GyW0fZ-YDGW9j-Sb14B9F0xhY3XOE672ASQO0keCGESaiZwL0iEqflNtKAYySFaFM1yQNOultRQHQmxJ-nVoIwupcJlDECx9GQfwVwNAZZfkiXdtJgfeAi2w8vpf3lQw6lW0N6pdnu4f6dRqlvxSpTsYkKj7TaUIUx60uQ4JxJePsYwZh_h0KdGjLM9rmEET4EHnEXYTBsZR8FbqHzogXE7xrAu-7ZbCS_X0tjrQYjG3JMiwv-VRvI_6NAWqRcQ382GMOZuQwGVNB6zLn5z1G9zde0Ved9py3bBG9s_SmATmXWQ_CrmW2tf5xPoCqP6N62yEUD9ZEagXCsgRjpU0dzNdvE1D6FzB8ZeUe8vYQS90VfPNNmM-8lE4qsoLamTcOqHgzx6RhuarRfSOaohOFTfowIAj6Q0QG-5g5boRqDsLWUj912BAdWk7hNP7QH1DTLFzZTov2oYdfHZij4L87MK8#DSD"
                },
                Genres = new List<string>()
                {
                    "триллер", "драма", "детектив"
                }
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "Большой куш",
                    Description = "Брэд Питт в роли цыгана, нелегальные бои, краденые алмазы и английский юмор в шедевре Гая Ричи",
                    Year = 2000,
                    Country = "Великобритания, США",
                    Time = 104,
                    Tagline = "Stealing stones is hazardous",
                    Director = "Гай Ричи",
                    Budget = 10000000,
                    Fees = 83557872,
                    AgeLimit = 16,
                    Rating = 8.5,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/15D2S2r30/33deda7SK/7htRvK7qLcqB7zW47Pf5ERgu4sxJy-F4M37R8H0rzARd-esRa2vgXRtB0HIEO5IzGxDdgtOS8wzND0QNZ5fI098SAeinlwTj0KJN4IWinGUdCrutFMbUWWpupb0IRrC4nVkjtKPzHP2b8FVrBTv3QmZ93Ir-__pt7BpNxNaawXp6CxEMfhagTpHbcKgw1ykRpG_2nH2W_Ug7c03ozQeoeEkFPxhLj-TdV2w1jw32S_ZKUbASRvv2kJjWHYQvjoUC1kf58MqGrL75X3w8ALPFtRxbTiBhonHsa-PRTOEbxIDt5YMYE4f4_RvoyfPp6hc6ki0ATpL37lQwksGIa7Ih6qoTscie5tBG_ft0zOxPUbGYS7qohdJJgJMHyUBVT2DY_eUvAAfnbEWf0MkTYXrX4mah9FpelyLctB7dIBPGYfJyb0HYOhog7tUvxDTMl32FuO-GJEGCRVyvDwE4UaMwzDVN5_QHgzRd3wTZ-zFqV2Ki8UAW4m_-DADqyQif0rXyRqMN5MJG3F6Nv_QYpOcVIYhz8ihJ3kVgt5exyIGrdCBFvffgixfEMVf0PRPJWste4pFwEsbnhqjg3ik8GwZh5uLrSfT6bsg-XTO4tNDn9aU0R7JUeb7F6Df3YTRVg7hc2c2PAL_fwO2rWMn7CUqLZvoR2Koi855UkBohZKeG0R6O7x0MjiqwKqlTZBxYQwUFvG_WMEm-aeBnO6lY0SfgBIWRk2j3cwjJkxDdqwmyw8pmCdSqWnMSKEDisXw3IhHmyl9x_JYCoKJ5w3DQ3Nfdabyf5mT5PuXMK3PpiOE3rOTFZffsU_uweS9IPasFDlf6jhn4ohqzglzQ6r1w9wKV1tbH-VB2tuTKcTMQSGxTjcGUC5KUQaY9KB_7dbhde_jUpTk3FAcDmJlTbOX7cdp3Cup5bEbmlxLkXGKl-L9OgYomf5kIuuIkxgE_2NCkF_mVtEceqH3eDcyHq6HM8T-gwC15G-w3ZxiNo-BRdwk6n65aeSh-fley4GQCeQh78r2S_lfpyPIGgHZVv6isMOsFUcxnHjjZNn1ULxcN5MG_-NBVibscV_dIYTcU2YcZMke6IlWERtqfYiAUFgFc6y4p8q5vEYw6bqSaCR_IQBwTeWHYH2rwtcYR4Ld3uXj1p2Ts5QWD-DcviOEDXN0X3arXDk5ZPOpaw2p8wJaNfIe6qW6---38wua4_vHb4MC81229XC_KxPmCjcy_a4F8SbP4cGXpxxADq5yJk0wpMzGOa2Z66QDeznPmHGTCTZSLhsly7lNlRMIq8M6h73Qo3H_lxQhXkixptpX85x8tCN0HLAwp5X_sOxs8_dcQoVcxTlfO_uFoel7HhiRIAgEQ75Il9u6jRbSCAjBiveuoXAQX9VEUj45QEbqBcI8LxZxFq6gERcmzgJ9bjME7NNmjhepDtk6VuOJad3qclOrVlMOSoda-C3FAhsbk1t3nEDAgI3HVRNsSSJm-WfAHf7kEZfNAzCERz4hTX3QdI9x5L3FyC76OXcQK8svy0NwKxZSzgklWLp81MLaW1N71e_BIDLOVCcjnDuAVQvGgC_u1fJmDlEz12bNkQw9IRTv4cWv5VgeyYvUwolrTHujoXh2wPxbJnsYf-czODsB6jd_YmASrbZlEd96owTadsBNPIdRFM0TIteXPVHN7zElbcNlf3X6TXlLdaB4aY5KI-IqFcMMGoV56X_XIOh6k6pU3HATUq3G9VF_KZDVejcwjh_20eYvUfCVJ__hvw2Rxy-zZC4nuY6ZGAfR6Uh-uIJROFYiX_iG6YtNJYLqGfNqZp6DEAE8hidiHOviJSr1Yt3sNUI0r6HTRPWt8z9vMhSvk3fcVSneKCoEojkpTphTkDhFsr7YFYnrPBWhCRqBaHUugyAz_eQXkf860ZdJxpPPrKWgJt0B0iYkDsAfr5HEv0HlnfT4bMvqJRMbiO2LcmMKFfH9OSer6383cHubszgnLcLzoq3WNzG9uFG02PaRn441UZfPoYAlllwhHe9wJW3hJ84HScz7SXSBWGr-KFOgeHRhPMjGGeiNJ1DICdCKVM9BUyDt9zZT_stC5-oXolxvB_A0rxFSthXusA8fsQSfIqS_lyofKEgFoiuJ7pphYOpVcuzJdujJvbagublzmvatQhEj7TQ0IkxowVRbJvOufXcgZUzRs7bWfcAt7WOUv0C33TXbHenpd9KJy86bMBP5ZWJOSmf5WW2XQuqpkyv0rzByMt9FFZP-CoJme6XQDY0nYfa_IBMEd_zRvQ_hNl8jlD5lSmzp-XYBOcvvyXAAODfznImEa2teJ6IrqXK6dPyiErF9NUTwf-kSRMnXUn3fJcP2LrFwtwaP8O9_oBTtQ8RcZQo--zpWABh7fHuw0-hUYG04hBsJfdXj6CvS24U8cBCBXEcnYj74wkR6FMOsXqcABR7iMLbWLLB__8H0DyFlzEabTPmb9sNoqA_LE_HLxMDsq4SYqFxms_mboEtUvWAyo-4lVaIu-RDmKQXT7GyW0fZ-YDGW9j-Sb14B9F0xhY3XOE672ASQO0keCGESaiZwL0iEqflNtKAYySFaFM1yQNOultRQHQmxJ-nVoIwupcJlDECx9GQfwVwNAZZfkiXdtJgfeAi2w8vpf3lQw6lW0N6pdnu4f6dRqlvxSpTsYkKj7TaUIUx60uQ4JxJePsYwZh_h0KdGjLM9rmEET4EHnEXYTBsZR8FbqHzogXE7xrAu-7ZbCS_X0tjrQYjG3JMiwv-VRvI_6NAWqRcQ382GMOZuQwGVNB6zLn5z1G9zde0Ved9py3bBG9s_SmATmXWQ_CrmW2tf5xPoCqP6N62yEUD9ZEagXCsgRjpU0dzNdvE1D6FzB8ZeUe8vYQS90VfPNNmM-8lE4qsoLamTcOqHgzx6RhuarRfSOaohOFTfowIAj6Q0QG-5g5boRqDsLWUj912BAdWk7hNP7QH1DTLFzZTov2oYdfHZij4L87MK8#DSD"
                },
                Genres = new List<string>()
                {
                    "криминал", "комедия", "боевик"
                }
            },
            new GenerateMovieModel
            {
                Movie = new Movie
                {
                    Name = "Джентльмены",
                    Description = "Наркобарон хочет уйти на покой, но криминальный мир не отпускает. Успешное возвращение Гая Ричи к корням",
                    Year = 2019,
                    Country = "Великобритания, США",
                    Time = 104,
                    Tagline = "Criminal. Class",
                    Director = "Гай Ричи",
                    Budget = 22000000,
                    Fees = 115171795,
                    AgeLimit = 18,
                    Rating = 8.5,
                    PosterLink = "https://kinopoisk-ru.clstorage.net/15D2S2r30/33deda7SK/7htRvK7qLcqB7zW47Pf5ERgu4sxJy-F4M37R8H0rzARd-esRa2vgXRtB0HIMA6ovCyTdk4-G_x2QQ0wNct6A598TQL3zlmT_1LJN2JmynFBpH9epBMuIWWpupb0IRrC4nVkjtKPzHP2b8FVrBTv3QmZ93Ir-__pt7BpNxNaawXp6CxEMfhagTpHbcKgw1ykRpG_2nH2W_Ug7c03ozQeoeEkFPxhLj-TdV2w1jw32S_ZKUbASRvv2kJjWHYQvjoUC1kf58MqGrL75X3w8ALPFtRxbTiBhonHsa-PRTOEbxIDt5YMYE4f4_RvoyfPp6hc6ki0ATpL37lQwksGIa7Ih6qoTscie5tBG_ft0zOxPUbGYS7qohdJJgJMHyUBVT2DY_eUvAAfnbEWf0MkTYXrX4mah9FpelyLctB7dIBPGYfJyb0HYOhog7tUvxDTMl32FuO-GJEGCRVyvDwE4UaMwzDVN5_QHgzRd3wTZ-zFqV2Ki8UAW4m_-DADqyQif0rXyRqMN5MJG3F6Nv_QYpOcVIYhz8ihJ3kVgt5exyIGrdCBFvffgixfEMVf0PRPJWste4pFwEsbnhqjg3ik8GwZh5uLrSfT6bsg-XTO4tNDn9aU0R7JUeb7F6Df3YTRVg7hc2c2PAL_fwO2rWMn7CUqLZvoR2Koi855UkBohZKeG0R6O7x0MjiqwKqlTZBxYQwUFvG_WMEm-aeBnO6lY0SfgBIWRk2j3cwjJkxDdqwmyw8pmCdSqWnMSKEDisXw3IhHmyl9x_JYCoKJ5w3DQ3Nfdabyf5mT5PuXMK3PpiOE3rOTFZffsU_uweS9IPasFDlf6jhn4ohqzglzQ6r1w9wKV1tbH-VB2tuTKcTMQSGxTjcGUC5KUQaY9KB_7dbhde_jUpTk3FAcDmJlTbOX7cdp3Cup5bEbmlxLkXGKl-L9OgYomf5kIuuIkxgE_2NCkF_mVtEceqH3eDcyHq6HM8T-gwC15G-w3ZxiNo-BRdwk6n65aeSh-fley4GQCeQh78r2S_lfpyPIGgHZVv6isMOsFUcxnHjjZNn1ULxcN5MG_-NBVibscV_dIYTcU2YcZMke6IlWERtqfYiAUFgFc6y4p8q5vEYw6bqSaCR_IQBwTeWHYH2rwtcYR4Ld3uXj1p2Ts5QWD-DcviOEDXN0X3arXDk5ZPOpaw2p8wJaNfIe6qW6---38wua4_vHb4MC81229XC_KxPmCjcy_a4F8SbP4cGXpxxADq5yJk0wpMzGOa2Z66QDeznPmHGTCTZSLhsly7lNlRMIq8M6h73Qo3H_lxQhXkixptpX85x8tCN0HLAwp5X_sOxs8_dcQoVcxTlfO_uFoel7HhiRIAgEQ75Il9u6jRbSCAjBiveuoXAQX9VEUj45QEbqBcI8LxZxFq6gERcmzgJ9bjME7NNmjhepDtk6VuOJad3qclOrVlMOSoda-C3FAhsbk1t3nEDAgI3HVRNsSSJm-WfAHf7kEZfNAzCERz4hTX3QdI9x5L3FyC76OXcQK8svy0NwKxZSzgklWLp81MLaW1N71e_BIDLOVCcjnDuAVQvGgC_u1fJmDlEz12bNkQw9IRTv4cWv5VgeyYvUwolrTHujoXh2wPxbJnsYf-czODsB6jd_YmASrbZlEd96owTadsBNPIdRFM0TIteXPVHN7zElbcNlf3X6TXlLdaB4aY5KI-IqFcMMGoV56X_XIOh6k6pU3HATUq3G9VF_KZDVejcwjh_20eYvUfCVJ__hvw2Rxy-zZC4nuY6ZGAfR6Uh-uIJROFYiX_iG6YtNJYLqGfNqZp6DEAE8hidiHOviJSr1Yt3sNUI0r6HTRPWt8z9vMhSvk3fcVSneKCoEojkpTphTkDhFsr7YFYnrPBWhCRqBaHUugyAz_eQXkf860ZdJxpPPrKWgJt0B0iYkDsAfr5HEv0HlnfT4bMvqJRMbiO2LcmMKFfH9OSer6383cHubszgnLcLzoq3WNzG9uFG02PaRn441UZfPoYAlllwhHe9wJW3hJ84HScz7SXSBWGr-KFOgeHRhPMjGGeiNJ1DICdCKVM9BUyDt9zZT_stC5-oXolxvB_A0rxFSthXusA8fsQSfIqS_lyofKEgFoiuJ7pphYOpVcuzJdujJvbagublzmvatQhEj7TQ0IkxowVRbJvOufXcgZUzRs7bWfcAt7WOUv0C33TXbHenpd9KJy86bMBP5ZWJOSmf5WW2XQuqpkyv0rzByMt9FFZP-CoJme6XQDY0nYfa_IBMEd_zRvQ_hNl8jlD5lSmzp-XYBOcvvyXAAODfznImEa2teJ6IrqXK6dPyiErF9NUTwf-kSRMnXUn3fJcP2LrFwtwaP8O9_oBTtQ8RcZQo--zpWABh7fHuw0-hUYG04hBsJfdXj6CvS24U8cBCBXEcnYj74wkR6FMOsXqcABR7iMLbWLLB__8H0DyFlzEabTPmb9sNoqA_LE_HLxMDsq4SYqFxms_mboEtUvWAyo-4lVaIu-RDmKQXT7GyW0fZ-YDGW9j-Sb14B9F0xhY3XOE672ASQO0keCGESaiZwL0iEqflNtKAYySFaFM1yQNOultRQHQmxJ-nVoIwupcJlDECx9GQfwVwNAZZfkiXdtJgfeAi2w8vpf3lQw6lW0N6pdnu4f6dRqlvxSpTsYkKj7TaUIUx60uQ4JxJePsYwZh_h0KdGjLM9rmEET4EHnEXYTBsZR8FbqHzogXE7xrAu-7ZbCS_X0tjrQYjG3JMiwv-VRvI_6NAWqRcQ382GMOZuQwGVNB6zLn5z1G9zde0Ved9py3bBG9s_SmATmXWQ_CrmW2tf5xPoCqP6N62yEUD9ZEagXCsgRjpU0dzNdvE1D6FzB8ZeUe8vYQS90VfPNNmM-8lE4qsoLamTcOqHgzx6RhuarRfSOaohOFTfowIAj6Q0QG-5g5boRqDsLWUj912BAdWk7hNP7QH1DTLFzZTov2oYdfHZij4L87MK8#DSD"
                },
                Genres = new List<string>()
                {
                    "криминал", "комедия", "боевик"
                }
            },
        };
    }
}
