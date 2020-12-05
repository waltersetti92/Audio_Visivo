using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using Newtonsoft.Json;
using System.IO;




namespace Fibonacci_AudioVideo
{
    public partial class Prima_Interazione : UserControl
    {
        public Main parentForm { get; set; }
        List<PictureBox> pictureBoxList = new List<PictureBox>();


        public Prima_Interazione()
        {
            InitializeComponent();
            pictureBoxList.Add(star1);
            pictureBoxList.Add(star2);
            this.BackgroundImage = Properties.Resources.Transparency_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            label2.Visible = false;
            label1.Visible = false;
            Sequence_Start();      
        }


       
        public void setPos(int w, int h)
        {

            int offset = 0;
            Location = new Point(offset, offset);
            Width = w - 1 * offset;
            Height = h - 1 * offset;
           
        }
        public void Sequence_Start()
        {

 
        }
        private void Prima_Interazione_Load(object sender, EventArgs e)
        {
            
  
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

           

        public void label1_Click(object sender, EventArgs e)
        {
            if (parentForm.interaction == 1)
            {
                star1.Visible = true;
                star2.Visible = true;
                label2.Visible = true;
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
