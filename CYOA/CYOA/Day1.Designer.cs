namespace CYOA
{
    partial class Day1
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
            this.day1label = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.tutorial4 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // day1label
            // 
            this.day1label.Font = new System.Drawing.Font("Franklin Gothic Demi", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day1label.ForeColor = System.Drawing.Color.Yellow;
            this.day1label.Location = new System.Drawing.Point(246, 149);
            this.day1label.Name = "day1label";
            this.day1label.Size = new System.Drawing.Size(237, 98);
            this.day1label.TabIndex = 0;
            this.day1label.Text = "Day 1";
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.Black;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.ForeColor = System.Drawing.Color.Red;
            this.Next.Location = new System.Drawing.Point(522, 374);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(200, 75);
            this.Next.TabIndex = 12;
            this.Next.Text = "Next!";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // tutorial4
            // 
            this.tutorial4.BackColor = System.Drawing.Color.Black;
            this.tutorial4.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorial4.ForeColor = System.Drawing.Color.Yellow;
            this.tutorial4.Location = new System.Drawing.Point(190, 227);
            this.tutorial4.Name = "tutorial4";
            this.tutorial4.Size = new System.Drawing.Size(315, 103);
            this.tutorial4.TabIndex = 32;
            this.tutorial4.Text = "(Tutorial Day)";
            this.tutorial4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(672, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(50, 50);
            this.Exit.TabIndex = 33;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Day1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.tutorial4);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.day1label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Day1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "passintro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label day1label;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label tutorial4;
        private System.Windows.Forms.Button Exit;
    }
}