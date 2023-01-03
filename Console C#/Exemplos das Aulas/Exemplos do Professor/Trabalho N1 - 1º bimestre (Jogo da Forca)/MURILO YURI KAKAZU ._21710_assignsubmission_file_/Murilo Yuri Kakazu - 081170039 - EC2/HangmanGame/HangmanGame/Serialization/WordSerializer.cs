using HangmanGame.ExceptionHandling;
using HangmanGame.Gameplay;
using System;
using System.IO;

namespace HangmanGame.Serialization
{
    /// <summary>
    /// Serializa e Desserializa objetos do tipo Word
    /// </summary>
    public static class WordSerializer
    {
        /// <summary>
        /// Lê e retorna um conjunto de instâncias do objeto Word a partir de um arquivo
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        /// Runtime: ~2ms
        public static Word[] Deserialize(string path)
        {
            try
            {
                Word[] words;
                string[] lines = File.ReadAllLines(path);
                int wordCount = 0;

                for (int i = 0; i < lines.Length; i++)
                    if (lines[i].Contains("P:"))
                        wordCount++;

                words = new Word[wordCount];

                int line = 1;
                for (int i = 0; i < words.Length; i++)
                {
                    int hints = 0;

                    while (true)
                    {
                        if ((line + 1) > lines.Length || lines[line++].Contains("P:"))
                            break;

                        hints++;
                    }

                    words[i].Hints = new Hint[hints];
                }

                line = 0;
                for (int i = 0; i < words.Length; i++)
                {
                    words[i].Text = lines[line++].Replace("P:", "").ToUpper();
                    words[i].Letters = new Letter[words[i].Text.Length];

                    for (int j = 0; j < words[i].Letters.Length; j++)
                        words[i].Letters[j].Char = char.ToUpper(words[i].Text[j]);

                    for (int j = 0; j < words[i].Hints.Length; j++)
                        words[i].Hints[j].Text = lines[line++].Replace("D:", "").ToUpper();
                }

                return words;
            }
            catch (Exception e)
            {
                ErrorLog.Append(e);
                return null;
            }
        }

        #region Old Code
        ///* Código abaixo removido por ser de difícil manutenção e leitura *///
        /// Runtime: ~6ms

        //public static Word[] Deserialize(string path)
        //{
        //    try
        //    {
        //        Collection<Word> words = new Collection<Word>();
        //        StreamReader reader = new StreamReader(path);
        //        string line;

        //        while ((line = reader.ReadLine()) != null)
        //        {
        //            Collection<Letter> letters = new Collection<Letter>();
        //            Collection<Hint> hints = new Collection<Hint>();
        //            Word w = new Word() { Text = line.Substring(2, line.Length - 2) };

        //            foreach (char c in w.Text)
        //                letters.Add(new Letter() { Char = c, Visible = false });
        //            w.Letters = letters.ToArray();

        //            while (reader.Peek() != 80 && (line = reader.ReadLine()) != null && line.StartsWith("D:")) // 80 = letra P
        //                hints.Add(new Hint() { Text = line.Substring(2, line.Length - 2), Visible = false });
        //            w.Hints = hints.ToArray();

        //            letters = null;
        //            hints = null;

        //            words.Add(w);
        //        }

        //        reader.Dispose();

        //        return words.ToArray();
        //    }
        //    catch (Exception e)
        //    {
        //        ErrorLog.Append(e);
        //        return null;
        //    }
        //}
        #endregion
    }
}
