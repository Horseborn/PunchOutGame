
namespace PunchOutGame
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
            this.enemyLife = new System.Windows.Forms.ProgressBar();
            this.playerLife = new System.Windows.Forms.ProgressBar();
            this.enemyBoxer = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.boxer = new System.Windows.Forms.PictureBox();
            this.enemyTimer = new System.Windows.Forms.Timer(this.components);
            this.enemyMove = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.enemyBoxer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxer)).BeginInit();
            this.SuspendLayout();
            // 
            // enemyLife
            // 
            this.enemyLife.Location = new System.Drawing.Point(12, 44);
            this.enemyLife.Name = "enemyLife";
            this.enemyLife.Size = new System.Drawing.Size(300, 25);
            this.enemyLife.TabIndex = 0;
            // 
            // playerLife
            // 
            this.playerLife.Location = new System.Drawing.Point(521, 44);
            this.playerLife.Name = "playerLife";
            this.playerLife.Size = new System.Drawing.Size(300, 25);
            this.playerLife.TabIndex = 1;
            // 
            // enemyBoxer
            // 
            this.enemyBoxer.BackColor = System.Drawing.Color.Transparent;
            this.enemyBoxer.Image = global::PunchOutGame.Properties.Resources.enemy_stand;
            this.enemyBoxer.Location = new System.Drawing.Point(385, 297);
            this.enemyBoxer.Name = "enemyBoxer";
            this.enemyBoxer.Size = new System.Drawing.Size(77, 185);
            this.enemyBoxer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemyBoxer.TabIndex = 2;
            this.enemyBoxer.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // boxer
            // 
            this.boxer.BackColor = System.Drawing.Color.Transparent;
            this.boxer.Image = global::PunchOutGame.Properties.Resources.boxer_stand;
            this.boxer.Location = new System.Drawing.Point(401, 367);
            this.boxer.Name = "boxer";
            this.boxer.Size = new System.Drawing.Size(61, 153);
            this.boxer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.boxer.TabIndex = 4;
            this.boxer.TabStop = false;
            // 
            // enemyTimer
            // 
            this.enemyTimer.Enabled = true;
            this.enemyTimer.Interval = 1000;
            this.enemyTimer.Tick += new System.EventHandler(this.enemyPunchEvent);
            // 
            // enemyMove
            // 
            this.enemyMove.Enabled = true;
            this.enemyMove.Interval = 20;
            this.enemyMove.Tick += new System.EventHandler(this.enemyMove_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PunchOutGame.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(825, 566);
            this.Controls.Add(this.boxer);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.enemyBoxer);
            this.Controls.Add(this.playerLife);
            this.Controls.Add(this.enemyLife);
            this.Name = "Form1";
            this.Text = "Punch Out Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.enemyBoxer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar enemyLife;
        private System.Windows.Forms.ProgressBar playerLife;
        private System.Windows.Forms.PictureBox enemyBoxer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox boxer;
        private System.Windows.Forms.Timer enemyTimer;
        private System.Windows.Forms.Timer enemyMove;
    }
}

