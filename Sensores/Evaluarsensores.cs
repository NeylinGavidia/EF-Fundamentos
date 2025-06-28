using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sensores
{
    public class Evaluarsensores
    {
        public void Evaluar()
        {
            Random r = new Random();
            int humo = r.Next(0, 100);
            int temp = r.Next(57, 91);

            if (humo > 0)
            {
                if (humo <= 25)
                    MostrarMensaje("Nivel bajo de humo", humo, ConsoleColor.Green);
                else if (humo <= 50)
                {
                    MostrarMensaje("Nivel moderado de humo", humo, ConsoleColor.Yellow);
                    MostrarAdvertencia("Temperatura en aumento", "Sistema de ventilación activado");
                }
                else if (humo <= 75)
                {
                    MostrarMensaje("Nivel alto de humo", humo, ConsoleColor.Red);
                    MostrarAdvertencia("Evacuar el sector", "Sistema a máxima potencia");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Nivel extremo de humo.");
                    Console.ResetColor();
                    Thread.Sleep(1000);

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Porcentaje de humo: {humo}%\n");
                    Thread.Sleep(1000);

                    MostrarAdvertencia("Evacuar personal", "Sistema de ventilación activado");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("LLAMANDO A LOS BOMBEROS\n");
                    Thread.Sleep(1000);
                }
            }

            if (temp >= 57 && temp <= 70)
                MostrarTemperatura("Temperatura en aumento", temp, ConsoleColor.Magenta);
            else if (temp > 70 && temp < 80)
            {
                MostrarTemperatura("Temperatura alta", temp, ConsoleColor.Red);
                MostrarAdvertencia("Evacuar personal", null);
            }
            else if (temp >= 80)
            {
                MostrarTemperatura("Incendio detectado", temp, ConsoleColor.Red);
                MostrarAdvertencia("Aspersores activados", "Llamando a bomberos");
                Console.WriteLine($"Temperatura: {temp} °C\n");
            }

            if (temp >= 57)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[ALERTA]");
                Console.Beep(1000, 1500);
                Console.Beep(1000, 1500);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Todo funcionando correctamente.\n");
            }

            Console.ResetColor();
        }

        private static void MostrarMensaje(string mensaje, int humo, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(mensaje);
            Console.WriteLine($"Porcentaje de humo: {humo}%\n");
            Console.ResetColor();
        }

        private static void MostrarAdvertencia(string advertencia, string extra)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(advertencia);
            if (!string.IsNullOrEmpty(extra))
                Console.WriteLine(extra);
            Console.ResetColor();
            Thread.Sleep(1000);
        }

        private static void MostrarTemperatura(string mensaje, int temp, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"{mensaje}. Temperatura actual: {temp} °C\n");
            Thread.Sleep(1000);
            Console.ResetColor();
        }
    }
}
