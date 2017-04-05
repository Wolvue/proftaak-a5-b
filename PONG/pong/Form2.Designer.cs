namespace PONG
{
    partial class MainMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Multiplayer_start = new System.Windows.Forms.Button();
            this.Singleplayer_start = new System.Windows.Forms.Button();
            this.Bal = new System.Windows.Forms.PictureBox();
            this.bot1 = new System.Windows.Forms.PictureBox();
            this.bot2 = new System.Windows.Forms.PictureBox();
            this.balmovement = new System.Windows.Forms.Timer(this.components);
            this.Bordertop = new System.Windows.Forms.PictureBox();
            this.Borderbottom = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bordertop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Borderbottom)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.Borderbottom);
            this.panel1.Controls.Add(this.Multiplayer_start);
            this.panel1.Controls.Add(this.Singleplayer_start);
            this.panel1.Controls.Add(this.Bal);
            this.panel1.Controls.Add(this.bot1);
            this.panel1.Controls.Add(this.bot2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 752);
            this.panel1.TabIndex = 1;
            // 
            // Multiplayer_start
            // 
            this.Multiplayer_start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Multiplayer_start.AutoSize = true;
            this.Multiplayer_start.BackColor = System.Drawing.Color.Black;
            this.Multiplayer_start.Font = new System.Drawing.Font("ModeSeven", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplayer_start.ForeColor = System.Drawing.Color.Red;
            this.Multiplayer_start.Location = new System.Drawing.Point(135, 238);
            this.Multiplayer_start.Name = "Multiplayer_start";
            this.Multiplayer_start.Size = new System.Drawing.Size(414, 66);
            this.Multiplayer_start.TabIndex = 7;
            this.Multiplayer_start.Text = "Multiplayer";
            this.Multiplayer_start.UseVisualStyleBackColor = false;
            this.Multiplayer_start.Click += new System.EventHandler(this.Multiplayer_start_Click);
            // 
            // Singleplayer_start
            // 
            this.Singleplayer_start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Singleplayer_start.AutoSize = true;
            this.Singleplayer_start.BackColor = System.Drawing.Color.Black;
            this.Singleplayer_start.Font = new System.Drawing.Font("ModeSeven", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Singleplayer_start.ForeColor = System.Drawing.Color.Red;
            this.Singleplayer_start.Location = new System.Drawing.Point(135, 142);
            this.Singleplayer_start.Name = "Singleplayer_start";
            this.Singleplayer_start.Size = new System.Drawing.Size(414, 66);
            this.Singleplayer_start.TabIndex = 6;
            this.Singleplayer_start.Text = "Singleplayer";
            this.Singleplayer_start.UseVisualStyleBackColor = false;
            this.Singleplayer_start.Click += new System.EventHandler(this.Singleplayer_start_Click);
            // 
            // Bal
            // 
            this.Bal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Bal.BackColor = System.Drawing.Color.White;
            this.Bal.Location = new System.Drawing.Point(48, 465);
            this.Bal.Name = "Bal";
            this.Bal.Size = new System.Drawing.Size(25, 25);
            this.Bal.TabIndex = 5;
            this.Bal.TabStop = false;
            // 
            // bot1
            // 
            this.bot1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bot1.BackColor = System.Drawing.Color.White;
            this.bot1.Location = new System.Drawing.Point(675, 339);
            this.bot1.Name = "bot1";
            this.bot1.Size = new System.Drawing.Size(30, 250);
            this.bot1.TabIndex = 4;
            this.bot1.TabStop = false;
            // 
            // bot2
            // 
            this.bot2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bot2.BackColor = System.Drawing.Color.White;
            this.bot2.Location = new System.Drawing.Point(12, 365);
            this.bot2.Name = "bot2";
            this.bot2.Size = new System.Drawing.Size(30, 250);
            this.bot2.TabIndex = 3;
            this.bot2.TabStop = false;
            // 
            // balmovement
            // 
            this.balmovement.Enabled = true;
            this.balmovement.Interval = 30;
            this.balmovement.Tick += new System.EventHandler(this.balmovement_Tick);
            // 
            // Bordertop
            // 
            this.Bordertop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bordertop.BackColor = System.Drawing.Color.Black;
            this.Bordertop.Location = new System.Drawing.Point(0, 0);
            this.Bordertop.Name = "Bordertop";
            this.Bordertop.Size = new System.Drawing.Size(717, 14);
            this.Bordertop.TabIndex = 2;
            this.Bordertop.TabStop = false;
            // 
            // Borderbottom
            // 
            this.Borderbottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Borderbottom.BackColor = System.Drawing.Color.Black;
            this.Borderbottom.Location = new System.Drawing.Point(0, 735);
            this.Borderbottom.Name = "Borderbottom";
            this.Borderbottom.Size = new System.Drawing.Size(717, 14);
            this.Borderbottom.TabIndex = 3;
            this.Borderbottom.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 752);
            this.Controls.Add(this.Bordertop);
            this.Controls.Add(this.panel1);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bordertop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Borderbottom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Singleplayer_start;
        private System.Windows.Forms.PictureBox Bal;
        private System.Windows.Forms.PictureBox bot1;
        private System.Windows.Forms.PictureBox bot2;
        private System.Windows.Forms.Timer balmovement;
        private System.Windows.Forms.Button Multiplayer_start;
        private System.Windows.Forms.PictureBox Borderbottom;
        private System.Windows.Forms.PictureBox Bordertop;
    }
}