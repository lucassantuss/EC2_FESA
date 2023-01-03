namespace HangmanGame.Gameplay
{
    public struct Letter
    {
        public char Char { get; set; }
        public bool Visible { get; set; }


        /// <summary>
        /// Libera os recursos utilizados na memória.
        /// </summary>
        public void Dispose()
        {
            Char = default(char);
        }
    }
}
