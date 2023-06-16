using static System.Console;
using zaliczenie_72284;

Osoba osoba = new Osoba("Jan Kowalski");
osoba.DataUrodzenia = new DateTime(1956, 1, 1);
osoba.DataŚmierci = new DateTime(2036, 11, 30);

Console.WriteLine($"Imię: {osoba.Imię}");
Console.WriteLine($"Nazwisko: {osoba.Nazwisko}");
Console.WriteLine($"Data urodzenia: {osoba.DataUrodzenia}");
Console.WriteLine($"Data śmierci: {osoba.DataŚmierci}");
Console.WriteLine($"Imię i nazwisko: {osoba.ImięNazwisko}");
Console.WriteLine($"Wiek: {osoba.Wiek}");
