namespace SitoEratostenesa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Podaj liczbe (w zakresie od 2 do n): ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input<=1)
                {
                    throw new ArgumentException();
                }
                Sito(input);
                
            }
            catch (Exception)
            {

                Console.WriteLine("Podaj właściwą liczbę!");
                Console.ReadKey();
            }
        }

        static void Sito(int n) 
        {
            bool[] tab = new bool[n + 1];
            for (int i = 2; i * i <= n; i++)
            {
                if (tab[i] == true)
                {
                    continue;
                }
                for (int j = 2 * i; j <= n; j += i)
                {
                    tab[j] = true;
                }
            }
            Console.WriteLine("\nLiczby pierwsze: ");
            for (int i = 2; i <= n; i++)
            {
                if (tab[i] == false)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\n\nBlizniaki: ");
            for (int i = 2; i <= n-2; i++)
            {
                if (tab[i] == false && tab[i+2] == false)
                {
                    Console.Write($"{i} & {i+2}   ");
                }
            }
            Console.WriteLine("\n\nCzworaki: ");
            for (int i = 2; i <= n-8; i++)
            {
                if (tab[i] == false && tab[i + 2] == false && tab[i + 6] == false && tab[i + 8] == false)
                {
                    Console.Write($"{i} & {i + 2} & {i+6} & {i+8}   ");
                }
            }
            Console.ReadKey();
        }
    }
}