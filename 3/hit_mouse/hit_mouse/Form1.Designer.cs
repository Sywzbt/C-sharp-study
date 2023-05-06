namespace hit_mouse
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            imageList1 = new ImageList(components);
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ImageList = imageList1;
            button1.Location = new Point(115, 91);
            button1.Name = "button1";
            button1.Size = new Size(139, 159);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "design-medium.jpg");
            imageList1.Images.SetKeyName(1, "white.png");
            // 
            // button2
            // 
            button2.ImageList = imageList1;
            button2.Location = new Point(274, 91);
            button2.Name = "button2";
            button2.Size = new Size(139, 159);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.ImageList = imageList1;
            button3.Location = new Point(433, 91);
            button3.Name = "button3";
            button3.Size = new Size(139, 159);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.ImageList = imageList1;
            button4.Location = new Point(115, 285);
            button4.Name = "button4";
            button4.Size = new Size(139, 159);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.ImageList = imageList1;
            button5.Location = new Point(274, 285);
            button5.Name = "button5";
            button5.Size = new Size(139, 159);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.ImageList = imageList1;
            button6.Location = new Point(433, 285);
            button6.Name = "button6";
            button6.Size = new Size(139, 159);
            button6.TabIndex = 3;
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.ImageList = imageList1;
            button7.Location = new Point(115, 474);
            button7.Name = "button7";
            button7.Size = new Size(139, 159);
            button7.TabIndex = 8;
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.ImageList = imageList1;
            button8.Location = new Point(274, 474);
            button8.Name = "button8";
            button8.Size = new Size(139, 159);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.ImageList = imageList1;
            button9.Location = new Point(433, 474);
            button9.Name = "button9";
            button9.Size = new Size(139, 159);
            button9.TabIndex = 6;
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(677, 168);
            button10.Name = "button10";
            button10.Size = new Size(196, 70);
            button10.TabIndex = 9;
            button10.Text = "Start";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 670);
            label1.Name = "label1";
            label1.Size = new Size(39, 19);
            label1.TabIndex = 10;
            label1.Text = "剩餘";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(677, 308);
            label2.Name = "label2";
            label2.Size = new Size(39, 19);
            label2.TabIndex = 11;
            label2.Text = "擊中";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(677, 373);
            label3.Name = "label3";
            label3.Size = new Size(39, 19);
            label3.TabIndex = 12;
            label3.Text = "失誤";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "初級", "中級", "高級" });
            comboBox1.Location = new Point(677, 69);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 27);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 745);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button10);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Label label1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private ComboBox comboBox1;
        private ImageList imageList1;
    }
}