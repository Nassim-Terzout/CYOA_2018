namespace CYOA
{
    partial class intro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(intro));
            this.input = new System.Windows.Forms.TextBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.instructions1 = new System.Windows.Forms.Label();
            this.belowtboxtext = new System.Windows.Forms.Label();
            this.AverageSchoolPC = new System.Windows.Forms.PictureBox();
            this.uglyguy = new System.Windows.Forms.PictureBox();
            this.MrKrabs1 = new System.Windows.Forms.PictureBox();
            this.MrKrabs2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AverageSchoolPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uglyguy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MrKrabs1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MrKrabs2)).BeginInit();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(237, 195);
            this.input.MaxLength = 16;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(222, 20);
            this.input.TabIndex = 0;
            // 
            // Namelabel
            // 
            this.Namelabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.Location = new System.Drawing.Point(188, 168);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(306, 24);
            this.Namelabel.TabIndex = 1;
            this.Namelabel.Text = "Please enter your desired name below";
            this.Namelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.Black;
            this.Next.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.ForeColor = System.Drawing.Color.Red;
            this.Next.Location = new System.Drawing.Point(259, 333);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(200, 75);
            this.Next.TabIndex = 2;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(688, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(50, 50);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // instructions1
            // 
            this.instructions1.BackColor = System.Drawing.Color.Black;
            this.instructions1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions1.ForeColor = System.Drawing.Color.White;
            this.instructions1.Location = new System.Drawing.Point(12, 9);
            this.instructions1.Name = "instructions1";
            this.instructions1.Size = new System.Drawing.Size(670, 159);
            this.instructions1.TabIndex = 4;
            this.instructions1.Text = resources.GetString("instructions1.Text");
            this.instructions1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.instructions1.Click += new System.EventHandler(this.label1_Click);
            // 
            // belowtboxtext
            // 
            this.belowtboxtext.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.belowtboxtext.Location = new System.Drawing.Point(174, 233);
            this.belowtboxtext.Name = "belowtboxtext";
            this.belowtboxtext.Size = new System.Drawing.Size(348, 24);
            this.belowtboxtext.TabIndex = 5;
            this.belowtboxtext.Text = "When you have entered a name press \"Next\"";
            this.belowtboxtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AverageSchoolPC
            // 
            this.AverageSchoolPC.BackgroundImage = global::CYOA.Properties.Resources.clip_art_2445416_960_720;
            this.AverageSchoolPC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AverageSchoolPC.Location = new System.Drawing.Point(1, 283);
            this.AverageSchoolPC.Name = "AverageSchoolPC";
            this.AverageSchoolPC.Size = new System.Drawing.Size(226, 217);
            this.AverageSchoolPC.TabIndex = 7;
            this.AverageSchoolPC.TabStop = false;
            // 
            // uglyguy
            // 
            this.uglyguy.BackgroundImage = global::CYOA.Properties.Resources.teacher_manager_between_chair_and_desk_hi;
            this.uglyguy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uglyguy.Location = new System.Drawing.Point(505, 295);
            this.uglyguy.Name = "uglyguy";
            this.uglyguy.Size = new System.Drawing.Size(249, 205);
            this.uglyguy.TabIndex = 6;
            this.uglyguy.TabStop = false;
            // 
            // MrKrabs1
            // 
            this.MrKrabs1.BackgroundImage = global::CYOA.Properties.Resources._13501541911789678376money_svg1;
            this.MrKrabs1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MrKrabs1.Location = new System.Drawing.Point(259, 408);
            this.MrKrabs1.Name = "MrKrabs1";
            this.MrKrabs1.Size = new System.Drawing.Size(100, 86);
            this.MrKrabs1.TabIndex = 11;
            this.MrKrabs1.TabStop = false;
            // 
            // MrKrabs2
            // 
            this.MrKrabs2.BackgroundImage = global::CYOA.Properties.Resources._13501541911789678376money_svg1;
            this.MrKrabs2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MrKrabs2.Location = new System.Drawing.Point(365, 408);
            this.MrKrabs2.Name = "MrKrabs2";
            this.MrKrabs2.Size = new System.Drawing.Size(100, 86);
            this.MrKrabs2.TabIndex = 12;
            this.MrKrabs2.TabStop = false;
            // 
            // intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.MrKrabs2);
            this.Controls.Add(this.MrKrabs1);
            this.Controls.Add(this.AverageSchoolPC);
            this.Controls.Add(this.uglyguy);
            this.Controls.Add(this.belowtboxtext);
            this.Controls.Add(this.instructions1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "intro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Name";
            this.Load += new System.EventHandler(this.intro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AverageSchoolPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uglyguy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MrKrabs1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MrKrabs2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Namelabel;
        public System.Windows.Forms.TextBox input;
        public System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label instructions1;
        private System.Windows.Forms.Label belowtboxtext;
        private System.Windows.Forms.PictureBox uglyguy;
        private System.Windows.Forms.PictureBox AverageSchoolPC;
        private System.Windows.Forms.PictureBox MrKrabs1;
        private System.Windows.Forms.PictureBox MrKrabs2;
    }
}