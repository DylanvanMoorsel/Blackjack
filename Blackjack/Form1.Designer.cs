namespace Blackjack
{
    partial class Form1
    {
        private System.Windows.Forms.Button btnStart, btnShuffle, btnDelen;
        private System.Windows.Forms.Label lblPlayer, lblDealer;
        private System.Windows.Forms.PictureBox picPlayer1, picPlayer2, picDealer1, picDealer2;

        private void InitializeComponent()
        {
            // form instellingen
            this.ClientSize = new Size(450, 450);
            this.Text = "Blackjack";

            // shuffle knop
            btnShuffle = new Button();
            btnShuffle.Text = "Shuffle";
            btnShuffle.Location = new Point(20, 386);
            btnShuffle.Size = new Size(120, 52);
            btnShuffle.Click += btnShuffle_Click;

            // start knop
            btnStart = new Button();
            btnStart.Text = "Start Spel";
            btnStart.Location = new Point(159, 386);
            btnStart.Size = new Size(120, 52);
            btnStart.Click += btnStart_Click;

            // delen knop
            btnDelen = new Button();
            btnDelen.Text = "Delen";
            btnDelen.Location = new Point(298, 386);
            btnDelen.Size = new Size(120, 52);
            btnDelen.Click += btnDelen_Click;

            // lokale player
            lblPlayer = new Label();
            lblPlayer.Text = "Player kaarten:";
            lblPlayer.Location = new Point(50, 200);
            lblPlayer.Size = new Size(300, 30);

            // dealer
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

            // afbeelding van dealer
            picDealer1 = new PictureBox();
            picDealer1.Location = new Point(50, 50);
            picDealer1.Size = new Size(80, 120);
            picDealer1.SizeMode = PictureBoxSizeMode.StretchImage;

            picDealer2 = new PictureBox();
            picDealer2.Location = new Point(150, 50);
            picDealer2.Size = new Size(80, 120);
            picDealer2.SizeMode = PictureBoxSizeMode.StretchImage;

            // Alles toevoegen aan het form
            this.Controls.Add(btnShuffle);
            this.Controls.Add(btnStart);
            this.Controls.Add(btnDelen);
            this.Controls.Add(lblPlayer);
            this.Controls.Add(lblDealer);
            this.Controls.Add(picDealer1);
            this.Controls.Add(picDealer2);
            this.Controls.Add(picPlayer1);
            this.Controls.Add(picPlayer2);
        }
    }
}