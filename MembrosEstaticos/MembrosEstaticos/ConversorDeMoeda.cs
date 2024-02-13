using System;
using System.Globalization;

namespace Course {
    class ConversorDeMoeda {

        public static double dolar, compra;
        public static double iof = 0.06;

        public static double Cotacao() {
            return (dolar * compra) + (dolar * compra * iof);
        }
    }
}
