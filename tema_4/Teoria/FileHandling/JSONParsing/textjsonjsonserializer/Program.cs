using System;
using System.Text.Json;
using textjsonjsonserializer;

namespace jsonparser
{
    public class Program
    {
        public static void Main()
        {
            SerializeJson();
            DeserializeJson();
            AppendJson();
            DeserializeJson();
        }
        private static void SerializeJson()
        {
            var person = new List<Person>
        {
            new Person { Name = "John", Age = 30, IsMarried = true },
            new Person { Name = "Jane", Age = 25, IsMarried = false }
        };

            string jsonString = JsonSerializer.Serialize(person);
            File.WriteAllText("person.json", jsonString);
        }
        private static void DeserializeJson()
        {
            string jsonFromFile = File.ReadAllText("person.json");
            var deserializedPerson = JsonSerializer.Deserialize<List<Person>>(jsonFromFile);

            Console.WriteLine("Deserialized data:");
            foreach (var p in deserializedPerson)
            {
                Console.WriteLine($"Name: {p.Name}");
                Console.WriteLine($"Age: {p.Age}");
                Console.WriteLine($"IsMarried: {p.IsMarried}");
                Console.WriteLine();
            }
        }
        private static void AppendJson()
        {
            var newPeople = new List<Person>
        {
            new Person { Name = "Alice", Age = 25, IsMarried = false },
            new Person { Name = "Bob", Age = 35, IsMarried = true }
        };
            List<Person> existingPeople;
            string jsonFromFile = File.ReadAllText("person.json");
            if (!string.IsNullOrEmpty(jsonFromFile))
            {
                existingPeople = JsonSerializer.Deserialize<List<Person>>(jsonFromFile);
            }
            else
            {
                existingPeople = new List<Person>();
            }

            existingPeople.AddRange(newPeople);
            string jsonString = JsonSerializer.Serialize(existingPeople);
            File.WriteAllText("person.json", jsonString);
        }
    }
}
