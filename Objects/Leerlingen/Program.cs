namespace Leerlingen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string voornaam, naam, klas;

            Console.WriteLine("Gegevens van de leerling opvragen");
            Console.WriteLine();

            Console.Write("Geef de voornaam van de leerling: ");
            voornaam = Console.ReadLine();
            Console.Write("Geef de naam van de leerling: ");
            naam = Console.ReadLine();
            Console.Write("Geef de klas van de leerling: ");
            klas = Console.ReadLine();

            Gegevens Leerling1 = new Gegevens(naam, voornaam, klas);

            Console.Clear();

            Console.WriteLine("Voornaam: " + Leerling1.Voornaam);
            Console.WriteLine("Naam: " + Leerling1.Naam);
            Console.WriteLine("Klas: " + Leerling1.Klas);
        }
    }
}
