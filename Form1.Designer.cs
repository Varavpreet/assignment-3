namespace CricketTradingCards
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxPlayers = new ListBox();
            pbPhoto = new PictureBox();
            lblName = new Label();
            lblTeam = new Label();
            lblRuns = new Label();
            lblWickets = new Label();
            lblMatches = new Label();
            lblAverage = new Label();
            btnAddPlayer = new Button();
            btnRemovePlayer = new Button();
            background = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbPhoto).BeginInit();
            background.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxPlayers
            // 
            listBoxPlayers.FormattingEnabled = true;
            listBoxPlayers.Location = new Point(30, 23);
            listBoxPlayers.Name = "listBoxPlayers";
            listBoxPlayers.Size = new Size(150, 104);
            listBoxPlayers.TabIndex = 0;
            listBoxPlayers.SelectedIndexChanged += ListBoxPlayers_SelectedIndexChanged;
            // 
            // pbPhoto
            // 
            pbPhoto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbPhoto.Image = Properties.Resources.cricket;
            pbPhoto.Location = new Point(31, 3);
            pbPhoto.Name = "pbPhoto";
            pbPhoto.Size = new Size(223, 203);
            pbPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPhoto.TabIndex = 1;
            pbPhoto.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(118, 214);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 20);
            lblName.TabIndex = 2;
            lblName.Text = "label1";
            lblName.Visible = false;
            // 
            // lblTeam
            // 
            lblTeam.AutoSize = true;
            lblTeam.Location = new Point(118, 245);
            lblTeam.Name = "lblTeam";
            lblTeam.Size = new Size(50, 20);
            lblTeam.TabIndex = 3;
            lblTeam.Text = "label2";
            lblTeam.Visible = false;
            // 
            // lblRuns
            // 
            lblRuns.AutoSize = true;
            lblRuns.Location = new Point(118, 277);
            lblRuns.Name = "lblRuns";
            lblRuns.Size = new Size(50, 20);
            lblRuns.TabIndex = 4;
            lblRuns.Text = "label3";
            lblRuns.Visible = false;
            // 
            // lblWickets
            // 
            lblWickets.AutoSize = true;
            lblWickets.Location = new Point(118, 308);
            lblWickets.Name = "lblWickets";
            lblWickets.Size = new Size(50, 20);
            lblWickets.TabIndex = 5;
            lblWickets.Text = "label4";
            lblWickets.Visible = false;
            // 
            // lblMatches
            // 
            lblMatches.AutoSize = true;
            lblMatches.Location = new Point(118, 337);
            lblMatches.Name = "lblMatches";
            lblMatches.Size = new Size(50, 20);
            lblMatches.TabIndex = 6;
            lblMatches.Text = "label5";
            lblMatches.Visible = false;
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Location = new Point(118, 366);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(50, 20);
            lblAverage.TabIndex = 7;
            lblAverage.Text = "label6";
            lblAverage.Visible = false;
            // 
            // btnAddPlayer
            // 
            btnAddPlayer.Location = new Point(30, 155);
            btnAddPlayer.Name = "btnAddPlayer";
            btnAddPlayer.Size = new Size(150, 48);
            btnAddPlayer.TabIndex = 8;
            btnAddPlayer.Text = "Add player";
            btnAddPlayer.UseVisualStyleBackColor = true;
            btnAddPlayer.Click += btnAddPlayer_Click;
            // 
            // btnRemovePlayer
            // 
            btnRemovePlayer.Location = new Point(30, 226);
            btnRemovePlayer.Name = "btnRemovePlayer";
            btnRemovePlayer.Size = new Size(150, 47);
            btnRemovePlayer.TabIndex = 9;
            btnRemovePlayer.Text = "Remove player";
            btnRemovePlayer.UseVisualStyleBackColor = true;
            btnRemovePlayer.Click += btnRemovePlayer_Click;
            // 
            // background
            // 
            background.Controls.Add(lblName);
            background.Controls.Add(lblTeam);
            background.Controls.Add(lblRuns);
            background.Controls.Add(pbPhoto);
            background.Controls.Add(lblAverage);
            background.Controls.Add(lblWickets);
            background.Controls.Add(lblMatches);
            background.Location = new Point(447, 39);
            background.Name = "background";
            background.Size = new Size(305, 399);
            background.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(background);
            Controls.Add(btnRemovePlayer);
            Controls.Add(btnAddPlayer);
            Controls.Add(listBoxPlayers);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbPhoto).EndInit();
            background.ResumeLayout(false);
            background.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxPlayers;
        private PictureBox pbPhoto;
        private Label lblName;
        private Label lblTeam;
        private Label lblRuns;
        private Label lblWickets;
        private Label lblMatches;
        private Label lblAverage;
        private FlowLayoutPanel panelCard;
        private Button btnAddPlayer;
        private Button btnRemovePlayer;
        private Panel background;
    }
}
