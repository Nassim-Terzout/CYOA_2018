namespace CYOA
{
    partial class BuySell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuySell));
            this.symbol1 = new System.Windows.Forms.ComboBox();
            this.Tradebutton = new System.Windows.Forms.Button();
            this.slabel = new System.Windows.Forms.Label();
            this.tlabel = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.stockl1 = new System.Windows.Forms.Label();
            this.stockl2 = new System.Windows.Forms.Label();
            this.qlabel = new System.Windows.Forms.Label();
            this.quantity1 = new System.Windows.Forms.ComboBox();
            this.tutorial4 = new System.Windows.Forms.Label();
            this.tutorial5 = new System.Windows.Forms.Label();
            this.closehelp = new System.Windows.Forms.Button();
            this.loops = new System.Windows.Forms.Timer(this.components);
            this.symbol2 = new System.Windows.Forms.ComboBox();
            this.symbol3 = new System.Windows.Forms.ComboBox();
            this.symbol4 = new System.Windows.Forms.ComboBox();
            this.symbol5 = new System.Windows.Forms.ComboBox();
            this.t1 = new System.Windows.Forms.RadioButton();
            this.t2 = new System.Windows.Forms.RadioButton();
            this.tradeloops = new System.Windows.Forms.Timer(this.components);
            this.stock2 = new System.Windows.Forms.Button();
            this.stock1 = new System.Windows.Forms.Button();
            this.userimg = new System.Windows.Forms.PictureBox();
            this.top = new System.Windows.Forms.PictureBox();
            this.HUD = new System.Windows.Forms.Timer(this.components);
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).BeginInit();
            this.SuspendLayout();
            // 
            // symbol1
            // 
            this.symbol1.Enabled = false;
            this.symbol1.FormattingEnabled = true;
            this.symbol1.Items.AddRange(new object[] {
            "NVDA",
            "MU"});
            this.symbol1.Location = new System.Drawing.Point(522, 283);
            this.symbol1.Name = "symbol1";
            this.symbol1.Size = new System.Drawing.Size(121, 21);
            this.symbol1.TabIndex = 20;
            // 
            // Tradebutton
            // 
            this.Tradebutton.BackColor = System.Drawing.Color.Red;
            this.Tradebutton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tradebutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Tradebutton.Location = new System.Drawing.Point(477, 468);
            this.Tradebutton.Name = "Tradebutton";
            this.Tradebutton.Size = new System.Drawing.Size(203, 69);
            this.Tradebutton.TabIndex = 21;
            this.Tradebutton.Text = "Trade";
            this.Tradebutton.UseVisualStyleBackColor = false;
            this.Tradebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // slabel
            // 
            this.slabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.slabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slabel.ForeColor = System.Drawing.Color.Black;
            this.slabel.Location = new System.Drawing.Point(456, 245);
            this.slabel.Name = "slabel";
            this.slabel.Size = new System.Drawing.Size(237, 35);
            this.slabel.TabIndex = 22;
            this.slabel.Text = "Stock Symbol";
            this.slabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlabel
            // 
            this.tlabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tlabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlabel.ForeColor = System.Drawing.Color.Black;
            this.tlabel.Location = new System.Drawing.Point(456, 159);
            this.tlabel.Name = "tlabel";
            this.tlabel.Size = new System.Drawing.Size(237, 35);
            this.tlabel.TabIndex = 23;
            this.tlabel.Text = "Transaction ";
            this.tlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // money
            // 
            this.money.BackColor = System.Drawing.Color.Black;
            this.money.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money.ForeColor = System.Drawing.Color.Lime;
            this.money.Location = new System.Drawing.Point(456, 84);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(237, 35);
            this.money.TabIndex = 24;
            this.money.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Welcome
            // 
            this.Welcome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Welcome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(457, -4);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(150, 88);
            this.Welcome.TabIndex = 25;
            this.Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Welcome.Click += new System.EventHandler(this.Welcome_Click);
            // 
            // stockl1
            // 
            this.stockl1.BackColor = System.Drawing.Color.Transparent;
            this.stockl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockl1.Location = new System.Drawing.Point(12, 114);
            this.stockl1.Name = "stockl1";
            this.stockl1.Size = new System.Drawing.Size(124, 23);
            this.stockl1.TabIndex = 27;
            this.stockl1.Text = "Nvidia (NVDA)";
            // 
            // stockl2
            // 
            this.stockl2.BackColor = System.Drawing.Color.Transparent;
            this.stockl2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockl2.Location = new System.Drawing.Point(12, 338);
            this.stockl2.Name = "stockl2";
            this.stockl2.Size = new System.Drawing.Size(100, 23);
            this.stockl2.TabIndex = 29;
            this.stockl2.Text = "Micron (MU)";
            // 
            // qlabel
            // 
            this.qlabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.qlabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qlabel.ForeColor = System.Drawing.Color.Black;
            this.qlabel.Location = new System.Drawing.Point(456, 352);
            this.qlabel.Name = "qlabel";
            this.qlabel.Size = new System.Drawing.Size(237, 35);
            this.qlabel.TabIndex = 31;
            this.qlabel.Text = "Quantity/Price";
            this.qlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantity1
            // 
            this.quantity1.Enabled = false;
            this.quantity1.FormattingEnabled = true;
            this.quantity1.Items.AddRange(new object[] {
            "$2000",
            "$5000",
            "$10000"});
            this.quantity1.Location = new System.Drawing.Point(522, 390);
            this.quantity1.Name = "quantity1";
            this.quantity1.Size = new System.Drawing.Size(121, 21);
            this.quantity1.TabIndex = 32;
            // 
            // tutorial4
            // 
            this.tutorial4.BackColor = System.Drawing.Color.Black;
            this.tutorial4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorial4.ForeColor = System.Drawing.Color.Red;
            this.tutorial4.Location = new System.Drawing.Point(118, 1);
            this.tutorial4.Name = "tutorial4";
            this.tutorial4.Size = new System.Drawing.Size(315, 119);
            this.tutorial4.TabIndex = 33;
            this.tutorial4.Text = resources.GetString("tutorial4.Text");
            // 
            // tutorial5
            // 
            this.tutorial5.BackColor = System.Drawing.Color.Black;
            this.tutorial5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorial5.ForeColor = System.Drawing.Color.Red;
            this.tutorial5.Location = new System.Drawing.Point(118, 120);
            this.tutorial5.Name = "tutorial5";
            this.tutorial5.Size = new System.Drawing.Size(315, 422);
            this.tutorial5.TabIndex = 34;
            this.tutorial5.Text = resources.GetString("tutorial5.Text");
            // 
            // closehelp
            // 
            this.closehelp.BackColor = System.Drawing.Color.Black;
            this.closehelp.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closehelp.ForeColor = System.Drawing.Color.Red;
            this.closehelp.Location = new System.Drawing.Point(477, 468);
            this.closehelp.Name = "closehelp";
            this.closehelp.Size = new System.Drawing.Size(203, 69);
            this.closehelp.TabIndex = 35;
            this.closehelp.Text = "Close help";
            this.closehelp.UseVisualStyleBackColor = false;
            this.closehelp.Click += new System.EventHandler(this.closehelp_Click);
            // 
            // loops
            // 
            this.loops.Enabled = true;
            this.loops.Tick += new System.EventHandler(this.loops_Tick);
            // 
            // symbol2
            // 
            this.symbol2.FormattingEnabled = true;
            this.symbol2.Items.AddRange(new object[] {
            "AMD",
            "AMZN"});
            this.symbol2.Location = new System.Drawing.Point(522, 283);
            this.symbol2.Name = "symbol2";
            this.symbol2.Size = new System.Drawing.Size(121, 21);
            this.symbol2.TabIndex = 36;
            // 
            // symbol3
            // 
            this.symbol3.FormattingEnabled = true;
            this.symbol3.Items.AddRange(new object[] {
            "GOOGL",
            "BBY"});
            this.symbol3.Location = new System.Drawing.Point(522, 283);
            this.symbol3.Name = "symbol3";
            this.symbol3.Size = new System.Drawing.Size(121, 21);
            this.symbol3.TabIndex = 37;
            // 
            // symbol4
            // 
            this.symbol4.FormattingEnabled = true;
            this.symbol4.Items.AddRange(new object[] {
            "NKE",
            "ANF"});
            this.symbol4.Location = new System.Drawing.Point(522, 283);
            this.symbol4.Name = "symbol4";
            this.symbol4.Size = new System.Drawing.Size(121, 21);
            this.symbol4.TabIndex = 38;
            // 
            // symbol5
            // 
            this.symbol5.FormattingEnabled = true;
            this.symbol5.Items.AddRange(new object[] {
            "FB",
            "AEO"});
            this.symbol5.Location = new System.Drawing.Point(522, 283);
            this.symbol5.Name = "symbol5";
            this.symbol5.Size = new System.Drawing.Size(121, 21);
            this.symbol5.TabIndex = 39;
            // 
            // t1
            // 
            this.t1.AutoSize = true;
            this.t1.Enabled = false;
            this.t1.Location = new System.Drawing.Point(522, 197);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(43, 17);
            this.t1.TabIndex = 40;
            this.t1.TabStop = true;
            this.t1.Text = "Buy";
            this.t1.UseVisualStyleBackColor = true;
            // 
            // t2
            // 
            this.t2.AutoSize = true;
            this.t2.Enabled = false;
            this.t2.Location = new System.Drawing.Point(571, 197);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(50, 17);
            this.t2.TabIndex = 41;
            this.t2.TabStop = true;
            this.t2.Text = "Short";
            this.t2.UseVisualStyleBackColor = true;
            // 
            // tradeloops
            // 
            this.tradeloops.Enabled = true;
            this.tradeloops.Tick += new System.EventHandler(this.tradeloops_Tick);
            // 
            // stock2
            // 
            this.stock2.BackgroundImage = global::CYOA.Properties.Resources.good2;
            this.stock2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stock2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stock2.Location = new System.Drawing.Point(12, 364);
            this.stock2.Name = "stock2";
            this.stock2.Size = new System.Drawing.Size(396, 173);
            this.stock2.TabIndex = 30;
            this.stock2.UseVisualStyleBackColor = true;
            // 
            // stock1
            // 
            this.stock1.BackgroundImage = global::CYOA.Properties.Resources.good1;
            this.stock1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stock1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stock1.Location = new System.Drawing.Point(12, 140);
            this.stock1.Name = "stock1";
            this.stock1.Size = new System.Drawing.Size(396, 173);
            this.stock1.TabIndex = 28;
            this.stock1.UseVisualStyleBackColor = true;
            // 
            // userimg
            // 
            this.userimg.BackColor = System.Drawing.Color.Transparent;
            this.userimg.BackgroundImage = global::CYOA.Properties.Resources.thumb_14400082930User;
            this.userimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userimg.Location = new System.Drawing.Point(593, -1);
            this.userimg.Name = "userimg";
            this.userimg.Size = new System.Drawing.Size(112, 94);
            this.userimg.TabIndex = 26;
            this.userimg.TabStop = false;
            // 
            // top
            // 
            this.top.BackgroundImage = global::CYOA.Properties.Resources.investopedia;
            this.top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.top.Location = new System.Drawing.Point(-1, -1);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(694, 85);
            this.top.TabIndex = 9;
            this.top.TabStop = false;
            // 
            // HUD
            // 
            this.HUD.Enabled = true;
            this.HUD.Tick += new System.EventHandler(this.HUD_Tick);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(593, 120);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 42);
            this.Exit.TabIndex = 42;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // BuySell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 547);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.symbol5);
            this.Controls.Add(this.symbol4);
            this.Controls.Add(this.symbol3);
            this.Controls.Add(this.symbol2);
            this.Controls.Add(this.closehelp);
            this.Controls.Add(this.tutorial5);
            this.Controls.Add(this.tutorial4);
            this.Controls.Add(this.quantity1);
            this.Controls.Add(this.qlabel);
            this.Controls.Add(this.stock2);
            this.Controls.Add(this.stockl2);
            this.Controls.Add(this.stock1);
            this.Controls.Add(this.stockl1);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.money);
            this.Controls.Add(this.tlabel);
            this.Controls.Add(this.slabel);
            this.Controls.Add(this.Tradebutton);
            this.Controls.Add(this.symbol1);
            this.Controls.Add(this.userimg);
            this.Controls.Add(this.top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuySell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuySell";
            this.Load += new System.EventHandler(this.BuySell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox top;
        private System.Windows.Forms.ComboBox symbol1;
        private System.Windows.Forms.Button Tradebutton;
        private System.Windows.Forms.Label slabel;
        private System.Windows.Forms.Label tlabel;
        public System.Windows.Forms.Label money;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.PictureBox userimg;
        private System.Windows.Forms.Label stockl1;
        private System.Windows.Forms.Button stock1;
        private System.Windows.Forms.Label stockl2;
        private System.Windows.Forms.Button stock2;
        private System.Windows.Forms.Label qlabel;
        private System.Windows.Forms.ComboBox quantity1;
        private System.Windows.Forms.Label tutorial4;
        private System.Windows.Forms.Label tutorial5;
        private System.Windows.Forms.Button closehelp;
        private System.Windows.Forms.Timer loops;
        private System.Windows.Forms.ComboBox symbol2;
        private System.Windows.Forms.ComboBox symbol3;
        private System.Windows.Forms.ComboBox symbol4;
        private System.Windows.Forms.ComboBox symbol5;
        private System.Windows.Forms.RadioButton t1;
        private System.Windows.Forms.RadioButton t2;
        private System.Windows.Forms.Timer tradeloops;
        private System.Windows.Forms.Timer HUD;
        private System.Windows.Forms.Button Exit;
    }
}