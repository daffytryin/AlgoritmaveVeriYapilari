using System;

namespace Giris
{
    class Giris
    {
        static void Main(string[] args)
        {
            byte num1 = 8; //işaretsiz byte, yalnızca pozitif değerler
            sbyte num2 = -8; //işaretli byte

            //byte 8 bit yer tutar: _ _ _ _ _ _ _ _ 
            // soldaki bit 1 ise negatif 0 ise pozitif sayı tutar

            Console.WriteLine("Byte min: {0} {1}", byte.MinValue, byte.MaxValue);

            Console.ReadKey();
        }
    }
}