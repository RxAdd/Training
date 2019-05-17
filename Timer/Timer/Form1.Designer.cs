namespace Timer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl31 = new Timer.UserControl3();
            this.elementHost3 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl32 = new Timer.UserControl3();
            this.elementHost4 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl41 = new Timer.UserControl4();
            this.elementHost5 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl33 = new Timer.UserControl3();
            this.elementHost6 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl34 = new Timer.UserControl3();
            this.elementHost7 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl42 = new Timer.UserControl4();
            this.elementHost8 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl35 = new Timer.UserControl3();
            this.elementHost9 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl36 = new Timer.UserControl3();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.elementHost2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.elementHost3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.elementHost4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.elementHost5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.elementHost6, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.elementHost7, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.elementHost8, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.elementHost9, 7, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1857, 560);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(200, 100);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Child = null;
            // 
            // elementHost2
            // 
            this.elementHost2.Location = new System.Drawing.Point(3, 3);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(200, 100);
            this.elementHost2.TabIndex = 0;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.Child = this.userControl31;
            // 
            // elementHost3
            // 
            this.elementHost3.Location = new System.Drawing.Point(235, 3);
            this.elementHost3.Name = "elementHost3";
            this.elementHost3.Size = new System.Drawing.Size(200, 100);
            this.elementHost3.TabIndex = 1;
            this.elementHost3.Text = "elementHost3";
            this.elementHost3.Child = this.userControl32;
            // 
            // elementHost4
            // 
            this.elementHost4.Location = new System.Drawing.Point(467, 3);
            this.elementHost4.Name = "elementHost4";
            this.elementHost4.Size = new System.Drawing.Size(200, 100);
            this.elementHost4.TabIndex = 2;
            this.elementHost4.Text = "elementHost4";
            this.elementHost4.Child = this.userControl41;
            // 
            // elementHost5
            // 
            this.elementHost5.Location = new System.Drawing.Point(699, 3);
            this.elementHost5.Name = "elementHost5";
            this.elementHost5.Size = new System.Drawing.Size(200, 100);
            this.elementHost5.TabIndex = 3;
            this.elementHost5.Text = "elementHost5";
            this.elementHost5.Child = this.userControl33;
            // 
            // elementHost6
            // 
            this.elementHost6.Location = new System.Drawing.Point(931, 3);
            this.elementHost6.Name = "elementHost6";
            this.elementHost6.Size = new System.Drawing.Size(200, 100);
            this.elementHost6.TabIndex = 4;
            this.elementHost6.Text = "elementHost6";
            this.elementHost6.Child = this.userControl34;
            // 
            // elementHost7
            // 
            this.elementHost7.Location = new System.Drawing.Point(1169, 8);
            this.elementHost7.Name = "elementHost7";
            this.elementHost7.Size = new System.Drawing.Size(200, 100);
            this.elementHost7.TabIndex = 5;
            this.elementHost7.Text = "elementHost7";
            this.elementHost7.Child = this.userControl42;
            // 
            // elementHost8
            // 
            this.elementHost8.Location = new System.Drawing.Point(1403, 11);
            this.elementHost8.Name = "elementHost8";
            this.elementHost8.Size = new System.Drawing.Size(200, 100);
            this.elementHost8.TabIndex = 6;
            this.elementHost8.Text = "elementHost8";
            this.elementHost8.Child = this.userControl35;
            // 
            // elementHost9
            // 
            this.elementHost9.Location = new System.Drawing.Point(1640, 7);
            this.elementHost9.Name = "elementHost9";
            this.elementHost9.Size = new System.Drawing.Size(200, 100);
            this.elementHost9.TabIndex = 7;
            this.elementHost9.Text = "elementHost9";
            this.elementHost9.Child = this.userControl36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1857, 560);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private UserControl3 userControl31;
        private System.Windows.Forms.Integration.ElementHost elementHost3;
        private UserControl3 userControl32;
        private System.Windows.Forms.Integration.ElementHost elementHost4;
        private UserControl4 userControl41;
        private System.Windows.Forms.Integration.ElementHost elementHost5;
        private UserControl3 userControl33;
        private System.Windows.Forms.Integration.ElementHost elementHost6;
        private UserControl3 userControl34;
        private System.Windows.Forms.Integration.ElementHost elementHost7;
        private UserControl4 userControl42;
        private System.Windows.Forms.Integration.ElementHost elementHost8;
        private UserControl3 userControl35;
        private System.Windows.Forms.Integration.ElementHost elementHost9;
        private UserControl3 userControl36;
    }
}

