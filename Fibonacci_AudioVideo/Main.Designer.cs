namespace Fibonacci_AudioVideo
{
    partial class Main
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
            this.initial1 = new Fibonacci_AudioVideo.Initial();
            this.prima_Interazione1 = new Fibonacci_AudioVideo.Prima_Interazione();
            this.SuspendLayout();
            // 
            // initial1
            // 
            this.initial1.BackColor = System.Drawing.Color.Transparent;
            this.initial1.Location = new System.Drawing.Point(60, 52);
            this.initial1.Name = "initial1";
            this.initial1.parentForm = null;
            this.initial1.Size = new System.Drawing.Size(857, 359);
            this.initial1.TabIndex = 0;
            // 
            // prima_Interazione1
            // 
            this.prima_Interazione1.BackColor = System.Drawing.Color.White;
            this.prima_Interazione1.BackgroundImage = global::Fibonacci_AudioVideo.Properties.Resources.Transparency_background;
            this.prima_Interazione1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prima_Interazione1.Location = new System.Drawing.Point(60, 37);
            this.prima_Interazione1.Name = "prima_Interazione1";
            this.prima_Interazione1.parentForm = null;
            this.prima_Interazione1.Size = new System.Drawing.Size(787, 487);
            this.prima_Interazione1.TabIndex = 1;
            this.prima_Interazione1.Load += new System.EventHandler(this.prima_Interazione1_Load);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fibonacci_AudioVideo.Properties.Resources.galaxy;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prima_Interazione1);
            this.Controls.Add(this.initial1);
            this.Name = "Main";
            this.Text = "POSTAZIONE AUDIO-VISIVA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Initial initial1;
        private Prima_Interazione prima_Interazione1;
    }
}

