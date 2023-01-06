using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex24_DevolveOutStruct
{
    internal class Program
    {
        #region Enunciado
        /* 24
         * 
         * Faça um método que receba um vetor de inteiros e ele deverá devolver:
         * 
         * •	a média dos elementos do vetor.
         * •	a soma
         * •	o maior valor
         * •	o menor valor
         * 
         * Faça duas versões do método: uma que devolve uma estrutura e outra que devolve por parâmetro de referência.
         */
        #endregion

        struct Devolução
        {
            public double media;
            public int soma, maior, menor;
        }

        #region Programa Principal
        static void Main(string[] args)
        {
            double media;
            int soma, maior, menor;
            int[] vetInt = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Chama o método que usa o ref
            DevolverResultadosOUT(vetInt, out media, out soma, out maior, out menor);

            // Passa para a variável struct os dados obtidos no método usando struct
            Devolução dados = DevolverResultadosSTRUCT(vetInt);

            // Exibe com REF
            Console.WriteLine($"Média: {media}\nSoma: {soma}\nMaior: {maior}\nMenor: {menor}\n");

            // Exibe com STRUCT
            Console.WriteLine($"Média: {dados.media}\nSoma: {dados.soma}\nMaior: {dados.maior}\nMenor: {dados.menor}");

            Console.ReadKey();
        }
        #endregion

        #region Devolver Resultados por Parâmetro
        static void DevolverResultadosOUT(int[] vetInt,
                                          out double media,
                                          out int soma,
                                          out int maior,
                                          out int menor)
        {
            soma = 0;
            maior = vetInt[0];
            menor = vetInt[0];

            foreach (int pos in vetInt)
            {
                soma += pos;

                if (pos > maior)
                {
                    maior = pos;
                }

                if (pos < menor)
                {
                    menor = pos;
                }
            }

            media = soma / vetInt.Length;
        }
        #endregion

        #region Devolver Resultados usando STRUCT
        static Devolução DevolverResultadosSTRUCT(int[] vetInt)
        {
            Devolução retorno = new Devolução();

            int aux = 0;

            retorno.maior = vetInt[0];
            retorno.menor = vetInt[0];

            foreach (int pos in vetInt)
            {
                retorno.soma = aux + pos;
                aux = retorno.soma;

                if (pos > retorno.maior)
                {
                    retorno.maior = pos;
                }

                if (pos < retorno.menor)
                {
                    retorno.menor = pos;
                }
            }

            retorno.media = retorno.soma / vetInt.Length;

            return retorno;
        }
        #endregion
    }
}