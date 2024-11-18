using System;

namespace ExerciseFive
{
    public class PersonaHelper
    {
        public int ClassifyAge(int age)
        {
            if (age < 18)
            {
                return 0; // Infància
            }
            else if (age >= 18 && age <= 65)
            {
                return 1; // Adulta
            }
            else if (age > 65)
            {
                return 2; // Senescència
            }
            return -1; // Desconeguda
        }

        public bool IsEven(int age)
        {
            return age % 2 == 0;
        }

        public (bool IsShort, bool IsPalindrome) NameAnalyser(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("No has introduït un nom vàlid.");
            }

            bool IsShort = name.Length < 5;
            string reversedName = new string(name.ToCharArray().Reverse().ToArray());
            bool IsPalindrome = name.Equals(reversedName, StringComparison.OrdinalIgnoreCase);

            return (IsShort, IsPalindrome);
        }

        public int VerifyColour(string colour)
        {
            if (string.IsNullOrEmpty(colour))
            {
                return -1; // No valid
            }

            string colourLower = colour.ToLower();
            if (colourLower == "blau" || colourLower == "verd")
            {
                return 0; // Calmant
            }
            return 1; // Exclusiu
        }

        public int PersonalityTest(string preference)
        {
            switch (preference.ToLower())
            {
                case "matí":
                    return 0; // Matinal
                case "nit":
                    return 1; // Nocturna
                default:
                    return 2; // Imprevista
            }
        }
    }
}
