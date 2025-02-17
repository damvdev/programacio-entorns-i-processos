using System;
using System.Formats.Asn1;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;


namespace csvparser
{
    public class Program
    {
        public static void Main()
        {
            ReadCsv();
            WriteCsv();
            AppendCsv();
            ReadCsv();
        }
        private static void ReadCsv()
        {
            using var reader = new StreamReader("file.csv");
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<Person>();
            foreach (var record in records)
            {
                Console.Write($"{record.Id}: {record.Name}, la seva data de naixement és:  {record.DateOfBirth}. ");
                Console.WriteLine((record.IsLiving == true) ? "És viu" : "És mort");
            }
        }
        private static void WriteCsv()
        {
            const bool isLiving = true;
            using var writer = new StreamWriter("file.csv");
            using var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);

            var records = new List<Person> {
                new Person { Id = 1, Name = "Primer empleat", IsLiving = isLiving, DateOfBirth = new DateTime(1990, 1, 1) },
                new Person { Id = 2, Name = "Segon empleat", IsLiving = isLiving, DateOfBirth = new DateTime(1991, 1, 1) }
            };

            csvWriter.WriteRecords(records);
        }
        private static void AppendCsv()
        {
            const bool isLiving = true;
            //en afegir registres, no cal afegir la capçalera
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
            };
            using var stream = File.Open("file.csv", FileMode.Append);
            using var writer = new StreamWriter(stream);
            using var csvWriter = new CsvWriter(writer, config);
            var records = new List<Person>
            {
                new Person { Id = 3, Name = "Tercer empleat", IsLiving = isLiving, DateOfBirth = new DateTime(1991, 1, 1) }
            };
            csvWriter.WriteRecords(records);
        }
    }
}
