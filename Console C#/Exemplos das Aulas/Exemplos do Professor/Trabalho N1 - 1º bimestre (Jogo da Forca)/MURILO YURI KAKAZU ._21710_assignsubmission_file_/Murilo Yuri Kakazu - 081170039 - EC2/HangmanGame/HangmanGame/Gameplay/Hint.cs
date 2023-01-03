namespace HangmanGame.Gameplay
{
    public struct Hint
    {
        public string Text { get; set; }
        public bool Visible { get; set; }

        /// <summary>
        /// Libera os recursos utilizados na memória.
        /// </summary>
        public void Dispose()
        {
            Text = null;
        }
    }
}
