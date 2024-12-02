// See https://aka.ms/new-console-template for more information
using _20241202;

Console.WriteLine("Hello, World!");
List<Book> Booklist = [];

string[] angolkonyv = ["Book of bill", "Realm of Runaterra", "The 48 Laws of Power", "Berserk Deluxe Volume 1", "Gravity Falls Journal 3", "Berserk Deluxe Volume 2", "White Nights", "Pumpkin Spice Cafe", "The Art of Arcane", "Berserk Deluxe Volume 3", "Gravity Falls Journal 2", "Gravity Falls Journal 1", "The Ruination", "Into the pit", "The survival logbook"];
string[] magyarkonyv = ["Titkos világ", "Titkos világ2", "Titkos világ3", "Ne agyald túl!", "Hét év Tibetben", "Valami könyv név", "A két lotti", "Még könyv név", "Apám üzent", "A Monarchia szerelmesei", "Hazafi", "Kodály és a cifra palota", "Doszpot nyomoz", "A pokol fiai", "A bél-agy kapcsolat", "Az Árulók"];


for (int i = 0; i < 15; i++)
{
    bool nyelvrnd = Random.Shared.Next(100) < 10;
    string[] konyvnyelv = nyelvrnd ? angolkonyv : magyarkonyv;
    int keszlet1 = Random.Shared.Next(100);
    if (keszlet1 <= 30)
    {
        keszlet1 = 0;
    }
    else
    {
        keszlet1 = Random.Shared.Next(5, 10);
    }
    Booklist.Add(new Book(
        ISBN: Random.Shared.NextInt64(1000000000, 9999999999),
        cim: konyvnyelv[Random.Shared.Next(konyvnyelv.Length)],
        kiadas: Random.Shared.Next(2007, DateTime.Now.Year),
        nyelv: nyelvrnd,
        keszlet: keszlet1,
        ar: 4500));
    Console.WriteLine(Booklist.Last());
}
