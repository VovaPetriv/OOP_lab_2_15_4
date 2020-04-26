using System;

namespace OOP_lab_2_15_4
{
    public class Program
    {
        public static int IndexOfMin(int[] array)
        {
            int index = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[index] >= array[i])
                {
                    index = i;
                }
            }

            return index;
        }

        public static long Multiplication(int[] array)
        {
            long d = 1;

            bool zero = false;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] == 0)
                {
                    zero = true;
                    break;
                }

                d *= array[i];
            }

            if (zero)
            {
                return d;
            }
            else
            {
                return 0;
            }
        }

        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];

            for (int i = 0; i < a.Length; ++i)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < a.Length; ++i)
            {
                Console.WriteLine("a[{0}] = {1} ", i, a[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Hомер мiнiмального елемента масиву: {0}", IndexOfMin(a));
            Console.WriteLine("Добуток елементiв масиву,розташованих до першого нульового елемента: {0}", Multiplication(a));
        }
    }
}
