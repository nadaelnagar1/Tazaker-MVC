﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;
using Tazaker.Data.Enums;
using Tazaker.Models;

namespace Tazaker.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
            

                //Adding cinemas
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Id=new Guid("11223344-5566-7788-99AA-BBCCDDEEFF00"),
                            Name = "VOX Cinemas City Centre Alexandria",
                            Logo = "https://media0001.elcinema.com/uploads/_310x310_9ad5cdee298cc9765c7d87bfa86556533633d9b3fe8f61b1cb43a3f1129ce0dd.jpg",
                            Description = "The biggest blockbusters in Egypt are just one click away. Discover the perfect movie for you, find session times and book tickets at VOX Cinemas."
                        },
                        new Cinema()
                        {
                            Id=new Guid("22223344-5566-7788-99AA-BBCCDDEEFF00"),
                            Name = "Cine Plex",
                            Logo = "https://scontent.fcai19-8.fna.fbcdn.net/v/t1.6435-9/99131992_10151481767414990_897803148758876160_n.jpg?_nc_cat=107&ccb=1-7&_nc_sid=174925&_nc_ohc=Ve_d6VBf7BQAX_WzSwq&_nc_ht=scontent.fcai19-8.fna&oh=00_AfBtt3yCxzZ0_CHqq76xHabSFMh_6etsD9_lRsK0aZDYLA&oe=63A73A6D",
                            Description = "Movies · Event Cinema · Buy or Rent Movies at Home with Cineplex Store!"
                        },
                        new Cinema()
                        {
                             Id=new Guid("33223344-5566-7788-99AA-BBCCDDEEFF00"),
                            Name = "San Stefano Cinema ",
                            Logo = "https://media0001.elcinema.com/uploads/_310x310_6e1c5a3ee148ed0d65d8eb762daaa791e6f483f4a3ef1064828cccf358319ce6.jpg",
                            Description = "Bringing your favorite movies to the big screen and giving you an unforgettable cinema experience from Cairo to Alexandria!"
                        },
                        new Cinema()
                        {
                            Id = new Guid("44223344-5566-7788-99AA-BBCCDDEEFF00"),
                            Name = "Cinema Amir",
                            Logo = "http://photos.cinematreasures.org/production/photos/322968/1604581267/large.jpg?1604581267",
                            Description = "Sea cinema Amir Cinema. Foad St., Raml Station. Downtown · Alexandria · Egypt"
                        },
                       
                    }
                    );
                    context.SaveChanges();
                }
                //Adding Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                         new Actor()
                        {
                             Id=new Guid("41223344-5566-7788-99AA-BBCCDDEEFF00"),
                            FullName = "Dwayne Johnson",
                            Bio = "This is the Bio of the actor",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BMTkyNDQ3NzAxM15BMl5BanBnXkFtZTgwODIwMTQ0NTE@._V1_UY1200_CR84,0,630,1200_AL_.jpg"

                        },
                        new Actor()
                        {
                            Id=new Guid("41223344-5566-7788-99BB-BBCCDDEEFF00"),
                            FullName = "Sarah Shahi",
                            Bio = "This is the Bio of the actor",
                            ProfilePictureURL = "https://www3.pictures.stylebistro.com/gi/Hollywood+Foreign+Press+Association+InStyle+ACjbh2y9ETtx.jpg"
                        },
                        new Actor()
                        {
                            Id=new Guid("41223344-5566-7788-99CC-BBCCDDEEFF00"),
                            FullName = "Noah Centineo",
                            Bio = "This is the Bio of the actor",
                            ProfilePictureURL = "https://flxt.tmsimg.com/assets/552683_v9_bc.jpg"
                        },
                        new Actor()
                        {
                            Id=new Guid("41223344-5566-7788-99DD-BBCCDDEEFF00"),
                            FullName = "Auli'i Cravalho",
                            Bio = "This is the Bio of the actor",
                            ProfilePictureURL = "https://www.indiewire.com/wp-content/uploads/2022/04/0049356352.original-e1650488783221.jpg"
                        },
                        new Actor()
                        {
                             Id=new Guid("41223344-5566-7788-99EE-BBCCDDEEFF00"),
                            FullName = "Chadwick Aaron Boseman",
                            Bio = "This is the Bio of the actor",
                            ProfilePictureURL = "https://hollywoodlife.com/wp-content/uploads/2018/03/chadwick-boseman-8.jpg?w=683"
                        },
                         new Actor()
                        {
                             Id=new Guid("41223344-5566-7788-99FF-BBCCDDEEFF00"),
                            FullName = "Michael B. Jordan",
                            Bio = "This is the Bio of the actor",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cd/2018-05-12-_Cannes-L%27acteur_Michael_B._Jordan-2721_%2842075892224%29.jpg/1200px-2018-05-12-_Cannes-L%27acteur_Michael_B._Jordan-2721_%2842075892224%29.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Adding Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            Id=new Guid("11223344-5566-7788-99AA-BBCCDDEEFF11"),
                            FullName = "Kevin Feige",
                            Bio = "This is the Bio of the first producer",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRWlCOvtGUEfpVUvEcss1EwGTijABjwR6tHCsX8M3qz&s"

                        },
                        new Producer()
                        {
                          Id=new Guid("11223344-5566-7788-99AA-BBCCDDEEFF22"),
                            FullName = "Nate Moore",
                            Bio = "This is the Bio of the second producer",
                            ProfilePictureURL = "https://static.wikia.nocookie.net/marvelcinematicuniverse/images/9/9a/Nate_Moore.jpg/revision/latest/top-crop/width/360/height/360?cb=20221027164004"
                        },
                        new Producer()
                        {
                            Id=new Guid("11223344-5566-7788-99AA-BBCCDDEEFF33"),
                            FullName = "Osnat Shurer",
                            Bio = "This is the Bio of the second producer",
                            ProfilePictureURL = "https://www.tribute.ca/news/wp-content/uploads/2017/03/osnat-shurer.jpg"
                        },
                        new Producer()
                        {
                            Id=new Guid("11223344-5566-7788-99AA-BBCCDDEEFF44"),
                            FullName = "Hiram Garcia",
                            Bio = "This is the Bio of the second producer",
                            ProfilePictureURL = "https://deadline.com/wp-content/uploads/2017/06/hiram-garcia-frank-masi-jpg.jpeg"
                        },
                        new Producer()
                        {
                            Id=new Guid("11223344-5566-7788-99AA-BBCCDDEEFF55"),
                            FullName = "Dwayne Johnson",
                            Bio = "This is the Bio of the second producer",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BMTkyNDQ3NzAxM15BMl5BanBnXkFtZTgwODIwMTQ0NTE@._V1_UY1200_CR84,0,630,1200_AL_.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Adding movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Id=new Guid("11223344-0066-7788-99AA-BBCCDDEEFF00"),
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId =new Guid("11223344-5566-7788-99AA-BBCCDDEEFF00"),
                            ProducerId = new Guid("11223344-5566-7788-99AA-BBCCDDEEFF11"),
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                             Id=new Guid("11223344-1166-7788-99AA-BBCCDDEEFF00"),
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = new Guid("22223344-5566-7788-99AA-BBCCDDEEFF00"),
                            ProducerId = new Guid("11223344-5566-7788-99AA-BBCCDDEEFF22"),
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Id=new Guid("11223344-2266-7788-99AA-BBCCDDEEFF00"),
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = new Guid("33223344-5566-7788-99AA-BBCCDDEEFF00"),
                            ProducerId = new Guid("11223344-5566-7788-99AA-BBCCDDEEFF33"),
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Id=new Guid("11223344-3366-7788-99AA-BBCCDDEEFF00"),
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId =new Guid("33223344-5566-7788-99AA-BBCCDDEEFF00"),
                            ProducerId =new Guid("11223344-5566-7788-99AA-BBCCDDEEFF44"),
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Id=new Guid("11223344-4466-7788-99AA-BBCCDDEEFF00"),
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = new Guid("44223344-5566-7788-99AA-BBCCDDEEFF00"),
                            ProducerId = new Guid("11223344-5566-7788-99AA-BBCCDDEEFF44"),
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Id=new Guid("11223344-5566-7788-99AA-BBCCDDEEFF00"),
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = new Guid("44223344-5566-7788-99AA-BBCCDDEEFF00"),
                            ProducerId = new Guid("11223344-5566-7788-99AA-BBCCDDEEFF33"),
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
               
            }
        }
    }
}
