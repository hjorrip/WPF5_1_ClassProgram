namespace WPF5_1_ClassProgram.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WPF5_1_ClassProgram.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WPF5_1_ClassProgram.Models.ClassDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WPF5_1_ClassProgram.Models.ClassDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.TypeOfClasses.AddOrUpdate(
                n => n.Name,
                new TypeOfClass()
                {
                    Name = "Forritun"
                },
                new TypeOfClass()
                {
                    Name = "Kerfisstjórn"
                },
                new TypeOfClass()
                {
                    Name = "Graffísk hönnun"
                }
                );

        }
    }
}
