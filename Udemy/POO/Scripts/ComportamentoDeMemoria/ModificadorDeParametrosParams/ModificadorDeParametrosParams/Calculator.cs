using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorDeParametrosParams {
    internal class Calculator {

        // Calculadora com vetor, o params diz que pode receber uma funcao com uma quantidade variavel de valores
        public static int Sum(params int[] numbers) {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }

    }
}
