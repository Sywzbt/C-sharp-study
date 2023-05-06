using System.Net.Security;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public static int Add(int a, int b) 
        {
            return a + b;
        }
        public static int Min(int a, int b)
        {
            return a - b;
        }
        public static int Mult(int a, int b)
        {
            return a * b;
        }
        public static int Div(int a, int b)
        {
            return a / b;
        }
        public Form1()
        {
            InitializeComponent();
        }

        int num1, num2;
        string ops;
        int result; 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ops = "+";
            num1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ops = "-";
            num1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ops = "*";
            num1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ops = "/";
            num1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)//=
        {
            num2 = Convert.ToInt32(textBox1.Text);
            switch (ops)
            {
                case "+":
                    result = Add(num1, num2);
                    break;

                case "-":
                    result = Min(num1, num2);
                    break;

                case "*":
                    result = Mult(num1, num2);
                    break;

                case "/":
                    result = Div(num1, num2);
                    break;
            }
            textBox1.Text = Convert.ToString(result);
        }
    }
}