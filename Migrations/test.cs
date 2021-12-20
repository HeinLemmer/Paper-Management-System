namespace Section2_IPG521.Migrations
{
    using Section2_IPG521.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class test : DbMigrationsConfiguration<Section2_IPG521.Data.PapersDbContext>
    {
        public test()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Section2_IPG521.Data.PapersDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.

            context.Topics.AddOrUpdate(
                s => s.TopicName,
                new Topic { TopicName = "Data Science" },
                new Topic { TopicName = "Education" },
                new Topic { TopicName = "Human-Computer interaction" },
                new Topic { TopicName = "Internet of Things" });
        }
    }
}
