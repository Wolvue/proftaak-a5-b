namespace PONG
{
    partial class Pong
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
            this.speelbord = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Bal = new System.Windows.Forms.PictureBox();
            this.goal1 = new System.Windows.Forms.PictureBox();
            this.goal2 = new System.Windows.Forms.PictureBox();
            this.bordertop = new System.Windows.Forms.PictureBox();
            this.borderdown = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.punten2 = new System.Windows.Forms.Label();
            this.punten1 = new System.Windows.Forms.Label();
            this.speler2 = new System.Windows.Forms.PictureBox();
            this.speler1 = new System.Windows.Forms.PictureBox();
            this.Snelheid = new System.Windows.Forms.Timer(this.components);
            this.spelerev3 = new System.Windows.Forms.Timer(this.components);
            this.invisibility = new System.Windows.Forms.Timer(this.components);
            this.speelbord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bordertop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speler2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speler1)).BeginInit();
            this.SuspendLayout();
            // 
            // speelbord
            // 
            this.speelbord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speelbord.AutoSize = true;
            this.speelbord.BackColor = System.Drawing.Color.Black;
            this.speelbord.Controls.Add(this.label1);
            this.speelbord.Controls.Add(this.Bal);
            this.speelbord.Controls.Add(this.goal1);
            this.speelbord.Controls.Add(this.goal2);
            this.speelbord.Controls.Add(this.bordertop);
            this.speelbord.Controls.Add(this.borderdown);
            this.speelbord.Controls.Add(this.label3);
            this.speelbord.Controls.Add(this.punten2);
            this.speelbord.Controls.Add(this.punten1);
            this.speelbord.Controls.Add(this.speler2);
            this.speelbord.Controls.Add(this.speler1);
            this.speelbord.Location = new System.Drawing.Point(0, 0);
            this.speelbord.Name = "speelbord";
            this.speelbord.Size = new System.Drawing.Size(705, 468);
            this.speelbord.TabIndex = 0;
            this.speelbord.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(245, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Bal
            // 
            this.Bal.BackColor = System.Drawing.Color.White;
            this.Bal.Location = new System.Drawing.Point(63, 212);
            this.Bal.Name = "Bal";
            this.Bal.Size = new System.Drawing.Size(21, 21);
            this.Bal.TabIndex = 10;
            this.Bal.TabStop = false;
            // 
            // goal1
            // 
            this.goal1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.goal1.Location = new System.Drawing.Point(0, 0);
            this.goal1.Name = "goal1";
            this.goal1.Size = new System.Drawing.Size(10, 430);
            this.goal1.TabIndex = 9;
            this.goal1.TabStop = false;
            // 
            // goal2
            // 
            this.goal2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goal2.Location = new System.Drawing.Point(673, -4);
            this.goal2.Name = "goal2";
            this.goal2.Size = new System.Drawing.Size(10, 432);
            this.goal2.TabIndex = 8;
            this.goal2.TabStop = false;
            // 
            // bordertop
            // 
            this.bordertop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bordertop.BackColor = System.Drawing.Color.White;
            this.bordertop.Location = new System.Drawing.Point(0, 0);
            this.bordertop.Name = "bordertop";
            this.bordertop.Size = new System.Drawing.Size(683, 10);
            this.bordertop.TabIndex = 7;
            this.bordertop.TabStop = false;
            // 
            // borderdown
            // 
            this.borderdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borderdown.BackColor = System.Drawing.Color.White;
            this.borderdown.Location = new System.Drawing.Point(0, 420);
            this.borderdown.Name = "borderdown";
            this.borderdown.Size = new System.Drawing.Size(683, 10);
            this.borderdown.TabIndex = 6;
            this.borderdown.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("ModeSeven", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(311, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 43);
            this.label3.TabIndex = 5;
            this.label3.Text = "-";
            // 
            // punten2
            // 
            this.punten2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.punten2.AutoSize = true;
            this.punten2.BackColor = System.Drawing.Color.Transparent;
            this.punten2.Font = new System.Drawing.Font("ModeSeven", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punten2.ForeColor = System.Drawing.Color.White;
            this.punten2.Location = new System.Drawing.Point(398, 9);
            this.punten2.Name = "punten2";
            this.punten2.Size = new System.Drawing.Size(46, 43);
            this.punten2.TabIndex = 4;
            this.punten2.Text = "0";
            this.punten2.Click += new System.EventHandler(this.punten2_Click);
            // 
            // punten1
            // 
            this.punten1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.punten1.AutoSize = true;
            this.punten1.BackColor = System.Drawing.Color.Transparent;
            this.punten1.Font = new System.Drawing.Font("ModeSeven", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punten1.ForeColor = System.Drawing.Color.White;
            this.punten1.Location = new System.Drawing.Point(230, 9);
            this.punten1.Name = "punten1";
            this.punten1.Size = new System.Drawing.Size(46, 43);
            this.punten1.TabIndex = 2;
            this.punten1.Text = "0";
            this.punten1.Click += new System.EventHandler(this.label1_Click);
            // 
            // speler2
            // 
            this.speler2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.speler2.BackColor = System.Drawing.Color.White;
            this.speler2.Location = new System.Drawing.Point(642, 174);
            this.speler2.Name = "speler2";
            this.speler2.Size = new System.Drawing.Size(25, 100);
            this.speler2.TabIndex = 1;
            this.speler2.TabStop = false;
            // 
            // speler1
            // 
            this.speler1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.speler1.BackColor = System.Drawing.Color.White;
            this.speler1.Location = new System.Drawing.Point(16, 174);
            this.speler1.Name = "speler1";
            this.speler1.Size = new System.Drawing.Size(25, 100);
            this.speler1.TabIndex = 0;
            this.speler1.TabStop = false;
            // 
            // Snelheid
            // 
            this.Snelheid.Enabled = true;
            this.Snelheid.Interval = 20;
            this.Snelheid.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // spelerev3
            // 
            this.spelerev3.Enabled = true;
            this.spelerev3.Interval = 20;
            this.spelerev3.Tick += new System.EventHandler(this.spelerev3_Tick);
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(682, 428);
            this.Controls.Add(this.speelbord);
            this.Name = "Pong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.speelbord.ResumeLayout(false);
            this.speelbord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bordertop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speler2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speler1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel speelbord;
        private System.Windows.Forms.Label punten1;
        private System.Windows.Forms.PictureBox speler2;
        private System.Windows.Forms.PictureBox speler1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label punten2;
        private System.Windows.Forms.Timer Snelheid;
        private System.Windows.Forms.PictureBox borderdown;
        private System.Windows.Forms.PictureBox bordertop;
        private System.Windows.Forms.PictureBox goal2;
        private System.Windows.Forms.PictureBox goal1;
        private System.Windows.Forms.PictureBox Bal;
        private System.Windows.Forms.Timer spelerev3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer invisibility;
    }
}

