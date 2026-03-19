// Form1.Designer.cs
namespace Blackjack
{
    partial class Form1
    {
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblDealer;

        private void InitializeComponent()
        {
            btnStart = new Button();
            lblPlayer = new Label();
            lblDealer = new Label();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(112, 189);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(147, 52);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start Spel";
            btnStart.Click += btnStart_Click;
            // 
            // lblPlayer
            // 
            lblPlayer.Location = new Point(50, 100);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(300, 30);
            lblPlayer.TabIndex = 1;
            lblPlayer.Text = "Jouw kaarten: ";
            // 
            // lblDealer
            // 
            lblDealer.Location = new Point(50, 50);
            lblDealer.Name = "lblDealer";
            lblDealer.Size = new Size(300, 30);
            lblDealer.TabIndex = 2;
            lblDealer.Text = "Dealer kaarten: ";
            // 
            // Form1
            // 
            ClientSize = new Size(382, 253);
            Controls.Add(btnStart);
            Controls.Add(lblPlayer);
            Controls.Add(lblDealer);
            Name = "Form1";
            Text = "Blackjack";
            ResumeLayout(false);
        }
    }
}