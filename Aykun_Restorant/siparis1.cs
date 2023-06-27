using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aykun_Restorant
{
    public partial class siparis1 : UserControl
    {
        public siparis1()
        {
            InitializeComponent();
        }

        private void siparis1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Coca Cola");
            comboBox1.Items.Add("Sprite");
            comboBox1.Items.Add("Fanta");
            comboBox1.Items.Add("Coca Cola Diyet");
            comboBox1.Items.Add("Şalgam");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Textbox değerlerini temizliyoruz
            textBox1.Text = "";
            textBox2.Text = "";
            //combobox değerlerini temizliyoruz 
            comboBox1.Text = ""; 

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
