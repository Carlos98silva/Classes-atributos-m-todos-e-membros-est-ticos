using System;
using System.Globalization;

namespace ExercicioFuncionario {
    class Funcionario {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double salariobruto) {
            SalarioBruto = ((SalarioBruto * salariobruto) / 100) + SalarioBruto;
        }

        public override string ToString() {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
