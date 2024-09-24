using System;
using System.Threading.Channels;

namespace GameCourse_for_3._1
{
    public class Program
    {
        //public static bool CemBolmek(int[] reqemler)
        //{
        //    int cem = 0;
        //    for (int i = 0; i < reqemler.Length; i++)
        //    {
        //        cem += reqemler[i];
        //    }
        //    return cem % 2 == 0; 
        //}

        //public static void Main(string[] args)
        //{
        //    int[] reqems = { 1, 2, 3, 4, 5 };
        //    bool sonuc = CemBolmek(reqems); 

        //    if (sonuc)
        //    {
        //        Console.WriteLine("cem 2'ye bölünür.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("cem 2'ye bölünmür.");
        //    }
        //}



















        //public static bool IsPrime(int number)
        //{
        //    if(number <= 1)
        //    {
        //        return false;
        //    }
        //    if (number == 2)
        //    {
        //        return true;
        //    }
        //    if (number % 2 == 0)
        //    {
        //        return false;
        //    }


        //    for (int i = 3; i <= Math.Sqrt(number); i+= 2)
        //    {
        //        if (number % i == 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;

        //}
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("eded yazin: ");
        //    int input = Convert.ToInt32(Console.ReadLine());
        //    bool result = IsPrime(input);

        //    if (result)
        //    {
        //        Console.WriteLine(input + " Eded sade deyil.");
        //    }
        //    else
        //    {
        //        Console.WriteLine(input + " Eded Sadedir. ");
        //    }
        //}








        //public static double CalcAvg(int[] imtahan)
        //{
        //    int cem = 0;
        //    for (int i = 0; i < imtahan.Length; i++)
        //    {
        //        cem += imtahan[i];
        //    }

        //    double ortalama = (double)cem / imtahan.Length;
        //    return ortalama;
        //}

        //public static void Main(string[] args)
        //{
        //    int[] imtahan = { 70, 80, 55, 60, 42 };

        //    double ortalama = CalcAvg(imtahan);

        //    if(ortalama > 60)
        //    {
        //        Console.WriteLine("Mezun oldunuz");
        //    }
        //    else
        //    {
        //        Console.WriteLine(" gelen ile qaldi");
        //    }

        //}




      public static void Main(string[] args)
        {
            int[] years = { 25, 32, 67, 99, 39 };

            Console.Write("Yash daxil et: ");
            int adaminyasi = Convert.ToInt32(Console.ReadLine());

            bool adaminyaslar = false;
            for (int i = 0; i < years.Length; i++)
            {
                if (years[i] == adaminyasi)
                {
                    adaminyaslar = true;
                    break;
                }
            }

            if (adaminyaslar)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }




        }
        
        










    }
}