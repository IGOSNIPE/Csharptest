namespace _1710
{
    

    class Program
    {
        static int Suma(int a, int b)
        {
            return a + b;
        }

        static void WczytajLiczbyIWypisz()
        {
            int a = System.Int32.Parse(System.Console.ReadLine());
            int b = System.Int32.Parse(System.Console.ReadLine());
            System.Console.WriteLine("{0} + {1} = {2}", a, b, Suma(a, b));
        }

        static void Main(string[] args)
        {
            //Powiedzmy że przyjeżdża do ciebie producent z fajnymi super fantastycznymi mebelkami, jest to krzeslo stol i szaf
            // Powiedzmy ze do Twojego sklepu przyszedl ktos kupic szafke, krzeslo i stol a Ty musisz zebrac zamowienie
            // Napisz program do zbierania takiego zamowienia i wyswietlania na ekran ceny calkowitej
            System.Console.WriteLine("Co byś chcioł?\n1. krzyslo \n2.stol\n3.szefke\n4.wychodze stad");
            int wybor = System.Int32.Parse(System.Console.ReadLine());
            if(wybor != 4)
            {
                System.Console.WriteLine("Podaj producenta");
                string producent = System.Console.ReadLine();
                System.Console.WriteLine("Podaj kolekcje");
                string kolekcja = System.Console.ReadLine();
                System.Console.WriteLine("Podaj cene");
                double cena = System.Double.Parse(System.Console.ReadLine());

                if (wybor == 1)
                {
                    System.Console.WriteLine("Poda mnie obicie tygo krzysla:\n1. Drewno \n2. Welna\n3. Jedwab \n4.Diament");
                    int obicieJakoInt = System.Int32.Parse(System.Console.ReadLine());

                    krzeslo.Materialy obicie = (krzeslo.Materialy)obicieJakoInt;

                    //krzeslo noweKrzeslo = new krzeslo(producent, ...);
                    krzeslo noweKrzeslo = new krzeslo(producent, kolekcja, obicie, cena);
                }
                if (wybor == 2)
                {
                    System.Console.WriteLine("Podaj szerokość");
                    int szerokoscuser = System.Int32.Parse(System.Console.ReadLine());

                    System.Console.WriteLine("Podaj długość");
                    int dlugoscuser = System.Int32.Parse(System.Console.ReadLine());

                    stol.szerokosc szerokosc = (stol.szerokosc)szerokoscuser;
                    stol.dlugosc dlugosc = (stol.dlugosc)dlugoscuser;

                    stol nowystol = new stol(producent, kolekcja, obicie, cena, szerokosc, dlugosc)
                }
            }
            // tutaj wyjscie z programu czy tam wyswietlenie ceny
        }
    }
}
