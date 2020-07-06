namespace CYOA
{
    partial class path1
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
            this.output = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.Label();
            this.HUD = new System.Windows.Forms.Timer(this.components);
            this.describ = new System.Windows.Forms.Label();
            this.daylabel = new System.Windows.Forms.Label();
            this.next2 = new System.Windows.Forms.Button();
            this.next1 = new System.Windows.Forms.Button();
            this.next4 = new System.Windows.Forms.Button();
            this.next5 = new System.Windows.Forms.Button();
            this.next3 = new System.Windows.Forms.Button();
            this.stocks = new System.Windows.Forms.PictureBox();
            this.cat = new System.Windows.Forms.PictureBox();
            this.NVDA = new System.Windows.Forms.PictureBox();
            this.pizzab = new System.Windows.Forms.PictureBox();
            this.corolla = new System.Windows.Forms.PictureBox();
            this.userimg = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NVDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corolla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userimg)).BeginInit();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.Black;
            this.output.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.ForeColor = System.Drawing.Color.White;
            this.output.Location = new System.Drawing.Point(0, 370);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(736, 98);
            this.output.TabIndex = 1;
            // 
            // Welcome
            // 
            this.Welcome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Welcome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(494, -2);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(162, 68);
            this.Welcome.TabIndex = 29;
            this.Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // money
            // 
            this.money.BackColor = System.Drawing.Color.Black;
            this.money.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money.ForeColor = System.Drawing.Color.Lime;
            this.money.Location = new System.Drawing.Point(494, 66);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(243, 35);
            this.money.TabIndex = 30;
            this.money.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HUD
            // 
            this.HUD.Enabled = true;
            this.HUD.Tick += new System.EventHandler(this.HUD_Tick);
            // 
            // describ
            // 
            this.describ.BackColor = System.Drawing.Color.Black;
            this.describ.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.describ.ForeColor = System.Drawing.Color.Lime;
            this.describ.Location = new System.Drawing.Point(210, -2);
            this.describ.Name = "describ";
            this.describ.Size = new System.Drawing.Size(284, 68);
            this.describ.TabIndex = 32;
            this.describ.Text = "Choose mode of transportation";
            this.describ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // daylabel
            // 
            this.daylabel.BackColor = System.Drawing.Color.Black;
            this.daylabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daylabel.ForeColor = System.Drawing.Color.Yellow;
            this.daylabel.Location = new System.Drawing.Point(-19, -2);
            this.daylabel.Name = "daylabel";
            this.daylabel.Size = new System.Drawing.Size(234, 68);
            this.daylabel.TabIndex = 33;
            this.daylabel.Text = "Day 1";
            this.daylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // next2
            // 
            this.next2.BackColor = System.Drawing.Color.Black;
            this.next2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next2.ForeColor = System.Drawing.Color.Red;
            this.next2.Location = new System.Drawing.Point(567, 315);
            this.next2.Name = "next2";
            this.next2.Size = new System.Drawing.Size(155, 52);
            this.next2.TabIndex = 45;
            this.next2.Text = "Next";
            this.next2.UseVisualStyleBackColor = false;
            this.next2.Visible = false;
            this.next2.Click += new System.EventHandler(this.next2_Click);
            // 
            // next1
            // 
            this.next1.BackColor = System.Drawing.Color.Black;
            this.next1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next1.ForeColor = System.Drawing.Color.Red;
            this.next1.Location = new System.Drawing.Point(567, 315);
            this.next1.Name = "next1";
            this.next1.Size = new System.Drawing.Size(155, 52);
            this.next1.TabIndex = 46;
            this.next1.Text = "Next";
            this.next1.UseVisualStyleBackColor = false;
            this.next1.Visible = false;
            this.next1.Click += new System.EventHandler(this.next1_Click);
            // 
            // next4
            // 
            this.next4.BackColor = System.Drawing.Color.Black;
            this.next4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next4.ForeColor = System.Drawing.Color.Red;
            this.next4.Location = new System.Drawing.Point(567, 315);
            this.next4.Name = "next4";
            this.next4.Size = new System.Drawing.Size(155, 52);
            this.next4.TabIndex = 47;
            this.next4.Text = "Next";
            this.next4.UseVisualStyleBackColor = false;
            this.next4.Visible = false;
            this.next4.Click += new System.EventHandler(this.next4_Click);
            // 
            // next5
            // 
            this.next5.BackColor = System.Drawing.Color.Black;
            this.next5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next5.ForeColor = System.Drawing.Color.Red;
            this.next5.Location = new System.Drawing.Point(567, 315);
            this.next5.Name = "next5";
            this.next5.Size = new System.Drawing.Size(155, 52);
            this.next5.TabIndex = 48;
            this.next5.Text = "Next";
            this.next5.UseVisualStyleBackColor = false;
            this.next5.Visible = false;
            this.next5.Click += new System.EventHandler(this.next5_Click);
            // 
            // next3
            // 
            this.next3.BackColor = System.Drawing.Color.Black;
            this.next3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next3.ForeColor = System.Drawing.Color.Red;
            this.next3.Location = new System.Drawing.Point(567, 315);
            this.next3.Name = "next3";
            this.next3.Size = new System.Drawing.Size(155, 52);
            this.next3.TabIndex = 49;
            this.next3.Text = "Next";
            this.next3.UseVisualStyleBackColor = false;
            this.next3.Visible = false;
            this.next3.Click += new System.EventHandler(this.next3_Click);
            // 
            // stocks
            // 
            this.stocks.BackgroundImage = global::CYOA.Properties.Resources.Stock_Market_PNG_HD1;
            this.stocks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stocks.Location = new System.Drawing.Point(37, 72);
            this.stocks.Name = "stocks";
            this.stocks.Size = new System.Drawing.Size(402, 295);
            this.stocks.TabIndex = 55;
            this.stocks.TabStop = false;
            this.stocks.Visible = false;
            // 
            // cat
            // 
            this.cat.BackgroundImage = global::CYOA.Properties.Resources.Cat_PNG_HD1;
            this.cat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cat.Location = new System.Drawing.Point(37, 69);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(402, 292);
            this.cat.TabIndex = 54;
            this.cat.TabStop = false;
            this.cat.Visible = false;
            // 
            // NVDA
            // 
            this.NVDA.BackgroundImage = global::CYOA.Properties.Resources.GeForce_GTX_1080_21;
            this.NVDA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NVDA.Location = new System.Drawing.Point(37, 78);
            this.NVDA.Name = "NVDA";
            this.NVDA.Size = new System.Drawing.Size(402, 289);
            this.NVDA.TabIndex = 53;
            this.NVDA.TabStop = false;
            this.NVDA.Visible = false;
            // 
            // pizzab
            // 
            this.pizzab.BackgroundImage = global::CYOA.Properties.Resources.Stretched_out_Steve;
            this.pizzab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pizzab.Location = new System.Drawing.Point(37, 72);
            this.pizzab.Name = "pizzab";
            this.pizzab.Size = new System.Drawing.Size(402, 295);
            this.pizzab.TabIndex = 51;
            this.pizzab.TabStop = false;
            this.pizzab.Visible = false;
            // 
            // corolla
            // 
            this.corolla.BackgroundImage = global::CYOA.Properties.Resources.Toyota_Transparent_PNG1;
            this.corolla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.corolla.Location = new System.Drawing.Point(37, 114);
            this.corolla.Name = "corolla";
            this.corolla.Size = new System.Drawing.Size(402, 219);
            this.corolla.TabIndex = 31;
            this.corolla.TabStop = false;
            this.corolla.Visible = false;
            // 
            // userimg
            // 
            this.userimg.BackColor = System.Drawing.Color.Transparent;
            this.userimg.BackgroundImage = global::CYOA.Properties.Resources.Mild;
            this.userimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userimg.Location = new System.Drawing.Point(656, -2);
            this.userimg.Name = "userimg";
            this.userimg.Size = new System.Drawing.Size(80, 68);
            this.userimg.TabIndex = 28;
            this.userimg.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(567, 104);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(155, 42);
            this.Exit.TabIndex = 58;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // path1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.next1);
            this.Controls.Add(this.next2);
            this.Controls.Add(this.next3);
            this.Controls.Add(this.next4);
            this.Controls.Add(this.stocks);
            this.Controls.Add(this.cat);
            this.Controls.Add(this.NVDA);
            this.Controls.Add(this.pizzab);
            this.Controls.Add(this.next5);
            this.Controls.Add(this.daylabel);
            this.Controls.Add(this.describ);
            this.Controls.Add(this.corolla);
            this.Controls.Add(this.money);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.userimg);
            this.Controls.Add(this.output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "path1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "path1";
            this.Load += new System.EventHandler(this.path1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NVDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corolla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userimg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label money;
        private System.Windows.Forms.Timer HUD;
        public System.Windows.Forms.Label output;
        public System.Windows.Forms.Label describ;
        public System.Windows.Forms.Label daylabel;
        public System.Windows.Forms.PictureBox userimg;
        public System.Windows.Forms.Label Welcome;
        public System.Windows.Forms.PictureBox corolla;
        public System.Windows.Forms.Button next2;
        public System.Windows.Forms.Button next1;
        public System.Windows.Forms.Button next4;
        public System.Windows.Forms.Button next5;
        public System.Windows.Forms.Button next3;
        public System.Windows.Forms.PictureBox pizzab;
        public System.Windows.Forms.PictureBox NVDA;
        public System.Windows.Forms.PictureBox cat;
        public System.Windows.Forms.PictureBox stocks;
        private System.Windows.Forms.Button Exit;
    }
}