using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;     //custom color is forbidden

            MyDialog.ShowHelp = true;       //to get help (def false)
            MyDialog.Color = richTextBox1.BackColor;     //setting current color

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = MyDialog.Color;     //uptading color
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1.BackColor = Color.LightGray;
            splitContainer1.Panel2.BackColor = Color.Gray;
            button1.Text = "this";
            button2.Text = "that";

            toolStripProgressBar1.Value += 20;
            if (toolStripProgressBar1.Value >= toolStripProgressBar1.Maximum)
            {
                //Application.Exit();
                this.Close();
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            splitContainer1.Panel1.BackColor = Color.Green;
            splitContainer1.Panel2.BackColor = Color.Red;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button2.Text = "-";
            button1.Text = "-";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.BackColor = Color.LightGray;
            splitContainer1.Panel1.BackColor = Color.Gray;
            button2.Text = "this";
            button1.Text = "that";

            toolStripProgressBar1.Value += 10;
            if (toolStripProgressBar1.Value >= toolStripProgressBar1.Maximum)
            {
                //Application.Exit();
                this.Close();
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            splitContainer1.Panel2.BackColor = Color.Green;
            splitContainer1.Panel1.BackColor = Color.Red;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Text = "-";
            button1.Text = "-";
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Maximum += 20;
            toolStripProgressBar1.Width += 20;
        }

        
        public class Numbers
        {
            
            public byte b_var;
            public const double d_var = 1.618;
            public long[] l_arr;

            public ShortEnum s_var;
            public enum ShortEnum : short
                {
                    s_0 = 0,
                    s_1 = 1
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Numbers numbers = new Numbers();
            Random rand = new Random();
            numbers.b_var = (byte)rand.Next();
            numbers.l_arr = new long[] { rand.Next(), rand.Next()};

            numbers.s_var = Numbers.ShortEnum.s_0;
            numbers.s_var = Numbers.ShortEnum.s_1;

            double res_1 = numbers.b_var + Numbers.d_var;
            double res_2 = numbers.b_var - Numbers.d_var;
            double res_3 = numbers.b_var * Numbers.d_var;
            double res_4 = numbers.b_var / Numbers.d_var;

            label1.Text = Math.Round(res_1, 3).ToString();
            label2.Text = Math.Round(res_2, 3).ToString();
            label3.Text = Math.Round(res_3, 3).ToString();
            label4.Text = Math.Round(res_4, 3).ToString();

            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "b + c d";
            label2.Text = "b - c d";
            label3.Text = "b * c d";
            label4.Text = "b / c d";

            label1.ForeColor = Color.DarkGray;
            label2.ForeColor = Color.DarkGray;
            label3.ForeColor = Color.DarkGray;
            label4.ForeColor = Color.DarkGray;
        }
    }
}

