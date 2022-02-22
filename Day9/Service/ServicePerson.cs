using Day9.DTO;
using Day9.Model;
using Day9.Data;
namespace Day9.Service
{
    public class ServicePerson : IServicePerson
    {
        private PersonContext _dbContext;
        public ServicePerson(PersonContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddPerson(DTOPerson person)
        {
            _dbContext.person.Add(
                new Person
                {
                    FirstName = person.FirstName,
                    LastName = person.LastName,
                    Gender = person.Gender,
                    DateOfBirth = person.DateOfBirth,
                    BirthPlace = person.BirthPlace
                });

            _dbContext.SaveChanges();
        }
        public void UpdatePerson(Person person)
        {
            var item = _dbContext.person.FirstOrDefault(m => m.Id == person.Id);
            if (item != null)
            {
                item.FirstName = person.FirstName;
                item.LastName = person.LastName;
                item.DateOfBirth = person.DateOfBirth;
                item.Gender = person.Gender;
                item.BirthPlace = person.BirthPlace;
                _dbContext.SaveChanges();
            }
        }
        public void DeletePerSon(int id)
        {
            var item = _dbContext.person.FirstOrDefault(m => m.Id == id);
            if (item != null)
            {
                _dbContext.person.Remove(item);
                _dbContext.SaveChanges();
            }
        }
        public List<Person> FilterPerson(FilterPerson persons)
        {
            return _dbContext.person.Where(m => (!string.IsNullOrEmpty(persons.FirstName)) && m.FirstName.ToLower() == persons.FirstName.ToLower()
            || (!string.IsNullOrEmpty(persons.LastName) && m.LastName.ToLower() == persons.LastName.ToLower()
            || m.Gender == persons.Gender
            || m.BirthPlace == persons.BirthPlace)).ToList();
        }
    }
}