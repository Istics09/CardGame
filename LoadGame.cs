using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Gaming
{
    internal class LoadGame
    {
        public Random rand = new Random();
        public List<string> middleCards = new List<string>();
        public string middleCardName;

        public List<string> PlayersCard = new List<string>();
        public List<string> BotsCard = new List<string>();
        public int space = 30;
        public char[] suits = { 'k', 'p', 'r', 't' };
        public int player = 1;
        public void Load_Game(object sender, EventArgs e, Control Target)
        {
            PictureBox pictureBox = new PictureBox
            {
                Name = "Photo",
                Size = new Size(200, 150),
                Location = new Point(20, 350),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Image.FromFile($"../../../Image/back.png")
            };

            Target.Controls.Add(pictureBox);

            for (int i = 0; i < 5; i++)
            {
                char charackter = suits[rand.Next(suits.Length)];
                int number = rand.Next(1, 14);
                string Choosed = $"{charackter} {number}";

                Card_Actions card_Actions = new Card_Actions();

                Game_Logic game_Logic = new Game_Logic();


                PlayersCard.Add( Choosed );
                PictureBox playersCard = new PictureBox
                {
                    Size = new Size(100, 150),
                    Location = new Point((Target.Width / 2) - (i * space), Convert.ToInt32(Target.Width * 0.5)),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BackColor = Color.Transparent,
                    Image = Image.FromFile($"../../../Image/{Choosed}.png"),
                    Name = Choosed
                };

                playersCard.MouseEnter += card_Actions.Mouse_Enter;
                playersCard.MouseLeave += card_Actions.Mouse_leave;
                playersCard.MouseClick += (sender, e) => game_Logic.Check_Card(sender, e, Target);
                Target.Controls.Add(playersCard);
            }

            for(int i = 0; i < 5; i++)
            {
                char charackter = suits[rand.Next(suits.Length)];
                int number = rand.Next(1, 14);
                string Choosed = $"{charackter} {number}";
                BotsCard.Add(Choosed);
                PictureBox BotCards = new PictureBox
                {
                    Size = new Size(100, 150),
                    Location = new Point((Target.Width / 2) - (i * space), Convert.ToInt32(Target.Width * 0.02)),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BackColor = Color.Transparent,
                    Image = Image.FromFile($"../../../Image/{Choosed}.png"),
                    Name = Choosed
                };

                 Target.Controls.Add(BotCards);

            }

            for(int i = 0; i < 1; i++)
            {
                char charackter = suits[rand.Next(suits.Length)];
                int number = rand.Next(1, 14);
                string Choosed = $"{charackter} {number}";
                PictureBox middleCard = new PictureBox
                {
                    Size = new Size(100, 150),
                    Location = new Point((Target.Width / 2), Convert.ToInt32(Target.Width * 0.25)),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BackColor = Color.Transparent,
                    Image = Image.FromFile($"../../../Image/{Choosed}.png"),
                    Name = Choosed
                };

                middleCardName = Choosed;

                MessageBox.Show(middleCardName);


                Target.Controls.Add(middleCard);
            }

        }
        public List<string> Get_MiddleCard()
        {
            return middleCards;
        }

        public List<string> Get_PlayersCard()
        {
            return PlayersCard;
        }

        public List<string> Get_BotsCard()
        {
            return BotsCard;
        }
        public string Return_Name
        {
            get { return middleCardName; }
        }

        public List<string> Return_List()
        {
             return middleCards;
        }
    }
}
