 using System;

namespace ValueAndRefTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 30;
            int number2 = 85;
            number1 = number2;
            number2 = 100;
            Console.WriteLine("Sayi1:   "+number1);


            int[] series1 = new int[] {10,20,30 };
            int[] series2 = new int[] { 100, 200, 300 };
            series1 = series2;
            series2[0] = 999;

            Console.WriteLine("Dizi1'in ilk elemanı:    "+series1[0]);
        }
    }
}
