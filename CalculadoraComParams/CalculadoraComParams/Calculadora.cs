using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraComParams
{
    class Calculadora
    {
        // Funcao sem params lhe obriga a instanciar o vetor 
        // toda vez que for usá-lo na main ou em outro lugar
        //public static int Soma(int[] numeros)
        //{
        //    int soma = 0;
        //    for (int i = 0; i < numeros.Length; i++)
        //    {
        //        soma += numeros[i];
        //    }
        //    return soma;
        //}

        // usando o params, não precisamos instanciar o 
        // vetor todaz vez que for usá-lo, pois neste 
        // caso temos um valor infinito de possibilidades
        // de tamanho do vetor
        public static int Soma(params int[] numeros) // incrivel: basta colocar a palavra "params", só isso!
        {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }
            return soma;
        }
    }
}
