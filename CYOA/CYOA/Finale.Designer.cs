namespace CYOA
{
    partial class Finale
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
            this.HUD = new System.Windows.Forms.Timer(this.components);
            this.Flabel = new System.Windows.Forms.Label();
            this.fmood = new System.Windows.Forms.Label();
            this.fmoney = new System.Windows.Forms.Label();
            this.userimg = new System.Windows.Forms.PictureBox();
            this.Mscore = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userimg)).BeginInit();
            this.SuspendLayout();
            // 
            // HUD
            // 
            this.HUD.Enabled = true;
            this.HUD.Tick += new System.EventHandler(this.HUD_Tick);
            // 
            // Flabel
            // 
            this.Flabel.AutoSize = true;
            this.Flabel.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Flabel.Location = new System.Drawing.Point(232, 9);
            this.Flabel.Name = "Flabel";
            this.Flabel.Size = new System.Drawing.Size(193, 44);
            this.Flabel.TabIndex = 0;
            this.Flabel.Text = "Your results";
            // 
            // fmood
            // 
            this.fmood.AutoSize = true;
            this.fmood.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmood.Location = new System.Drawing.Point(78, 95);
            this.fmood.Name = "fmood";
            this.fmood.Size = new System.Drawing.Size(190, 44);
            this.fmood.TabIndex = 1;
            this.fmood.Text = "Final Mood";
            // 
            // fmoney
            // 
            this.fmoney.AutoSize = true;
            this.fmoney.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmoney.Location = new System.Drawing.Point(390, 95);
            this.fmoney.Name = "fmoney";
            this.fmoney.Size = new System.Drawing.Size(206, 44);
            this.fmoney.TabIndex = 2;
            this.fmoney.Text = "Final Money";
            // 
            // userimg
            // 
            this.userimg.BackColor = System.Drawing.Color.Transparent;
            this.userimg.BackgroundImage = global::CYOA.Properties.Resources.Mild;
            this.userimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userimg.Location = new System.Drawing.Point(114, 142);
            this.userimg.Name = "userimg";
            this.userimg.Size = new System.Drawing.Size(106, 102);
            this.userimg.TabIndex = 28;
            this.userimg.TabStop = false;
            // 
            // Mscore
            // 
            this.Mscore.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mscore.ForeColor = System.Drawing.Color.Lime;
            this.Mscore.Location = new System.Drawing.Point(363, 166);
            this.Mscore.Name = "Mscore";
            this.Mscore.Size = new System.Drawing.Size(272, 66);
            this.Mscore.TabIndex = 29;
            this.Mscore.Text = "Cash";
            this.Mscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(288, 352);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(78, 49);
            this.exit.TabIndex = 30;
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Finale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(676, 421);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Mscore);
            this.Controls.Add(this.userimg);
            this.Controls.Add(this.fmoney);
            this.Controls.Add(this.fmood);
            this.Controls.Add(this.Flabel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Finale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash";
            this.Load += new System.EventHandler(this.Finale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Flabel;
        private System.Windows.Forms.Label fmood;
        private System.Windows.Forms.Label fmoney;
        private System.Windows.Forms.PictureBox userimg;
        public System.Windows.Forms.Timer HUD;
        private System.Windows.Forms.Label Mscore;
        private System.Windows.Forms.Label exit;
    }
}