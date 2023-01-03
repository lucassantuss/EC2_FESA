using System;

namespace HangmanGame.Events.Input
{
    public class InputArgs
    {
        public ConsoleKeyInfo KeyInfo { get; private set; }

        /// <summary>
        /// ctor.
        /// </summary>
        /// <param name="info">Informações de entrada de usuário</param>
        public InputArgs(ConsoleKeyInfo info)
        {
            KeyInfo = info;
        }
    }
}
