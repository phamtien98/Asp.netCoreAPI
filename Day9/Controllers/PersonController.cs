using Microsoft.AspNetCore.Mvc;
using Day9.Service;
using Day9.DTO;
using Day9.Model;
namespace Day9.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IServicePerson _servicePerson;
        public PersonController(IServicePerson servicePerson)
        {
            _servicePerson = servicePerson;
        }

        [HttpPost("/add-person")]
        public void AddPerson([FromBody] DTOPerson person)
        {
            _servicePerson.AddPerson(person);
        }

        [HttpPut("/edit-person")]
        public void EditPerson([FromBody] Person person)
        {
            _servicePerson.UpdatePerson(person);
        }

        [HttpDelete("/delete-person")]
        public void DeletePerson(int id)
        {
            _servicePerson.DeletePerSon(id);
        }

        [HttpPost("/filter-person")]
        public List<Person> FilterPerson([FromBody] FilterPerson filterPerson)
        {
            return _servicePerson.FilterPerson(filterPerson);
        }
    }
}