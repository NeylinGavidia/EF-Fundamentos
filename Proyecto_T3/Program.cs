using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Mapa;
using Sensores;

namespace Proyecto_T3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            Minicial mapa = new Minicial();
            Inicio diseño = new Inicio();
            Evaluarsensores sensores = new Evaluarsensores();
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Bienvenido al Sistema Contra Incendios de Lunaselter");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine("Elije una opción:");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                Console.WriteLine("1. Revisar mapa o croquis");
                Thread.Sleep(300);
                Console.WriteLine("2. Revisar los sensores y zonas afectas");
                Thread.Sleep(300);
                Console.WriteLine("0. Salir");
                Thread.Sleep(300);
                op = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Gracias por usar el Sistema Contra incendios de la empresa LUNASELTER");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        return;
                    case 1:
                        mapa.Croquis();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("                    -- PRESIONE ENTER PARA VOLVER --    ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        
                        //mapa.Croquis();
                        //Console.Clear();
                        diseño.MostrarEncabezado();

                        string[] zonas = { "ÁREA DE TRATAMIENTO DE GAS", "ÁREA DE DESCANSO", "ÁREA DE OFICINAS" };

                        foreach (string zona in zonas)
                        {
                            Console.Clear();
                            diseño.MostrarZona(zona);

                            for (int i = 0; i < 2; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine($"Sensor {i + 1}\n");
                                sensores.Evaluar();
                                Console.WriteLine();
                            }

                            Console.ReadKey();
                            Console.Clear();
                        }

                            Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("SALIENDO DEL SISTEMA...");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Gracias por usar el Sistema Contra incendios de la empresa LUNASELTER");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        return;
                    default:
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Opción no válida, intente de nuevo.");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.ResetColor();
                        break;
                }
            }
            while (true);
        }
    }
}

