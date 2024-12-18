Console.Write("Lütfen bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());

//Deger 10 dan buyuk mu?, kucuk mu? yoksa esit mi? sorgusu. 
if (sayi < 10)
{
    Console.WriteLine("Girilen sayı 10'dan küçüktür.");
}
else if (sayi > 10)
{
    Console.WriteLine("Girilen sayı 10'dan büyüktür.");
}
else
{
    Console.WriteLine("Girilen sayı 10'a eşittir.");
}

//Tek mi? cift mi? kontrol yapisi.

if (sayi % 2 == 0)
{
    Console.WriteLine("Cift sayidir.");
}
else
{
    Console.WriteLine("Tek sayidir.");
}