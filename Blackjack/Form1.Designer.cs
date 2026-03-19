// Form1.Designer.cs
namespace Blackjack
{
    partial class Form1
    {
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.PictureBox picPlayer2;
        private System.Windows.Forms.PictureBox picDealer2;

        private void InitializeComponent()
        {
            btnStart = new Button();
            lblPlayer = new Label();
            lblDealer = new Label();
            picPlayer2 = new PictureBox();
            picDealer2 = new PictureBox();
            picDealer1 = new PictureBox();
            picPlayer1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picPlayer2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDealer2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDealer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer1).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(159, 386);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(147, 52);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start Spel";
            btnStart.Click += btnStart_Click;
            // 
            // lblPlayer
            // 
            lblPlayer.Location = new Point(50, 200);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(300, 30);
            lblPlayer.TabIndex = 1;
            lblPlayer.Text = "Jouw kaarten:";
            // 
            // lblDealer
            // 
            lblDealer.Location = new Point(50, 20);
            lblDealer.Name = "lblDealer";
            lblDealer.Size = new Size(300, 30);
            lblDealer.TabIndex = 2;
            lblDealer.Text = "Dealer kaarten:";
            // 
            // picPlayer2
            // 
            picPlayer2.Location = new Point(150, 230);
            picPlayer2.Name = "picPlayer2";
            picPlayer2.Size = new Size(80, 120);
            picPlayer2.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlayer2.TabIndex = 6;
            picPlayer2.TabStop = false;
            // 
            // picDealer2
            // 
            picDealer2.Location = new Point(150, 50);
            picDealer2.Name = "picDealer2";
            picDealer2.Size = new Size(80, 120);
            picDealer2.SizeMode = PictureBoxSizeMode.StretchImage;
            picDealer2.TabIndex = 4;
            picDealer2.TabStop = false;
            // 
            // picDealer1
            // 
            picDealer1.Location = new Point(50, 50);
            picDealer1.Name = "picDealer1";
            picDealer1.Size = new Size(80, 120);
            picDealer1.SizeMode = PictureBoxSizeMode.StretchImage;
            picDealer1.TabIndex = 3;
            picDealer1.TabStop = false;
            // 
            // picPlayer1
            // 
            picPlayer1.Location = new Point(50, 230);
            picPlayer1.Name = "picPlayer1";
            picPlayer1.Size = new Size(80, 120);
            picPlayer1.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlayer1.TabIndex = 5;
            picPlayer1.TabStop = false;
            // 
            // Form1
            // 
            ClientSize = new Size(450, 450);
            Controls.Add(btnStart);
            Controls.Add(lblPlayer);
            Controls.Add(lblDealer);
            Controls.Add(picDealer1);
            Controls.Add(picDealer2);
            Controls.Add(picPlayer1);
            Controls.Add(picPlayer2);
            Name = "Form1";
            Text = "Blackjack";
            ((System.ComponentModel.ISupportInitialize)picPlayer2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDealer2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDealer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer1).EndInit();
            ResumeLayout(false);
        }

        private PictureBox picDealer1;
        private PictureBox picPlayer1;
    }
}