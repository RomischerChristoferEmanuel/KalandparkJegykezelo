using KalandparkJegykezelo;
List<Jegyvasarlas>adatok=new List<Jegyvasarlas>();
Console.WriteLine("Napi jegyvásárlások:");
foreach(string sor in File.ReadAllLines("jegyek.txt"))
{
    adatok.Add(new Jegyvasarlas(sor));
}
foreach(Jegyvasarlas aktualis in adatok)
{
    Console.WriteLine(aktualis);
}
Console.WriteLine("\nStatisztika:");
int telj = adatok.Sum(x => x.FizetendoOsszeg());
Console.WriteLine($"Kalandpark teljes napi bevétele: {telj} Ft");
Jegyvasarlas leg = adatok.MaxBy(x => x.FelnottJegyek);
Console.WriteLine($"Legtöbbet fizető látogató: {leg.LatogatoNev} ({leg.FelnottJegyek*4000+leg.GyerekJegyek*2500} Ft)");