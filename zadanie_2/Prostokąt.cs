using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{

    public class Prostokąt
    {
        private double bokA;
        private double bokB;

        public double BokA
        {
            get { return bokA; }
            set
            {
                if (double.IsNaN(value) || value < 0)
                    throw new ArgumentException("Długość boku A musi być skończoną nieujemną liczbą.");

                bokA = value;
            }
        }

        public double BokB
        {
            get { return bokB; }
            set
            {
                if (double.IsNaN(value) || value < 0)
                    throw new ArgumentException("Długość boku B musi być skończoną nieujemną liczbą.");

                bokB = value;
            }
        }

        public Prostokąt(double bokA, double bokB)
        {
            BokA = bokA;
            BokB = bokB;
        }

        /// <summary>
        /// Tworzy obiekt Prostokąt reprezentujący arkusz papieru o podanym formacie.
        /// </summary>
        /// <param name="format">Format arkusza papieru.</param>
        /// <returns>Obiekt Prostokąt reprezentujący arkusz papieru.</returns>
        public static Prostokąt ArkuszPapieru(string format)
        {
            if (string.IsNullOrEmpty(format) || format.Length < 2)
                throw new ArgumentException("Nieprawidłowy format arkusza.");

            char szereg = format[0];
            if (!wysokośćArkusza0.ContainsKey(szereg))
                throw new ArgumentException("Nieprawidłowy format arkusza.");

            byte indeks;
            if (!byte.TryParse(format.Substring(1), out indeks))
                throw new ArgumentException("Nieprawidłowy format arkusza.");

            decimal wysokość = wysokośćArkusza0[szereg];
            double pierwiastekZDwóch = Math.Sqrt(2);

            // Obliczanie długości boków na podstawie formatu arkusza papieru
            double bokA = Math.Round((double)decimal.Divide(wysokość, (decimal)Math.Pow(pierwiastekZDwóch, indeks)), 2);
            double bokB = Math.Round((double)decimal.Divide(wysokość, (decimal)Math.Pow(pierwiastekZDwóch, indeks + 1)), 2);

            return new Prostokąt(bokA, bokB);
        }

        // Słownik przechowujący wysokości arkuszy papieru
        private static readonly Dictionary<char, decimal> wysokośćArkusza0 = new Dictionary<char, decimal>
        {
            ['A'] = 1189,
            ['B'] = 841,
            ['C'] = 594
        };
    }
}