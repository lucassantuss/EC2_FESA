using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Partida.Serialization
{
    public static class Serializer
    {
        /// <summary>
        /// Carrega todas as palavras e dicas do arquivo de texto
        /// </summary>
        /// <param name="arquivo">Nome do arquivo</param>
        /// <returns>Retorna um array de palavras</returns>
        public static Word[] CarregarTodasAsPalavras(string arquivo)
        {
            StreamReader sr = new StreamReader(arquivo);

            int contagemPalavras = 0;

            string[] split = sr.ReadToEnd().Split('P');

            foreach (string s in split)
                if (s.StartsWith(":"))
                    contagemPalavras++;

            Word[] palavras = new Word[contagemPalavras];

            for (int i = 0; i < contagemPalavras; i++)
            {
                palavras[i] = new Word();
                int contagemDicas = 0;

                sr = new StreamReader(arquivo);
                string line = "";
                int pFound = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("P:"))
                        pFound++;

                    if (pFound - 1 == i)
                    {
                        palavras[i].Text = line.Substring(2, line.Length - 2);
                        break;
                    }
                }

                string hString = "";

                while ((line = sr.ReadLine()) != null && line.Contains("D:"))
                {
                    contagemDicas++;
                    hString += line.Substring(2, line.Length - 2) + "|";
                }

                Hints[] dicas = new Hints[contagemDicas];

                int lastIndex = 0;
                for (int j = 0; j < contagemDicas; j++)
                {
                    dicas[j] = new Hints();
                    dicas[j].text = hString.Substring(lastIndex, hString.IndexOf("|") - lastIndex);
                    lastIndex = hString.IndexOf("|");
                    hString = hString.Remove(lastIndex, 1);
                    dicas[j].visible = false;
                }

                palavras[i].Hint = dicas;

                palavras[i].Letter = new Letters[palavras[i].Text.Length];

                for (int j = 0; j < palavras[i].Text.Length; j++)
                {
                    Letters l = new Letters();
                    l.Char = palavras[i].Text[j];
                    l.visible = false;
                    palavras[i].Letter[j] = l;
                }
            }

            return palavras;
        }

        /// <summary>
        /// Seleciona as musicas na pasta correta
        /// </summary>
        /// <param name="pasta">Caminho da pasta</param>
        /// <returns>retorna um array de musicas</returns>
        public static Music[] PegarMusicas(string pasta)
        {
            string[] array = Directory.GetFiles(pasta);
            Music[] musicas = new Music[array.Length];
            for (int i = 0; i < musicas.Length; i++)
            {
                musicas[i] = new Music();
                musicas[i].Source = array[i];
            }
                return musicas;
        }
    }
}
