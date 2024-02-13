using System;
using System.Globalization;

namespace ExercicioSecao5 {
    class Program {
        static void Main(string[] args) {
            
            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
                if (resp == 's' || resp == 'S') {
                    Console.Write("Entre o valor de depósito inicial: ");
                    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta = new ContaBancaria(numero, titular, depositoInicial);
                } else {
                    conta = new ContaBancaria(numero, titular);
                }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: " + conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: " + conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine() ,CultureInfo.InvariantCulture);
                if (quantia > 0.00) {
                    conta.Saque(quantia);
                    Console.WriteLine("Dados da conta atualizados: " + conta);
                } else {
                    Console.WriteLine("Dados da conta atualizados: " + conta);     
                }

        }
    }
}