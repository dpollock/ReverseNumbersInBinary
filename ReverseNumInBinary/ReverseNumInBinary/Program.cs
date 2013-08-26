using System;
using System.Diagnostics;

namespace ReverseNumInBinary
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var watch = new Stopwatch();
            watch.Start();
            for (long i = 1; i <= 1000000000; i++)
            {
                ulong result = ReverseInBinary(i);

                if (i % 1000000 == 0) //every million spit out a number
                    Console.WriteLine("{0} -> {1}", i, result);

            }

            watch.Stop();
            long time = watch.ElapsedMilliseconds;
            Console.WriteLine("Elapsed Time(ms): {0}", time);
            Console.ReadLine();
        }

        public static ulong ReverseInBinary(long num)
        {
            string binaryString = Convert.ToString(num, 2);
            string reversedBinaryString = ReverseString(binaryString);
            ulong result = Convert.ToUInt64(reversedBinaryString, 2);
            return result;
        }

        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}