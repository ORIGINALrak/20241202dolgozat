using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241202
{
    internal class Author
    {
        public Guid id { get; set; }

        public string Vezeteknev
        {
            get => Vezeteknev;
            private set
            {
                if (value.Length >= 3  && value.Length <= 32) throw new Exception(
                    $"A vezetéknév minimum 3 és maximum 32 karakter lehet");
                Vezeteknev = value;
            }
        }

        public string Keresztnev
        {
            get => Keresztnev;
            private set
            {
                if (value.Length >= 3 && value.Length <= 32) throw new Exception(
                    $"A Keresztnev minimum 3 és maximum 32 karakter lehet");
                Keresztnev = value;
            }
        }
        public override string ToString() => $"{Vezeteknev} {Keresztnev} {id}";
        public Author(string vezeteknev, string keresztnev)
        {
            id = Guid.NewGuid();
            Vezeteknev = vezeteknev;
            Keresztnev = keresztnev;

        }
    }
}
