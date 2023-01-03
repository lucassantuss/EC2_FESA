namespace HangmanGame.Gameplay
{
    public struct Word
    {
        #region Properties
        public string Text { get; set; }
        public Letter[] Letters { get; set; }
        public Hint[] Hints { get; set; }
        /// <summary>
        /// Retorna se todas as dicas foram reveladas
        /// </summary>
        public bool RevealedAllHints
        {
            get
            {
                foreach (var hint in Hints)
                    if (hint.Visible == false)
                        return false;
                return true;
            }
        }
        /// <summary>
        /// Retorna se todas as letras foram reveladas
        /// </summary>
        public bool RevealedAllLetters
        {
            get
            {
                foreach (var letter in Letters)
                    if (!letter.Visible)
                        return false;
                return true;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Retorna se uma letra já foi revelada na palavra
        /// </summary>
        /// <param name="c">Letra a ser verificada</param>
        /// <returns></returns>
        public bool HasRevealedLetter(char c)
        {
            if (!HasLetter(c))
                return false;

            foreach (var letter in Letters)
                if (char.ToUpper(letter.Char) == char.ToUpper(c) && letter.Visible == false)
                    return false;
            return true;

        }

        /// <summary>
        /// Retorna se a palavra contém uma letra
        /// </summary>
        /// <param name="c">Letra a ser verificada</param>
        /// <returns></returns>
        public bool HasLetter(char c)
        {
            foreach (var letter in Letters)
                if (char.ToUpper(letter.Char) == char.ToUpper(c))
                    return true;
            return false;
        }

        /// <summary>
        /// Revela uma letra na palavra
        /// </summary>
        /// <param name="c">Letra a ser revelada</param>
        public void RevealLetter(char c)
        {
            for (int i = 0; i < Letters.Length; i++)
                if (char.ToUpper(Letters[i].Char) == char.ToUpper(c))
                    Letters[i].Visible = true;
        }

        /// <summary>
        /// Revela uma dica na palavra
        /// </summary>
        public void RevealAnotherHint()
        {
            for (int i = 0; i < Hints.Length; i++)
                if (!Hints[i].Visible)
                {
                    Hints[i].Visible = true;
                    return;
                }
        }

        /// <summary>
        /// Reinicia a palavra, tornando suas letras e dicas invisíveis
        /// </summary>
        public void Reset()
        {
            for (int i = 0; i < Letters.Length; i++)
                Letters[i].Visible = false;
            for (int i = 0; i < Hints.Length; i++)
                Hints[i].Visible = false;
        }

        /// <summary>
        /// Libera os recursos utilizados na memória
        /// </summary>
        public void Dispose()
        {
            Text = null;
            foreach (var item in Letters)
                item.Dispose();
            foreach (var item in Hints)
                item.Dispose();
            Letters = null;
            Hints = null;
        }
        #endregion
    }
}
