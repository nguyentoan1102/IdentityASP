namespace ExampleAjax.Migrations
{
    using ExampleAjax.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ExampleAjax.Models.StudentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ExampleAjax.Models.StudentContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            CreateStudients(context);
        }

        private void CreateStudients(StudentContext context)
        {
            if (context.Students.Count() == 0)
            {
                List<Student> listProductCategory = new List<Student>()
                {
                    new Student() { StudentName="Toan",StudentAddress="Hanoi" },
                    new Student() { StudentName="Tu",StudentAddress="Bac Ninh" },
                    new Student() { StudentName="Kiet",StudentAddress="Hai Duong" },
                    new Student() { StudentName="Hieu",StudentAddress="Bac Ninh" }
                };
                context.Students.AddRange(listProductCategory);
                context.SaveChanges();
            }
        }
    }
}