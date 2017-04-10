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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Borderbottom = new System.Windows.Forms.PictureBox();
            this.Multiplayer_start = new System.Windows.Forms.Button();
            this.Singleplayer_start = new System.Windows.Forms.Button();
            this.Bal = new System.Windows.Forms.PictureBox();
            this.bot2 = new System.Windows.Forms.PictureBox();
            this.bot1 = new System.Windows.Forms.PictureBox();
            this.balmovement = new System.Windows.Forms.Timer(this.components);
            this.Bordertop = new System.Windows.Forms.PictureBox();
            this.ev3ticks = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Borderbottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bordertop)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Exit_button);
            this.panel1.Controls.Add(this.Borderbottom);
            this.panel1.Controls.Add(this.Multiplayer_start);
            this.panel1.Controls.Add(this.Singleplayer_start);
            this.panel1.Controls.Add(this.Bal);
            this.panel1.Controls.Add(this.bot2);
            this.panel1.Controls.Add(this.bot1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 752);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PONG.Properties.Resources.PT_logo_transparant_1000x1000;
            this.pictureBox1.Location = new System.Drawing.Point(569, 613);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ModeSeven", 10F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(485, 654);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Made by";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("ModeSeven", 80F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(172, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 134);
            this.label2.TabIndex = 10;
            this.label2.Text = "PONG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 557);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // Exit_button
            // 
            this.Exit_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit_button.AutoSize = true;
            this.Exit_button.BackColor = System.Drawing.Color.Black;
            this.Exit_button.Font = new System.Drawing.Font("ModeSeven", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_button.ForeColor = System.Drawing.Color.Red;
            this.Exit_button.Location = new System.Drawing.Point(159, 508);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(414, 66);
            this.Exit_button.TabIndex = 8;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
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
            // Multiplayer_start
            // 
            this.Multiplayer_start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Multiplayer_start.AutoSize = true;
            this.Multiplayer_start.BackColor = System.Drawing.Color.Black;
            this.Multiplayer_start.Font = new System.Drawing.Font("ModeSeven", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplayer_start.ForeColor = System.Drawing.Color.Red;
            this.Multiplayer_start.Location = new System.Drawing.Point(159, 375);
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
            this.Singleplayer_start.Location = new System.Drawing.Point(159, 233);
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
            // bot2
            // 
            this.bot2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bot2.BackColor = System.Drawing.Color.White;
            this.bot2.Location = new System.Drawing.Point(675, 339);
            this.bot2.Name = "bot2";
            this.bot2.Size = new System.Drawing.Size(30, 250);
            this.bot2.TabIndex = 4;
            this.bot2.TabStop = false;
            // 
            // bot1
            // 
            this.bot1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bot1.BackColor = System.Drawing.Color.White;
            this.bot1.Location = new System.Drawing.Point(12, 365);
            this.bot1.Name = "bot1";
            this.bot1.Size = new System.Drawing.Size(30, 250);
            this.bot1.TabIndex = 3;
            this.bot1.TabStop = false;
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
            // ev3ticks
            // 
            this.ev3ticks.Enabled = true;
            this.ev3ticks.Interval = 1000;
            this.ev3ticks.Tick += new System.EventHandler(this.ev3ticks_Tick);
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
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Borderbottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bordertop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Singleplayer_start;
        private System.Windows.Forms.PictureBox Bal;
        private System.Windows.Forms.PictureBox bot2;
        private System.Windows.Forms.PictureBox bot1;
        private System.Windows.Forms.Timer balmovement;
        private System.Windows.Forms.Button Multiplayer_start;
        private System.Windows.Forms.PictureBox Borderbottom;
        private System.Windows.Forms.PictureBox Bordertop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer ev3ticks;
    }
}