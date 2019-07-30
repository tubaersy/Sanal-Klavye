using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanalKlavye
{
    public partial class Form1 : Form
    {
        Klavye k = new Klavye();
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;  // hangi text kutusu olursa olsun
            k.yazi = t;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            k.Yaz(b.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            k.yazi = textBox1;
        }

        private void Button43_Click(object sender, EventArgs e)
        {
            k.Yaz(" ");
        }

        
    }
}
