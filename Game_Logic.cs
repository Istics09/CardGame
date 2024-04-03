using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming
{
    internal class Game_Logic : LoadGame
    {
        public Game_Logic()
        {
        }
        Random rand = new Random();
        public void Check_Card(object sender, EventArgs e, Control Target)
        {
            PictureBox clicked = sender as PictureBox;
            string name = Return_Name;
            List<string> middleCards = Return_List();
            string cardsAsString = string.Join(", ", middleCards);
            MessageBox.Show("cardsAsString: " + cardsAsString);
            MessageBox.Show("Name: " + name);

            List<string> botsCard = Get_BotsCard();
            string botsCards = string.Join(", ", botsCard);
            MessageBox.Show("bot kártyái: ");



        }
    }
}
