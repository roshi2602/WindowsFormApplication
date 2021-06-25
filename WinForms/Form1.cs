using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form    //form1 is derived class //form is base class
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)   //for button click
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click me");   //this will display an alertbox after running the debugger and then clicking on click button
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();  //this will close after running the debugger and then clicking on close button
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this is keyword which refers to address of current class
            this.BackColor = Color.Red;  //after running the debugger when i click on red button my background should change to red

            //for button color  to be changed
            button3.ForeColor = Color.Red;

            button4.ForeColor = Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;//after running the debugger when i click on red button my background should change to green

            //for button color  to be changed
            button4.ForeColor = Color.Green;

            button3.ForeColor = Color.Black;

        }
    }
}
