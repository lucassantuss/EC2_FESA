using System;

namespace DESAFIO_SEQUÊNCIA
{
    class Program
    { /*Dado um nº inicial, calcule N sequências, onde o usuário irá escolher o número e o valor de N.

        EX:
        1
        11
        21
        1211
        111221
        312211

        No exemplo acima há 6 sequências (linhas).
        A lógica para criar uma nova sequência é a seguinte: com base na última, contam-se os caracteres iguais que
        aparecem em sequência. Então, coloca-se a quantidade de caracteres seguidos do caractere que estava sendo
        analisado. Sendo assim, no exemplo acima o valor da próxima linha, tomando como base a última linha gerada até
        então (312211) será:
        (1 caractere 3, 1 caractere 1, 2 caracteres 2, 2 caracteres 1): 13112221.
        Vale ressaltar que o primeiro elemento da sequência sempre será composto por apenas um caractere alfanumérico.
        */

        static void Main(string[] args)
        {
            int contador = 0;
            string numQualquer = "";
            //solicita um número inicial
            
                Console.WriteLine("Digite um nº inicial: ");
                numQualquer = Console.ReadLine();
          
            //solicita número de sequência
            Console.WriteLine("Valor de sequência: ");
            int numSequencia = int.Parse(Console.ReadLine());

            //Primeiro valor.
            Console.WriteLine($"\nSequencia:\n{numQualquer}");

            //Laço passando por todos da sequência
            for (int i = 0; i < numSequencia - 1; i++)
            {
                char primeiraLetra = numQualquer[0];
                string saida = "";
                contador = 0;

                //varre caracter por caracter
                foreach (char letra in numQualquer)
                {
                    if (letra == primeiraLetra)
                    {
                        contador++;
                    }
                    else
                    {
                        saida += contador.ToString() + primeiraLetra ;
                        primeiraLetra = letra;
                        contador = 1;
                    }

                }

                saida += contador.ToString() + primeiraLetra;
                numQualquer = saida;

                
                Console.WriteLine($"\n{saida}\n");

            }


        }
    }
}
