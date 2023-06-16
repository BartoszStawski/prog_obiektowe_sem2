using System;
using zadanie_3;

Wektor v1 = new Wektor(1, 2, 3);
Wektor v2 = new Wektor(4, 5, 6);

Wektor suma = v1 + v2;
Wektor różnica = v1 - v2;
Wektor iloczynSkalar = v1 * 2.5;
Wektor iloraz = v2 / 3.0;

Console.WriteLine("Suma: " + string.Join(", ", suma));
Console.WriteLine("Różnica: " + string.Join(", ", różnica));
Console.WriteLine("Iloczyn skalarny: " + Wektor.IloczynSkalarny(v1, v2));
Console.WriteLine("Iloraz: " + string.Join(", ", iloraz));
