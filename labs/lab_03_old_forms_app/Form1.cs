using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_03_old_forms_app
{
    public partial class Form1 : Form
    {
        static int counter = 0;

        public Form1()
        {
            InitializeComponent();


        }

        void Intialise()
        {
            label1.Text = "Welcome - What is your name?";
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello" + " " + textBox1.Text + " " + "How are you?";
            counter++;
            label2.Text = counter.ToString();
        }
    }
}
