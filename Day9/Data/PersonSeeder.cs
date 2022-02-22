using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day9.Model;
namespace Day9.Data
{
    public class PersonSeeder
    {
        private readonly PersonContext _context;
        public PersonSeeder(PersonContext context)
        {
            _context = context;
        }

        public void SeedData()
        {
            _context.person.AddRange(new List<Person> {
            new Person { FirstName = "Tien", LastName="Pham",DateOfBirth=new DateTime(1998,03,26),Gender="male",BirthPlace="TB" },
            new Person {  FirstName = "Nam", LastName="Nguyen",DateOfBirth=new DateTime(2000,03,26),Gender="other",BirthPlace="HN" },
            new Person {  FirstName = "Huong", LastName="Tran",DateOfBirth=new DateTime(2002,03,26),Gender="female",BirthPlace="QN" }
        });
            _context.SaveChanges();
        }

    }
}