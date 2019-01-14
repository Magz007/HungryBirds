using HungryBirds.Models;
using System;
using System.Linq;

namespace HungryBirds.Models
{
    public static class DbInitializer
    {
        public static void Initialize(PupilContext context)
        {
            //context.Database.EnsureCreated();

            // Look for any students.
            if (context.Student.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
            new Student{FirstMidName="Carson",LastName="Alexander",DateOfBirth= "May", School= "Bucks", YearGroup= "Three", Class = "Miss Smith", Allergies="Gluten"},
            new Student{FirstMidName="Carson",LastName="Alexander",DateOfBirth= "May", School= "Bucks", YearGroup= "Three", Class = "Miss Smith", Allergies="Gluten"},

            };
            foreach (Student s in students)
            {
                context.Student.Add(s);
            }
            context.SaveChanges();
        }
    }
}
