using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasya_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            timerleft = 3;
            timer1.Start();
        }
        public int timerleft
        { 
            get; 
            set;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerleft > 0)
            {
                timerleft = timerleft - 1;

            }
            else
            {
                timer1.Stop();
                new Form2().Show();
                this.Hide();
            }
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
