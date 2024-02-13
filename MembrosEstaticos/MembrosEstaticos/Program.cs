using Course;
using System;
using System.Globalization;

namespace MembrosEstaticos {
    class Program {
        static void Main(string[] args) {

            Console.Write("Qual é a cotação do dólar? ");
            ConversorDeMoeda.dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            ConversorDeMoeda.compra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valor = ConversorDeMoeda.Cotacao();

            Console.WriteLine("Valor a ser pago = " + valor.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}