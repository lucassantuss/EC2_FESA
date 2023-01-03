namespace HangmanGame.Gameplay
{
    public struct Attempt
    {
        public char Char { get; set; }
        public bool IsCorrect { get; set; }

        /// <summary>
        /// Libera os recursos utilizados na memória.
        /// </summary>
        public void Dispose()
        {
            Char = default(char);
        }
    }
}
