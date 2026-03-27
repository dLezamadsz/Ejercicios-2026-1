using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEjercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {
                Console.WriteLine("Elige una operación");
                Console.WriteLine("(1) Rectángulo\n(2) Triángulo\n(3) Año Bisiesto\n(4) Calculadora");
                string op = Console.ReadLine();
                switch (op)
                {
                    default: run = false; break;
                    case "1": Rectangulo(); break;
                    case "2": Triangulo(); break;
                    case "3": Bisiesto(); break;
                    case "4": Calculadora(); break;
                }

                Console.WriteLine("¿Continuar?\n(1) Sí     (2) No");
                string cont = Console.ReadLine();
                if (cont != "1")
                {
                    run = false;
                }
            }
        }

        static void Rectangulo()
        {
            Console.WriteLine("Ingresa la base del rectángulo:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la altura del rectángulo:");
            int h = int.Parse(Console.ReadLine());
            if(b < 0 || h < 0)
            {
                Console.WriteLine("Uno de los valores es negativo.");
            }
            else
            {
                int perimetro = 2 * b + 2 * h;
                int area = b * h;
                Console.WriteLine($"El perímetro del rectángulo es de {perimetro} u.\nEl área del rectángulo es de {area} u^2.");
            }
            Console.ReadLine();
        }

        static void Triangulo()
        {
            Console.WriteLine("Ingresa la base del triángulo:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la altura del triángulo:");
            int h = int.Parse(Console.ReadLine());
            if (b < 0 || h < 0)
            {
                Console.WriteLine("Uno de los valores es negativo.");
                Console.ReadLine();
            }
            else
            {
                int area = (b * h) / 2;
                Console.WriteLine($"El área del triángulo es de {area} u^2.");
            }
            Console.ReadLine();
        }

        static void Bisiesto()
        {
            Console.WriteLine("Ingresa el año que deseas calcular:");
            int x = int.Parse(Console.ReadLine());

            if (x % 400 == 0)
            {
                Console.WriteLine("El año es bisiesto.");
            }
            else if (x % 4 == 0 && x % 100 != 0)
            {
                Console.WriteLine("El año es bisiesto.");
            }
            else
            {
                Console.WriteLine("El año no es bisiesto.");
            }
            Console.ReadLine();
        }

        static void Calculadora()
        {
            Console.WriteLine("Ingresa el primer número:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo número:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la operación a realizar:");
            Console.WriteLine("(1) Suma\n(2) Resta\n(3) Multiplicación\n(4) División\n(5) Módulo");
            string op = Console.ReadLine();

            float resultado = 0;
            switch (op)
            {
                default: Console.WriteLine("No se pudo realizar una operación."); break;
                case "1": resultado = x + y; Console.WriteLine($"La suma de {x} y {y} es {resultado}."); break;
                case "2": resultado = x - y; Console.WriteLine($"La diferencia entre {x} y {y} es {resultado}."); break;
                case "3": resultado = x * y; Console.WriteLine($"El producto de {x} y {y} es {resultado}."); break;
                case "4": resultado = x / y; Console.WriteLine($"El resultado de {x} / {y} es {resultado}."); break;
                case "5": resultado = x % y; Console.WriteLine($"El módulo entre {x} y {y} es {resultado}."); break;
            }
            Console.ReadLine();
        }
    }
}
