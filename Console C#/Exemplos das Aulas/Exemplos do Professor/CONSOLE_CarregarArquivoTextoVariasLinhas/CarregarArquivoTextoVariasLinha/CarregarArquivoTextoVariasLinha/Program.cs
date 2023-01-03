using System;
using System.IO;
using System.Text;

namespace CarregarArquivoTextoVariasLinha
{
    class Program
    {
        static void Main(string[] args)
        {
            //vamos salvar esse arquivo no C:\ com quebras de linha:

            string conteudo =
                "isso está em uma linha " + Environment.NewLine +
                "isso está na próxima linha" + Environment.NewLine +
                "isso está na última linha";

            File.WriteAllText("dados.txt", conteudo, Encoding.UTF8);


            string[] vetor = {"primeira linha",
                             "segunda linha",
                             "Terceira linha"};

            File.WriteAllLines("dadosVetor.txt", vetor,  Encoding.UTF8);




            if (File.Exists("dados.txt"))
            {
                string[] linhas = File.ReadAllLines("dados.txt", Encoding.UTF8);

                for (int n = 0; n < linhas.Length; n++)
                    Console.WriteLine(linhas[n].ToUpper());

                /*Console.WriteLine(" o mesmo código acima mas com foreach");
                                
                foreach (string valor in linhas)
                    Console.WriteLine(valor); */

                Console.ReadLine();
            }
        }
    }
}
