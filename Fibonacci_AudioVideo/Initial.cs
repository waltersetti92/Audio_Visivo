using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci_AudioVideo
{
    public partial class Initial : UserControl
    {
        public Main parentForm { get; set; }
        public Prima_Interazione interazione = null;
        public Initial()
        {
            InitializeComponent();
            interazione = new Prima_Interazione();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Opaque, true);
            labLuda.BackColor = Color.Transparent;
            this.BackColor = Color.Transparent;
        }
        public void setPos(int w, int h)
        {
            int offset = 50;
            Location = new Point(offset, offset);
            Width = w - 2 * offset;
            Height = h - 2 * offset;
            labLuda.Location = new Point(w / 2 - labLuda.Width / 2 - offset, 200);
        }
        private void Initial_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
                parentForm.onStart();
                
        }
    }
}
