using System;

namespace A133590.Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.TreatControlCAsInput = true;
            ConsoleKeyInfo cki;


            Console.WriteLine("Ejercicio 5.");
            Console.WriteLine("El programa lee las teclas presionadas hasta que se presiona CTRL+F");
            while (true)
            {
                cki = Console.ReadKey();
                if ((cki.Modifiers & ConsoleModifiers.Control) != 0 && cki.Key == ConsoleKey.F) break;
            }

            Console.WriteLine("Presione cualquier tecla para salir..");
            Console.ReadKey();
        }
    }
}
