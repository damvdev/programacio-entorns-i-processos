using System;

public class Program
{
    // Constants
    private const float LowerBound = 4.0f;
    private const float UpperBound = 9.0f;

    public static void Main()
    {
        const string MsgAverage = "Nota mitjana del grup: {0:F2}";
        const string MsgCountInRange = "Nombre d'alumnes amb notes entre {0} i {1}: {2}";
        float[] marks = { 5.5f, 10f, 3.5f, 1.25f, 1.75f, 6.2f, 5.15f, 6.75f, 4.15f, 9.25f, 8.75f, 2.75f, 0.0f, 1.35f, 6.55f };

        float average = CalculateAverage(marks);
        DisplayMarks(marks);
        Console.WriteLine(MsgAverage, average);

        int countInRange = CountMarksInRange(marks, LowerBound, UpperBound);
        DisplayMarks(marks);
        Console.WriteLine(MsgAverage, average);
        Console.WriteLine(MsgCountInRange, LowerBound, UpperBound, countInRange);
    }

    /// <summary>
    /// Calculates the average of the marks.
    /// </summary>
    /// <param name="marks">Array of marks.</param>
    /// <returns>Average value.</returns>
    private static float CalculateAverage(float[] marks)
    {
        return marks.Average();
    }

    /// <summary>
    /// Displays all marks in the array.
    /// </summary>
    /// <param name="marks">Array of marks.</param>
    private static void DisplayMarks(float[] marks)
    {
        const string MsgMark = "Nota {0}: {1:F2}";
        for (int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine(MsgMark, i + 1, marks[i]);
        }
    }

    /// <summary>
    /// Counts the number of marks within a specified range (inclusive).
    /// </summary>
    /// <param name="marks">Array of marks.</param>
    /// <param name="lowerBound">Lower bound of the range.</param>
    /// <param name="upperBound">Upper bound of the range.</param>
    /// <returns>Count of marks within range.</returns>
    private static int CountMarksInRange(float[] marks, float lowerBound, float upperBound)
    {
        return marks.Count(mark => mark >= lowerBound && mark <= upperBound);
    }
}
