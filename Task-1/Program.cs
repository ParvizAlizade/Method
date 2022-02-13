using System;

namespace ConsoleApp1
{
    class Program
    {  //CalcAvg metodu -Gondeirlmis imtahanlar qiymeti siyahisina(integer array)
       //    esasen hemin qiymetlerin ortalamasini qaytaran metod yazin.
       //    Main metodunda bu metodu call edib, burdan qayidan deyere esasen ortalama 
       //    60 - dan boyukdursa console-da "mezun oldunuz" eks halda "mezun ola bilmediniz" yazisi yazdirin
    }
    static void Main(string[] args)
    {
        int[] imtahanbali = { 40, 60, 83 };
    
    }
    static int Imtahancemi (int[] a)
    {
        int cem = 0;
        for (int i = 0; i < a.Length; i++)
        {
            cem += a[i];
        }
        return cem;
    }

}
