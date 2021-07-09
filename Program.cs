using System;

namespace CalculadoraInversa
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese uno de estos signos (+,-,*,/,^,%)");
            string signo = Console.ReadLine();
            double total = 0;
            switch (signo)
            {
                case "+": total = num1 + num2; break;
                case "-": total = num1 - num2; break;
                case "*": total = num1 * num2; break;
                case "/": total = (double)num1 / (double)num2; break;
                case "^":
                    total = Math.Pow(num1, num2); break;
                case "%": total = num1 % num2; break;
                default:
                    Console.WriteLine("Opcion incorrecta."); break;
            }
            string resultado = num1 + signo + num2 + " = " + total;

            Console.WriteLine(resultado);
        }
    }
}
