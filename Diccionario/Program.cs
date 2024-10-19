using System.ComponentModel.Design;
using System.Collections.Generic;

namespace Listas
{

    internal class Listas_Tuplas
    {
        static void Main(string[] args)
        {
            List<Tuple<string, string>> diccionario = CrearDiccionario();
            Traducir(diccionario);
        }

        public static List<Tuple<string, string>> CrearDiccionario()
        {
            List<Tuple<string, string>> diccionario = new List<Tuple<string, string>>();
            Console.WriteLine("\tIngreso de palabras al diccionario");
            Console.WriteLine("\n───────────────────────────────────────────────────");
            for (int i = 0; i < 3; i++)
            {

                Console.Write($"Ingrese palabra #{i+1} en Ingles: ");
                string ing = Console.ReadLine();
                Console.Write($"Ingrese la traduccion de la palabra #{i + 1}: ");
                string esp = Console.ReadLine();
                diccionario.Add(new Tuple <string,string>(ing, esp));
            }
            Console.WriteLine("\n───────────────────────────────────────────────────");
            return diccionario;

        }
        public static void Traducir(List<Tuple<string,string>> diccionario)
        {
            Console.Clear();
            Console.Write("Ingrese la palabra a traducir: ");
            string pal = Console.ReadLine();
            bool e = false;
            foreach (var duo in diccionario)
            {
                if (duo.Item1.Equals(pal, StringComparison.OrdinalIgnoreCase))
                {
                    e = true;
                    Console.WriteLine($"La traduccion de {pal}  es: {duo.Item2}"); break;
                }
                if (duo.Item2.Equals(pal, StringComparison.OrdinalIgnoreCase))
                {
                    e = true;
                    Console.WriteLine($"La traduccion de {pal}  es: {duo.Item1}"); break;
                }
            }
            if (!e)
            {
                Console.WriteLine($"La palabra {pal} no se ha encontrado en el diccionario");
            }
        }
    }
}
