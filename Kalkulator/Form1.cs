using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        // Zmienna globalna
        public bool onoff = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (onoff)
            {
                textBox1.Text += "1";

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (onoff)
            {
                textBox1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (onoff)
            {
                textBox1.Text += "6";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (onoff)
            {
                textBox1.Text += " + ";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            onoff = !onoff;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (onoff)
            {
                textBox1.Text += "0";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (onoff)
            {
                textBox1.Text += "3.14";
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (onoff)
            {
                textBox1.Text += "2";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (onoff)
            {
                textBox1.Text += "4";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (onoff)
            {
                textBox1.Text += "5";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (onoff)
            {
                textBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (onoff)
            {
                textBox1.Text += "8";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (onoff)
            {
                textBox1.Text += "9";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (onoff)
            {
                textBox1.Text += "2.71";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                // Obliczanie wyra¿enia w TextBox
                textBox1.Text = new DataTable().Compute(textBox1.Text, null).ToString();
            }
            catch
            {
                textBox1.Text = "Error";  // W przypadku b³êdnego wyra¿enia
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (onoff)
            {
                textBox1.Text += " - ";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (onoff)
            {
                textBox1.Text += " * ";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (onoff)
            {
                textBox1.Text += " / ";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }


}
