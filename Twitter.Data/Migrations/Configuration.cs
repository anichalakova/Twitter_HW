using Twitter.Models;

namespace Twitter.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<Twitter.Data.TwitterDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Twitter.Data.TwitterDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Users.AddOrUpdate(
                u=>u.Username,
                new User { Username = "TestUser", Email = "testuser@test.com", Password = "123"}
                );

            context.SaveChanges();
        }
    }
}
