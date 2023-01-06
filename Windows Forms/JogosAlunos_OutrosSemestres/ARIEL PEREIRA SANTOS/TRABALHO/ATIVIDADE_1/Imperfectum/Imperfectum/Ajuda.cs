using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imperfectum
{
    public partial class Ajuda : Form
    {
        public Ajuda()
        {
            InitializeComponent();
            DadosUsuario.CarregaAtual();
            BackgroundImage = new Bitmap("background.jpg");
            rtxtHist.Text += DadosUsuario.usuarios[0].user + ", filho único, você é fruto de um casamento entre um comerciante e uma plebeia da capital de" +
                " Fareins, o maior reino do continente Oeste." + Environment.NewLine + Environment.NewLine + " Após casar-se, seu pai gastou 9/10 de sua fortuna para comprar um titulo de barão " +
                "do rei, para que você e sua mãe pudessem viver, mesmo que sem muito poder, em paz. Porém, o que ele não esperava era que o mundo " +
                "dos nobres era podre e inescrupuloso, onde qualquer migalha de poder é fortemente cobiçada. As propriedades de sua família passaram, " +
                "a ser disputadas entre nobres maiores sem mesmo que seu pai soubesse, até que quando os nobres se moveram já era tarde demais." +
                " Você tinha 7 anos quando aconteceu, a única terra advinda de seu titulo de nobreza, o vilarejo onde cresceu foi atacado " +
                "por soldados de dois nobres vizinhos que sempre foram cordiais com sua família em banquetes e bailes. Esses nobres agora estavam " +
                "enviando soldados para saquear suas terras e matar seu povo, alegando que sua família estava traindo o reino ao negociar com nações " +
                "vizinhas. Felizmente ou infelizmente, em meio ao caos você e sua mãe conseguem fugir sob a proteção do mordomo e do chefe dos guardas que morrem " +
                "para proteger vocês." + Environment.NewLine + Environment.NewLine + "A direção de sua fuga é o reino de Hollevin, um reino vizinho " +
                "mas não servo de Fareins, na verdade existem até especulações de que os dois reinos estejam em conflitos por debaixo dos panos. " +
                "Sua jornada não é nada fácil, sair do centro do reino sob os olhos dos nobresm detentores da maior parte das terras, sendo uma mulher " +
                "sozinha e ainda tendo que cuidar de uma criança prova-se ser uma tarefa beirando um milagre, no entanto sua mãe consegue. " +
                "Seria realmente um milagre se ela não ficasse doente. Após 2 anos de fuga, vocês chegam em uma vila um tanto quanto remota, na borda de Hollevin com " +
                "Saharan (um reino vizinho), e se instalam com a ajuda do chefe local. Pensando que o pesadelo tinha acabado, a pessoa que te " +
                "deu vida e lutou para proteger-te por mais de 9 anos passa a tossir incontrolavelmente todos os dias, ela começa a ter problemas de insônia também " +
                "e passa a não conseguir mais comer direito, o doutor da vila diz que devido à condições extremas de desnutrição e estresse " +
                "ela desenvolveu outras doenças extremamentes agressivas e que não à restava mais de um ano." + Environment.NewLine + Environment.NewLine
                + "Forçado a trabalhar (nos campos da vila por migalhas de pão, carregando sacos para os comerciantes por poucas moedas de prata, " +
                "ficando de vigia a noite para os guardas apenas para que o deixassem continuar na vila" +
                ") em busca de sobreviver e sustentar o pouco tempo que resta de sua mãe seus sentimentos negativos de ódio e " +
                "vingança pelo reino que um dia chamou de casa só aumentam, até que um dia seu maior medo se torna realidade." +
                "A morte de sua mãe já era esperada porém a sua vinda não deixou de ser dolorosa. Agora completamente órfão, você se entrega aos " +
                "guardas da vila para servir ao reino, na esperança de que um dia possa se vingar." + Environment.NewLine+Environment.NewLine+
                "Com sede de vingança você se esforça mais que todos outros recrutas, seus dias de treinamento com o chefe dos guardas de " +
                "sua família se provam não ser em vão e te dão uma leve vantagem sobre seus competidores. O tempo passa e a hora de se provar ao " +
                "reino finalmente chega, agora candidato à um exercito particular do rei, ele o convoca para capital e te entrega uma missão, com a promessa " +
                "de que caso consiga completa-la ele lhe dará um título de cavaleiro e um posto em seu exercito, já é um começo para a sua vingança.";
            rtxtComoJogar.Text += "Após aceitar a missão do rei " + DadosUsuario.usuarios[0].user + " segue para o vilarejo conforme suas instruções." +
                " Quem dará mais detalhes sobre sua missão será o chefe da vila. Tente interagir com os habitantes também, quem sabe eles não podem te ajudar."
                + Environment.NewLine + Environment.NewLine+"Em breve mais funções serão adicionadas, no momento o jogo se encontra repetivel indefinidamente." ;
        }
    }
}
