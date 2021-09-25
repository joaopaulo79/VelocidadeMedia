using System;

namespace VelocidadeMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            double vm, s, t;
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n============ Velocidade Media ============");
            Console.ResetColor();

            Console.WriteLine("\nDigite os valores de distância (em metros)");
            Console.WriteLine("e de tempo (em segundos), para calcular");
            Console.WriteLine("a velocidade média (m/s)\n");
            
            Console.Write("Distância (metros) percorrida..: ");
            s = Convert.ToDouble(Console.ReadLine());

            Console.Write("Tempo (segundos) gasto.........: ");
            t = Convert.ToDouble(Console.ReadLine());

            vm = s / t;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n==== Resultado ====\n");
            Console.ResetColor();

            Console.WriteLine($"Velocidade média é {vm:N1} m/s\n");
        }
    }
}
