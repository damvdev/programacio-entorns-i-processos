using System;

namespace colleccions
{
    public class Person : IComparable<Person>
    {
        const string NAME = "John";
        const string SURNAME = "Doe";

        public string Name { get; set; }
        public string Surname { get; set; }
        public Person(string name, string surname)
        {

            Name = name;
            Surname = surname;
        }
        public Person() : this(NAME, SURNAME) { }
        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}";
        }

        public int CompareTo(Person? other)
        {
            return (other == null) ? 1 : Surname.CompareTo(other.Surname);
        }
    }
}
