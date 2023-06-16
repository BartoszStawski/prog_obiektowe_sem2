using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_5
{
    /// <summary>
    /// Klasa reprezentująca macierz o ogólnym typie elementów.
    /// </summary>
    /// <typeparam name="T">Typ elementów macierzy.</typeparam>
    public class Macierz<T> : IEquatable<Macierz<T>> where T : IEquatable<T>
    {
        private readonly T[,] elements;

        /// <summary>
        /// Wymiar wierszy macierzy.
        /// </summary>
        public int WymiarWierszy { get; }

        /// <summary>
        /// Wymiar kolumn macierzy.
        /// </summary>
        public int WymiarKolumn { get; }

        /// <summary>
        /// Konstruktor tworzący macierz o podanym wymiarze.
        /// </summary>
        /// <param name="wymiarWierszy">Wymiar wierszy macierzy.</param>
        /// <param name="wymiarKolumn">Wymiar kolumn macierzy.</param>
        public Macierz(int wymiarWierszy, int wymiarKolumn)
        {
            if (wymiarWierszy <= 0 || wymiarKolumn <= 0)
            {
                throw new ArgumentException("Wymiar wierszy i kolumn musi być większy od zera.");
            }

            WymiarWierszy = wymiarWierszy;
            WymiarKolumn = wymiarKolumn;

            elements = new T[WymiarWierszy, WymiarKolumn];
        }

        /// <summary>
        /// Indeksator umożliwiający dostęp do elementów macierzy.
        /// </summary>
        /// <param name="wiersz">Indeks wiersza.</param>
        /// <param name="kolumna">Indeks kolumny.</param>
        /// <returns>Element macierzy o podanych indeksach.</returns>
        public T this[int wiersz, int kolumna]
        {
            get
            {
                ValidateIndeks(wiersz, kolumna);
                return elements[wiersz, kolumna];
            }
            set
            {
                ValidateIndeks(wiersz, kolumna);
                elements[wiersz, kolumna] = value;
            }
        }

        private void ValidateIndeks(int wiersz, int kolumna)
        {
            if (wiersz < 0 || wiersz >= WymiarWierszy || kolumna < 0 || kolumna >= WymiarKolumn)
            {
                throw new IndexOutOfRangeException("Nieprawidłowy indeks.");
            }
        }

        /// <summary>
        /// Przeciążona metoda porównująca dwie macierze.
        /// </summary>
        /// <param name="macierz1">Pierwsza macierz do porównania.</param>
        /// <param name="macierz2">Druga macierz do porównania.</param>
        /// <returns>True, jeśli macierze są równe. False w przeciwnym razie.</returns>
        public static bool operator ==(Macierz<T> macierz1, Macierz<T> macierz2)
        {
            if (ReferenceEquals(macierz1, macierz2))
            {
                return true;
            }

            if (macierz1 is null || macierz2 is null)
            {
                return false;
            }

            if (macierz1.WymiarWierszy != macierz2.WymiarWierszy || macierz1.WymiarKolumn != macierz2.WymiarKolumn)
            {
                return false;
            }

            for (int i = 0; i < macierz1.WymiarWierszy; i++)
            {
                for (int j = 0; j < macierz1.WymiarKolumn; j++)
                {
                    if (!macierz1[i, j].Equals(macierz2[i, j]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Przeciążona metoda porównująca dwie macierze.
        /// </summary>
        /// <param name="macierz1">Pierwsza macierz do porównania.</param>
        /// <param name="macierz2">Druga macierz do porównania.</param>
        /// <returns>True, jeśli macierze nie są równe. False w przeciwnym razie.</returns>
        public static bool operator !=(Macierz<T> macierz1, Macierz<T> macierz2)
        {
            return !(macierz1 == macierz2);
        }

        /// <summary>
        /// Przesłonięta metoda sprawdzająca równość obiektów.
        /// </summary>
        /// <param name="obj">Obiekt do porównania.</param>
        /// <returns>True, jeśli obiekty są równe. False w przeciwnym razie.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Macierz<T> other)
            {
                return this == other;
            }

            return false;
        }

        /// <summary>
        /// Metoda sprawdzająca równość dwóch macierzy.
        /// </summary>
        /// <param name="other">Inna macierz do porównania.</param>
        /// <returns>True, jeśli macierze są równe. False w przeciwnym razie.</returns>
        public bool Equals(Macierz<T> other)
        {
            return this == other;
        }

        /// <summary>
        /// Przesłonięta metoda zwracająca unikatowy identyfikator dla obiektu.
        /// </summary>
        /// <returns>Hash code obiektu.</returns>
        public override int GetHashCode()
        {
            return elements.GetHashCode();
        }
    }
}