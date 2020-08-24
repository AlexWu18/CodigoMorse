using System;
using System.Collections.Generic;

namespace CodigoMorse
{
    class Program
    {
        static void Main(string[] args)
        {
            string Frase;
            Dictionary<string, string> Morse = new Dictionary<string, string>
            {
                {"a", ".-"},
                {"b", "-..."}, 
                {"c", "-.-."}, 
                {"d", "-.."},
                {"e", "."},
                {"f", "..-."},
                {"g", "--."},
                {"h", "...."},
                {"i", ".."},
                {"j", ".---"},
                {"k", "-.-"},
                {"l", ".-.."},
                {"m", "--"},
                {"n", "-."},
                {"o", "---"},
                {"p", ".--."},
                {"q", "--.-"},
                {"r", ".-."},
                {"s", "..."},
                {"t", "-"},
                {"u", "..-"},
                {"v", "...-"},
                {"w", ".--"},
                {"x", "-..-"},
                {"y", "-.--"},
                {"z", "--.."},
                
                {"0", "-----"},
                {"1", ".----"},
                {"2", "..---"},
                {"3", "...--"},
                {"4", "....-"},
                {"5", "....."},
                {"6", "-...."},
                {"7", "--..."},
                {"8", "---.."},
                {"9", "----."}
            };

            Console.WriteLine("Escribe que lo que deseas traducir : ");
            Frase = Console.ReadLine();
            string Texto = Frase.ToLower();
            Console.Clear();
            Console.WriteLine("La frase introducida es : " + (Texto));
            Console.WriteLine("");

            foreach (char c in Frase.ToCharArray())
            {
                string cosa = Morse[c.ToString()].Trim();
                foreach (char c2 in cosa.ToCharArray())
                {
                    if (c2 == '.')
                        Console.Beep(1000, 250);
                    
                    else
                        Console.Beep(1000, 750);
                }
                System.Threading.Thread.Sleep(100);
                Console.Write(" " + (cosa));
            }
           
            Console.WriteLine("\n");
            Console.WriteLine("\n Programa finalizado");
            Console.ReadKey();
        }
        
    }
}
