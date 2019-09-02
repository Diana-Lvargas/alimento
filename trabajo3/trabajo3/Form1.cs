using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbAlimentos.Items.Add("enchiladas");
            cbAlimentos.Items.Add("pozole");
        }

        private void CbAlimentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cbAlimentos.SelectedIndex;
            label1.Text = indice.ToString();
            label2.Text = cbAlimentos.Items[indice].ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cbAlimentos.Items.Add(textBox1.Text);
        }
    }
}
