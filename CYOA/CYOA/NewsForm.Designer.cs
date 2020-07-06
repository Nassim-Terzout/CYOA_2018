namespace CYOA
{
    partial class NewsForm
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
            this.newsl = new System.Windows.Forms.Label();
            this.Newssir = new System.Windows.Forms.Label();
            this.Firstnext = new System.Windows.Forms.Button();
            this.textloops = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // newsl
            // 
            this.newsl.BackColor = System.Drawing.Color.Transparent;
            this.newsl.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsl.ForeColor = System.Drawing.Color.White;
            this.newsl.Location = new System.Drawing.Point(94, -1);
            this.newsl.Name = "newsl";
            this.newsl.Size = new System.Drawing.Size(315, 96);
            this.newsl.TabIndex = 33;
            this.newsl.Text = "Nvidia News ";
            this.newsl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Newssir
            // 
            this.Newssir.BackColor = System.Drawing.Color.Transparent;
            this.Newssir.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Newssir.ForeColor = System.Drawing.Color.White;
            this.Newssir.Location = new System.Drawing.Point(42, 70);
            this.Newssir.Name = "Newssir";
            this.Newssir.Size = new System.Drawing.Size(410, 197);
            this.Newssir.TabIndex = 34;
            this.Newssir.Click += new System.EventHandler(this.Newssir_Click);
            // 
            // Firstnext
            // 
            this.Firstnext.BackColor = System.Drawing.Color.Black;
            this.Firstnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Firstnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firstnext.ForeColor = System.Drawing.Color.Red;
            this.Firstnext.Location = new System.Drawing.Point(313, 241);
            this.Firstnext.Name = "Firstnext";
            this.Firstnext.Size = new System.Drawing.Size(177, 65);
            this.Firstnext.TabIndex = 35;
            this.Firstnext.Text = "Return";
            this.Firstnext.UseVisualStyleBackColor = false;
            this.Firstnext.Click += new System.EventHandler(this.Firstnext_Click);
            // 
            // textloops
            // 
            this.textloops.Enabled = true;
            this.textloops.Tick += new System.EventHandler(this.textloops_Tick);
            // 
            // NewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(502, 318);
            this.Controls.Add(this.Firstnext);
            this.Controls.Add(this.Newssir);
            this.Controls.Add(this.newsl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewsForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Firstnext;
        public System.Windows.Forms.Label Newssir;
        private System.Windows.Forms.Timer textloops;
        public System.Windows.Forms.Label newsl;
    }
}