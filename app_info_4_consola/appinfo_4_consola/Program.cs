using System;

namespace appinfo_4_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!", args.Length);
            if (args.Length == 2) {
                int n1 = int.Parse(args[0]);
                int n2 = int.Parse(args[1]);
                int resultado = n1 + n2;

                Console.WriteLine("Resultado: {0}", resultado);
            }
       

        }
    }
}
