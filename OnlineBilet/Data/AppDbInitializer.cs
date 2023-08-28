using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using OnlineBilet.Data.Enums;
using OnlineBilet.Data.Static;
using OnlineBilet.Models;

namespace OnlineBilet.Data
{
    //Dependency Injection
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)


        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //burasi veri gönderip almak için
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated(); //var olduğundan emin olmak eklemeden önce (oluştu mu?)

                //bu kısımda da verileri ekleyeceğiz
                //lAZİM OLANLAR

                
                //Actor
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-3.jpeg",
                            FullName = "Angelina Jolie",
                            Bio = "Amerikalı oyuncu, film yapımcısı ve hayırsever. Üç Altın Küre, iki Sinema Oyuncuları Derneği Ödülü ve bir de Oscar sahibidir. Hayırsever çalışmalarıyla da tanınan Jolie, pek çok kez dünyanın en çekici insanları listelerinde yer aldı."
                        },
                        new Actor()
                        {
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-5.jpeg",
                            FullName = "Will Smith",
                            Bio = "Amerikalı sinema oyuncusu, yapımcı ve rap müzisyeni. Biri kız, ikisi erkek olmak üzere üç çocuğu vardır. Will'in son sekiz filmi gişelerden 100 milyon dolar ve üstü gelir getirmiştir."
                        },
                        new Actor()
                        {
                            ProfilePictureUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4c/Brad_Pitt_2019_by_Glenn_Francis.jpg/330px-Brad_Pitt_2019_by_Glenn_Francis.jpg",
                            FullName = "Brad Pitt",
                            Bio = "William Bradley Pitt, Amerikalı oyuncu ve film yapımcısıdır. Yapım şirketi Plan B Entertainment ile yapımcı olarak bir Akademi Ödülü ve Primetime Emmy Ödülü'nün yanı sıra oyunculuğuyla iki Altın Küre Ödülü ve bir Akademi Ödülü de dâhil olmak üzere birçok ödül almaya hak kazanmıştır."
                        },
                         new Actor()
                        {
                            ProfilePictureUrl = "https://img04.imgsinemalar.com/images/afis_buyuk/j/joaquin-phoenix-1649150798.jpg",
                            FullName = "Joaquin Phoenix",
                            Bio = "Joaquin Rafael Phoenix, Leaf Phoenix olarak da bilinir, Amerikalı oyuncu, müzik videosu yönetmeni, prodüktör, müzisyen ve aktivist. Ridley Scott'ın yönettiği Gladyatör filmindeki Commodus rolüyle dikkatleri üzerine çekmiştir. Bu rolle en iyi yardımcı erkek oyuncu dalında Oscar ödülüne aday olmuştur. "
                        },
                         new Actor(){
                         ProfilePictureUrl = "https://i.guim.co.uk/img/media/b092555894f591f51929cf6a6ee5ab46b6232f0a/438_300_1449_869/master/1449.jpg?width=1200&height=1200&quality=85&auto=format&fit=crop&s=383db0f4b82a88631c7bff372a055272",
                            FullName = "Parker Posey",
                            Bio = "Parker Posey (d. 8 Kasım 1968, Baltimore, Maryland, ABD), Amerikalı oyuncu ve şarkıcı."
                        },
                         new Actor()
                        {
                            ProfilePictureUrl = "https://vogue.com.tr/static//original/18-05/03/angelina-jolie-495918880.jpg",
                            FullName = "Angelina Jolie",
                            Bio = "Amerikalı oyuncu, film yapımcısı ve hayırsever. Üç Altın Küre, iki Sinema Oyuncuları Derneği Ödülü ve bir de Oscar sahibidir. Hayırsever çalışmalarıyla da tanınan Jolie, pek çok kez dünyanın en çekici insanları listelerinde yer aldı."
                        }
                    });
                    context.SaveChanges();
                }
                //Director
                if (!context.Directors.Any())
                {
                    context.Directors.AddRange(new List<Director>()
                    {
                        new Director()
                        {
                            ProfilePictureUrl = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcRVUb5xFSylNWNiif3-yJ1RmBQBD61YlqxMJUryQ3M199N84H3H",
                             FullName = "Robert Stromberg",
                            Bio = "Robert Stromberg, Amerikalı özel efekt sanatçısı, tasarımcı ve film yapımcısıdır . Stromberg'in kredileri arasında James Cameron'ın Avatar'ı , Tim Burton'ın Alice Harikalar Diyarında ve Sam Raimi'nin Muhteşem ve Kudretli Oz gibi filmleri yer alıyor ."

                        },
                        new Director()
                        {
                            ProfilePictureUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1c/Martin_Scorsese_Berlinale_2010_%28cropped2%29.jpg/330px-Martin_Scorsese_Berlinale_2010_%28cropped2%29.jpg",
                             FullName = "Martin Scorsese",
                            Bio = "Martin Charles Scorsese 17 Kasım 1942 doğumlu) Amerikalı ve İtalyan film yönetmeni, yapımcı , senarist ve oyuncu. Scorsese, Yeni Hollywood döneminin en önemli figürlerinden biri olarak ortaya çıktı ."

                        },
                        new Director()
                        {
                            ProfilePictureUrl = "https://images.mubicdn.net/images/cast_member/419689/cache-605844-1606165098/image-w856.jpg",
                             FullName = "Ari Aster",
                            Bio = "Ari Aster Amerikalı bir film yönetmeni ve senarist. En çok A24 için üç korku filmini yazıp yönetmesiyle tanınır: Ayin (2018), Ritüel (2019) ve Disappointment Blvd. (2022)."

                        }

                    });
                    context.SaveChanges();

                }
                //Movie
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            MovieName = "Korkuyorum",
                            Description = "Korkuyorum, otoriter annesi Mona ile çalkantılı bir ilişkisi olan ve babasını hiç tanımayan son derece gergin ve paranoyak bir adam olan Beau Wassermann'ın hikayesini konu ediyor. Kaygı bozukluğundan ve korku ataklarından muzdarip olan Beau, annesinin ölümü üzerine cenazesine katılmak için eski evine gitmek zorunda kalır. Ancak yolculuk sırasında onu bekleyen kötü güçlerle yüzleşmek zorunda kalır. Beau için bu yolculuk, iç dünyanın gizemini ve annesiyle olan ilişkisini çözmeye çalıştığı bir keşif yolculuğuna dönüşür.",
                            Price =  100,
                            ImageUrl = "https://sinemasayfam.com/wp-content/uploads/2023/01/beau-is-afraid-692x1024.png",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2) ,
                            IMDB = 4.5,
                            //HallNumber = 1,
                            DirectorId = 3,
                            MovieCategory = MovieCategory.Comedy,



                        },
                        new Movie()
                        {
                            MovieName = "Ghost",
                            Description = "Molly ve Sam, aşk yaşayan, New Yorklu bir çifttir. Sam cüzdanını taşıyan bir serseri tarafından bıçaklanarak öldürülür. Ruhu bedeni terkettiğinde ölümden sonraki yaşamı yavaş yavaş keşfetme fırsatı bulur. Ölülerin ruhlarının canlılarla aynı ortamda varolduğu ama yaşayanların ruhları göremediği bir ortamdır bu.",
                            Price = 39.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            //HallNumber = 4,
                            DirectorId = 3,
                            MovieCategory = MovieCategory.Horror
                        }
                    });
                    context.SaveChanges();
                   
                }
                //actor_movie
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    { 
                        new  Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 1
                        },
                        new  Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 1
                        }
                    });
                    context.SaveChanges();
                    
                }
            }
        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@onlinebilet.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Dnz@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

                string appUserEmail = "user@onlinebilet.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Dnz@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }

            }
        }
    }
}


// Her service kapsamı için yeni bir örnek oluşturulur. Bu servisler, servis kapsamı içinde singleton (tekton) gibi davranırlar. Eğer servis temizlenebilir ise, servis kapsamı sona erip ortadan kaldırıldığında otomatik olarak temizlenir.

//Genellikle her istemcinin talebi için oluşturulan geçici bir hizmet kapsamıdır. Bu kapsam, bir istemcinin talebini işlerken kullanılacak bağımlılıkların oluşturulmasını ve sonlandırılmasını yönetir. Böylece, her istemcinin kendi hizmet kapsamı olduğundan, bir istemcinin diğer istemcilerle etkileşimleri veya verileri paylaşması engellenir.