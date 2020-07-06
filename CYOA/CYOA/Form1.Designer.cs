namespace CYOA
{
    partial class Menu
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
            this.newstart = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.cash = new System.Windows.Forms.PictureBox();
            this.lambo = new System.Windows.Forms.PictureBox();
            this.cashpic = new System.Windows.Forms.PictureBox();
            this.titlee = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlee)).BeginInit();
            this.SuspendLayout();
            // 
            // newstart
            // 
            this.newstart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.newstart.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newstart.Location = new System.Drawing.Point(266, 413);
            this.newstart.Name = "newstart";
            this.newstart.Size = new System.Drawing.Size(200, 75);
            this.newstart.TabIndex = 1;
            this.newstart.Text = "Start";
            this.newstart.UseVisualStyleBackColor = false;
            this.newstart.Click += new System.EventHandler(this.Help_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(697, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(50, 50);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // cash
            // 
            this.cash.BackColor = System.Drawing.Color.Transparent;
            this.cash.BackgroundImage = global::CYOA.Properties.Resources.Heart_clip_art_valentine_heart_29_1969px;
            this.cash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cash.Location = new System.Drawing.Point(641, 321);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(97, 74);
            this.cash.TabIndex = 3;
            this.cash.TabStop = false;
            // 
            // lambo
            // 
            this.lambo.BackColor = System.Drawing.Color.Transparent;
            this.lambo.BackgroundImage = global::CYOA.Properties.Resources.car_29078_960_720;
            this.lambo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lambo.Location = new System.Drawing.Point(603, 401);
            this.lambo.Name = "lambo";
            this.lambo.Size = new System.Drawing.Size(144, 87);
            this.lambo.TabIndex = 4;
            this.lambo.TabStop = false;
            // 
            // cashpic
            // 
            this.cashpic.BackColor = System.Drawing.Color.Transparent;
            this.cashpic.BackgroundImage = global::CYOA.Properties.Resources.ancient_money_clipart;
            this.cashpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cashpic.Location = new System.Drawing.Point(550, 244);
            this.cashpic.Name = "cashpic";
            this.cashpic.Size = new System.Drawing.Size(103, 81);
            this.cashpic.TabIndex = 5;
            this.cashpic.TabStop = false;
            // 
            // titlee
            // 
            this.titlee.BackColor = System.Drawing.Color.Transparent;
            this.titlee.BackgroundImage = global::CYOA.Properties.Resources.tradinglife;
            this.titlee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.titlee.Location = new System.Drawing.Point(143, 2);
            this.titlee.Name = "titlee";
            this.titlee.Size = new System.Drawing.Size(441, 92);
            this.titlee.TabIndex = 6;
            this.titlee.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CYOA.Properties.Resources.lgi01a201310180400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.titlee);
            this.Controls.Add(this.cashpic);
            this.Controls.Add(this.lambo);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.newstart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button newstart;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox cash;
        private System.Windows.Forms.PictureBox lambo;
        private System.Windows.Forms.PictureBox cashpic;
        private System.Windows.Forms.PictureBox titlee;
    }
}

