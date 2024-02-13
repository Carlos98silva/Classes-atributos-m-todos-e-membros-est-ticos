using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade) {
                Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            } else {
                Console.WriteLine("Pessoa mais velha " + p2.Nome);
            }

            Media p3 = new Media();
            Media p4 = new Media();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            p3.Nomefunc = Console.ReadLine();
            Console.Write("Salário: ");
            p3.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            p4.Nomefunc = Console.ReadLine();
            Console.Write("Salário: ");
            p4.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double medio = (p3.Salario + p4.Salario) / 2.0;
            Console.WriteLine("Salário médio = " + medio.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}