using System;

namespace AlgoritmaveVeriYapilari.Giris
{
    class Giris
    {
        static void Main(string[] args)
        {
            //byte num1 = 8; //işaretsiz byte, yalnızca pozitif değerler
            //sbyte num2 = -8; //işaretli byte

            //byte 8 bit yer tutar: _ _ _ _ _ _ _ _ 
            // soldaki bit 1 ise negatif 0 ise pozitif sayı tutar
            //0 1 1 1 1 1 1 = 127
            //1 0 0 0 0 0 0 = - 128

            //Console.WriteLine("Byte min: {0} max : {1}", byte.MinValue, byte.MaxValue);
            //Console.WriteLine("SByte min: {0} max : {1}", sbyte.MinValue, sbyte.MaxValue);
            //Console.ReadKey();

            //var numbers = new String[] {
            //"00000000", //0
            //"00000001", //1
            //"00000010", //2
            //"00000011", //3
            //"00001011", //11
            //"10000000", //128 | -128
            //"10000001", //129 | -128+1 = -127
            //"10001111"  //143 | -128+15 = -113
            //};

            //foreach (var item in numbers) 
            //{ 
            //    sbyte number = Convert.ToSByte(item,2);
            //    Console.WriteLine(number);
            //}

            Console.WriteLine("{0} - {1}", ushort.MinValue, ushort.MaxValue); //UNSİGNED ise negatif olmaz
            Console.WriteLine("{0} - {1}", int.MinValue, int.MaxValue);

        }
    }
}