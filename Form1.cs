using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;
namespace Hsv_Color
{
    public partial class Form1 : Form
    {
        Image<Hsv, byte> img;
        Image<Gray, byte> HueImg;
        Image<Gray, byte> SaturaImg;
        Image<Gray, byte> ValueImg;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    img = new Image<Hsv, byte>(ofd.FileName);
                    pictureBox1.Image = img.ToBitmap();
                }
            }

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            HueImg = img[0];
            SaturaImg = img[1];
            ValueImg = img[2];

            pictureBox2.Image = HueImg.Bitmap;
            pictureBox3.Image = SaturaImg.Bitmap;
            pictureBox4.Image = ValueImg.Bitmap;
        }
    }
}
