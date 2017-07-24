using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace horse
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        int imgName = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            imgName++;
            PictureBox1.Image = Image.FromFile(@"D:\horse\"+ imgName.ToString()+ ".PNG");
            if (imgName > 15)
                imgName =1;
          

        }

        private void button1_Click(object sender, EventArgs e)
        {

            run.Enabled = true;
            move.Enabled = true;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

            int imgName = 1;
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            run.Interval = 50;
            move.Interval = 50;

            

        }

        private void move_Tick(object sender, EventArgs e)
        {
            PictureBox1.Left += 20;
            if (PictureBox1.Left >= 1000)
                PictureBox1.Left = 0;
                
        }
    }
}
