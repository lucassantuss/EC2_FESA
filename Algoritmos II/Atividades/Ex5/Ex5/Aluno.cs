using System;
using System.Collections.Generic;
using System.Text;

namespace Ex5
{
    class Aluno
    {
        private string nome;
        private double nota1;
        private double nota2;

        #region Propriedades - Nome
        public string Nome
        {
            get => nome;

            set
            {
                int cont = 0;

                foreach (char x in value)
                {
                    if (x.ToString() == " ")
                    {
                        cont++;
                    }
                }

                if (cont == 0)
                {
                    throw new Exception("\nDigite um nome e sobrenome!!");
                }
                else
                {
                    nome = value;
                }
            }
        }
        #endregion

        #region Propriedades - Nota 1
        public double Nota1
        {
            get => nota1;

            set
            {
                if (value >= 0 && value <= 10)
                    nota1 = value;
                else
                    throw new Exception("\nDigite uma nota entre 0 a 10");
            }
        }
        #endregion

        #region Propriedades - Nota 2
        public double Nota2
        {
            get => nota2;

            set
            {
                if (value >= 0 && value <= 10)
                    nota2 = value;
                else
                    throw new Exception("\nDigite uma nota entre 0 a 10");
            }
        }
        #endregion

        #region Propriedades - Média
        public double Media
        {
            get => (nota1 + nota2) / 2;
        }
        #endregion
    }
}