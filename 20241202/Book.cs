using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _20241202
{
    internal class Book
    {
        private bool nyelv;

        public List<Author> Szerzok { get; set; }

        public long ISBN
        {
            get => ISBN;
            private set
            {

                if (value.ToString().Length != 10) throw new Exception(
                    $"Csak 10 hosszú lehet");

                ISBN = value;
            }
        }
        public string Cim
        {
            get => Cim;
            private set
            {
                if (value.Length <= 3 && value.Length >= 64) throw new Exception(
                    $"Csak 3 és 64 között lehet a cím hossza");
                Cim = value;
            }
        }
        public int Kiadas
        {
            get => Kiadas;
            private set
            {
                if (value < 2007 && value > DateTime.Now.Year) throw new Exception(
                    $"A kiadás éve csak 2007 és a jelenlegi év közti év lehet");
                Kiadas = value;
            }
        }
        public string Nyelv
        {
            get => Nyelv;
            private set
            {
                if (value != "angol" || value != "német" || value != "magyar") throw new Exception(
                    $"A nyelv csak angol német és magyar lehet");
                Nyelv = value;
            }
        }

        public int Keszlet
        {
            get => Keszlet;
            set
            {
                if (value <= 0) throw new Exception(
                    $"A készletnek nagyobbnak kell lenni mint minusz");
                Keszlet = value;
            }
        }
        public int Ar
        {
            get => Ar;
            private set
            {
                if (value <= 1000 && value >= 10000 && value % 100 == 0) throw new Exception(
                    $"Az árnak 1000 nél többnek 10000nél kisebbnek és 100 ra kerekítve kell lennie");
                Ar = value;
            }
        }
        public override string ToString() => $"{Keszlet} van a készleten, {Nyelv} nyelvű, ára: {Ar}, az ISBN azonosítója {ISBN}, a kiadás éve: {Kiadas}";
        
        public Book(long ISBN, string cim, int kiadas, string nyelv, int keszlet, int ar, params string[] szerzok)
        {
            this.ISBN = ISBN;
            Cim = cim;
            Kiadas = kiadas;
            Nyelv = nyelv;
            Keszlet = keszlet;
            Ar = ar;
        }

        public Book(string cim, params string[] szerzok)
        {
            Cim = cim;
            Szerzok = [];
            foreach (var vezeteknev in szerzok)
            {
                Szerzok.Add(new Author(vezeteknev: vezeteknev, keresztnev: vezeteknev));
            }
        }

        public Book(long ISBN, string cim, int kiadas, bool nyelv, int keszlet, int ar)
        {
            this.ISBN = ISBN;
            Cim = cim;
            Kiadas = kiadas;
            this.nyelv = nyelv;
            Keszlet = keszlet;
            Ar = ar;
        }
    }
}
