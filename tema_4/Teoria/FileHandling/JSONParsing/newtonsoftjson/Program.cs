using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Formatting = Newtonsoft.Json.Formatting;

namespace jsonparser
{
    public class Program
    {
        public static void Main()
        {
            SerializedJson();
            DeserializedJson();
            AppendJson();
            DeserializedJson();
        }

        private static void AppendJson()
        {
            var newPeople = new List<Person>
            {
                new Person { Name = "Alice", Age = 25, IsMarried = false },
                new Person { Name = "Bob", Age = 35, IsMarried = true }
            };

            string jsonFromFile = File.ReadAllText("people.json");

            JArray existingArray;
            if (string.IsNullOrEmpty(jsonFromFile))
            {
                existingArray = new JArray();
            }
            else
            {
                existingArray = JArray.Parse(jsonFromFile);
            }

            var newPeopleObjects = newPeople.Select(p => JObject.FromObject(p)).ToList();

            foreach (var person in newPeopleObjects)
            {
                existingArray.Add(person);
            }

            string updatedJson = existingArray.ToString(Formatting.Indented);
            File.WriteAllText("people.json", updatedJson);
        }

        private static void DeserializedJson()
        {
            List<Person> loadedPeople = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText("people.json"));
            Console.WriteLine("Deserialized data:");
            foreach (var person in loadedPeople)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, IsMarried: {person.IsMarried}");
            }
        }

        private static void SerializedJson()
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "John", Age = 30, IsMarried = true },
                new Person { Name = "Jane", Age = 25, IsMarried = false }
            };

            string json = JsonConvert.SerializeObject(people, Formatting.Indented);
            File.WriteAllText("people.json", json);
        }
    }
}
