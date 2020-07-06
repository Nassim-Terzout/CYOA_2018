namespace CYOA
{
    partial class Result
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
            this.wl = new System.Windows.Forms.Label();
            this.cash = new System.Windows.Forms.PictureBox();
            this.tutorial5 = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cash)).BeginInit();
            this.SuspendLayout();
            // 
            // wl
            // 
            this.wl.Font = new System.Drawing.Font("Franklin Gothic Demi", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wl.ForeColor = System.Drawing.Color.Red;
            this.wl.Location = new System.Drawing.Point(145, 152);
            this.wl.Name = "wl";
            this.wl.Size = new System.Drawing.Size(345, 98);
            this.wl.TabIndex = 1;
            this.wl.Text = "- $30000";
            this.wl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cash
            // 
            this.cash.BackColor = System.Drawing.Color.Transparent;
            this.cash.BackgroundImage = global::CYOA.Properties.Resources.ancient_money_clipart;
            this.cash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cash.Location = new System.Drawing.Point(482, 152);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(103, 98);
            this.cash.TabIndex = 6;
            this.cash.TabStop = false;
            // 
            // tutorial5
            // 
            this.tutorial5.BackColor = System.Drawing.Color.Black;
            this.tutorial5.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorial5.ForeColor = System.Drawing.Color.Yellow;
            this.tutorial5.Location = new System.Drawing.Point(227, 9);
            this.tutorial5.Name = "tutorial5";
            this.tutorial5.Size = new System.Drawing.Size(286, 50);
            this.tutorial5.TabIndex = 20;
            this.tutorial5.Text = "Trading Summary";
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.Black;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.ForeColor = System.Drawing.Color.Red;
            this.Next.Location = new System.Drawing.Point(522, 374);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(200, 75);
            this.Next.TabIndex = 21;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(672, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(50, 50);
            this.Exit.TabIndex = 22;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.tutorial5);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.wl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox cash;
        private System.Windows.Forms.Label tutorial5;
        private System.Windows.Forms.Button Next;
        public System.Windows.Forms.Label wl;
        private System.Windows.Forms.Button Exit;
    }
}