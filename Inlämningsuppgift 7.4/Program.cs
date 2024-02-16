using System;

namespace uppgift_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ord = { "hej", "neä", "ja" };
            char check = 'j';
            bool svar = FinnsTecknetIAllaSträngar(ord, 'J');
            if (svar = true)
            {
                Console.WriteLine("Tecknet finns i alla strängar");
            }
            else
            {
                Console.WriteLine("Tecknet finns inte i alla strängar");
            }
        }
        static bool FinnsTecknetIAllaSträngar(string[] x, char y) 
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i].ToLower().Contains(y.ToString().ToLower()));
                return true;
            }
            return false;
        }
    }
}
