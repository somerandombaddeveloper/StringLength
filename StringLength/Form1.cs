using System;

namespace StringLength
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String txt = textBox1.Text;
            label1.Text = "String Length: " + txt.Length;
        }
    }
}
