using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.IO;
using Newtonsoft.Json;
using System.Threading;

//Postazione Audio_Visiva
namespace Fibonacci_AudioVideo
{
    

    public partial class Main : Form
    {
        public static readonly string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        public static readonly string resourcesPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\resources";
        private const string background_image = "galaxy.jpg";
        private UserControl currUC = null;
        public Main()
        {
            Business_Logic BL = new Business_Logic(this);
            InitializeComponent();
            initial1.parentForm = this;
            prima_Interazione1.parentForm = this;
            initial1.Visible = false;
            prima_Interazione1.Visible = false;
            BackgroundImageLayout = ImageLayout.Stretch;
            BackgroundImage = Image.FromFile(resourcesPath + "\\" + background_image);
            home();
          
        }
        public void Status_Changed(string k)
        {
            this.BeginInvoke((Action)delegate ()
            {
                int status = int.Parse(k);
                if (status == 1)
                {
                    onStart();
                }
                if (status == 2)
                {
                    home();
                }

            });
        }
        public void home()
        {
            if (currUC != null) currUC.Visible = false;
            initial1.Show();
            currUC = initial1;
        }
        public void onStart()
        {
            initial1.Visible = false;
            prima_Interazione1.Visible = true;
            currUC = prima_Interazione1;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Size size = this.Size;
            initial1.setPos(size.Width, size.Height);
            prima_Interazione1.setPos(size.Width, size.Height);
        }
    }
}
