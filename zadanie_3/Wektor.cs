using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    internal class Wektor
    {
        private double[] współrzędne;

        // Indeksator umożliwia dostęp do poszczególnych współrzędnych wektora
        public double this[int indeks]
        {
            get => współrzędne[indeks];
            set => współrzędne[indeks] = value;
        }

        // Właściwość zwracająca długość wektora
        public double Długość => IloczynSkalarny(this, this);

        // Właściwość zwracająca wymiar wektora
        public int Wymiar => współrzędne.Length;

        // Konstruktor tworzący wektor o podanym wymiarze
        public Wektor(int wymiar)
        {
            współrzędne = new double[wymiar];
        }

        // Konstruktor tworzący wektor na podstawie podanych współrzędnych
        public Wektor(params double[] współrzędne)
        {
            this.współrzędne = współrzędne;
        }

        // Metoda obliczająca iloczyn skalarny dwóch wektorów
        public static double IloczynSkalarny(Wektor wektor1, Wektor wektor2)
        {
            if (wektor1.Wymiar != wektor2.Wymiar)
                throw new ArgumentException("Wektory mają różny wymiar.");

            double suma = 0;
            for (int i = 0; i < wektor1.Wymiar; i++)
            {
                suma += wektor1[i] * wektor2[i];
            }
            return suma;
        }

        // Metoda obliczająca sumę podanych wektorów
        public static Wektor Suma(params Wektor[] wektory)
        {
            if (wektory.Length == 0)
                throw new ArgumentException("Brak wektorów do zsumowania.");

            int wymiar = wektory[0].Wymiar;
            Wektor suma = new Wektor(wymiar);

            for (int i = 0; i < wymiar; i++)
            {
                for (int j = 0; j < wektory.Length; j++)
                {
                    suma[i] += wektory[j][i];
                }
            }

            return suma;
        }

        // Przeciążenie operatora dodawania wektorów
        public static Wektor operator +(Wektor wektor1, Wektor wektor2)
        {
            if (wektor1.Wymiar != wektor2.Wymiar)
                throw new ArgumentException("Wektory mają różny wymiar.");

            Wektor suma = new Wektor(wektor1.Wymiar);

            for (int i = 0; i < wektor1.Wymiar; i++)
            {
                suma[i] = wektor1[i] + wektor2[i];
            }

            return suma;
        }

        public static Wektor operator -(Wektor wektor1, Wektor wektor2)
        {
            if (wektor1.Wymiar != wektor2.Wymiar)
                throw new ArgumentException("Wektory mają różny wymiar.");

            Wektor różnica = new Wektor(wektor1.Wymiar);

            for (int i = 0; i < wektor1.Wymiar; i++)
            {
                różnica[i] = wektor1[i] - wektor2[i];
            }

            return różnica;
        }

        public static Wektor operator *(Wektor wektor, double skalar)
        {
            Wektor wynik = new Wektor(wektor.Wymiar);

            for (int i = 0; i < wektor.Wymiar; i++)
            {
                wynik[i] = wektor[i] * skalar;
            }

            return wynik;
        }

        public static Wektor operator *(double skalar, Wektor wektor)
        {
            return wektor * skalar;
        }

        // Przeciążenie operatora dzielenia wektora przez skalar
        public static Wektor operator /(Wektor wektor, double skalar)
        {
            if (skalar == 0)
                throw new DivideByZeroException("Nie można dzielić przez zero.");

            Wektor wynik = new Wektor(wektor.Wymiar);

            for (int i = 0; i < wektor.Wymiar; i++)
            {
                wynik[i] = wektor[i] / skalar;
            }

            return wynik;
        }

public override string ToString()
        {
            // Tworzenie tablicy, w której zostaną przechowane sformatowane współrzędne
            string[] formattedCoordinates = współrzędne.Select(c => Math.Round(c, 2).ToString()).ToArray();

            // Łączenie sformatowanych współrzędnych przy użyciu separatora ", " i zwracanie wyniku jako napisu
            return string.Join(", ", formattedCoordinates);
        }
    }
}