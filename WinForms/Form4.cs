using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello"+ textBox1.Text);  //on running debugger , in label give name and then click button
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //logic for enter an integer and it gives textbox result
            int x = int.Parse(textBox2.Text);
            x *= x;
            textBox3.Text =x.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //logic to clear the screen by clicking clear button
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox3.Focus();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //logic to close the application
            if (MessageBox.Show("do u want to exit?", "close window", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        //keyevent
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //operation performed on textbox1
            //for keydown

            //  for this select textbox1 ->property->keydown->double click for event
            if (e.KeyCode == Keys.Enter)
                MessageBox.Show("submitted");
            else if (e.KeyCode == Keys.Escape)
                MessageBox.Show("want to cancel??");


            //for this, enter your name in textbox and press enter
        }

        private void f(object sender, EventArgs e)
        {

        }
    }
}
