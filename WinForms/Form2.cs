using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToLongDateString());   //on running console and clicking on Datebutton ,it will give todays date
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToLongTimeString()); //on running console and clicking on Timebutton ,it will give todays time
        }
    }
}
