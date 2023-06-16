using zadanie_2;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Tworzenie prostokąta o podanych długościach boków
            Prostokąt prostokąt1 = new Prostokąt(4.5, 3.2);
            Console.WriteLine($"Prostokąt 1: Bok A = {prostokąt1.BokA}, Bok B = {prostokąt1.BokB}");

            // Ustawianie długości boków za pomocą właściwości
            prostokąt1.BokA = 6.8;
            prostokąt1.BokB = 2.3;
            Console.WriteLine($"Prostokąt 1 po zmianie: Bok A = {prostokąt1.BokA}, Bok B = {prostokąt1.BokB}");

            // Tworzenie prostokąta na podstawie formatu arkusza papieru
            Prostokąt prostokąt2 = Prostokąt.ArkuszPapieru("A0");
            Console.WriteLine($"Prostokąt 2: Bok A = {prostokąt2.BokA}, Bok B = {prostokąt2.BokB}");

            Prostokąt prostokąt3 = Prostokąt.ArkuszPapieru("B2");
            Console.WriteLine($"Prostokąt 3: Bok A = {prostokąt3.BokA}, Bok B = {prostokąt3.BokB}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Wystąpił wyjątek: {ex.Message}");
        }
    }
}