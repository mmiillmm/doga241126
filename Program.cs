using System.Text;
using varosok;

List<Varos> varos = [];

using StreamReader sr = new(
    path: @"..\..\..\src\varosok.csv",
    encoding: Encoding.UTF8);

sr.ReadLine();

while (!sr.EndOfStream) varos.Add(new Varos(sr.ReadLine()));

Console.WriteLine($"0. feladat: Ennyi entry van a fileban: {varos.Count}");

Console.WriteLine("\n");

var f1 = varos.Where(x => x.Orszag == "Kína").Sum(x => x.Lakossag);

Console.WriteLine($"1. feladat: Ennyi fő él Kínában: {Math.Round(f1 * 100)/100} millió");

Console.WriteLine("\n");

var f2 = varos.Where(x => x.Orszag == "India").Average(x => x.Lakossag);

Console.WriteLine($"2. feladat: Ennyi az indiai nagyvárosok átlaglélekszáma: {Math.Round(f2 * 100)/100} millió");

Console.WriteLine("\n");

var f3 = varos.OrderByDescending(x => x.Lakossag).FirstOrDefault();

Console.WriteLine($"3. feladat: Legnépesebb város: {f3.VarosNev}");

Console.WriteLine("\n");

var f4 = varos.OrderByDescending(x => x.Lakossag).Where(x => x.Lakossag > 20);

Console.WriteLine("4. feladat: 20 millió főnél nagyobb városok sorrendben");
foreach (var city in f4)
{
    Console.WriteLine(city.VarosNev);
}

Console.WriteLine("\n");

var f5 = varos
    .GroupBy(x => x.Orszag)
    .Where(g => g.Count() > 1)
    .Select(g => g.Key);

Console.WriteLine("5. feladat: Országok amelyeknek több városa van a listában:");

foreach (var orszag in f5)
{
    Console.WriteLine(orszag);
}

Console.WriteLine("\n");

var f6 = varos
    .GroupBy(x => x.VarosNev[0])
    .OrderByDescending(g => g.Count())
    .FirstOrDefault();

Console.WriteLine($"6. feladat: Legtöbb nagyváros kezdőbetűje: {f6.Key}");

Console.ReadKey();