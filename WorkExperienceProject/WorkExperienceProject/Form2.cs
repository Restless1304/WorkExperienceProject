using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;






namespace WorkExperienceProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 temp1 = new Form1();
            temp1.Region = this.Region;
            temp1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Roll_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\WILL.LAPSLEY\Desktop\DiceRoller-master\DiceRoller\DiceRoller.exe");
        }
    }
}
