namespace HangmanGame.Gameplay
{
    public struct Character
    {
        public byte ID { get; set; }
        public string Source { get; set; }

        /// <summary>
        /// Libera os recursos utilizados na memória.
        /// </summary>
        public void Dispose()
        {
            ID = default(byte);
            Source = null;
        }
    }
}
