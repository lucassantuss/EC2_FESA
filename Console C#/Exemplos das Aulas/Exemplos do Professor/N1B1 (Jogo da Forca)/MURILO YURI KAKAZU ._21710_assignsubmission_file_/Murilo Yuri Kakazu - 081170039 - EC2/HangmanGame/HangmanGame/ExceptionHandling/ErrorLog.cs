using System;
using System.IO;

namespace HangmanGame.ExceptionHandling
{
    public static class ErrorLog
    {
        /// <summary>
        /// Serializa e adiciona uma instância de exceção ao log de erros.
        /// </summary>
        /// <param name="e"></param>
        public static void Append(Exception e)
        {
            StreamWriter writer = new StreamWriter("logs/errors.txt", append: true);
            writer.WriteLine(DateTime.Now + ":");
            writer.WriteLine(e);
            writer.WriteLine(new string('-', 20));
            writer.Close();
        }
    }
}
