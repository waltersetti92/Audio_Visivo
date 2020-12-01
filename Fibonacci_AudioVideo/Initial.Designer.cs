namespace Fibonacci_AudioVideo
{
    partial class Initial
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labLuda = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labLuda
            // 
            this.labLuda.AutoSize = true;
            this.labLuda.BackColor = System.Drawing.Color.Transparent;
            this.labLuda.Font = new System.Drawing.Font("Snap ITC", 53.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLuda.ForeColor = System.Drawing.Color.Gold;
            this.labLuda.Location = new System.Drawing.Point(11, 87);
            this.labLuda.Margin = new System.Windows.Forms.Padding(3);
            this.labLuda.Name = "labLuda";
            this.labLuda.Size = new System.Drawing.Size(1266, 92);
            this.labLuda.TabIndex = 2;
            this.labLuda.Text = "UNA SEZIONE TUTTA D\'ORO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fibonacci_AudioVideo.Properties.Resources.group1;
            this.pictureBox1.Location = new System.Drawing.Point(500, 307);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Snap ITC", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MediumBlue;
            this.button1.Location = new System.Drawing.Point(895, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "INIZIA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Initial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labLuda);
            this.Name = "Initial";
            this.Size = new System.Drawing.Size(1280, 701);
            this.Load += new System.EventHandler(this.Initial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labLuda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}
