using ExercicioFuncionario;
using System;
using System.Globalization;

namespace Exercicio2 {
    class Program {
        static void Main(string[] args) {

            Funcionario p = new Funcionario();

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            p.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            p.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            Console.WriteLine();
            Console.Write("Funcionário: " + p);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.AumentarSalario(aumento);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}