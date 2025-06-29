using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Mapa
{
    public class Minicial
    {
        public void Croquis()
        {
            Console.Clear();
            Console.WriteLine("            ┌──────────────────────────────────────────────┐");
            Console.WriteLine("            │                                              │");
            Console.WriteLine("            │         (Área de tratamiento de gas)         │");
            Console.WriteLine("            │                                              │");
            Console.WriteLine("            │      SENSOR                     SENSOR       │");
            Console.WriteLine("            │        1                           2         │");
            Console.WriteLine("            │                                              │");
            Console.WriteLine("            │──────────────────────────────────────────────│");
            Console.WriteLine("            │ SENSOR                 │ SENSOR              │");
            Console.WriteLine("            │   1                    │   2                 │");
            Console.WriteLine("            │                        │                     │");
            Console.WriteLine("            │  (Área de descanso)    │     (Oficinas)      │");
            Console.WriteLine("            │                        │                     │");
            Console.WriteLine("            │         SENSOR         │         SENSOR      │");
            Console.WriteLine("            │           2            │            1        │");
            Console.WriteLine("            └──────────────────────────────────────────────┘");
            Thread.Sleep(2000);
        }

        public void Area1(bool alerta1, bool alerta2)
        {
            Console.WriteLine("            ┌──────────────────────────────────────────────┐");
            Console.WriteLine("            │                                              │");
            Console.WriteLine("            │         (Área de tratamiento de gas)         │");
            Console.WriteLine("            │                                              │");
            Console.ForegroundColor = alerta1 ? ConsoleColor.Red : ConsoleColor.Green;
            Console.Write("            │      SENSOR ");
            Console.Write("1");
            Console.ResetColor();
            Console.ForegroundColor = alerta2 ? ConsoleColor.Red : ConsoleColor.Green;
            Console.Write("                     SENSOR ");
            Console.Write("2");
            Console.ResetColor();
            Console.WriteLine("   │");
            Console.WriteLine("            │                                              │");
            Console.WriteLine("            └──────────────────────────────────────────────┘");
        }
        public void Area2(bool alerta1, bool alerta2)
        {
            Console.WriteLine("            ┌────────────────────────┐");
            Console.ForegroundColor = alerta1 ? ConsoleColor.Red : ConsoleColor.Green;
            Console.Write("            │ SENSOR ");
            Console.Write("1");
            Console.ResetColor();
            Console.WriteLine("               │");
            Console.WriteLine("            │                        │");
            Console.WriteLine("            │  (Área de descanso)    │");
            Console.WriteLine("            │                        │");
            Console.ForegroundColor = alerta2 ? ConsoleColor.Red : ConsoleColor.Green;
            Console.Write("            │         SENSOR ");
            Console.Write("2");
            Console.ResetColor();
            Console.WriteLine("       │");
            Console.WriteLine("            └────────────────────────┘");
        }

        public void Area3(bool alerta1, bool alerta2)
        {
            Console.WriteLine("            ┌─────────────────────┐");
            Console.ForegroundColor = alerta2 ? ConsoleColor.Red : ConsoleColor.Green;
            Console.Write("            │ SENSOR ");
            Console.Write("2");
            Console.ResetColor();
            Console.WriteLine("            │");
            Console.WriteLine("            │                     │");
            Console.WriteLine("            │     (Oficinas)      │");
            Console.WriteLine("            │                     │");
            Console.ForegroundColor = alerta1 ? ConsoleColor.Red : ConsoleColor.Green;
            Console.Write("            │         SENSOR ");
            Console.Write("1");
            Console.ResetColor();
            Console.WriteLine("    │");
            Console.WriteLine("            └─────────────────────┘");
        }

    }
}
