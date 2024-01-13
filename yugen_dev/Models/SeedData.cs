
using yugen_dev.Models;

namespace yugen_dev.Data
{
    public static class SeedData
    {
        public static void Initialize(YugenContext context)
        {
            context.Database.EnsureCreated();
            // Seed Dishes
            var ikura = new Dish
            {
                NameFr = "Ikura Burini",
                NameJap = " いくらブリニ",
                Description = "Blini garni d'œufs de saumon.",
                DetailedDescription = "Petits blinis moelleux, couronnés d'œufs de saumon pour une explosion de saveurs marines et une touche subtilement sucrée.",
                SignatureDish = false,
                ImagePath = "not defined",
                Category = 1
            };
            var torufu = new Dish
            {
                NameFr = "Torufu Chawanmushi",
                NameJap = "トリュフ茶碗蒸し",
                Description = "Flan aux œufs et truffes.",
                DetailedDescription = "Flan japonais à la vapeur, préparé avec des œufs, du bouillon dashi, des crevettes et des truffes noires, offrant une texture soyeuse et des arômes riches.",
                SignatureDish = false,
                ImagePath = "not defined",
                Category = 1
            };
            var maguro = new Dish
            {
                NameFr = "Maguro no Tataki",
                NameJap = "マグロのたたき",
                Description = "Tranches de thon saisi sur croustille de riz.",
                DetailedDescription = "Thon rouge légèrement saisi, tranché finement, présenté sur une croustille de riz croquante, offrant une texture et des saveurs contrastées.",
                SignatureDish = false,
                ImagePath = "not defined",
                Category = 1
            };
            var agedashi = new Dish
            {
                NameFr = "Agedashi Tofu",
                NameJap = "揚げ出し豆腐",
                Description = "Cubes de tofu frits, nappés d'une sauce dashi légère.",
                DetailedDescription = "Cubes de tofu frits légèrement croustillants, servis dans un bouillon dashi avec des condiments tels que de la sauce soja, du radis râpé et des oignons verts.",
                SignatureDish = false,
                ImagePath = "not defined",
                Category = 2
            };
            var tempura = new Dish
            {
                NameFr = "Tempura de shiitake",
                NameJap = "椎茸の天ぷら",
                Description = "Croustillantes bouchées de champignon shiitake enrobées d'une pâte dorée.",
                DetailedDescription = "Des champignons shiitake enrobés d'une pâte légère et dorée, puis frits pour obtenir une texture croustillante. Servis avec une sauce dip, offrent une expérience culinaire équilibrée entre la subtilité des champignons et la légèreté de la pâte croustillante.",
                SignatureDish = false,
                ImagePath = "not defined",
                Category = 2
            };
            var robusutā = new Dish
            {
                NameFr = "Robusutā no Tempura",
                NameJap = "ロブスターの天ぷら ",
                Description = "Morceaux de homard croustillants, enveloppés dans une pâte légère.",
                DetailedDescription = "Morceaux de homard délicatement enrobés de pâte légère, frits à la perfection, créant une tempura croustillante et savoureuse.",
                SignatureDish = false,
                ImagePath = "not defined",
                Category = 2
            };
            var kani = new Dish
            {
                NameFr = "Kani to Yuzu no Sūpu",
                NameJap = "カニと柚子のスープ",
                Description = "Soupe de crabe, infusée au yuzu.",
                DetailedDescription = "Soupe délicate au crabe, subtilement parfumée au yuzu, mariant la douceur du crabe avec la fraîcheur acidulée du yuzu pour une expérience gustative équilibrée.",
                SignatureDish = false,
                ImagePath = "not defined",
                Category = 2
            };

            var miyabi = new Dish
            {
                NameFr = "Miyabi",
                NameJap = "雅",
                Description = "Sushis au caviar rouge sublimés par une sauce au sésame et à l'umeshu.",
                DetailedDescription = "Explorez l'harmonie exquise entre nos délicats sushis et la sophistication du caviar. Chaque bouchée révèle une fusion parfaite de saveurs raffinées, une expérience gastronomique où la tradition japonaise rencontre l'élégance contemporaine.",
                SignatureDish = true,
                ImagePath = "img/dish1.jpg",
                Category = 3
            };
            var sora = new Dish
            {
                NameFr = "Sora Reinbōrōru",
                NameJap = "空レインボーロール",
                Description = "Sushis rolls mariant saumon, avocat, concombre et légumes frais.",
                DetailedDescription = "Plongez dans l'harmonie exquise du Sora Reinbōrōru, où chaque bouchée dévoile une symphonie de fraîcheur subtile. Ce rouleau céleste incarne l'essence de la gastronomie japonaise, offrant une fusion parfaite de saveurs délicates et raffinées.",
                SignatureDish = true,
                ImagePath = "img/dish2.jpg",
                Category = 3
            };
            var himitsu = new Dish
            {
                NameFr = "Himitsu",
                NameJap = "秘密",
                Description = "Création secrète du chef, aux saveurs mystérieuses.",
                DetailedDescription = "Plongez dans l'univers exquis de notre plat signature, le Himitsu, une création mystérieuse du chef révolutionnant l'art du sushi. Chaque bouchée dévoile une expérience gustative exceptionnelle, faisant de Himitsu une véritable énigme gastronomique. ",
                SignatureDish = true,
                ImagePath = "img/dish3.jpg",
                Category = 3
            };
            var tobiko = new Dish
            {
                NameFr = "Océan Tobiko",
                NameJap = "オーシャン トビコ",
                Description = "Assortiment de sushis rolls avec du caviar tobiko, saumon, graines de sésame, de l'avocat et du concombre.",
                DetailedDescription = "Un assemblage gourmet de caviar tobiko, saumon, avocat, et concombre, enveloppé dans une fusion de saveurs. Les œufs vibrants de tobiko éclatent avec la richesse marine, tandis que le saumon fondant et l'avocat crémeux complètent une symphonie gustative.",
                SignatureDish = false,
                ImagePath = "not defined",
                Category = 4
            };
            var moriawase = new Dish
            {
                NameFr = "Torufu Sushi no Moriawase",
                NameJap = "トリュフ寿司の盛り合わせ",
                Description = "Assortiment de sushis sublimés par la truffe.",
                DetailedDescription = "Une combinaison exquise de sushis, agrémentée de truffe noire, ajoutant une dimension aromatique et terreuse à chaque bouchée.",
                SignatureDish = false,
                ImagePath = "not defined",
                Category = 4
            };
            var omakase = new Dish
            {
                NameFr = "Sushi Omakase",
                NameJap = "お任せ寿司",
                Description = "Assortiment personnalisé de sushis, soigneusement sélectionnés par le chef.",
                DetailedDescription = "Un assortiment personnalisé de sushis, soigneusement sélectionnés par le chef, offrant une expérience culinaire unique.",
                SignatureDish = false,
                ImagePath = "not defined",
                Category = 4
            };

            var zenzai = new Dish
            {
                NameFr = "Zenzai",
                NameJap = "ぜんざい",
                Description = "Soupe sucrée à base de haricots rouges avec des boulettes de mochi fondu.",
                DetailedDescription = "Une soupe sucrée, marie l'onctuosité de l'anko (pâte de haricots rouges sucrée) avec des boulettes de mochi tendres. Elle offre une expérience gustative équilibrée entre la douceur des haricots rouges et la texture moelleuse du mochi.",
                SignatureDish = false,
                ImagePath = "not defined",
                Category = 5
            };
            var warabi = new Dish
            {
                NameFr = "Warabi Mochi",
                NameJap = "わらび餅",
                Description = "Gelée de fougère douce, saupoudrée de kinako.",
                DetailedDescription = " Une gelée traditionnelle à base de fécule de fougère (warabi), servie avec de la poudre de kinako (farine de soja grillée) et du sirop de sucre brun pour une douceur subtile et une texture unique.",
                SignatureDish = false,
                ImagePath = "not defined",
                Category = 5
            };
            var anmitsu = new Dish
            {
                NameFr = "Anmitsu",
                NameJap = "あんみつ",
                Description = "Gelée d'agar-agar, haricots rouges sucrés, fruits variés et kuromitsu.",
                DetailedDescription = "Un dessert traditionnel composé de morceaux de gelée d'agar-agar, de haricots rouges sucrés (anko), de fruits variés et de sirop de sucre noir (kuromitsu), offrant une combinaison de textures et de saveurs harmonieuse.",
                SignatureDish = false,
                ImagePath = "not defined",
                Category = 5
            };

            context.Dishes.AddRange(ikura, torufu, maguro, agedashi, tempura, robusutā, kani, miyabi, sora, himitsu, tobiko, moriawase, omakase, zenzai, warabi, anmitsu);


            var omakasee = new Menu
            {
                NameFr = "Menu Omakase",
                NameJap = "メニューお任せ",
                Price = 230,
                ImagePath = "img/dish12.jpg"
            };
            var yugen = new Menu
            {
                NameFr = "Menu Yūgen",
                NameJap = "メニュー幽玄",
                Price = 250,
                ImagePath = "img/dish14.jpg"
            };
            var Shibui = new Menu
            {
                NameFr = "Menu Shibui",
                NameJap = "メニュー渋い",
                Price = 185,
                ImagePath = "img/dish15.jpg"
            };

            context.Menus.AddRange(omakasee, yugen, Shibui);

            context.MenuDish.AddRange(
// menu yugen
new MenuDish
{
    Menu = yugen,

    Dish = miyabi
},
               new MenuDish
               {
                   Menu = yugen,

                   Dish = torufu
               },
              new MenuDish
              {
                  Menu = yugen,

                  Dish = agedashi
              },



               new MenuDish
               {
                   Menu = yugen,

                   Dish = tobiko
               },
               new MenuDish
               {
                   Menu = yugen,

                   Dish = anmitsu
               },
            //    menu omakasee
            new MenuDish
            {
                Menu = omakasee,

                Dish = himitsu
            },
               new MenuDish
               {
                   Menu = omakasee,

                   Dish = ikura
               },
                 new MenuDish
                 {
                     Menu = omakasee,

                     Dish = kani
                 },

                 new MenuDish
                 {
                     Menu = omakasee,

                     Dish = omakase
                 },
                 new MenuDish
                 {
                     Menu = omakasee,

                     Dish = warabi
                 },
                 //menu Shibui
                 new MenuDish
                 {
                     Menu = Shibui,

                     Dish = sora
                 },
                new MenuDish
                {
                    Menu = Shibui,

                    Dish = maguro
                },
                 new MenuDish
                 {
                     Menu = Shibui,

                     Dish = tempura
                 },

                 new MenuDish
                 {
                     Menu = Shibui,

                     Dish = moriawase
                 },
                 new MenuDish
                 {
                     Menu = Shibui,

                     Dish = zenzai
                 }
            );

            context.SaveChanges();
        }
    }
}