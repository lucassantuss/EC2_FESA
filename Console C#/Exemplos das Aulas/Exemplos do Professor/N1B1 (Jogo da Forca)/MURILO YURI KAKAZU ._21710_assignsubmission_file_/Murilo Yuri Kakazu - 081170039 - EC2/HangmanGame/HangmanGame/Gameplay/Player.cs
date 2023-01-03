using HangmanGame.ExceptionHandling;
using HangmanGame.Generic;
using HangmanGame.Serialization.Extensions;
using System;

namespace HangmanGame.Gameplay
{
    public class Player
    {
        #region Properties
        public byte Health { get; protected set; }
        protected Collection<Attempt> Attempts { get; set; }
        public bool IsAlive { get { return (Health > 0); } }
        public bool HasWon { get; protected set; }
        public Character Character { get; protected set; }
        #endregion

        #region Methods

        #region ctor
        /// <summary>
        /// ctor.
        /// </summary>
        /// <param name="initialHealth">Quantidade de vida inicial</param>
        public Player(byte initialHealth)
        {
            Attempts = new Collection<Attempt>();
            Health = initialHealth;
            Character = new Character();
            RefreshCharacter();
        }
        #endregion

        /// <summary>
        /// Retira uma quantia de vida do jogador.
        /// </summary>
        /// <param name="amount">Quantia a ser retirada</param>
        public void Damage(byte amount)
        {
            Health -= amount;

            RefreshCharacter();

            if (Health <= 0)
                Kill();
        }

        /// <summary>
        /// Mata instantaneamente o jogador, definindo sua vida como 0.
        /// </summary>
        public void Kill()
        {
            Health = 0;
            RefreshCharacter();
        }

        /// <summary>
        /// Adiciona uma nova tentativa de jogo à lista de tentativas do jogador.
        /// </summary>
        /// <param name="c">Letra tentada</param>
        /// <param name="correct">True: a tentativa está correta. False: a tentativa está errada</param>
        public void AddAttempt(char c, bool correct)
        {
            Attempts.Add(new Attempt() { Char = c, IsCorrect = correct });
        }

        /// <summary>
        /// Retorna todas as tentativas do jogador, em forma de array
        /// </summary>
        /// <returns></returns>
        public Attempt[] GetAllAttempts()
        {
            return Attempts.ToArray();
        }

        /// <summary>
        /// Renova o jogador, reiniciando todas as suas propriedades
        /// </summary>
        /// <param name="health">Quantia de vida inicial</param>
        public void Reset(byte health)
        {
            HasWon = false;
            Health = health;
            RefreshCharacter();
            Attempts.Clear();
        }

        /// <summary>
        /// Faz com que o jogador ganhe a partida
        /// </summary>
        public void Save()
        {
            HasWon = true;
            RefreshCharacter();
        }

        /// <summary>
        /// Atualiza as informações do personagem do jogador
        /// </summary>
        protected void RefreshCharacter()
        {
            Character.Dispose();

            if (!HasWon)
                Character = Character.FromXML("db/characters/" + Health + ".xml");
            else
                Character = Character.FromXML("db/characters/happy.xml");
        }

        /// <summary>
        /// Libera os recursos utilizados na memória.
        /// </summary>
        public void Dispose()
        {
            try
            {
                Character.Dispose();
                Attempts.Clear();

                foreach (var item in Attempts)
                    item.Dispose();

                Attempts = null;
            }
            catch (Exception e)
            {
                ErrorLog.Append(e);
            }
        }
        #endregion
    }
}
