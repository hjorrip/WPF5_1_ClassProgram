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


            context.Classes.AddOrUpdate(
                n => new { n.Name, n.TypeOfClass },
                new Class()
                {
                    Name = "WPF",
                    TypeOfClass = "Forritun"
                },
                new Class()
                {
                    Name = "C#",
                    TypeOfClass = "Forritun"
                },
                new Class()
                {
                    Name = "Cisco",
                    TypeOfClass = "Kerfisstjórn"
                }
                );

            context.SaveChanges();

            context.Students.AddOrUpdate(
                s => new {s.FirstName, s.LastName},
                new Student()
                {
                    FirstName = "Hjörtur",
                    LastName = "Pálsson",
                    DateOfBirth = new DateTime(1987,08,22),
                    ClassId = context.Classes.Where(c => c.Name.Equals("WPF")).FirstOrDefault().Id
                },
                new Student()
                {
                    FirstName = "Bjarnfreður",
                    LastName = "Batman",
                    DateOfBirth = new DateTime(1990,05,18),
                    ClassId = context.Classes.Where(c => c.Name.Equals("C#")).FirstOrDefault().Id
                }
                );

            context.SaveChanges();

        }
    }
}
