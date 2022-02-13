Console.WriteLine(Gunler.Cuma);
Console.WriteLine((int)Gunler.Perşembe);


int sicaklık = 15;
if (sicaklık <= (int)HavaDurumu.Normal)
{
    Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını beklemelisin ! ");

}
else if (sicaklık >= (int)HavaDurumu.Sicak)
{
    Console.WriteLine("Dışarıya çıkmak için sıcak bir gün ! ");
}
else if (sicaklık>=(int)HavaDurumu.Normal && sicaklık < (int)HavaDurumu.CokSicak)
{
    Console.WriteLine("Hadi Dışarı çıkalım");

}



enum Gunler
{
    Pazartesi = 1,
    Salı,
    Çarşamba =91,
    Perşembe,
    Cuma,
    Cumartesi,
    Pazar
}

enum HavaDurumu
{
    Soguk = 5,
    Normal = 20,
    Sicak = 25,
    CokSicak = 35

}