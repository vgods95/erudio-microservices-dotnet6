using RestWithASPNET.Model;

namespace RestWithASPNET.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                people.Add(new Person()
                {
                    Id = 1,
                    FirstName = "Vinícius",
                    LastName = "Godoy",
                    Address = "Jaú/SP - Brasil",
                    Gender = "Male"
                });
            }
            return people;
        }

        public Person FindById(long id)
        {
            return new Person()
            {
                Id = 1,
                FirstName = "Vinícius",
                LastName = "Godoy",
                Address = "Jaú/SP - Brasil",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
