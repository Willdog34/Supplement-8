using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedLinqAssignment
{
    /// <summary>
    /// Repository for managing and querying a collection of Person objects.
    /// </summary>
    public class PersonRepository
    {
        private List<Person> data;

        /// <summary>
        /// Initializes the data field with 1,000,000 unique Person objects.
        /// </summary>
        public void InitializeData()
        {
            var random = new Random();
            data = new List<Person>();

            for (int i = 0; i < 1_000_000; i++)
            {
                data.Add(new Person
                {
                    Id = i + 1,
                    Name = $"Person_{random.Next(1, 10000)}",
                    Birthday = DateTime.Now.AddYears(-random.Next(18, 100))
                });
            }
        }

        /// <summary>
        /// Returns all people born after the specified date.
        /// </summary>
        public IEnumerable<Person> GetPeopleBornAfter(DateTime date)
        {
            return data.Where(p => p.Birthday > date);
        }

        /// <summary>
        /// Returns all people with the specified name.
        /// </summary>
        public IEnumerable<Person> GetPeopleByName(string name)
        {
            return data.Where(p => p.Name == name);
        }

        /// <summary>
        /// Returns the person with the specified ID, or null if not found.
        /// </summary>
        public Person GetPersonById(int id)
        {
            return data.FirstOrDefault(p => p.Id == id);
        }
    }
}