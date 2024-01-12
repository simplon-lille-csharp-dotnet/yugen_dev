
using yugen_dev.Models;

namespace yugen_dev.Data
{
    public static class SeedData
    {
        public static void Initialize(YugenContext context)
        {
            context.Database.EnsureCreated();
            if (context.Clients.Any())
            {
                return; // DB has been seeded
            }

            var clients = new Client[]
            {
                new Client
    {
         FirstName = "Alice",
        LastName = "Smith",
        Email = "alice.smith@gmail.com",
        Address = "123 Rue de Wazemmes, Lille, France",
        PhoneNumber = "123789",
        Password = "letmein",
        Preferences = "gluten-free"
    },
    new Client
    {
        FirstName = "Élla",
        LastName = "Davis",
        Email = "ella.davis@gmail.com",
        Address = "456 Avenue de la République, Wazemmes, Lille, France",
        PhoneNumber = "987123",
        Password = "password123",
        Preferences = "none"
    },
    new Client
    {
        FirstName = "Daniel",
        LastName = "Brown",
        Email = "daniel.brown@gmail.com",
        Address = "456 Rue du Général de Gaulle, Marcq-en-Barœul, France",
        PhoneNumber = "456789",
        Password = "securepass",
        Preferences = "none"
    },
    new Client
    {
        FirstName = "Sophia",
        LastName = "Lee",
        Email = "sophia.lee@gmail.com",
        Address = "404 Boulevard Gambetta, Roubaix, France",
        PhoneNumber = "987654",
        Password = "p@ssw0rd",
        Preferences = "none"
    },
    new Client
    {
        FirstName = "Sophie",
        LastName = "Leroux",
        Email = "sophie.leroux@gmail.com",
        Address = "606 Quai des mines, Valenciennes, France",
        PhoneNumber = "123456",
        Password = "pass123",
        Preferences = "vegetarian"
    },
    new Client
    {
        FirstName = "Olivia",
        LastName = "Clark",
        Email = "olivia.clark@gmail.com",
        Address = "123 Rue de la Paix, Valenciennes, France",
        PhoneNumber = "789123",
        Password = "olivia123",
        Preferences = "none"
    },
    new Client
    {
        FirstName = "William",
        LastName = "Taylor",
        Email = "william.taylor@gmail.com",
        Address = "789 Rue de Lomme, Lille, France",
        PhoneNumber = "987654",
        Password = "101 Rue du Vieux Lille, Lille, France",
        Preferences = "none"
    },
    new Client
    {
        FirstName = "Lucas",
        LastName = "Lemoine",
        Email = "lucas.lemoine@gmail.com",
        Address = "789 Boulevard de la République, Lille, France",
        PhoneNumber = "654321",
        Password = "ellapass",
        Preferences = "gluten-free"
    },
                new Client
                {
                    FirstName = "Mathieu",
                    LastName = "Renault",
                    Email = "mathieu.renault@gmail.com",
                    Address = "456 Avenue des Arts, Lille, France",
                    PhoneNumber = "987654",
                    Password = "qwerty",
                    Preferences = "none"
                },
                new Client
                {
                    FirstName = "Alexandre",
                    LastName = "Bernard",
                    Email = "alexandre.bernard@gmail.com",
                    Address = "123 Rue de la Liberté, Lille, France",
                    PhoneNumber = "111222",
                    Password = "password123",
                    Preferences = "none"
                },
            };

            foreach (Client client in clients)
            {
                context.Clients.Add(client);
            }


            // Seed Dishes
            var dishes = new Dish[]
            {
                 new Dish
                {
                    NameFr = "Ikura Burini",
                    NameJap = " いくらブリニ",
                    Description = "Blini garni d'œufs de saumon",
                    DetailedDescription = "Petits blinis moelleux, couronnés d'œufs de saumon pour une explosion de saveurs marines et une touche subtilement sucrée.",
                    SignatureDish = false,
                    ImagePath = "not defined",
                    Category =1
                },
                 new Dish
                {
                    NameFr = "Torufu Chawanmushi",
                    NameJap = "トリュフ茶碗蒸し",
                    Description = "Flan aux œufs et truffes",
                    DetailedDescription = "Flan japonais à la vapeur, préparé avec des œufs, du bouillon dashi, des crevettes et des truffes noires, offrant une texture soyeuse et des arômes riches.",
                    SignatureDish = false,
                    ImagePath = "not defined",
                    Category =1
                },
                  new Dish
                {
                    NameFr = "Maguro no Tataki",
                    NameJap = "マグロのたたき",
                    Description = "Tranches de thon saisi sur croustille de riz",
                    DetailedDescription = "Thon rouge légèrement saisi, tranché finement, présenté sur une croustille de riz croquante, offrant une texture et des saveurs contrastées.",
                    SignatureDish = false,
                    ImagePath = "not defined",
                    Category =1
                },
                 new Dish
                {
                    NameFr = "Agedashi Tofu",
                    NameJap = "揚げ出し豆腐",
                    Description = "Cubes de tofu frits, nappés d'une sauce dashi légère.",
                    DetailedDescription = "Cubes de tofu frits légèrement croustillants, servis dans un bouillon dashi avec des condiments tels que de la sauce soja, du radis râpé et des oignons verts.",
                    SignatureDish = false,
                    ImagePath = "not defined",
                    Category =2
                },
                   new Dish
                {
                    NameFr = "Tempura de shiitake",
                    NameJap = "椎茸の天ぷら",
                    Description = "Croustillantes bouchées de champignon shiitake enrobées d'une pâte dorée.",
                    DetailedDescription = "Des champignons shiitake enrobés d'une pâte légère et dorée, puis frits pour obtenir une texture croustillante. Servis avec une sauce dip,  offrent une expérience culinaire équilibrée entre la subtilité des champignons et la légèreté de la pâte croustillante.",
                    SignatureDish = false,
                    ImagePath = "not defined",
                    Category =2
                },
                 new Dish
                {
                    NameFr = "Robusutā no Tempura",
                    NameJap = "ロブスターの天ぷら ",
                    Description = "Morceaux de homard croustillants, enveloppés dans une pâte légère",
                    DetailedDescription = "Morceaux de homard délicatement enrobés de pâte légère, frits à la perfection, créant une tempura croustillante et savoureuse.",
                    SignatureDish = false,
                    ImagePath = "not defined",
                    Category =2
                },
                 new Dish
                {
                    NameFr = "Kani to Yuzu no Sūpu",
                    NameJap = "カニと柚子のスープ",
                    Description = "Soupe de crabe, infusée au yuzu.",
                    DetailedDescription = "Soupe délicate au crabe, subtilement parfumée au yuzu, mariant la douceur du crabe avec la fraîcheur acidulée du yuzu pour une expérience gustative équilibrée.",
                    SignatureDish = false,
                    ImagePath = "not defined",
                    Category =2
                },

                new Dish
                {
                    NameFr = "Miyabi",
                    NameJap = "雅",
                    Description = "Sushis au caviar",
                    DetailedDescription = "Explorez l'harmonie exquise entre nos délicats sushis et la sophistication du caviar. Chaque bouchée révèle une fusion parfaite de saveurs raffinées, une expérience gastronomique où la tradition japonaise rencontre l'élégance contemporaine.",
                    SignatureDish = true,
                    ImagePath = "img/dish1.jpg",
                    Category = 3
                },
                new Dish
                {
                    NameFr = "Sora Reinbōrōru",
                    NameJap = "空レインボーロール",
                    Description = "Sushi rolls",
                    DetailedDescription = "Plongez dans l'harmonie exquise du Sora Reinbōrōru, où chaque bouchée dévoile une symphonie de fraîcheur subtile. Ce rouleau céleste incarne l'essence de la gastronomie japonaise, offrant une fusion parfaite de saveurs délicates et raffinées.",
                    SignatureDish = true,
                    ImagePath = "img/dish2.jpg",
                    Category = 3
                },
                 new Dish
                {
                    NameFr = "Himitsu",
                    NameJap = "秘密",
                    Description = "Assortiment de sushis",
                    DetailedDescription = "Plongez dans l'univers exquis de notre plat signature, le Himitsu, une création mystérieuse du chef révolutionnant l'art du sushi. Un assortiment exclusif, soigneusement sélectionné, alliant sophistication, mystère et délice.",
                    SignatureDish = true,
                    ImagePath = "img/dish3.jpg",
                    Category = 3
                },
                 new Dish
                {
                    NameFr = "Océan Tobiko",
                    NameJap = "オーシャン トビコ",
                    Description = "Assortiment de Sushi Roll avec du caviar tobiko, saumon, graines de sésame, l'avocat et le concombre.",
                    DetailedDescription = "Un assemblage gourmet de caviar tobiko, saumon, avocat, et concombre, enveloppé dans une fusion de saveurs. Les œufs vibrants de tobiko éclatent avec la richesse marine, tandis que le saumon fondant et l'avocat crémeux complètent une symphonie gustative.",
                    SignatureDish = false,
                    ImagePath = "not defined",
                    Category =4
                },
                   new Dish
                {
                    NameFr = "Torufu Sushi no Moriawase",
                    NameJap = "トリュフ寿司の盛り合わせ",
                    Description = "Assortiment de sushis sublimés par la truffe",
                    DetailedDescription = "Une combinaison exquise de sushis, agrémentée de truffe noire, ajoutant une dimension aromatique et terreuse à chaque bouchée.",
                    SignatureDish = false,
                    ImagePath = "not defined",
                    Category =4
                },
                   new Dish
                {
                    NameFr = "Sushi Omakase",
                    NameJap = "お任せ寿司",
                    Description = "Assortiment personnalisé de sushis, soigneusement sélectionnés par le chef",
                    DetailedDescription = "Un assortiment personnalisé de sushis, soigneusement sélectionnés par le chef, offrant une expérience culinaire unique.",
                    SignatureDish = false,
                    ImagePath = "not defined",
                    Category =4
                },

                   new Dish
                {
                    NameFr = "Zenzai",
                    NameJap = "ぜんざい",
                    Description = "Soupe sucrée à base de haricots rouges avec des boulettes de mochi fondu",
                    DetailedDescription = "Une soupe sucrée, marie l'onctuosité de l'anko (pâte de haricots rouges sucrée) avec des boulettes de mochi tendres. Elle offre une expérience gustative équilibrée entre la douceur des haricots rouges et la texture moelleuse du mochi.",
                    SignatureDish = false,
                    ImagePath = "not defined",
                    Category =5
                },
                 new Dish
                {
                    NameFr = "Warabi Mochi",
                    NameJap = "わらび餅",
                    Description = "Gelée de fougère douce, saupoudrée de kinako.",
                    DetailedDescription = " Une gelée traditionnelle à base de fécule de fougère (warabi), servie avec de la poudre de kinako (farine de soja grillée) et du sirop de sucre brun pour une douceur subtile et une texture unique.",
                    SignatureDish = false,
                    ImagePath = "not defined",
                    Category =5
                },
                 new Dish
                {
                    NameFr = "Anmitsu",
                    NameJap = "あんみつ",
                    Description = "Gelée d'agar-agar, haricots rouges sucrés, fruits variés et kuromitsu.",
                    DetailedDescription = "Un dessert traditionnel composé de morceaux de gelée d'agar-agar, de haricots rouges sucrés (anko), de fruits variés et de sirop de sucre noir (kuromitsu), offrant une combinaison de textures et de saveurs harmonieuse.",
                    SignatureDish = false,
                    ImagePath = "not defined",
                    Category =5
                },

            };

            foreach (Dish dish in dishes)
            {
                context.Dishes.Add(dish);
            }

            var menus = new Menu[]
           {
                 new Menu
                {
                    NameFr = "Menu Omakase",
                    NameJap = "メニューお任せ",
                    Price = 230
                },
                 new Menu
                {
                    NameFr = "Menu Yūgen",
                    NameJap = "メニュー幽玄",
                    Price = 250
                },
                   new Menu
                {
                    NameFr = "Menu Shibui",
                    NameJap = "メニュー渋い",
                    Price = 185
                },
                 };

            foreach (Menu menu in menus)
            {
                context.Menus.Add(menu);
            }


            context.SaveChanges();
        }
    }
}