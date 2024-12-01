namespace TradingCardAssign
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.image_display_list = new System.Windows.Forms.ImageList(this.components);
            this.player_Display = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.reboundsLabel = new System.Windows.Forms.Label();
            this.assistLabel = new System.Windows.Forms.Label();
            this.stealsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // image_display_list
            // 
            this.image_display_list.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.image_display_list.ImageSize = new System.Drawing.Size(16, 16);
            this.image_display_list.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // player_Display
            // 
            this.player_Display.GridLines = true;
            this.player_Display.HideSelection = false;
            this.player_Display.Location = new System.Drawing.Point(12, 58);
            this.player_Display.Name = "player_Display";
            this.player_Display.Size = new System.Drawing.Size(841, 401);
            this.player_Display.TabIndex = 0;
            this.player_Display.Tag = "TradingCard";
            this.player_Display.UseCompatibleStateImageBehavior = false;
            this.player_Display.SelectedIndexChanged += new System.EventHandler(this.player_Display_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(1024, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(629, 401);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(1031, 470);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(124, 25);
            this.playerNameLabel.TabIndex = 10;
            this.playerNameLabel.Text = "Player Name";
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Location = new System.Drawing.Point(1031, 495);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(120, 25);
            this.teamNameLabel.TabIndex = 11;
            this.teamNameLabel.Text = "Team Name";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Location = new System.Drawing.Point(1031, 520);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(66, 25);
            this.pointsLabel.TabIndex = 12;
            this.pointsLabel.Text = "Points";
            // 
            // reboundsLabel
            // 
            this.reboundsLabel.AutoSize = true;
            this.reboundsLabel.Location = new System.Drawing.Point(1031, 545);
            this.reboundsLabel.Name = "reboundsLabel";
            this.reboundsLabel.Size = new System.Drawing.Size(107, 25);
            this.reboundsLabel.TabIndex = 13;
            this.reboundsLabel.Text = "Rebounds:";
            // 
            // assistLabel
            // 
            this.assistLabel.AutoSize = true;
            this.assistLabel.Location = new System.Drawing.Point(1031, 570);
            this.assistLabel.Name = "assistLabel";
            this.assistLabel.Size = new System.Drawing.Size(75, 25);
            this.assistLabel.TabIndex = 14;
            this.assistLabel.Text = "Assists";
            // 
            // stealsLabel
            // 
            this.stealsLabel.AutoSize = true;
            this.stealsLabel.Location = new System.Drawing.Point(1031, 595);
            this.stealsLabel.Name = "stealsLabel";
            this.stealsLabel.Size = new System.Drawing.Size(78, 25);
            this.stealsLabel.TabIndex = 15;
            this.stealsLabel.Text = "Steals: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1665, 1018);
            this.Controls.Add(this.stealsLabel);
            this.Controls.Add(this.assistLabel);
            this.Controls.Add(this.reboundsLabel);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.player_Display);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList image_display_list;
        private System.Windows.Forms.ListView player_Display;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Label reboundsLabel;
        private System.Windows.Forms.Label assistLabel;
        private System.Windows.Forms.Label stealsLabel;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}

