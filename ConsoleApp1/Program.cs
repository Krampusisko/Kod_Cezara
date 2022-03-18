namespace Kod_Cezara
{
    class Program
    { 
        public static char kod(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
            return ch;
            }
            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }
        public static string Szyfrowanie(string input, int key)
        {
            string output = string.Empty;
            foreach (char ch in input)
                output += kod(ch, key);
            return output;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Tekst do szyfrowania:");
            string UserString = Console.ReadLine();
            Console.WriteLine("\n");

            Console.Write("Wprowadź swój klucz:");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Zaszyfrowany Tekst:");
            string cipherText = Szyfrowanie(UserString, key);
            Console.WriteLine(cipherText);
            Console.Write("\n");

            Console.ReadKey();

        }
    }
}
