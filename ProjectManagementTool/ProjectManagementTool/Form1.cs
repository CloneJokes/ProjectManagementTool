using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementTool
{
    public partial class Form1 : Form
    {
        int TogMove;
        int MValX;
        int MValY;

        public Form1()
        {
            InitializeComponent();
            label8.Text = DateTime.Today.ToLongDateString();
            label9.Text = "("+lstCollection1.Items.Count.ToString()+")";
            label10.Text = "(" + lstCollection2.Items.Count.ToString() + ")";
            label11.Text = "(" + lstCollection3.Items.Count.ToString() + ")";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //
        }

        private void label8_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void panel1_MouseUp_1(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked){
                
                try
                {
                    string item = textBox1.Text + ", " + DateTime.Today.ToLongDateString();
                    lstCollection1.Items.Add(item);
                }
                catch
                {
                    MessageBox.Show("You Fucked Up", "FeelsBadMan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (checkBox2.Checked)
            {

                try
                {
                    string item = textBox1.Text + ", " + DateTime.Today.ToLongDateString();
                    lstCollection2.Items.Add(item);
                }
                catch
                {
                    MessageBox.Show("You Fucked Up", "FeelsBadMan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (checkBox3.Checked)
            {

                try
                {
                    string item = textBox1.Text + ", " + DateTime.Today.ToLongDateString();
                    lstCollection3.Items.Add(item);
                }
                catch
                {
                    MessageBox.Show("You Fucked Up", "FeelsBadMan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox1.Checked = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked)
            {

                try
                {
                    lstCollection1.Items.RemoveAt(lstCollection1.SelectedIndex);
                }
                catch
                {
                    MessageBox.Show("You Fucked Up", "FeelsBadMan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (checkBox2.Checked)
            {

                try
                {
                    lstCollection2.Items.RemoveAt(lstCollection2.SelectedIndex);
                }
                catch
                {
                    MessageBox.Show("You Fucked Up", "FeelsBadMan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (checkBox3.Checked)
            {

                try
                {
                    lstCollection3.Items.RemoveAt(lstCollection3.SelectedIndex);
                }
                catch
                {
                    MessageBox.Show("You Fucked Up", "FeelsBadMan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label9.Text = "(" + lstCollection1.Items.Count.ToString() + ")";
            label10.Text = "(" + lstCollection2.Items.Count.ToString() + ")";
            label11.Text = "(" + lstCollection3.Items.Count.ToString() + ")";
        }

        private void lstCollection1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = lstCollection1.SelectedItem.ToString();
        }

        private void lstCollection2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = lstCollection2.SelectedItem.ToString();
        }

        private void lstCollection3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = lstCollection3.SelectedItem.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                try
                {
                    lstCollection1.Items.Clear();
                }
                catch
                {
                    MessageBox.Show("You Fucked Up", "FeelsBadMan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (checkBox2.Checked)
            {

                try
                {
                    lstCollection2.Items.Clear();
                }
                catch
                {
                    MessageBox.Show("You Fucked Up", "FeelsBadMan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (checkBox3.Checked)
            {

                try
                {
                    lstCollection3.Items.Clear();
                }
                catch
                {
                    MessageBox.Show("You Fucked Up", "FeelsBadMan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
