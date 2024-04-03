namespace Gaming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;

            Button playersvsBot = new Button();
            Button playervsplayer = new Button();

            playersvsBot.Text = "Játék a gép ellen!";
            playervsplayer.Text = "2 Játékos mód";

            Button exit = new Button();
            exit.Text = "Kilépés";

            this.Controls.Add(playersvsBot);
            playersvsBot.Size = new Size(150, 50);
            playersvsBot.Name = "PlayerVSBot";
            playersvsBot.Location = new Point(this.Width / 3, 50);
            playersvsBot.Click += new EventHandler(Clear_Window);


            this.Controls.Add(playervsplayer);
            playervsplayer.Size = new Size(150, 50);
            playervsplayer.Location = new Point(this.Width / 3, 130);

            this.Controls.Add(exit);
            exit.Size = new Size(150, 50);
            exit.Location = new Point(this.Width / 3, 210);
        }


        private void Clear_Window(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            LoadGame load = new LoadGame();
            this.Controls.Clear();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            if(clickedButton.Name == "PlayerVSBot")
            {
                load.Load_Game(sender, e, this);
            }
        }

        
    }
}
