namespace CYOA
{
    partial class Passit
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
            this.password = new System.Windows.Forms.TextBox();
            this.userimg = new System.Windows.Forms.PictureBox();
            this.UserName = new System.Windows.Forms.Label();
            this.hint = new System.Windows.Forms.Label();
            this.Dayx = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.daycounter = new System.Windows.Forms.Timer(this.components);
            this.Explanation = new System.Windows.Forms.Label();
            this.Firstnext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userimg)).BeginInit();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.Enabled = false;
            this.password.Location = new System.Drawing.Point(275, 256);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(190, 20);
            this.password.TabIndex = 0;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // userimg
            // 
            this.userimg.BackColor = System.Drawing.Color.Transparent;
            this.userimg.BackgroundImage = global::CYOA.Properties.Resources.thumb_14400082930User;
            this.userimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userimg.Location = new System.Drawing.Point(321, 111);
            this.userimg.Name = "userimg";
            this.userimg.Size = new System.Drawing.Size(103, 81);
            this.userimg.TabIndex = 6;
            this.userimg.TabStop = false;
            this.userimg.Click += new System.EventHandler(this.userimg_Click);
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.Color.Transparent;
            this.UserName.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.UserName.Location = new System.Drawing.Point(188, 211);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(360, 33);
            this.UserName.TabIndex = 7;
            this.UserName.Text = "Name here";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hint
            // 
            this.hint.BackColor = System.Drawing.Color.Black;
            this.hint.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hint.ForeColor = System.Drawing.Color.Red;
            this.hint.Location = new System.Drawing.Point(185, 279);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(366, 92);
            this.hint.TabIndex = 8;
            this.hint.Text = "Different riddles will appear here!\r\nPress \"Close Help\" to begin todays riddle!";
            this.hint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hint.Click += new System.EventHandler(this.hint_Click);
            // 
            // Dayx
            // 
            this.Dayx.BackColor = System.Drawing.Color.Transparent;
            this.Dayx.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dayx.ForeColor = System.Drawing.Color.Yellow;
            this.Dayx.Location = new System.Drawing.Point(182, 32);
            this.Dayx.Name = "Dayx";
            this.Dayx.Size = new System.Drawing.Size(366, 59);
            this.Dayx.TabIndex = 9;
            this.Dayx.Text = "Day 1";
            this.Dayx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(688, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(50, 50);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.Black;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.ForeColor = System.Drawing.Color.Red;
            this.Next.Location = new System.Drawing.Point(538, 413);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(200, 75);
            this.Next.TabIndex = 11;
            this.Next.Text = "Next!";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Visible = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // daycounter
            // 
            this.daycounter.Enabled = true;
            this.daycounter.Tick += new System.EventHandler(this.daycounter_Tick);
            // 
            // Explanation
            // 
            this.Explanation.BackColor = System.Drawing.Color.Black;
            this.Explanation.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Explanation.ForeColor = System.Drawing.Color.Red;
            this.Explanation.Location = new System.Drawing.Point(160, 1);
            this.Explanation.Name = "Explanation";
            this.Explanation.Size = new System.Drawing.Size(427, 92);
            this.Explanation.TabIndex = 12;
            this.Explanation.Text = "Welcome to the passcode! You are overprotective and have set up riddles to preven" +
    "t computer theft. Everyday you must solve a riddle to unlock your trading portfo" +
    "lio! ";
            this.Explanation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Explanation.Click += new System.EventHandler(this.Explanation_Click);
            // 
            // Firstnext
            // 
            this.Firstnext.BackColor = System.Drawing.Color.Black;
            this.Firstnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firstnext.ForeColor = System.Drawing.Color.Red;
            this.Firstnext.Location = new System.Drawing.Point(538, 413);
            this.Firstnext.Name = "Firstnext";
            this.Firstnext.Size = new System.Drawing.Size(200, 75);
            this.Firstnext.TabIndex = 13;
            this.Firstnext.Text = "Close help!";
            this.Firstnext.UseVisualStyleBackColor = false;
            this.Firstnext.Click += new System.EventHandler(this.button1_Click);
            // 
            // Passit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CYOA.Properties.Resources.windows10erbaadelaekkertogfyldtmedpjat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.Firstnext);
            this.Controls.Add(this.Explanation);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Dayx);
            this.Controls.Add(this.hint);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.userimg);
            this.Controls.Add(this.password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Passit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pass1";
            this.Load += new System.EventHandler(this.Passit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox userimg;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Dayx;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Next;
        public System.Windows.Forms.Timer daycounter;
        public System.Windows.Forms.Label hint;
        public System.Windows.Forms.Label Explanation;
        private System.Windows.Forms.Button Firstnext;
        private System.Windows.Forms.TextBox password;
    }
}