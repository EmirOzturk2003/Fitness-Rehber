using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitness
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webControl1.Hide();
        }

        private void webControl1_Click(object sender, EventArgs e)
        {

        }
        void go(string adres)
        {
            webView1.Url = adres.ToString();
            webControl1.Show();
        }
        private void gogus1_Click(object sender, EventArgs e)
        {
            go("https://musclewiki.com/exercises/male/chest");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webView1.Url = "www.google.com";
            webControl1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            go("https://musclewiki.com/exercises/male/traps");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            go("https://musclewiki.com/exercises/male/shoulders");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            go("https://musclewiki.com/exercises/male/biceps");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            go("https://musclewiki.com/exercises/male/forearms");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            go("https://musclewiki.com/exercises/male/obliques");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            go("https://musclewiki.com/exercises/male/abdominals");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            go("https://musclewiki.com/exercises/male/quads");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            go("https://musclewiki.com/exercises/male/calves");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            go("https://musclewiki.com/exercises/male/traps");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            go("https://musclewiki.com/exercises/male/shoulders");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            go("https://musclewiki.com/exercises/male/triceps");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            go("https://musclewiki.com/exercises/male/forearms");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            go("https://musclewiki.com/exercises/male/traps_middle");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            go("https://musclewiki.com/exercises/male/lowerback");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            go("https://musclewiki.com/exercises/male/hamstrings");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            go("https://musclewiki.com/exercises/male/calves");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            go("https://musclewiki.com/exercises/male/glutes");
        }
    }
}
