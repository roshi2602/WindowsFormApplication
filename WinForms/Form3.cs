using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("text message");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("text", "title");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("more", "buttons", MessageBoxButtons.AbortRetryIgnore); //text , title , 3 buttons abort,retry,ignore
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("icon", "box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do u want to exit?", "close window", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();

            //this shows text do u want to exit and title close window along with message box-yes or no along with icon of ? and on clicking on yes, it closes the application
        }
    }
}
