using System;

namespace AdvancedLinqAssignment
{
    /// <summary>
    /// Represents a person with an ID, name, and birthday.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Unique identifier for the person.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the person.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Birthday of the person.
        /// </summary>
        public DateTime Birthday { get; set; }
    }
}