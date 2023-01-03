using HangmanGame.ExceptionHandling;
using System;

namespace HangmanGame.Events.Input
{
    #region EventHandler
    public delegate void KeyPressedEventHandler(object sender, InputArgs args);
    #endregion

    public static class InputHandler
    {
        #region Properties
        public static event KeyPressedEventHandler KeyPressed;
        #endregion

        #region Methods

        #region Events
        /// <summary>
        /// Evento a ser disparado quando uma entrada de usuário é recebida.
        /// </summary>
        /// <param name="args"></param>
        static void OnKeyPressed(InputArgs args)
        {
            KeyPressed(null, args);
        }
        #endregion

        /// <summary>
        /// Pede ao usuário uma nova entrada.
        /// </summary>
        public static void GetInput()
        {
            try
            {
                OnKeyPressed(new InputArgs(Console.ReadKey()));
            }
            catch (Exception e)
            {
                ErrorLog.Append(e);
            }
        }
        #endregion
    }
}
