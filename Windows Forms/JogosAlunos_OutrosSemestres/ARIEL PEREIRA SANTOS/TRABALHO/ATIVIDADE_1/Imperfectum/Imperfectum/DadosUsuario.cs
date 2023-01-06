using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imperfectum
{
    class DadosUsuario
    {
        public static Usuario[] usuarios;
        public static void CarregaArquivo()
        {
            string[] linhas = File.ReadAllLines("cadastros.txt");
            usuarios = new Usuario[linhas.Length];
            for (int c = 0; c < linhas.Length; c++)
            {
                string[] dados = linhas[c].Split('|');
                Usuario p = new Usuario();
                p.user = dados[0];
                p.senha = dados[1];
                usuarios[c] = p;
            }
        }
        public static void CarregaAtual()
        {
            string[] linhas = File.ReadAllLines("JogadorAtual.txt");
            usuarios = new Usuario[linhas.Length];
            for (int c = 0; c < linhas.Length; c++)
            {
                string[] dados = linhas[c].Split('|');
                Usuario p = new Usuario();
                p.user = dados[0];
                p.pontos = int.Parse(dados[1]);
                p.dificuldade = dados[2];
                p.musica = bool.Parse(dados[3]);
                p.cheat = bool.Parse(dados[4]);
                usuarios[c] = p;
            }
        }
        public static Usuario[] CarregaHall()
        {
            string[] linhas = File.ReadAllLines("ranking.txt");
            Usuario[] guerreiros = new Usuario[linhas.Length];
            usuarios = new Usuario[linhas.Length];
            int[] pontos = new int[linhas.Length];
            for (int c = 0; c < linhas.Length; c++)
            {
                string[] dados = linhas[c].Split('|');
                Usuario p = new Usuario();
                p.user = dados[0];
                p.pontos = int.Parse(dados[1]);
                p.dificuldade = dados[2];
                usuarios[c] = p;
                pontos[c] = p.pontos;
            }
            Array.Sort(pontos);
            Array.Reverse(pontos);
            for(int c = 0; c < linhas.Length; c++)
            {
                foreach(Usuario u in usuarios)
                {
                    if (pontos[c] == u.pontos)
                        guerreiros[c] = u;
                }
            }
            return guerreiros;
        }
    }
}
