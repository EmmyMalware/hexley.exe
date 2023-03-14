using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hexley
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Parent = pictureBox1;
            checkBox1.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
            button1.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void killDwm(string name)
        {
            foreach(var process in Process.GetProcesses())
            {
                if(process.ProcessName.Equals(name))
                {
                    process.Kill();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            killDwm("dwm.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (MessageBox.Show("Are you sure", "hexley", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
            }
        }
    }
}
