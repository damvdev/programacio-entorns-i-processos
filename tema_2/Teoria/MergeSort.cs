using System;
namespace MergeSort {
    public class Program
    {
        public static void Fusio(int[] v, int left, int m, int right)
        {
            int n = right - left + 1;
            int[] aux = new int[n];
            int k = 0;
            int i = left;
            int j = m + 1;
            while (i <= m && j <= right)
            {
                if (v[i] < v[j]) { aux[k] = v[i]; ++i; }
                else { aux[k] = v[j]; ++j; }
                ++k;
            }
            while (i <= m) { aux[k] = v[i]; ++i; ++k; }
            while (j <= right) { aux[k] = v[j]; ++j; ++k; }
            for (k = 0; k < n; ++k) v[left + k] = aux[k];
        }

        public static void OrdenacioFusio(int[] v, int left, int right)
        {
            if (left < right)
            {
                int m = (left + right) / 2;
                OrdenacioFusio(v, left, m);
                OrdenacioFusio(v, m + 1, right);
                Fusio(v, left, m, right);
            }
        }

        public static void Main()
        {
            int[] array = { 10, 4, 6, 4, 8, -13, 2, 3 };
            OrdenacioFusio(array, 0, array.Length - 1);
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
