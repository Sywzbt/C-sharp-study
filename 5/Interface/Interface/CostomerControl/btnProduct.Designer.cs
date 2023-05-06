namespace Interface.CostomerControl
{
    partial class btnProduct
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblProduceName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCattegory = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 10;
            this.guna2GradientPanel1.Controls.Add(this.lblProduceName);
            this.guna2GradientPanel1.Controls.Add(this.lblPrice);
            this.guna2GradientPanel1.Controls.Add(this.lblCattegory);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(4, 4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(230, 223);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // lblProduceName
            // 
            this.lblProduceName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProduceName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProduceName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduceName.Location = new System.Drawing.Point(0, 22);
            this.lblProduceName.Name = "lblProduceName";
            this.lblProduceName.Size = new System.Drawing.Size(230, 179);
            this.lblProduceName.TabIndex = 8;
            this.lblProduceName.Text = "Product Name";
            this.lblProduceName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProduceName.Click += new System.EventHandler(this.lable);
            // 
            // lblPrice
            // 
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.lblPrice.Location = new System.Drawing.Point(0, 201);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Padding = new System.Windows.Forms.Padding(0, 0, 5, 3);
            this.lblPrice.Size = new System.Drawing.Size(230, 22);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPrice.Click += new System.EventHandler(this.lable);
            // 
            // lblCattegory
            // 
            this.lblCattegory.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCattegory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCattegory.Location = new System.Drawing.Point(0, 0);
            this.lblCattegory.Name = "lblCattegory";
            this.lblCattegory.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblCattegory.Size = new System.Drawing.Size(230, 22);
            this.lblCattegory.TabIndex = 6;
            this.lblCattegory.Text = "Catgory";
            this.lblCattegory.Click += new System.EventHandler(this.lable);
            // 
            // btnProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.guna2GradientPanel1);
            this.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "btnProduct";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(238, 231);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label lblProduceName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCattegory;
    }
}
