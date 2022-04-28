using System;
namespace DatetimeveMath
{    class Program
    {        static void Main(string[] args)
        {   Console.WriteLine("Hangi Yıl doğdunuz? (yyyy şeklinde yazınız.)");
            Int32 yyyy =Int32.Parse(Console.ReadLine());
            System.Console.WriteLine("Hangi ay dogdunuz? (mm şeklinde yazınız.)");
            Int32 mm =Int32.Parse(Console.ReadLine());
            System.Console.WriteLine("Ayın kaçıncı günü doğdunuz? (dd şeklinde yazınız.)");
            Int32 dd =Int32.Parse(Console.ReadLine());
            double biryildatoplamsaniye = 365*24*60*60;
            double kayipdogumsaniye = (mm*30+dd)*24*60*60;
            double oyilkalansaniye = biryildatoplamsaniye - kayipdogumsaniye;
            double arayillarsaniye = (((DateTime.Now.Year)-1)-yyyy)*biryildatoplamsaniye;
            double gunumuzsaniye = (DateTime.Now.DayOfYear)*24*60*60;
            double sonucsaniye = oyilkalansaniye + arayillarsaniye + gunumuzsaniye;
            double sonucdakika = sonucsaniye/60;
            double sonucsaat = sonucdakika/60;
            double sonucgun = sonucsaat/24;
            double sonuchafta = sonucgun/7;
            double sonucay = sonucgun/30;
            double sonucyil = sonucsaniye/biryildatoplamsaniye;       
            System.Console.WriteLine("Kaç yıldır yaşıyorsunuz:" + Convert.ToString(sonucyil));
            System.Console.WriteLine("Kaç aydır yaşıyorsunuz:" + Convert.ToString(sonucay));
            System.Console.WriteLine("Kaç gündür yaşıyorsunuz:" + Convert.ToString(sonucgun));
            System.Console.WriteLine("Kaç saattir yaşıyorsunuz:" + Convert.ToString(sonucsaat));
            System.Console.WriteLine("Kaç dakikadir yaşıyorsunuz:" + Convert.ToString(sonucdakika));
            System.Console.WriteLine("Kaç saniyedir yaşıyorsunuz:" + Convert.ToString(sonucsaniye));
        }}}
