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
        public bool Evaluar()
        {
            bool alerta = false;
            Random r = new Random();
            int humo = r.Next(1, 100);

            // Evaluación del humo
            if (humo > 0)
            {
                if (humo <= 25)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nivel bajo de humo");
                    Console.WriteLine($"Porcentaje de humo: {humo}%\n");
                }
                else if (humo <= 50)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Nivel moderado de humo");
                    Console.WriteLine($"Porcentaje de humo: {humo}%\n");

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Temperatura en aumento");
                    Console.WriteLine("Sistema de ventilación activado\n");
                }
                else if (humo <= 75)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nivel alto de humo");
                    Console.WriteLine($"Porcentaje de humo: {humo}%\n");
                    alerta = true;

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Evacuar el sector");
                    Console.WriteLine("Sistema a máxima potencia\n");
                    Console.Beep(1000, 1500);
                    Console.Beep(1000, 1500);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Nivel extremo de humo.");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Thread.Sleep(1000);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Porcentaje de humo: {humo}%\n");
                    Thread.Sleep(1000);

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Evacuar personal");
                    Console.WriteLine("Sistema de ventilación activado");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("LLAMANDO A LOS BOMBEROS\n");
                    alerta = true;
                    Console.Beep(1000, 1500);
                    Console.Beep(1000, 1500);
                }
            }

            Console.ResetColor();
            Console.WriteLine();

            // Evaluación de temperatura
            int temperaturaFinal = r.Next(10, 91); 
            int temperaturaActual = 10; 

            while (temperaturaActual <= temperaturaFinal)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"Temperatura actual: {temperaturaActual} °C");
                Thread.Sleep(100); // Retardo para simular el aumento gradual
                temperaturaActual += r.Next(1, 5); // Incrementar gradualmente para que no sea raro
            }
            Console.WriteLine();

            // Temperatura final
            int temp = temperaturaFinal;

            if (temp >= 57 && temp <= 65)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Temperatura baja");
                Console.WriteLine($"Temperatura final: {temp} °C\n");
            }
            else if (temp > 65 && temp <= 75)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Temperatura moderada");
                Console.WriteLine($"Temperatura final: {temp} °C\n");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Posible riesgo de incendio");
                Console.WriteLine("Sistema de enfriamiento activado\n");
            }
            else if (temp > 75 && temp <= 85)
            {
               
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Temperatura alta");
                Console.WriteLine($"Temperatura final: {temp} °C\n");
                alerta = true;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Evacuar el sector");
                Console.WriteLine("Sistema a máxima potencia\n");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[ALERTA]");
                Console.Beep(1000, 1500);
                Console.Beep(1000, 1500);
            }
            else if (temp < 57)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Temperatura baja");
                Console.WriteLine($"Temperatura final: {temp} °C\n");
            }
            else // temp > 85
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Temperatura crítica detectada.");
                Console.BackgroundColor = ConsoleColor.Black;
                Thread.Sleep(1000);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Temperatura final: {temp} °C\n");
                Thread.Sleep(1000);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Incendio activo");
                Console.WriteLine("Aspersores activados - Llamando a bomberos\n");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[ALERTA MÁXIMA]");
                alerta = true;
                Console.Beep(1000, 1500);
                Console.Beep(1000, 1500);
            }
            Console.ResetColor();
            return alerta; //esto debe retornar un booleano ya que el metodo es un bool (en esta caso alerta que es el bool que maneja todos los condicionales)
        }
    }
}
