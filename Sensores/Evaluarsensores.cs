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
            int humo = r.Next(1, 200);

            // Evaluación del humo
            if (humo > 0)
            {
                if (humo <= 50)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nivel bajo de humo");
                    Console.WriteLine($"Porcentaje de humo: {humo}%\n");
                }
                else if (humo <= 100)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Nivel moderado de humo");
                    Console.WriteLine($"Porcentaje de humo: {humo}%\n");

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Temperatura en aumento");
                    Console.WriteLine("Sistema de ventilación activado\n");
                }
                else if (humo <= 167)
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
                else // >167
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("Nivel extremo de humo.");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine();
                    Thread.Sleep(1000);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Porcentaje de humo: "+ humo+ "%");
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
            int temperaturaFinal = r.Next(10, 800); 
            int temperaturaActual = 10; 

            while (temperaturaActual <= temperaturaFinal)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"Temperatura actual: {temperaturaActual} °C");
                Thread.Sleep(100); // Retardo para simular el aumento gradual
                temperaturaActual += r.Next(10, 30); // Incrementar gradualmente para que no sea raro
            }
            Console.WriteLine();

            // Temperatura final
            int temp = temperaturaFinal;

            if (temp > 30 && temp <= 60)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Temperatura baja - No visible");
                Console.WriteLine($"Temperatura final: {temp} °C\n");
            }
            else if (temp > 60 && temp <= 100)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Temperatura moderada - Riesgo posible");
                Console.WriteLine($"Temperatura final: {temp} °C\n");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Posible riesgo de incendio");
                Console.WriteLine("Sistema de enfriamiento activado\n");
            }
            else if (temp > 100 && temp <= 260)
            {
               
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Temperatura alta - Alerta de Incendio");
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
            else if (temp < 30)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Temperatura regular - Sin riesgos");
                Console.WriteLine($"Temperatura final: {temp} °C\n");
            }
            else // temp > 261
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("Temperatura crítica detectada. - Flashover");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("Temperatura final: " + temp + "°C");
                Thread.Sleep(1000);
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Incendio activo");
                Console.WriteLine("Aspersores activados - Llamando a bomberos");

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
