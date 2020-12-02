using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Notes
{
    public partial class NotePad : Form
    {
        public NotePad()
        {
            InitializeComponent();
        }
        public string path { get; set; }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void label1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        OpenFileDialog Dir = new OpenFileDialog();
        //        Dir.InitialDirectory = @"E:\";
        //        // Dir.Filter= "text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        //        Dir.Filter = "text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        //        Dir.Title = "Open";
        //        if (Dir.ShowDialog()==DialogResult.OK)
        //        {
        //            StreamReader sr = new StreamReader(Dir.FileName, Encoding.Default);
        //            string str = sr.ReadToEnd();
        //            sr.Close();
        //            rtb.Text = str;

        //        }

        //    }
        //    catch(Exception errorMsg)
        //    {
        //        MessageBox.Show(errorMsg.Message);
        //    }
        //    //string myComputerPath = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
        //    //System.Diagnostics.Process.Start("explorer", myComputerPath);
            
        //}

        private void rtb_TextChanged(object sender, EventArgs e)
        {

        }

        //private void label5_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog saveDir = new OpenFileDialog();
        //    saveDir.Title = "save file As";
        //    saveDir.Filter = "text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        //    saveDir.DefaultExt = "txt";
        //    if (saveDir.ShowDialog() == DialogResult.OK)
        //    {
        //        if (Path.GetExtension(saveDir.FileName) == ".txt"| Path.GetExtension(saveDir.FileName) == ".rtf")
        //        {
        //            rtb.SaveFile(saveDir.FileName, RichTextBoxStreamType.PlainText);
        //        }

        //    }
        //}

        private void NotePad_Load(object sender, EventArgs e)
        {

        }

        private void NotePad_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x = MessageBox.Show("Are you sure you wanna close this " +
                "Application", "Confirmation Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.No)
                e.Cancel = true;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                rtb.SaveFile(saveFileDialog1.FileName);
                rtb.Clear();
            }
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dir = new OpenFileDialog();
            dir.InitialDirectory = @"E:\";
            dir.Filter = "Text Files(*.txt)| *.txt | RTF Files(*.rtf) | *.rtf";
            if (dir.ShowDialog() == DialogResult.OK)
            {              
                path = dir.FileName;
                rtb.LoadFile(path);               
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            rtb.Clear();
            path = null;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path!=null)
            {
                rtb.SaveFile(path);
                rtb.Clear();
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    rtb.SaveFile(saveFileDialog1.FileName);
                    rtb.Clear();
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog()==DialogResult.OK)
            {
                
                if (rtb.SelectedText !="")               
                    rtb.SelectionFont = fontDialog1.Font; 
                else
                   rtb.Font = fontDialog1.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //rtb.SelectionColor != null
                if (rtb.SelectedText != "")
                    rtb.SelectionColor = colorDialog1.Color;
                else
                    rtb.ForeColor= colorDialog1.Color;
                //rtb.BackColor = colorDialog1.Color;
            }
        }
    }
}
//fonts and size of window, save in only txt file
