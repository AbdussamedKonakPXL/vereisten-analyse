namespace vereisten_analyse_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string juisteNaam = "SamedPXL";
            string juisteWachwood = "SamedPXL1";

            int tries = 3; 
            do
            {
                Console.Write("Gebruikersnaam: ");
                string naam = Console.ReadLine();

                Console.Write("Wachtwoord: ");
                string wachtwoord = Console.ReadLine();

                if (naam == juisteNaam && wachtwoord == juisteWachwood)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Jij bent ingelogd!");
                    Console.ResetColor();
                    return;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ingevulde gegevens zijn fout jij hebt nog {tries} pogingen");
                    Console.ResetColor();
                    tries -= 1;
                }
                
            } while (tries != 0);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Te veel pogingen probeer het later opnieuw!!");
            Console.ResetColor();
            
        }
    }
}
