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
    public class Program
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
                Console.WriteLine("2. Revisar los sensores y zonas afectadas");
                Thread.Sleep(300);
                Console.WriteLine("0. Salir");
                Thread.Sleep(300);
                op = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Gracias por usar el Sistema Contra incendios de la empresa LUNATSELDER");
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
                        
                        
                        diseño.MostrarEncabezado();

                        string[] zonas = { "ÁREA DE TRATAMIENTO DE GAS", "ÁREA DE DESCANSO", "OFICINAS" };

                        foreach (string zona in zonas)
                        {
                            Console.Clear();
                            diseño.MostrarZona(zona);

                            bool alerta1 = false;
                            bool alerta2 = false;

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"Sensor 1\n");
                            alerta1 = sensores.Evaluar();
                            Console.WriteLine();

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"Sensor 2\n");
                            alerta2 = sensores.Evaluar();
                            Console.WriteLine();

                            Console.ReadKey();
                            Console.Clear();

                            // Mostrar el croquis de la zona con sensores coloreados
                            switch (zona.ToUpper())
                            {
                                case "ÁREA DE TRATAMIENTO DE GAS":
                                    mapa.Area1(alerta1, alerta2);
                                    break;
                                case "ÁREA DE DESCANSO":
                                    mapa.Area2(alerta1, alerta2);
                                    break;
                                case "OFICINAS":
                                    mapa.Area3(alerta1, alerta2);
                                    break;
                            }

                            Console.WriteLine("\nPresione ENTER para continuar...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        Console.Clear();
                        Console.WriteLine("SALIENDO DEL SISTEMA...");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Gracias por usar el Sistema Contra incendios de la empresa LUNATSELDER");
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

