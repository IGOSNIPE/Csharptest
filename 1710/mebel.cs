/* 
     * 1.60 Napisz klasę mebel zawierającą publiczne pola producent i kolekcja
oraz klasy krzeslo, stol, szafka pochodne klasy mebel. Klasy pochodne
powinny posiadac następujące pola publiczne:
— klasa krzeslo pole obicie,
— klasa stol pola szerokosc i dlugosc,
— klasa szafka pola szerokosc, wysokosc i glebokosc
*/
namespace _1710
{
    class mebel
    {
        public string producent;
        public string kolekcja;
        public double cena;

        protected mebel(string producent, string kolekcja, double cena)
        {
            this.producent = producent;
            this.kolekcja = kolekcja;
            this.cena = cena;
        }
    }

    class krzeslo : mebel
    {
        public enum Materialy
        {
            Drewno = 1,
            Welna,
            Jedwab,
            Diament
        }

        public Materialy obicie;

        public krzeslo(string producent, string kolekcja, Materialy obicie, double cena) :
            base(producent, kolekcja, cena)
        {
            this.obicie = obicie;
        }
    }
    class stol : mebel
    {
        public double szerokosc, dlugosc;

        public stol(string producent, string kolekcja, double szerokosc, double dlugosc, double cena) :
            base(producent, kolekcja, cena)
        {
            this.szerokosc = szerokosc;
            this.dlugosc = dlugosc;
        }
    }
    class szafka : mebel
    {
        public double szerokosc, wysokosc, glebokosc;

        public szafka(string producent, string kolekcja, double szerokosc, double wysokosc, double glebokosc, double cena) :
            base(producent, kolekcja, cena)
        {
            this.szerokosc = szerokosc;
            this.wysokosc = wysokosc;
            this.glebokosc = glebokosc;
        }
    }
}
