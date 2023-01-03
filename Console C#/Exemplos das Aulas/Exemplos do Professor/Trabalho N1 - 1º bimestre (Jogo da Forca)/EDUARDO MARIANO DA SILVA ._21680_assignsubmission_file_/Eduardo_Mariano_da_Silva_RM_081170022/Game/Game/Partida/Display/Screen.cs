using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Partida.Display
{
    public static class Screen
    {
        public static bool PreventUsage { get; set; }

        /// <summary>
        /// Printa todas as informações na tela
        /// </summary>
        public static void PrintgameInfo()
        {
            if (!PreventUsage)
            {
                try
                {
                    PreventUsage = true;
                    Console.Clear();
                    PrintInfRefences();
                    PrintTime();
                    PrintPlayer(Jogo.Player.life);
                    PrintDiv(149);
                    PrintWordRefences();
                    PrintHintReference();
                    PrintDiv(149);
                    if (Jogo.Player.life == 0)
                        Program.Game.Finale();
                    PreventUsage = false;
                }
                catch (Exception e)
                {
                    PreventUsage = false;
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// Printa as Informações de ajuda na tela
        /// </summary>
        public static void PrintInfRefences()
        {
            PrintInf();
            PrintDiv(149);
            Console.WriteLine();
        }

        /// <summary>
        /// printa tudo referente a palavra na tela
        /// </summary>
        public static void PrintWordRefences()
        {
            Console.Write(printSpace((Console.WindowWidth - "----- PALAVRA -----".Length) / 2));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----- PALAVRA -----");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(printSpace((Console.WindowWidth - Program.Game.CurrentWord.Text.Length * 2) / 2));
            PrintWord();
            Console.WriteLine();
            Console.WriteLine();
            PrintDiv(149);

        }

        /// <summary>
        /// printa tudo referente as dicas na tela
        /// </summary>
        public static void PrintHintReference()
        {
            Console.Write(printSpace((Console.WindowWidth - "----- DICA -----".Length) / 2));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----- DICA -----");
            Console.WriteLine();
            PrintHint();
        }


        /// <summary>
        /// Printa a palavras mascarada
        /// </summary>
        private static void PrintWord()
        {
            for (int i = 0; i < Program.Game.CurrentWord.Text.Length; i++)
            {
                if (Program.Game.CurrentWord.Letter[i].visible == true)
                {
                    Console.Write(Program.Game.CurrentWord.Letter[i].Char + " ");
                    Program.Game.CurrentWord.Letter[i].visible = true;
                }
                else if (Program.Game.CurrentWord.Letter[i].Char == ' ')
                {
                    Console.Write(Program.Game.CurrentWord.Letter[i].Char + " ");
                    Program.Game.CurrentWord.Letter[i].visible = true;
                }
                else
                    Console.Write("_ ");
            }
        }

        /// <summary>
        /// Printa as dicas
        /// </summary>
        private static void PrintHint()
        {
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < Program.Game.CurrentWord.Hint.Length; i++)
            {
                if (Program.Game.CurrentWord.Hint[i].visible == true)
                {
                    Console.Write(printSpace((Console.WindowWidth - Program.Game.CurrentWord.Hint[i].text.Length) / 2));
                    Console.WriteLine(Program.Game.CurrentWord.Hint[i].text);
                }
            }
            Console.ResetColor();
        }

        /// <summary>
        /// Printa as instruções
        /// </summary>
        private static void PrintInf()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(printSpace((Console.WindowWidth - "Presione F2 para receber as dicas e F3 para Ligar/Desligar o som".Length) / 2));
            Console.WriteLine("Presione F2 para receber as dicas e F3 para Ligar/Desligar o som");

            Console.ResetColor();
        }

        /// <summary>
        /// Printa o tempo restante
        /// </summary>
        private static void PrintTime()
        {
            var time = TimeSpan.FromSeconds(Program.Game.RemainingTime).ToString(@"mm\:ss");
            Console.Write(printSpace((Console.WindowWidth - time.Length) / 2));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(time);
            Console.WriteLine();
            Console.WriteLine();
            Console.ResetColor();
        }

        /// <summary>
        /// Printa uma divisão na tela
        /// </summary>
        /// <param name="tam">quantidade de caracteres de divisão</param>
        public static void PrintDiv(int tam)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string div = new string('═', tam);
            Console.WriteLine(div);
            Console.ResetColor();
        }


        /// <summary>
        /// Printa as indicaçoes de vida conforme a vida decresce
        /// </summary>
        /// <param name="life"></param>
        public static void PrintPlayer(int life)
        {
            switch (life)
            {
                case 6:
                    Console.WriteLine(@"   ______________");
                    Console.WriteLine(@"   T              ~-._");
                    Console.WriteLine(@"   !].-----. >======- ~-._                                                                                                    ___---___ ");
                    Console.WriteLine(@"  /  | nn  |       .--.    _.                                                                                               .--         --.");
                    Console.WriteLine(@"  l__|-HH--|__  _  |__|_     ~-._                                                                                         ./   ()      .-. \.");
                    Console.WriteLine(@"  [I | nn  |  ]H T-|  | `--------^-----,---.                                                                             /   o    .   (   )  \");
                    Console.WriteLine(@"  [I_|_HH__|__]H_j-|__|_,--------------l___j                                                                            / .            '-'    \");
                    Console.WriteLine(@"  H\ | nn  |       |  |   .---- _.--~ /                                                                                | ()    .  O         .  |");
                    Console.WriteLine(@"  H=\l_HH__I__ZZ___I__I______.-~     /                                                                                |                         |");
                    Console.WriteLine(@"  H=_I_  |\.-------------,-/| |\  __/                                                                                 |    o           ()       |");
                    Console.WriteLine(@"  H[_ _) |]| [_]      HH |] | |[ ]_]                                                                                  |       .--.          O   |");
                    Console.WriteLine(@"  H==T   |/ ------------ -  -\| l/  \                                                                                  | .   |    |            |");
                    Console.WriteLine(@"  H=/|~HH~~T~~ZZ ~~T  T~~~~~~ -,_    \                                                                                  \    `.__.'    o   .  /");
                    Console.WriteLine(@"  H/_|_HH__|__  _  |__|_  `----   --._\ ___                                                                              \                   /");
                    Console.WriteLine(@"  [I | nn  |  ]H T-|  | `------------- Y   I                                                                              `\  o    ()      /'");
                    Console.WriteLine(@"  [I_| HH  |__]H_j-|__|_,--------------^---'                                                                                `--___   ___--' ");
                    Console.WriteLine(@"  I  |-nn--|       |  |      _.-~                                                                                                 ---");
                    Console.WriteLine(@"  \  | HH  |       `--'  _.-~");
                    Console.WriteLine(@"   i]`-----' >======-_,-");
                    Console.WriteLine(@"   l______________.-");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                case 5:
                    Console.WriteLine(@"   ______________");
                    Console.WriteLine(@"   T              ~-._");
                    Console.WriteLine(@"   !].-----. >======- ~-._                                                                                             ___---___ ");
                    Console.WriteLine(@"  /  | nn  |       .--.    _.                                                                                        .--         --.");
                    Console.WriteLine(@"  l__|-HH--|__  _  |__|_     ~-._                                                                                  ./   ()      .-. \.");
                    Console.WriteLine(@"  [I | nn  |  ]H T-|  | `--------^-----,---.                                                                      /   o    .   (   )  \");
                    Console.WriteLine(@"  [I_|_HH__|__]H_j-|__|_,--------------l___j                                                                     / .            '-'    \");
                    Console.WriteLine(@"  H\ | nn  |       |  |   .---- _.--~ /                                                                         | ()    .  O         .  |");
                    Console.WriteLine(@"  H=\l_HH__I__ZZ___I__I______.-~     /                                                                         |                         |");
                    Console.WriteLine(@"  H=_I_  |\.-------------,-/| |\  __/                                                                          |    o           ()       |");
                    Console.WriteLine(@"  H[_ _) |]| [_]      HH |] | |[ ]_]                                                                           |       .--.          O   |");
                    Console.WriteLine(@"  H==T   |/ ------------ -  -\| l/  \                                                                           | .   |    |            |");
                    Console.WriteLine(@"  H=/|~HH~~T~~ZZ ~~T  T~~~~~~ -,_    \                                                                           \    `.__.'    o   .  /");
                    Console.WriteLine(@"  H/_|_HH__|__  _  |__|_  `----   --._\ ___                                                                       \                   /");
                    Console.WriteLine(@"  [I | nn  |  ]H T-|  | `------------- Y   I                                                                       `\  o    ()      /'");
                    Console.WriteLine(@"  [I_| HH  |__]H_j-|__|_,--------------^---'                                                                         `--___   ___--'");
                    Console.WriteLine(@"  I  |-nn--|       |  |      _.-~                                                                                          ---");
                    Console.WriteLine(@"  \  | HH  |       `--'  _.-~");
                    Console.WriteLine(@"   i]`-----' >======-_,-");
                    Console.WriteLine(@"   l______________.-");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine(@"   ______________");
                    Console.WriteLine(@"   T              ~-._");
                    Console.WriteLine(@"   !].-----. >======- ~-._                                                                              ___---___ ");
                    Console.WriteLine(@"  /  | nn  |       .--.    _.                                                                         .--         --.");
                    Console.WriteLine(@"  l__|-HH--|__  _  |__|_     ~-._                                                                   ./   ()      .-. \.");
                    Console.WriteLine(@"  [I | nn  |  ]H T-|  | `--------^-----,---.                                                       /   o    .   (   )  \");
                    Console.WriteLine(@"  [I_|_HH__|__]H_j-|__|_,--------------l___j                                                      / .            '-'    \");
                    Console.WriteLine(@"  H\ | nn  |       |  |   .---- _.--~ /                                                          | ()    .  O         .  |");
                    Console.WriteLine(@"  H=\l_HH__I__ZZ___I__I______.-~     /                                                          |                         |");
                    Console.WriteLine(@"  H=_I_  |\.-------------,-/| |\  __/                                                           |    o           ()       |");
                    Console.WriteLine(@"  H[_ _) |]| [_]      HH |] | |[ ]_]                                                            |       .--.          O   |");
                    Console.WriteLine(@"  H==T   |/ ------------ -  -\| l/  \                                                            | .   |    |            |");
                    Console.WriteLine(@"  H=/|~HH~~T~~ZZ ~~T  T~~~~~~ -,_    \                                                            \    `.__.'    o   .  /");
                    Console.WriteLine(@"  H/_|_HH__|__  _  |__|_  `----   --._\ ___                                                        \                   /");
                    Console.WriteLine(@"  [I | nn  |  ]H T-|  | `------------- Y   I                                                        `\  o    ()      /'");
                    Console.WriteLine(@"  [I_| HH  |__]H_j-|__|_,--------------^---'                                                          `--___   ___--'");
                    Console.WriteLine(@"  I  |-nn--|       |  |      _.-~                                                                           ---");
                    Console.WriteLine(@"  \  | HH  |       `--'  _.-~");
                    Console.WriteLine(@"   i]`-----' >======-_,-    ");
                    Console.WriteLine(@"   l______________.-    ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine(@"   ______________");
                    Console.WriteLine(@"   T              ~-._");
                    Console.WriteLine(@"   !].-----. >======- ~-._                                                              ___---___ ");
                    Console.WriteLine(@"  /  | nn  |       .--.    _.                                                         .--         --.");
                    Console.WriteLine(@"  l__|-HH--|__  _  |__|_     ~-._                                                   ./   ()      .-. \.");
                    Console.WriteLine(@"  [I | nn  |  ]H T-|  | `--------^-----,---.                                       /   o    .   (   )  \");
                    Console.WriteLine(@"  [I_|_HH__|__]H_j-|__|_,--------------l___j                                      / .            '-'    \");
                    Console.WriteLine(@"  H\ | nn  |       |  |   .---- _.--~ /                                          | ()    .  O         .  |");
                    Console.WriteLine(@"  H=\l_HH__I__ZZ___I__I______.-~     /                                          |                         |");
                    Console.WriteLine(@"  H=_I_  |\.-------------,-/| |\  __/                                           |    o           ()       |");
                    Console.WriteLine(@"  H[_ _) |]| [_]      HH |] | |[ ]_]                                            |       .--.          O   |");
                    Console.WriteLine(@"  H==T   |/ ------------ -  -\| l/  \                                            | .   |    |            |");
                    Console.WriteLine(@"  H=/|~HH~~T~~ZZ ~~T  T~~~~~~ -,_    \                                            \    `.__.'    o   .  /");
                    Console.WriteLine(@"  H/_|_HH__|__  _  |__|_  `----   --._\ ___                                        \                   /");
                    Console.WriteLine(@"  [I | nn  |  ]H T-|  | `------------- Y   I                                        `\  o    ()      /'");
                    Console.WriteLine(@"  [I_| HH  |__]H_j-|__|_,--------------^---'                                          `--___   ___--'");
                    Console.WriteLine(@"  I  |-nn--|       |  |      _.-~                                                           ---");
                    Console.WriteLine(@"  \  | HH  |       `--'  _.-~");
                    Console.WriteLine(@"   i]`-----' >======-_,-    ");
                    Console.WriteLine(@"   l______________.-    ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine(@"   ______________");
                    Console.WriteLine(@"   T              ~-._");
                    Console.WriteLine(@"   !].-----. >======- ~-._                               ___---___ ");
                    Console.WriteLine(@"  /  | nn  |       .--.    _.                          .--         --.");
                    Console.WriteLine(@"  l__|-HH--|__  _  |__|_     ~-._                    ./   ()      .-. \.");
                    Console.WriteLine(@"  [I | nn  |  ]H T-|  | `--------^-----,---.        /   o    .   (   )  \");
                    Console.WriteLine(@"  [I_|_HH__|__]H_j-|__|_,--------------l___j       / .            '-'    \");
                    Console.WriteLine(@"  H\ | nn  |       |  |   .---- _.--~ /           | ()    .  O         .  |");
                    Console.WriteLine(@"  H=\l_HH__I__ZZ___I__I______.-~     /           |                         |");
                    Console.WriteLine(@"  H=_I_  |\.-------------,-/| |\  __/            |    o           ()       |");
                    Console.WriteLine(@"  H[_ _) |]| [_]      HH |] | |[ ]_]             |       .--.          O   |");
                    Console.WriteLine(@"  H==T   |/ ------------ -  -\| l/  \             | .   |    |            |");
                    Console.WriteLine(@"  H=/|~HH~~T~~ZZ ~~T  T~~~~~~ -,_    \             \    `.__.'    o   .  /");
                    Console.WriteLine(@"  H/_|_HH__|__  _  |__|_  `----   --._\ ___         \                   /");
                    Console.WriteLine(@"  [I | nn  |  ]H T-|  | `------------- Y   I         `\  o    ()      /'");
                    Console.WriteLine(@"  [I_| HH  |__]H_j-|__|_,--------------^---'           `--___   ___--'");
                    Console.WriteLine(@"  I  |-nn--|       |  |      _.-~                            ---");
                    Console.WriteLine(@"  \  | HH  |       `--'  _.-~");
                    Console.WriteLine(@"   i]`-----' >======-_,-    ");
                    Console.WriteLine(@"   l______________.-    ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                case 1:
                    Console.WriteLine(@"   ______________");
                    Console.WriteLine(@"   T              ~-._");
                    Console.WriteLine(@"   !].-----. >======- ~-._                          ___---___ ");
                    Console.WriteLine(@"  /  | nn  |       .--.    _.                     .--         --.");
                    Console.WriteLine(@"  l__|-HH--|__  _  |__|_     ~-._               ./   ()      .-. \.");
                    Console.WriteLine(@"  [I | nn  |  ]H T-|  | `--------^-----,---.   /   o    .   (   )  \");
                    Console.WriteLine(@"  [I_|_HH__|__]H_j-|__|_,--------------l___j  / .            '-'    \");
                    Console.WriteLine(@"  H\ | nn  |       |  |   .---- _.--~ /      | ()    .  O         .  |");
                    Console.WriteLine(@"  H=\l_HH__I__ZZ___I__I______.-~     /      |                         |");
                    Console.WriteLine(@"  H=_I_  |\.-------------,-/| |\  __/       |    o           ()       |");
                    Console.WriteLine(@"  H[_ _) |]| [_]      HH |] | |[ ]_]        |       .--.          O   |");
                    Console.WriteLine(@"  H==T   |/ ------------ -  -\| l/  \        | .   |    |            |");
                    Console.WriteLine(@"  H=/|~HH~~T~~ZZ ~~T  T~~~~~~ -,_    \        \    `.__.'    o   .  /");
                    Console.WriteLine(@"  H/_|_HH__|__  _  |__|_  `----   --._\ ___    \                   /");
                    Console.WriteLine(@"  [I | nn  |  ]H T-|  | `------------- Y   I    `\  o    ()      /'");
                    Console.WriteLine(@"  [I_| HH  |__]H_j-|__|_,--------------^---'      `--___   ___--'");
                    Console.WriteLine(@"  I  |-nn--|       |  |      _.-~                       ---");
                    Console.WriteLine(@"  \  | HH  |       `--'  _.-~");
                    Console.WriteLine(@"   i]`-----' >======-_,-    ");
                    Console.WriteLine(@"   l______________.-    ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                case 0:
                    #region Ultima animação
                    Console.Write(printSpace((Console.WindowWidth - @"____/ (  (    )   )  \___".Length) / 2));
                    Console.WriteLine(@"____/ (  (    )   )  \___");
                    Console.Write(printSpace((Console.WindowWidth - @"/( (  (  )   _    ))  )   )\".Length) / 2));
                    Console.WriteLine(@"/( (  (  )   _    ))  )   )\");
                    Console.Write(printSpace((Console.WindowWidth - @"((     (   )(    )  )   (   )  )".Length) / 2));
                    Console.WriteLine(@"((     (   )(    )  )   (   )  )");
                    Console.Write(printSpace((Console.WindowWidth - @"((/  ( _(   )   (   _) ) (  () )  )".Length) / 2));
                    Console.WriteLine(@"((/  ( _(   )   (   _) ) (  () )  )");
                    Console.Write(printSpace((Console.WindowWidth - @"( (  ( (_)   ((    (   )  .((_ ) .  )_".Length) / 2));
                    Console.WriteLine(@"( (  ( (_)   ((    (   )  .((_ ) .  )_");
                    Console.Write(printSpace((Console.WindowWidth - @"( (  )    (      (  )    )   ) . ) (   )".Length) / 2));
                    Console.WriteLine(@"( (  )    (      (  )    )   ) . ) (   )");
                    Console.Write(printSpace((Console.WindowWidth - @"(  (   (  (   ) (  _  ( _) ).  ) . ) ) ( )".Length) / 2));
                    Console.WriteLine(@"(  (   (  (   ) (  _  ( _) ).  ) . ) ) ( )");
                    Console.Write(printSpace((Console.WindowWidth - @"( (  (   ) (  )   (  ))     ) _)(   )  )  )".Length) / 2));
                    Console.WriteLine(@"( (  (   ) (  )   (  ))     ) _)(   )  )  )");
                    Console.Write(printSpace((Console.WindowWidth - @"( (  ( \ ) (    (_  ( ) ( )  )   ) )  )) ( )".Length) / 2));
                    Console.WriteLine(@"( (  ( \ ) (    (_  ( ) ( )  )   ) )  )) ( )");
                    Console.Write(printSpace((Console.WindowWidth - @"(  (   (  (   (_ ( ) ( _    )  ) (  )  )   )".Length) / 2));
                    Console.WriteLine(@"(  (   (  (   (_ ( ) ( _    )  ) (  )  )   )");
                    Console.Write(printSpace((Console.WindowWidth - @"( (  ( (  (  )     (_  )  ) )  _)   ) _( ( )".Length) / 2));
                    Console.WriteLine(@"( (  ( (  (  )     (_  )  ) )  _)   ) _( ( )");
                    Console.Write(printSpace((Console.WindowWidth - @"((  (   )(    (     _    )   _) _(_ (  (_ )".Length) / 2));
                    Console.WriteLine(@"((  (   )(    (     _    )   _) _(_ (  (_ )");
                    Console.Write(printSpace((Console.WindowWidth - @"(_((__(_(__(( ( ( |  ) ) ) )_))__))_)___)".Length) / 2));
                    Console.WriteLine(@"(_((__(_(__(( ( ( |  ) ) ) )_))__))_)___)");
                    Console.Write(printSpace((Console.WindowWidth - @"((__)        \\||lll|l||///          \_))".Length) / 2));
                    Console.WriteLine(@"((__)        \\||lll|l||///          \_))");
                    Console.Write(printSpace((Console.WindowWidth - @"(   /(/ (  )  ) )\   )".Length) / 2));
                    Console.WriteLine(@"(   /(/ (  )  ) )\   )");
                    Console.Write(printSpace((Console.WindowWidth - @"(    ( ( ( | | ) ) )\   )".Length) / 2));
                    Console.WriteLine(@"(    ( ( ( | | ) ) )\   )");
                    Console.Write(printSpace((Console.WindowWidth - @"(   /(| / ( )) ) ) )) )".Length) / 2));
                    Console.WriteLine(@"(   /(| / ( )) ) ) )) )");
                    Console.Write(printSpace((Console.WindowWidth - @"(     ( ((((_(|)_)))))     )".Length) / 2));
                    Console.WriteLine(@"(     ( ((((_(|)_)))))     )");
                    Console.Write(printSpace((Console.WindowWidth - @"(      ||\(|(|)|/||     )".Length) / 2));
                    Console.WriteLine(@"(      ||\(|(|)|/||     )");
                    Console.Write(printSpace((Console.WindowWidth - @"(        |(||(||)||||        )".Length) / 2));
                    Console.WriteLine(@"(        |(||(||)||||        )");
                    Console.Write(printSpace((Console.WindowWidth - @"(     //|/l|||)|\\ \     )".Length) / 2));
                    Console.WriteLine(@"(     //|/l|||)|\\ \     )");
                    Console.Write(printSpace((Console.WindowWidth - @"(/ / //  /|//||||\\  \ \  \ _)".Length) / 2));
                    Console.WriteLine(@"(/ / //  /|//||||\\  \ \  \ _)");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                    #endregion
            }

        }

        /// <summary>
        /// Printa espaços ma tela
        /// </summary>
        /// <param name="tam"></param>
        /// <returns></returns>
        public static string printSpace(int tam)
        {
            string space = new string(' ', tam);
            return space;
        }

    }
}
