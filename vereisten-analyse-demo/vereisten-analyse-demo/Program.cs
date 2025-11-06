namespace vereisten_analyse_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string juisteNaam = "SamedPXL";
            string juisteWachwood = "SamedPXL1";

            Console.Write("Gebruikersnaam: ");
            string naam = Console.ReadLine();

            Console.Write("Wachtwoord: ");
            string wachtwoord = Console.ReadLine();

            if (naam == juisteNaam && wachtwoord == juisteWachwood)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Jij bent ingelogd!");
                Console.ResetColor();
            }

            
        }
    }
}
