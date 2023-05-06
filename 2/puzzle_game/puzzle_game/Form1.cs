namespace puzzle_game
{
    public partial class Form1 : Form
    {
        int time = 0;
        private void rand()
        {
            int[] randomArry = new int[8];
            Random ran = new Random();
            for (int i = 0; i < 8; i++)
            {
                randomArry[i] = ran.Next(0, 8);
                for (int j = 0; j < i; j++)
                {
                    while (randomArry[j] == randomArry[i])
                    {
                        j = 0;
                        randomArry[i] = ran.Next(0, 8);
                    }
                }
            }
            button11.ImageIndex = randomArry[0]; button12.ImageIndex = randomArry[1];
            button13.ImageIndex = randomArry[2]; button21.ImageIndex = randomArry[3];
            button22.ImageIndex = randomArry[4]; button23.ImageIndex = randomArry[5];
            button31.ImageIndex = randomArry[6]; button32.ImageIndex = randomArry[7];
        }

        private void check()
        {

            if (button11.ImageIndex == 0 && button12.ImageIndex == 1 && button13.ImageIndex == 2 && button21.ImageIndex == 3 && button22.ImageIndex == 4 && button23.ImageIndex == 5 && button31.ImageIndex == 6 && button32.ImageIndex == 7 && button33.ImageIndex == 8)
            {
                timer1.Stop();

                label1.Text = "Congrations!";
                label2.Text = "‰Ô”ïŽžŠÔ" + time + "•b";
            }
        }



        public Form1()
        {
            
            InitializeComponent();
            rand();
            check();
            label1.Text = "";
            label2.Text = "‰Ô”ïŽžŠÔ";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button12.ImageIndex == 8)
            {
                button12.ImageIndex = button11.ImageIndex;
                button11.ImageIndex = 8;
            }
            else if (button21.ImageIndex == 8)
            {
                button21.ImageIndex = button11.ImageIndex;
                button11.ImageIndex = 8;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button11.ImageIndex == 8)
            {
                button11.ImageIndex = button12.ImageIndex;
                button12.ImageIndex = 8;
            }
            else if (button13.ImageIndex == 8)
            {
                button13.ImageIndex = button12.ImageIndex;
                button12.ImageIndex = 8;
            }
            else if (button22.ImageIndex == 8)
            {
                button22.ImageIndex = button12.ImageIndex;
                button12.ImageIndex = 8;
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button12.ImageIndex == 8)
            {
                button12.ImageIndex = button13.ImageIndex;
                button13.ImageIndex = 8;
            }
            else if (button23.ImageIndex == 8)
            {
                button23.ImageIndex = button13.ImageIndex;
                button13.ImageIndex = 8;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (button11.ImageIndex == 8)
            {
                button11.ImageIndex = button21.ImageIndex;
                button21.ImageIndex = 8;
            }
            else if (button31.ImageIndex == 8)
            {
                button31.ImageIndex = button21.ImageIndex;
                button21.ImageIndex = 8;
            }
            else if (button22.ImageIndex == 8)
            {
                button22.ImageIndex = button21.ImageIndex;
                button21.ImageIndex = 8;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (button12.ImageIndex == 8)
            {
                button12.ImageIndex = button22.ImageIndex;
                button22.ImageIndex = 8;
            }
            else if (button23.ImageIndex == 8)
            {
                button23.ImageIndex = button22.ImageIndex;
                button22.ImageIndex = 8;
            }
            else if (button21.ImageIndex == 8)
            {
                button21.ImageIndex = button22.ImageIndex;
                button22.ImageIndex = 8;
            }
            else if (button32.ImageIndex == 8)
            {
                button32.ImageIndex = button22.ImageIndex;
                button22.ImageIndex = 8;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (button13.ImageIndex == 8)
            {
                button13.ImageIndex = button23.ImageIndex;
                button23.ImageIndex = 8;
            }
            else if (button22.ImageIndex == 8)
            {
                button22.ImageIndex = button23.ImageIndex;
                button23.ImageIndex = 8;
            }
            else if (button33.ImageIndex == 8)
            {
                button33.ImageIndex = button23.ImageIndex;
                button23.ImageIndex = 8;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (button21.ImageIndex == 8)
            {
                button21.ImageIndex = button31.ImageIndex;
                button31.ImageIndex = 8;
            }
            else if (button32.ImageIndex == 8)
            {
                button32.ImageIndex = button31.ImageIndex;
                button31.ImageIndex = 8;
            }

        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (button31.ImageIndex == 8)
            {
                button31.ImageIndex = button32.ImageIndex;
                button32.ImageIndex = 8;
            }
            else if (button22.ImageIndex == 8)
            {
                button22.ImageIndex = button32.ImageIndex;
                button32.ImageIndex = 8;
            }
            else if (button33.ImageIndex == 8)
            {
                button33.ImageIndex = button32.ImageIndex;
                button32.ImageIndex = 8;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (button23.ImageIndex == 8)
            {
                button23.ImageIndex = button33.ImageIndex;
                button33.ImageIndex = 8;
            }
            else if (button32.ImageIndex == 8)
            {
                button32.ImageIndex = button33.ImageIndex;
                button33.ImageIndex = 8;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rand();
            time = 0;
            label1.Text = "";
            label2.Text = "‰Ô”ïŽžŠÔ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button11.ImageIndex = 0;
            button12.ImageIndex = 1;
            button13.ImageIndex = 2;
            button21.ImageIndex = 3;
            button22.ImageIndex = 4;
            button23.ImageIndex = 5;
            button31.ImageIndex = 6;
            button32.ImageIndex = 7;
            button33.ImageIndex = 8;
            check();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            time += 1;
        }
    }
}