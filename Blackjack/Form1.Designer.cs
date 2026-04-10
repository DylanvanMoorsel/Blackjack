namespace Blackjack
{
    partial class Form1
    {
        private System.Windows.Forms.Button btnStart, btnShuffle, btnDelen, btnHit, btnStand;
        private System.Windows.Forms.Label lblPlayer, lblDealer;
        private System.Windows.Forms.PictureBox picPlayer1, picPlayer2, picPlayer3, picDealer1, picDealer2;

        private void InitializeComponent()
        {
            // form instellingen
            this.ClientSize = new Size(450, 490);
            this.Text = "Blackjack";

            // shuffle knop
            btnShuffle = new Button();
            btnShuffle.Text = "Shuffle";
            btnShuffle.Location = new Point(20, 426);
            btnShuffle.Size = new Size(120, 42);
            btnShuffle.Click += btnShuffle_Click;

            // start knop
            btnStart = new Button();
            btnStart.Text = "Start Spel";
            btnStart.Location = new Point(159, 426);
            btnStart.Size = new Size(120, 42);
            btnStart.Click += btnStart_Click;

            // delen knop
            btnDelen = new Button();
            btnDelen.Text = "Delen";
            btnDelen.Location = new Point(298, 426);
            btnDelen.Size = new Size(120, 42);
            btnDelen.Click += btnDelen_Click;

            // hit knop
            btnHit = new Button();
            btnHit.Text = "Hit";
            btnHit.Location = new Point(20, 376);
            btnHit.Size = new Size(120, 42);
            btnHit.Click += btnHit_Click;

            // stand knop
            btnStand = new Button();
            btnStand.Text = "Stand";
            btnStand.Location = new Point(159, 376);
            btnStand.Size = new Size(120, 42);
            btnStand.Click += btnStand_Click;

            // label speler
            lblPlayer = new Label();
            lblPlayer.Text = "Player kaarten:";
            lblPlayer.Location = new Point(50, 200);
            lblPlayer.Size = new Size(300, 30);

            // label dealer
            lblDealer = new Label();
            lblDealer.Text = "Dealer kaarten:";
            lblDealer.Location = new Point(50, 20);
            lblDealer.Size = new Size(300, 30);

            // afbeeldingen van speler
            picPlayer1 = new PictureBox();
            picPlayer1.Location = new Point(50, 230);
            picPlayer1.Size = new Size(80, 120);
            picPlayer1.SizeMode = PictureBoxSizeMode.StretchImage;

            picPlayer2 = new PictureBox();
            picPlayer2.Location = new Point(150, 230);
            picPlayer2.Size = new Size(80, 120);
            picPlayer2.SizeMode = PictureBoxSizeMode.StretchImage;

            // derde kaart is eerst onzichtbaar
            picPlayer3 = new PictureBox();
            picPlayer3.Location = new Point(250, 230);
            picPlayer3.Size = new Size(80, 120);
            picPlayer3.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlayer3.Visible = false;

            // afbeeldingen van dealer
            picDealer1 = new PictureBox();
            picDealer1.Location = new Point(50, 50);
            picDealer1.Size = new Size(80, 120);
            picDealer1.SizeMode = PictureBoxSizeMode.StretchImage;

            picDealer2 = new PictureBox();
            picDealer2.Location = new Point(150, 50);
            picDealer2.Size = new Size(80, 120);
            picDealer2.SizeMode = PictureBoxSizeMode.StretchImage;

            // alles toevoegen aan het form
            this.Controls.Add(btnShuffle);
            this.Controls.Add(btnStart);
            this.Controls.Add(btnDelen);
            this.Controls.Add(btnHit);
            this.Controls.Add(btnStand);
            this.Controls.Add(lblPlayer);
            this.Controls.Add(lblDealer);
            this.Controls.Add(picDealer1);
            this.Controls.Add(picDealer2);
            this.Controls.Add(picPlayer1);
            this.Controls.Add(picPlayer2);
            this.Controls.Add(picPlayer3);
        }
    }
}