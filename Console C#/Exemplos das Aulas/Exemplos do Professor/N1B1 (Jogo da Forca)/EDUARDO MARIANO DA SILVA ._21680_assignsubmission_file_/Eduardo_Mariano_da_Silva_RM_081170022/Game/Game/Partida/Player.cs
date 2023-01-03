using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Player
    {
        public int life;

        public Player()
        {
            life = 6;
        }

        /// <summary>
        /// Infere dano ao jogador
        /// </summary>
        /// <param name="dmg">quantidade de dano</param>
        public void Damage(int dmg)
        {
            life -= dmg;
            if (life == 0)
            {
                Program.Game.Finale();
            }
        }

    }
}
