using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mapa
{
    public class Inicio
    {
        public void MostrarEncabezado()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("SISTEMAS CONTRA INCENDIO");
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Verificación de problemas\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("*** Empresa LUNATSELDER ***");
            Console.ResetColor();
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.Clear();
        }

        public void MostrarZona(string zona)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            Console.WriteLine(new string('+', 40));
            Console.WriteLine($"      {zona.ToUpper()}");
            Console.WriteLine(new string('+', 40));
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
