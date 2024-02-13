using System; // Importação de dependências.

namespace ClassTriângulo {  //Namespace da classe..
    class Triangulo { // Nome da classe.

        public double A;
        public double B; // Atributos da classe, prefixo 'public' indica que o atributo ou método pode ser usado em outros arquivos.
        public double C;

        public double Area() { // Nome do método ou função = "Area"; e lista de parâmetros do método = "()"
            double p = (A + B + C) / 2.0;
            return  Math.Sqrt(p * (p - A) * (p - B) * (p - C)); // Corpo do método
        }
    }
}
