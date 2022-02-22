using Day9.Model;
using Day9.DTO;
namespace Day9.Service
{
    public interface IServicePerson
    {
        void AddPerson(DTOPerson person);
        void UpdatePerson(Person person);
        void DeletePerSon(int id);
        List<Person> FilterPerson(FilterPerson person);
    }
}