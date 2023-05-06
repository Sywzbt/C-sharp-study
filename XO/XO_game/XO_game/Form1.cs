namespace xo_game
{
    public partial class Form1 : Form
    {
        Button[,] btn = new Button[3, 3];
        string player = "X";
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn[0, 0] = button1; btn[0, 1] = button2; btn[0, 2] = button3;
            btn[1, 0] = button4; btn[1, 1] = button5; btn[1, 2] = button6;
            btn[2, 0] = button7; btn[2, 1] = button8; btn[2, 2] = button9;
            button2.Click += button1_Click;
            button3.Click += button1_Click;
            button4.Click += button1_Click;
            button5.Click += button1_Click;
            button6.Click += button1_Click;
            button7.Click += button1_Click;
            button8.Click += button1_Click;
            button9.Click += button1_Click;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    btn[i, j].Text = "-";
                    btn[i, j].Enabled = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btnClick = (Button)sender;
            if (btnClick.Text == "-")
            {
                btnClick.Text = player;
                if (check())
                {
                    label1.Text = "Šß‰ÆŠlŸ";
                }
                else 
                {
                    switchPlayer();
                    computer();
                }

            }
            else
            {
                label1.Text = "ŠYŠi›ß“U“ü";
            }
        }
        private void computer() 
        {
            int i, j;
            Random ran = new Random();
            i = ran.Next(3);
            j = ran.Next(3);
            while (btn[i, j].Text != "-")
            {
                i = ran.Next(3);
                j = ran.Next(3);
            }
            btn[i, j].Text = player;

            if (check())
            {
                label1.Text = "“däIŠlŸ";
            }
            else
            {
                switchPlayer();
            }
        }

        private void switchPlayer()
        {
            if (player == "X")
            {
                player = "O";
            }
            else
            {
                player = "X";
            }
        }

        private bool check()
        {
            for (int i = 0; i < 3; i++)
            {
                if ((btn[i, 0].Text != "-") && btn[i, 0].Text == btn[i, 1].Text && btn[i, 1].Text == btn[i, 2].Text)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            btn[k, j].Enabled = false;
                        }
                    }
                    return true;
                }
            }

            for (int j = 0; j < 3; j++)
            {
                if (btn[0, j].Text != "-" && btn[0, j].Text == btn[1, j].Text && btn[1, j].Text == btn[2, j].Text)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            btn[i, k].Enabled = false;
                        }
                    }
                    return true;
                }
            }

            if (btn[0, 0].Text != "-" && btn[0, 0].Text == btn[1, 1].Text && btn[1, 1].Text == btn[2, 2].Text)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        btn[i, k].Enabled = false;
                    }
                }
                return true;
            }
            if (btn[0, 2].Text != "-" && btn[0, 2].Text == btn[1, 1].Text && btn[1, 1].Text == btn[2, 0].Text)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        btn[i, k].Enabled = false;
                    }
                }
                return true;
            }
            return false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            player = "X";
            label1.Text = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    btn[i, j].Text = "-";
                    btn[i, j].Enabled = true;
                }
            }
        }
    }
}