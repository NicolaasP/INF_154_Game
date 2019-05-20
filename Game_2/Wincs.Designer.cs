namespace Game_2
{
    partial class Wincs
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
            this.winBTN = new System.Windows.Forms.Button();
            this.thanx = new System.Windows.Forms.Label();
            this.Credits = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // winBTN
            // 
            this.winBTN.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winBTN.Location = new System.Drawing.Point(345, 380);
            this.winBTN.Name = "winBTN";
            this.winBTN.Size = new System.Drawing.Size(112, 47);
            this.winBTN.TabIndex = 0;
            this.winBTN.Text = "Exit";
            this.winBTN.UseVisualStyleBackColor = true;
            this.winBTN.Click += new System.EventHandler(this.WinBTN_Click);
            // 
            // thanx
            // 
            this.thanx.AutoSize = true;
            this.thanx.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanx.Location = new System.Drawing.Point(241, 41);
            this.thanx.Name = "thanx";
            this.thanx.Size = new System.Drawing.Size(314, 21);
            this.thanx.TabIndex = 1;
            this.thanx.Text = "Thank you for playing our game";
            this.thanx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Credits
            // 
            this.Credits.AutoSize = true;
            this.Credits.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credits.Location = new System.Drawing.Point(221, 154);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(0, 21);
            this.Credits.TabIndex = 2;
            this.Credits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Credits:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Wincs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Credits);
            this.Controls.Add(this.thanx);
            this.Controls.Add(this.winBTN);
            this.Name = "Wincs";
            this.Text = "Wincs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Wincs_FormClosing);
            this.Load += new System.EventHandler(this.Wincs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button winBTN;
        private System.Windows.Forms.Label thanx;
        private System.Windows.Forms.Label Credits;
        private System.Windows.Forms.Label label1;
    }
}