using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;

namespace Pasya_Converter
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
            
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPages1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }



       

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

         

       

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel10_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel15_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                string value1 = comboBox1.SelectedItem.ToString();
                string value2 = comboBox2.SelectedItem.ToString();

                double num = double.Parse(textBox1.Text);
                double hasil = 0;

                string[] units = { "KM", "HM", "DAM", "M", "DM", "CM", "MM" };
                double[] multipliers = { 1, 10, 100, 1000, 10000, 100000, 1000000 };

                int indexValue1 = Array.IndexOf(units, value1);
                int indexValue2 = Array.IndexOf(units, value2);

                if (indexValue1 >= 0 && indexValue2 >= 0)
                {
                    hasil = num * (multipliers[indexValue2] / multipliers[indexValue1]);
                }

                textBox5.Text = $"{hasil}{value2}";




        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel30_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string value3 = comboBox3.SelectedItem.ToString();
            string value4 = comboBox4.SelectedItem.ToString();

            double num = double.Parse(textBox2.Text);
            double hasil = 0;

            string[] units2 = { "KG", "HG", "DAG", "G", "DG", "CG", "MG" };
            double[] multipliers = { 1, 10, 100, 1000, 10000, 100000, 1000000 };

            int indexValue3 = Array.IndexOf(units2, value3);
            int indexValue4 = Array.IndexOf(units2, value4);

            if (indexValue3 >= 0 && indexValue4 >= 0)
            {
                hasil = num * (multipliers[indexValue4] / multipliers[indexValue3]);
            }

            textBox7.Text = $"{hasil}{value4}";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Masukkan nilai yang akan dikonversi.");
                return;
            }
            string value5 = comboBox5.SelectedItem.ToString();
            string value6 = comboBox6.SelectedItem.ToString();

            double num = double.Parse(textBox3.Text);
            double hasil2 = 0;

            string[] unitsTime = { "Hour", "min", "s" };
            double[] multipliersTime = { 1, 60, 3600 };

            int indexValue5 = Array.IndexOf(unitsTime, value5);
            int indexValue6 = Array.IndexOf(unitsTime, value6);

            if (indexValue5 >= 0 && indexValue6 >= 0)
            {
                hasil2 = num * (multipliersTime[indexValue6] / multipliersTime[indexValue5]);
            }

            textBox8.Text = $"{hasil2}{value6}";






        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage2);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage1);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage3);
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage4);
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage6);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Masukkan nilai yang akan dikonversi.");
                return;
            }
            string value7 = comboBox7.SelectedItem.ToString();
            string value8 = comboBox8.SelectedItem.ToString();

            double num = double.Parse(textBox4.Text);
            double hasil3 = 0;

            if (value7 == "`C")
            {
                if (value8 == "`F")
                {
                    hasil3 = (1.8 * num) + 32;
                }
                else if (value8 == "`K")
                {
                    hasil3 = num + 273;
                }
                else if (value8 == "`R")
                {
                    hasil3 = 0.8 * num;
                }



            }
            if (value7 == "`F")
            {
                if (value8 == "`C")
                {
                    hasil3 = (5 / 9 * num) - 32;
                }

                else if (value8 == "`R")
                {
                    hasil3 = (4 / 9 * num) - 32;
                }

            }
            if (value7 == "`K")
            {
                if (value8 == "`C")
                {
                    hasil3 = num - 273;
                }

                else if (value8 == "`R")
                {
                    hasil3 = (4 / 5 * num) - 273;
                }

            }
            if (value7 == "`R")
            {
                if (value8 == "`C")
                {
                    hasil3 = (4 / 5) * num;
                }
                else if (value8 == "`F")
                {
                    hasil3 = (9 / 4 * num) + 32;
                }
                else if (value8 == "`K")
                {
                    hasil3 = (5 / 4 * num) + 273;
                }

            }

            textBox9.Text = $"{hasil3}{value8}";


        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Masukkan nilai yang akan dikonversi.");
                return;
            }
            string value9 = comboBox11.SelectedItem.ToString();
            string value10 = comboBox13.SelectedItem.ToString();

            double num = double.Parse(textBox6.Text);
            double hasil4 = 0;

            string[] unitsData = { "GB", "MB", "KB" };
            double[] multipliersData = { 1, 1000, 1000000 };

            int indexValue9 = Array.IndexOf(unitsData, value9);
            int indexValue10 = Array.IndexOf(unitsData, value10);

            if (indexValue9 >= 0 && indexValue10 >= 0)
            {
                hasil4 = num * (multipliersData[indexValue10] / multipliersData[indexValue9]);
            }

            textBox10.Text = $"{hasil4}{value10}";


        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
             
        }
    }
}






        
    







        


    
    

 

