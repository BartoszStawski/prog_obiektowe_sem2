using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaliczenie_72284;

internal class Osoba
{
    private string firstName;
    private string lastName;

    public Osoba(string imięNazwisko)
    {
        ImięNazwisko = imięNazwisko;
    }

    public string Imię
    {
        get { return firstName; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Imię nie może być puste.");
            firstName = value;
        }
    }

    public string Nazwisko
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public DateTime? DataUrodzenia { get; set; }
    public DateTime? DataŚmierci { get; set; }

    public string ImięNazwisko
    {
        get { return $"{firstName} {lastName}".Trim(); }
        set
        {
            // Podział wartości "imięNazwisko" na części oddzielone spacją
            string[] parts = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length >= 1)
            {
                // Ustawienie wartości imienia na pierwszą część
                firstName = parts[0];

                if (parts.Length > 1)
                {
                    // Ustawienie wartości nazwiska na ostatnią część
                    lastName = parts[parts.Length - 1];
                }
                else
                {
                    // Jeśli brak nazwiska, ustawienie na pustą wartość
                    lastName = string.Empty;
                }
            }
            else
            {
                // Jeśli brak części, ustawienie imienia i nazwiska na puste wartości
                firstName = string.Empty;
                lastName = string.Empty;
            }
        }
    }

    public string Wiek
    {
        get
        {
            if (DataUrodzenia == null)
                return null;

            DateTime endDate = DataŚmierci ?? DateTime.Now;
            TimeSpan age = endDate - DataUrodzenia.Value;

            // Obliczenie wieku w latach, miesiącach i dniach
            int years = (int)(age.TotalDays / 365.25);
            int months = (int)((age.TotalDays % 365.25) / 30.4375);
            int days = (int)(age.TotalDays % 30.4375);

            // Zmienna przechowująca sformatowany wiek
            string formattedAge = "";

            // Dodanie liczby lat do sformatowanego wieku
            if (years > 0)
            {
                formattedAge += $"{years} {(years == 1 ? "rok" : (years >= 2 && years <= 4 ? "lata" : "lat"))} ";
            }

            // Dodanie liczby miesięcy do sformatowanego wieku
            if (months > 0)
            {
                formattedAge += $"{months} {(months == 1 ? "miesiąc" : (months >= 2 && months <= 4 ? "miesiące" : "miesięcy"))} ";
            }

            // Dodanie liczby dni do sformatowanego wieku
            if (days > 0)
            {
                formattedAge += $"{days} {(days == 1 ? "dzień" : "dni")} ";
            }

            // Usunięcie ewentualnych spacji na początku i końcu sformatowanego wieku
            return formattedAge.Trim();
        }
    }
}