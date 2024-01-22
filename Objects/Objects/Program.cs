namespace Objects
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Dier Hond = new Dier("Hond", "Pablo", 4, 8);

            Console.WriteLine("Hij is een " + Hond.Soort);
            Console.WriteLine("Zijn naam is " + Hond.Naam);
            Console.WriteLine("Hij heeft " + Hond.Aantalpoten + " poten");
            Console.WriteLine("Hij is " + Hond.Leeftijd + " jaar oud");
            Console.WriteLine($"Volgend jaar is Pablo {Hond.Leeftijdplus(Hond.Leeftijd)} jaar oud"); 
        }
    }
}
