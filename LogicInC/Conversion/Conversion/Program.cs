using System;

namespace Conversion {
    class Program {
        static void Main(string[] args) {
            double a;
            float b;
            int c;

            a = 5.1;
            b = (float)a;
            c = (int)a;

            Console.WriteLine("Casting Double para Float: " + b);
            Console.WriteLine("casting Double para Int: " + c);

            int d = 5;
            int e = 2;

            double resultado = (double)d / e; // Divisão inteira
            Console.WriteLine("Casting de divisaão de inteiros: " + resultado);
        }
    }
}