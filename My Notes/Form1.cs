using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Notes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.DoubleBuffer,
                true);
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "admin" && this.textBox2.Text == "123456")
            {
                MessageBox.Show("your data submitted successfully, you will be " +
                    "redirected to note APP");
                NotePad p = new NotePad();
                this.Hide();
                p.Show();
               // p.FormClosed+= (s, args) => this.Close();
                //FormClosingEventArgs m = new FormClosingEventArgs(CloseReason );
              //  this.Close();
            }
               
            else
                MessageBox.Show("please enter right data");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x=MessageBox.Show("Are you sure you wanna close this " +
                "Application", "Confirmation Message",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (x == DialogResult.No)
                e.Cancel = true;
        }
    }
}
