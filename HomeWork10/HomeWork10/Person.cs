using System.Collections.Generic;

namespace HomeWork10
{
    public class Person
    {
        public string FirstAndLastName { get; set; }
        public List<Person> persons = new List<Person>();
    }
}