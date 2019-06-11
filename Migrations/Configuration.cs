namespace AndrewsApi.Migrations
{
    using AndrewsApi.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AndrewsApi.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AndrewsApi.Models.ApplicationDbContext context)
        {

     //       context.Movies.AddOrUpdate(x=>x.id,

     //new Models.Movies() {id = 1, Title = "The Departed", Genre = "Drama", DirectorName = "Martin Scorsese" },
     //new Models.Movies() {id = 2, Title = "The Dark Knight", Genre = "Drama", DirectorName = "Christopher Nolan" },
     //new Models.Movies() {id = 3, Title = "Inception", Genre = "Drama", DirectorName = "Christopher Nolan" },
     //new Models.Movies() {id = 4, Title = "Pineapple Express", Genre = "Comedy", DirectorName = "David Gordon Green" },
     //new Models.Movies() {id = 5, Title = "Die Hard", Genre = "Action", DirectorName = "John McTiernan" }); ;
        
    //This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
