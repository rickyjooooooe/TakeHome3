using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeHomeW3_RickyJonathan_0706022210005
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }
        

        public string Label3
        {
            get { return label3.Text; }
            set { label3.Text = value; }
        }
        public bool CheckBox1Checked
        {
            get { return checkBox1form2.Checked; }
        }

        public bool CheckBox2Checked
        {
            get { return checkBox2form2.Checked; }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1magic_Click(object sender, EventArgs e)
        {
            if (checkBox1form2.Checked  && checkBox2form2.Checked)
            {
                MainForm form = Application.OpenForms["MainForm"] as MainForm;
                if (radioButton1red.Checked == true)
                {
                    form.BackColor = Color.Red;
                }
                if (radioButton2yellow.Checked == true)
                {
                    form.BackColor = Color.Yellow;
                }
                if (radioButton3grey.Checked == true)
                {
                    form.BackColor = Color.Gray;
                }
                if (radioButton4blue.Checked == true)
                {
                    form.BackColor = Color.Blue;
                }
                if (radioButton5green.Checked == true)
                {
                    form.BackColor = Color.Green;
                }
                if (radioButtontextpurple.Checked == true)
                {
                    form.ForeColor = Color.Purple;
                    form.Nama = Color.Purple;
                    form.Artist = Color.Purple;
                }
                if (radioButtontextorange.Checked == true)
                {
                    form.ForeColor = Color.Orange;
                    form.Nama = Color.Orange;
                    form.Artist = Color.Orange;
                }
                if (radioButtontextbrown.Checked == true)
                {
                    form.ForeColor = Color.Brown;
                    form.Nama = Color.Brown;
                    form.Artist = Color.Brown;
                }

                if (form != null)
                {
                    form.Refresh();
                }
            }
        }

        private void checkBox1form2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1form2.Checked && checkBox2form2.Checked)
            {
                button1magic.Enabled = true;
            }
            else
            {
                button1magic.Enabled = false;
            }
        }

        private void checkBox2form2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2form2.Checked)
            {
                button1magic.Enabled = true;
            }
            else
            {
                button1magic.Enabled = false;
            }
        }
    }
}
