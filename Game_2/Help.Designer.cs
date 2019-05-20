namespace Game_2
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.output = new System.Windows.Forms.PictureBox();
            this.forw = new System.Windows.Forms.Button();
            this.bak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.output)).BeginInit();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("output.BackgroundImage")));
            this.output.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.output.Location = new System.Drawing.Point(12, 12);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(1008, 549);
            this.output.TabIndex = 0;
            this.output.TabStop = false;
            // 
            // forw
            // 
            this.forw.Location = new System.Drawing.Point(522, 567);
            this.forw.Name = "forw";
            this.forw.Size = new System.Drawing.Size(119, 45);
            this.forw.TabIndex = 1;
            this.forw.Text = ">>";
            this.forw.UseVisualStyleBackColor = true;
            this.forw.Click += new System.EventHandler(this.Forw_Click);
            // 
            // bak
            // 
            this.bak.Location = new System.Drawing.Point(397, 567);
            this.bak.Name = "bak";
            this.bak.Size = new System.Drawing.Size(119, 45);
            this.bak.TabIndex = 2;
            this.bak.Text = "<<";
            this.bak.UseVisualStyleBackColor = true;
            this.bak.Click += new System.EventHandler(this.Bak_Click);
            // 
            // Help
            // 
            this.ClientSize = new System.Drawing.Size(1032, 624);
            this.Controls.Add(this.bak);
            this.Controls.Add(this.forw);
            this.Controls.Add(this.output);
            this.Name = "Help";
            ((System.ComponentModel.ISupportInitialize)(this.output)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox disp;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.PictureBox output;
        private System.Windows.Forms.Button forw;
        private System.Windows.Forms.Button bak;
    }
}