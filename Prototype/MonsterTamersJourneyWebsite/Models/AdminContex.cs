
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace MonsterTamersJourneyWebsite.Models
{


        public class AdminContex:DbContext
        {

            public AdminContex(DbContextOptions<AdminContex> options) : base(options) { }

            public DbSet<Creator> Creator { get; set; } = null!;
            public DbSet<FAQ> FAQ { get; set; } = null!;
            public DbSet<Media> Media { get; set; } = null!;
            public DbSet<News> News { get; set; } = null!;
            public DbSet<Press> Press { get; set; } = null!;
            public DbSet<SupportRequest> SupportRequest { get; set; } = null!;


            protected override void OnModelCreating(ModelBuilder modelBuilder)
                {

                    modelBuilder.Entity<Creator>().HasData(

                        new Creator
                        {
                            CreatorId = 1,
                            Email = "cherryinatree@gmail.com",
                            CreatorName = "Joe",
                            PreferedName = "Joey",
                            ContentPlatforms = "YouTube, Facebook",
                            SocialAccounts = "Facebook",
                            AboutYou = "I do Cool Stuff!",
                            RequestKey = true,
                            OtherRequests = "Can I get merch bro?"

                        }

                        );

                modelBuilder.Entity<FAQ>().HasData(

                    new FAQ
                    {
                        FAQId = 1,
                        Order = 1,
                        Title = "Why won't my game [blank]?",
                        Content = "Have you tried [blank]?"
                    }

                    );
                modelBuilder.Entity<Media>().HasData(

                    new Media
                    {
                        MediaId = 1,
                        Order = 1,
                        Title = "Trailer",
                        isImage = false,
                        VideoUrl = "https://youtu.be/uv6HXgWBnfw?si=gilVtCnkw8a7cweT",
                        ImageUrl = "https://dl.dropboxusercontent.com/scl/fi/cnc0ycr7fm4fg4kpho5sd/InGame2.png?rlkey=ypkf1i0vruzv6zawgafgdam70&dl=0"
                    },
                    new Media
                    {
                        MediaId = 2,
                        Order = 2,
                        Title = "Trailer",
                        isImage = true,
                        VideoUrl = "https://youtu.be/uv6HXgWBnfw?si=gilVtCnkw8a7cweT",
                        ImageUrl = "https://dl.dropboxusercontent.com/scl/fi/cnc0ycr7fm4fg4kpho5sd/InGame2.png?rlkey=ypkf1i0vruzv6zawgafgdam70&dl=0"



                    }

                    );
                modelBuilder.Entity<News>().HasData(

                    new News
                    {
                        NewsId = 1,
                        Order = 1,
                        Title = "Website Released",
                        Content = "The Website is now live!",
                        ImageUrl = "https://dl.dropboxusercontent.com/scl/fi/cnc0ycr7fm4fg4kpho5sd/InGame2.png?rlkey=ypkf1i0vruzv6zawgafgdam70&dl=0"
                    }

                    );
                modelBuilder.Entity<Press>().HasData(

                    new Press
                    {
                        PressId = 1,
                        Email = "cherryinatree@gmail.com",
                        name = "Jurno",
                        OutletName = "Big Press",
                        MainChannel = "Twitter",
                        TwitterHandel = "JornoWorksForBigPress",
                        OutletCatagory = "Digital Media",
                        RequestKey = true,
                        OtherRequests = "I'd like an interview."
                    }

                    );
                modelBuilder.Entity<SupportRequest>().HasData(

                    new SupportRequest
                    {
                        SupportRequestId = 1,
                        SupportEmail = "cherryinatree@gmail.com",
                        Subject = "My game won't load level 3",
                        Question = "I've tried X, Y, and Z. What should I do?"
                    }

                    );
            }
        }

}
