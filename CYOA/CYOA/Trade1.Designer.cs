namespace CYOA
{
    partial class trade1
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
            this.tradenext = new System.Windows.Forms.Button();
            this.stockl2 = new System.Windows.Forms.Label();
            this.stockl1 = new System.Windows.Forms.Label();
            this.loops = new System.Windows.Forms.Timer(this.components);
            this.Welcome = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.Label();
            this.stocknews1 = new System.Windows.Forms.Label();
            this.stocknews2 = new System.Windows.Forms.Label();
            this.daycount = new System.Windows.Forms.Label();
            this.tutorial1 = new System.Windows.Forms.Label();
            this.tutorial2 = new System.Windows.Forms.Label();
            this.tutorial5 = new System.Windows.Forms.Label();
            this.tutorial4 = new System.Windows.Forms.Label();
            this.tutorial3 = new System.Windows.Forms.Label();
            this.closehelp = new System.Windows.Forms.Button();
            this.news2 = new System.Windows.Forms.PictureBox();
            this.News = new System.Windows.Forms.PictureBox();
            this.stock2 = new System.Windows.Forms.Button();
            this.stock1 = new System.Windows.Forms.Button();
            this.userimg = new System.Windows.Forms.PictureBox();
            this.top = new System.Windows.Forms.PictureBox();
            this.dollas = new System.Windows.Forms.Timer(this.components);
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.news2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.News)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).BeginInit();
            this.SuspendLayout();
            // 
            // tradenext
            // 
            this.tradenext.BackColor = System.Drawing.Color.Red;
            this.tradenext.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tradenext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tradenext.Location = new System.Drawing.Point(761, 633);
            this.tradenext.Name = "tradenext";
            this.tradenext.Size = new System.Drawing.Size(203, 69);
            this.tradenext.TabIndex = 1;
            this.tradenext.Text = "Trade";
            this.tradenext.UseVisualStyleBackColor = false;
            this.tradenext.Click += new System.EventHandler(this.button1_Click);
            // 
            // stockl2
            // 
            this.stockl2.BackColor = System.Drawing.Color.Transparent;
            this.stockl2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockl2.Location = new System.Drawing.Point(43, 421);
            this.stockl2.Name = "stockl2";
            this.stockl2.Size = new System.Drawing.Size(100, 23);
            this.stockl2.TabIndex = 4;
            this.stockl2.Text = "Micron (MU)";
            // 
            // stockl1
            // 
            this.stockl1.BackColor = System.Drawing.Color.Transparent;
            this.stockl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockl1.Location = new System.Drawing.Point(43, 126);
            this.stockl1.Name = "stockl1";
            this.stockl1.Size = new System.Drawing.Size(124, 23);
            this.stockl1.TabIndex = 5;
            this.stockl1.Text = "Nvidia (NVDA)";
            // 
            // loops
            // 
            this.loops.Enabled = true;
            this.loops.Tick += new System.EventHandler(this.loops_Tick);
            // 
            // Welcome
            // 
            this.Welcome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Welcome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(741, 0);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(150, 94);
            this.Welcome.TabIndex = 9;
            this.Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // money
            // 
            this.money.BackColor = System.Drawing.Color.Black;
            this.money.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money.ForeColor = System.Drawing.Color.Lime;
            this.money.Location = new System.Drawing.Point(741, 93);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(240, 35);
            this.money.TabIndex = 11;
            this.money.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stocknews1
            // 
            this.stocknews1.BackColor = System.Drawing.Color.Transparent;
            this.stocknews1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocknews1.ForeColor = System.Drawing.Color.Black;
            this.stocknews1.Location = new System.Drawing.Point(744, 180);
            this.stocknews1.Name = "stocknews1";
            this.stocknews1.Size = new System.Drawing.Size(237, 35);
            this.stocknews1.TabIndex = 14;
            this.stocknews1.Text = "Read about .............";
            this.stocknews1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stocknews2
            // 
            this.stocknews2.BackColor = System.Drawing.Color.Transparent;
            this.stocknews2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocknews2.ForeColor = System.Drawing.Color.Black;
            this.stocknews2.Location = new System.Drawing.Point(744, 448);
            this.stocknews2.Name = "stocknews2";
            this.stocknews2.Size = new System.Drawing.Size(237, 35);
            this.stocknews2.TabIndex = 15;
            this.stocknews2.Text = "Read about .............";
            this.stocknews2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // daycount
            // 
            this.daycount.BackColor = System.Drawing.Color.Transparent;
            this.daycount.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daycount.ForeColor = System.Drawing.Color.Black;
            this.daycount.Location = new System.Drawing.Point(346, 97);
            this.daycount.Name = "daycount";
            this.daycount.Size = new System.Drawing.Size(240, 35);
            this.daycount.TabIndex = 16;
            this.daycount.Text = "Day1";
            this.daycount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tutorial1
            // 
            this.tutorial1.BackColor = System.Drawing.Color.Black;
            this.tutorial1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorial1.ForeColor = System.Drawing.Color.Red;
            this.tutorial1.Location = new System.Drawing.Point(201, 366);
            this.tutorial1.Name = "tutorial1";
            this.tutorial1.Size = new System.Drawing.Size(385, 106);
            this.tutorial1.TabIndex = 17;
            this.tutorial1.Text = "Above and below are two companies of the day. Everyday two new companies will app" +
    "ear. You must read the charts and decide which of the two you would like to eith" +
    "er buy or sell.";
            // 
            // tutorial2
            // 
            this.tutorial2.BackColor = System.Drawing.Color.Black;
            this.tutorial2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorial2.ForeColor = System.Drawing.Color.Red;
            this.tutorial2.Location = new System.Drawing.Point(507, 549);
            this.tutorial2.Name = "tutorial2";
            this.tutorial2.Size = new System.Drawing.Size(237, 52);
            this.tutorial2.TabIndex = 18;
            this.tutorial2.Text = "To the bottom right there will be a trade button. Press the trade button to make " +
    "a trade. If you are ready to make a trade click \"Close help\".";
            this.tutorial2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tutorial5
            // 
            this.tutorial5.BackColor = System.Drawing.Color.Black;
            this.tutorial5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorial5.ForeColor = System.Drawing.Color.Red;
            this.tutorial5.Location = new System.Drawing.Point(282, 9);
            this.tutorial5.Name = "tutorial5";
            this.tutorial5.Size = new System.Drawing.Size(385, 73);
            this.tutorial5.TabIndex = 19;
            this.tutorial5.Text = "Welcome to the watchlist! Two stocks that are appealing to you will be chosen eve" +
    "ryday. Analyse the trends and trade away!";
            // 
            // tutorial4
            // 
            this.tutorial4.BackColor = System.Drawing.Color.Black;
            this.tutorial4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorial4.ForeColor = System.Drawing.Color.Red;
            this.tutorial4.Location = new System.Drawing.Point(423, 124);
            this.tutorial4.Name = "tutorial4";
            this.tutorial4.Size = new System.Drawing.Size(315, 119);
            this.tutorial4.TabIndex = 20;
            this.tutorial4.Text = "In the top right corner your mood is represented by an icon and your money is dis" +
    "played. You will start with a mild mood and $100000. Be careful with your decisi" +
    "ons as this can easily change!";
            // 
            // tutorial3
            // 
            this.tutorial3.BackColor = System.Drawing.Color.Black;
            this.tutorial3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorial3.ForeColor = System.Drawing.Color.Red;
            this.tutorial3.Location = new System.Drawing.Point(741, 327);
            this.tutorial3.Name = "tutorial3";
            this.tutorial3.Size = new System.Drawing.Size(240, 117);
            this.tutorial3.TabIndex = 21;
            this.tutorial3.Text = "Based on current stocks you will be able to access insider news reports. Each new" +
    "s report costs $1000 but can give you some insight on which stock is best.";
            // 
            // closehelp
            // 
            this.closehelp.BackColor = System.Drawing.Color.Black;
            this.closehelp.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closehelp.ForeColor = System.Drawing.Color.Red;
            this.closehelp.Location = new System.Drawing.Point(761, 633);
            this.closehelp.Name = "closehelp";
            this.closehelp.Size = new System.Drawing.Size(203, 69);
            this.closehelp.TabIndex = 22;
            this.closehelp.Text = "Close help";
            this.closehelp.UseVisualStyleBackColor = false;
            this.closehelp.Click += new System.EventHandler(this.closehelp_Click);
            // 
            // news2
            // 
            this.news2.BackColor = System.Drawing.Color.Transparent;
            this.news2.BackgroundImage = global::CYOA.Properties.Resources.Newspaper_PNG_Clipart;
            this.news2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.news2.Enabled = false;
            this.news2.Location = new System.Drawing.Point(786, 499);
            this.news2.Name = "news2";
            this.news2.Size = new System.Drawing.Size(141, 119);
            this.news2.TabIndex = 13;
            this.news2.TabStop = false;
            this.news2.Click += new System.EventHandler(this.news2_Click);
            // 
            // News
            // 
            this.News.BackColor = System.Drawing.Color.Transparent;
            this.News.BackgroundImage = global::CYOA.Properties.Resources.Newspaper_PNG_Clipart;
            this.News.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.News.Enabled = false;
            this.News.Location = new System.Drawing.Point(786, 218);
            this.News.Name = "News";
            this.News.Size = new System.Drawing.Size(141, 119);
            this.News.TabIndex = 12;
            this.News.TabStop = false;
            this.News.Click += new System.EventHandler(this.News_Click);
            // 
            // stock2
            // 
            this.stock2.BackgroundImage = global::CYOA.Properties.Resources.good2;
            this.stock2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stock2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stock2.Location = new System.Drawing.Point(28, 448);
            this.stock2.Name = "stock2";
            this.stock2.Size = new System.Drawing.Size(716, 254);
            this.stock2.TabIndex = 3;
            this.stock2.UseVisualStyleBackColor = true;
            // 
            // stock1
            // 
            this.stock1.BackgroundImage = global::CYOA.Properties.Resources.good2;
            this.stock1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stock1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stock1.Location = new System.Drawing.Point(28, 152);
            this.stock1.Name = "stock1";
            this.stock1.Size = new System.Drawing.Size(716, 257);
            this.stock1.TabIndex = 2;
            this.stock1.UseVisualStyleBackColor = true;
            this.stock1.Click += new System.EventHandler(this.stock1_Click);
            // 
            // userimg
            // 
            this.userimg.BackColor = System.Drawing.Color.Transparent;
            this.userimg.BackgroundImage = global::CYOA.Properties.Resources.Mild;
            this.userimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userimg.Location = new System.Drawing.Point(891, 0);
            this.userimg.Name = "userimg";
            this.userimg.Size = new System.Drawing.Size(90, 94);
            this.userimg.TabIndex = 10;
            this.userimg.TabStop = false;
            // 
            // top
            // 
            this.top.BackgroundImage = global::CYOA.Properties.Resources.investopedia;
            this.top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.top.Location = new System.Drawing.Point(-1, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(982, 94);
            this.top.TabIndex = 8;
            this.top.TabStop = false;
            this.top.Click += new System.EventHandler(this.top_Click);
            // 
            // dollas
            // 
            this.dollas.Enabled = true;
            this.dollas.Tick += new System.EventHandler(this.dollas_Tick);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(891, 132);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(90, 45);
            this.Exit.TabIndex = 23;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // trade1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(981, 714);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.closehelp);
            this.Controls.Add(this.tutorial3);
            this.Controls.Add(this.tutorial4);
            this.Controls.Add(this.tutorial5);
            this.Controls.Add(this.tutorial2);
            this.Controls.Add(this.tutorial1);
            this.Controls.Add(this.daycount);
            this.Controls.Add(this.stocknews2);
            this.Controls.Add(this.stocknews1);
            this.Controls.Add(this.news2);
            this.Controls.Add(this.News);
            this.Controls.Add(this.money);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.stockl1);
            this.Controls.Add(this.stockl2);
            this.Controls.Add(this.stock2);
            this.Controls.Add(this.stock1);
            this.Controls.Add(this.tradenext);
            this.Controls.Add(this.userimg);
            this.Controls.Add(this.top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "trade1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.news2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.News)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button tradenext;
        private System.Windows.Forms.Button stock1;
        private System.Windows.Forms.Button stock2;
        private System.Windows.Forms.Label stockl2;
        private System.Windows.Forms.Label stockl1;
        private System.Windows.Forms.PictureBox top;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.PictureBox userimg;
        private System.Windows.Forms.PictureBox News;
        private System.Windows.Forms.PictureBox news2;
        private System.Windows.Forms.Label stocknews1;
        private System.Windows.Forms.Label stocknews2;
        private System.Windows.Forms.Label daycount;
        private System.Windows.Forms.Label tutorial1;
        private System.Windows.Forms.Label tutorial2;
        private System.Windows.Forms.Label tutorial5;
        private System.Windows.Forms.Label tutorial4;
        private System.Windows.Forms.Label tutorial3;
        private System.Windows.Forms.Button closehelp;
        public System.Windows.Forms.Timer loops;
        public System.Windows.Forms.Label money;
        private System.Windows.Forms.Timer dollas;
        private System.Windows.Forms.Button Exit;
    }
}