namespace hit_mouse
{
    public partial class Form1 : Form
    {
        Button[] btn = new Button[9];
        int hits, miss;
        double sec;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sec = 30;
            btn[0] = button1; btn[1] = button2; btn[2] = button3;
            btn[3] = button4; btn[4] = button5; btn[5] = button6;
            btn[6] = button7; btn[7] = button8; btn[8] = button9;
            button2.Click += button1_Click;
            button3.Click += button1_Click;
            button4.Click += button1_Click;
            button5.Click += button1_Click;
            button6.Click += button1_Click;
            button7.Click += button1_Click;
            button8.Click += button1_Click;
            button9.Click += button1_Click;
            for (int i = 0; i < 9; i++)
            {
                btn[i].ImageIndex = 1;
                btn[i].Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "剩餘時間" + (sec -= 0.1).ToString("#.0") + "秒";
            if (sec <= 0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                for (int i = 0; i < 9; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                btn[i].ImageIndex = 1;
            }
            Random ran = new Random();
            btn[ran.Next(0, 9)].ImageIndex = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hits = 0;
            miss = 0;
            label2.Text = "擊中:" + hits.ToString() + "次";
            label3.Text = "失誤:" + miss.ToString() + "次";
            for (int i = 0; i < 9; i++)
            {
                btn[i].ImageIndex = 1;
                btn[i].Enabled = true;
            }
            button10.Enabled = false;
            sec = 30;
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btnClick = (Button)sender;
            if (btnClick.ImageIndex == 0)
            {
                hits += 1;
                label2.Text = "擊中:" + hits.ToString() + "次";
                btnClick.ImageIndex = 1;
            }
            else
            {
                miss += 1;
                label3.Text = "失誤:" + miss.ToString() + "次";
                btnClick.ImageIndex = 1;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button10.Enabled = true;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    timer2.Interval = 1000;
                    break;
                case 1:
                    timer2.Interval = 500;
                    break;
                case 2:
                    timer2.Interval = 250;
                    break;
            }
        }
    }
}