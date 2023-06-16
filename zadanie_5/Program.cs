using zadanie_5;

/* Jako, że polecenie nie wskazywało sposobu generowania macierzy, poniżej przedstawione są dwa rozwiązania.
    W pierwszym z nich, każda macierz tworzona jest "ręcznie", poprzez przekazania odpowiednich wartości dla każdego miejsca w macierzy.
    Drugie rozwiązanie to losowe generowanie elementów macierzy, z zakresu liczbowego określonego w liniach od 58 do 60.
    W rozwiązaniu tym dodane zostało zwrócenie całych macierzy w konsoli, aby możliwa była weryfikacja ich zawartości.*/

class Program1
{
    static void Main(string[] args)
{
Macierz<int> macierz1 = new Macierz<int>(2, 2);
macierz1[0, 0] = 1;
macierz1[0, 1] = 2;
macierz1[1, 0] = 3;
macierz1[1, 1] = 4;

Macierz<int> macierz2 = new Macierz<int>(2, 2);
macierz2[0, 0] = 1;
macierz2[0, 1] = 2;
macierz2[1, 0] = 3;
macierz2[1, 1] = 4;

Macierz<int> macierz3 = new Macierz<int>(2, 2);
macierz3[0, 0] = 5;
macierz3[0, 1] = 6;
macierz3[1, 0] = 7;
macierz3[1, 1] = 8;

Console.WriteLine("Porównanie macierz1 i macierz2:");
Console.WriteLine(macierz1 == macierz2); // true

Console.WriteLine("Porównanie macierz1 i macierz3:");
Console.WriteLine(macierz1 == macierz3); // false

Console.WriteLine("Porównanie macierz2 i macierz3:");
Console.WriteLine(macierz2 == macierz3); // false
}
}

/*class Program2
{
    static void Main(string[] args)
    {
        int n = 3; // Wymiar macierzy

        Macierz<int> macierz1 = new Macierz<int>(n, n);
        Macierz<int> macierz2 = new Macierz<int>(n, n);
        Macierz<int> macierz3 = new Macierz<int>(n, n);

        Random random = new Random();

        // Wypełnianie macierzy losowymi wartościami
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                macierz1[i, j] = random.Next(1, 3); // Losowa wartość od 1 do 2
                macierz2[i, j] = random.Next(1, 3);
                macierz3[i, j] = random.Next(1, 3);
            }
        }

        Console.WriteLine("Zawartość macierz1:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(macierz1[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Zawartość macierz2:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(macierz2[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Zawartość macierz3:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(macierz3[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Porównanie macierz1 i macierz2:");
        Console.WriteLine(macierz1 == macierz2); // false

        Console.WriteLine("Porównanie macierz1 i macierz3:");
        Console.WriteLine(macierz1 == macierz3); // false

        Console.WriteLine("Porównanie macierz2 i macierz3:");
        Console.WriteLine(macierz2 == macierz3); // false
    }
}*/