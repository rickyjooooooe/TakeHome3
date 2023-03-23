using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace TakeHomeW3_RickyJonathan_0706022210005
{
    public partial class MainForm : Form
    {
        private SecondForm frmSecond;
        public MainForm()
        {
            InitializeComponent();
            frmSecond = new SecondForm();
        }
        public Color Nama
        {
            get { return textBox1name.ForeColor; }
            set { textBox1name.ForeColor = value; }
        }
        public Color Artist
        {
            get { return textBox2artist.ForeColor; }
            set { textBox2artist.ForeColor = value; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1name_TextChanged(object sender, EventArgs e)
        {

        }

        private bool isForm2Opened = false;
        private void buttonnextform_Click(object sender, EventArgs e)
        {
            
            SecondForm form2 = new SecondForm();
            form2.Show();
            isForm2Opened = true;
            //frmSecond.FormClosed += FrmSecond_FormClosed;
            // Update the state of the submit button
            UpdateSubmitButton();
        }
        private void FrmSecond_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Set the flag to indicate that the second form has been closed
            isForm2Opened = false;
            UpdateSubmitButton();
        }
        private void UpdateSubmitButton()
        {
            
            if (checkBox1true.Checked== true && isForm2Opened == true)
            {
                button1submit.Enabled = true;
            }
            else if (checkBox1true.Checked == false)
            {
                button1submit.Enabled = false;
            }
            else
            {
                button1submit.Enabled = false;
            }
        }
       
        private void checkBox1true_CheckedChanged(object sender, EventArgs e)
      {
 //           if  (checkBox1true.Checked  && )// && frmSecond.CheckBox1Checked == true && frmSecond.CheckBox2Checked == true)
 //           {
 //               button1submit.Enabled = true;
 //           }
//            else
//            {
 //               button1submit.Enabled = false;
 //           }
        }

        private void button1submit_Click(object sender, EventArgs e)
        {
            string name = textBox1name.Text;
            string artist = textBox2artist.Text;
            SecondForm form2 = Application.OpenForms["SecondForm"] as SecondForm;
            if (Application.OpenForms["SecondForm"] != null && checkBox1true.Checked)
            {
                string kata = $"Hi, my name is " + name + " and my favorite artist is " + artist;
                form2.Label3 = kata;
                form2.Refresh();
            }
        }

        
    }
}
