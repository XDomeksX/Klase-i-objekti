using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_i_objekti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();
            osoba.setIme("Domenik");
            osoba.setGodRodenja(2004);
            osoba.setPrezime("Milohanic");
            osoba.setVisina(195);
            osoba.setTezina(84);
            osoba.SetSpol('M');
            Console.WriteLine("Ime i prezime: " + osoba.getIme() +" "+ osoba.getPrezime());
            Console.WriteLine("Godina rođenja: " + osoba.getGodRodenja());
            Console.WriteLine("Visina: " + osoba.getVisina()+" cm");
            Console.WriteLine("Težina: " + osoba.getTezina());
            Console.WriteLine("Spol: " + osoba.GetSpol() + "\n");

            Osoba osoba1 = new Osoba("Ana", "Anić", 1997, 176, 65, 'Ž');
            Console.WriteLine(osoba1.ToString());

            Console.ReadKey();
        }
    }
    class Osoba
    {
        String ime, prezime;
        int godRodenja, visina, tezina;
        char spol;

        public override string ToString()
        {
            string ispis = "Ime i prezime: " + this.getIme() + " " + this.getPrezime() + "\n"
                + "Godina rođenja: " + this.getGodRodenja() + "\n"
                + "Visina: " + this.getVisina() + " cm" + "\n"
                + "Težina: " + this.getTezina() + "\n"
                + "Spol: " + this.GetSpol();
            return ispis;
        }
        public Osoba()
        {

        }
        public Osoba(String ime, String prezime, int godRodenja, int visina, int tezina, char spol)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godRodenja = godRodenja;
            this.visina = visina;
            this.tezina=tezina;
            this.spol = spol;
        }
        public char GetSpol()
        {
            return spol;
        }

        public void SetSpol(char value)
        {
            spol = value;
        }

        public void setIme (string ime)
        {
            this.ime = ime;
        }
        public void setGodRodenja (int godRodenja)
        {
            this.godRodenja = godRodenja;
        }
        public int getGodRodenja()
        {
            return this.godRodenja;
        }
        public string getIme()
        {
            return this.ime;
        }
        public void setPrezime (string prezime)
        {
            this.prezime = prezime;
        }

        public string getPrezime()
        {
            return this.prezime;
        }
        public void setVisina (int visina)
        {
            this.visina = visina;
        }
        public int getVisina()
        {
            return this.visina;
        }
        public void setTezina (int tezina)
        {
            this.tezina = tezina;
        }
        public int getTezina()
        {
            return this.tezina;
        }
    }
}
