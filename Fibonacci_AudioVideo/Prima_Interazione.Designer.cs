namespace Fibonacci_AudioVideo
{
    partial class Prima_Interazione
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
            this.pezzo0 = new System.Windows.Forms.PictureBox();
            this.star1 = new System.Windows.Forms.PictureBox();
            this.star2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pezzo0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).BeginInit();
            this.SuspendLayout();
            // 
            // pezzo0
            // 
            this.pezzo0.BackColor = System.Drawing.Color.Transparent;
            this.pezzo0.Image = global::Fibonacci_AudioVideo.Properties.Resources.Pezzo_0;
            this.pezzo0.Location = new System.Drawing.Point(157, 320);
            this.pezzo0.Name = "pezzo0";
            this.pezzo0.Size = new System.Drawing.Size(218, 186);
            this.pezzo0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pezzo0.TabIndex = 0;
            this.pezzo0.TabStop = false;
            this.pezzo0.Visible = false;
            // 
            // star1
            // 
            this.star1.BackColor = System.Drawing.Color.Transparent;
            this.star1.Image = global::Fibonacci_AudioVideo.Properties.Resources.stella;
            this.star1.Location = new System.Drawing.Point(230, 512);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(51, 58);
            this.star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star1.TabIndex = 1;
            this.star1.TabStop = false;
            this.star1.Visible = false;
            this.star1.WaitOnLoad = true;
            // 
            // star2
            // 
            this.star2.BackColor = System.Drawing.Color.Transparent;
            this.star2.Image = global::Fibonacci_AudioVideo.Properties.Resources.stella;
            this.star2.Location = new System.Drawing.Point(270, 256);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(51, 58);
            this.star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star2.TabIndex = 2;
            this.star2.TabStop = false;
            this.star2.Visible = false;
            this.star2.WaitOnLoad = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(13, 628);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "LE STELLE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(321, 628);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "LA LORO MELODIA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Prima_Interazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Fibonacci_AudioVideo.Properties.Resources.Transparency_background;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.star2);
            this.Controls.Add(this.star1);
            this.Controls.Add(this.pezzo0);
            this.Name = "Prima_Interazione";
            this.Size = new System.Drawing.Size(927, 869);
            this.Load += new System.EventHandler(this.Prima_Interazione_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pezzo0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pezzo0;
        private System.Windows.Forms.PictureBox star1;
        private System.Windows.Forms.PictureBox star2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
