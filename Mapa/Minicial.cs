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
            Console.WriteLine("┌──────────────────────────────────────────────┐");
            Console.WriteLine("│                                              │");
            Console.WriteLine("│         (Área de tratamiento de gas)         │");
            Console.WriteLine("│                                              │");
            Console.WriteLine("│      SENSOR                     SENSOR       │");
            Console.WriteLine("│        1                           2         │");
            Console.WriteLine("│                                              │");
            Console.WriteLine("│──────────────────────────────────────────────│");
            Console.WriteLine("│ SENSOR                 │ SENSOR              │");
            Console.WriteLine("│   1                    │   2                 │");
            Console.WriteLine("│                        │                     │");
            Console.WriteLine("│  (Área de descanso)    │     (Oficinas)      │");
            Console.WriteLine("│                        │                     │");
            Console.WriteLine("│         SENSOR         │         SENSOR      │");
            Console.WriteLine("│           2            │            1        │");
            Console.WriteLine("└──────────────────────────────────────────────┘");
            Thread.Sleep(2000);
        }
    }
}
