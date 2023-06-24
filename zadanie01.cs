using System;

class Program
{
    static void Main()
    {
        int czas = 3661; //czas w sekundach

        string sformatowanyCzas = FormatujCzas(czas);
        Console.WriteLine(sformatowanyCzas);
    }

    static string FormatujCzas(int sformatowanyCzas)
    {
        int godzina = czas / 3600;
        int minuty = (czas % 3600) / 60;
        int sekundy = (czas % 3600) % 60;

        string sformatowanaGodzina = godzina.ToString("D2");
        string sformatowanaMinuta = minuty.ToString("D2");
        string sformatowanaSekunda = sekundy.ToString("D2");

        return $"{sformatowanaGodzina}:{sformatowanaMinuta}:{sformatowanaSekunda}";
    }
}