using System;

namespace exemples
{
    public static class MyMath
    {
        private static Random Rnd = new Random();
        public static int NextInt(int bound) => Rnd.Next(bound + 1);

        public static double Abs(double value) => value < 0 ? -value : value;
    }
}
