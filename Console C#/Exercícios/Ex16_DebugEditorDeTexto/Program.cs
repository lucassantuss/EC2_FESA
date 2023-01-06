using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Ex16_DebugEditorDeTexto
{
    internal class Program
    {
        #region Enunciado
        /* 16. Editor de texto
         * 
         * O objetivo do programa a seguir é ir acumulando os textos digitados
         * cada vez que o usuário pressiona a tecla Enter.
         * 
         * Caso o texto digitado seja “sair” o programa deveria salvar
         * todo o texto digitado em um arquivo chamado “dados.txt” e fechar o programa.
         * 
         * Caso o programa seja aberto novamente e caso o arquivo “dados.txt” exista,
         * seu conteúdo deveria ser exibido antes que novos textos sejam solicitados novamente.
         * 
         * O programa apresenta uma série de problemas.
         * Ele logo de cara já exibe um erro se o arquivo não existir.
         * Ele também não está saindo ao digitar “sair” além não acumular as informações digitadas.
         * 
         * Tentei consertar, mas só piorei as coisas e agora ele não está mais nem compilando... :(
         */
        #endregion

        #region Programa Principal
        static void Main(string[] args)
        {
            if (File.Exists("dados.txt"))
            {
                string dadosNoDisco = File.ReadAllText("dados.txt");
                Console.WriteLine(dadosNoDisco);
            }

            string conteudo = "";
            string palavra;

            do
            {
                palavra = Console.ReadLine();

                if (palavra.ToUpper() != "SAIR")
                    conteudo += Environment.NewLine + palavra;
            }
            while (palavra.ToUpper() != "SAIR");

            File.WriteAllText("dados.txt", conteudo);
        }
        #endregion
    }
}