namespace Caculator
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
            this.txb_result = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_point = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_result
            // 
            this.txb_result.Location = new System.Drawing.Point(13, 24);
            this.txb_result.Name = "txb_result";
            this.txb_result.ReadOnly = true;
            this.txb_result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_result.Size = new System.Drawing.Size(230, 22);
            this.txb_result.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(32, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 305);
            this.panel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel1.Controls.Add(this.txb_result);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel2.Controls.Add(this.btn_point);
            this.splitContainer1.Panel2.Controls.Add(this.btn_0);
            this.splitContainer1.Panel2.Controls.Add(this.btn_clear);
            this.splitContainer1.Panel2.Controls.Add(this.equal);
            this.splitContainer1.Panel2.Controls.Add(this.btn_multiply);
            this.splitContainer1.Panel2.Controls.Add(this.btn_divide);
            this.splitContainer1.Panel2.Controls.Add(this.btn_minus);
            this.splitContainer1.Panel2.Controls.Add(this.btn_add);
            this.splitContainer1.Panel2.Controls.Add(this.btn_3);
            this.splitContainer1.Panel2.Controls.Add(this.btn_1);
            this.splitContainer1.Panel2.Controls.Add(this.btn_2);
            this.splitContainer1.Panel2.Controls.Add(this.btn_5);
            this.splitContainer1.Panel2.Controls.Add(this.btn_6);
            this.splitContainer1.Panel2.Controls.Add(this.btn_9);
            this.splitContainer1.Panel2.Controls.Add(this.btn_8);
            this.splitContainer1.Panel2.Controls.Add(this.btn_7);
            this.splitContainer1.Panel2.Controls.Add(this.btn_4);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Size = new System.Drawing.Size(261, 305);
            this.splitContainer1.SplitterDistance = 76;
            this.splitContainer1.TabIndex = 1;
            // 
            // btn_point
            // 
            this.btn_point.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_point.Location = new System.Drawing.Point(139, 180);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(41, 29);
            this.btn_point.TabIndex = 16;
            this.btn_point.Text = ".";
            this.btn_point.UseVisualStyleBackColor = true;
            this.btn_point.Click += new System.EventHandler(this.btn_point_Click);
            // 
            // btn_0
            // 
            this.btn_0.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_0.Location = new System.Drawing.Point(17, 180);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(102, 29);
            this.btn_0.TabIndex = 15;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_clear.Location = new System.Drawing.Point(17, 18);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(41, 29);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // equal
            // 
            this.equal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.equal.Location = new System.Drawing.Point(202, 180);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(41, 29);
            this.equal.TabIndex = 13;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_multiply.Location = new System.Drawing.Point(202, 73);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(41, 29);
            this.btn_multiply.TabIndex = 12;
            this.btn_multiply.Text = "*";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.btn_multiply_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_divide.Location = new System.Drawing.Point(202, 38);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(41, 29);
            this.btn_divide.TabIndex = 11;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_minus.Location = new System.Drawing.Point(202, 108);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(41, 29);
            this.btn_minus.TabIndex = 10;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_add
            // 
            this.btn_add.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_add.Location = new System.Drawing.Point(202, 145);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(41, 29);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_3
            // 
            this.btn_3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_3.Location = new System.Drawing.Point(139, 145);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(41, 29);
            this.btn_3.TabIndex = 8;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_1
            // 
            this.btn_1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_1.Location = new System.Drawing.Point(17, 145);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(41, 29);
            this.btn_1.TabIndex = 7;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_2.Location = new System.Drawing.Point(78, 145);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(41, 29);
            this.btn_2.TabIndex = 6;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_5
            // 
            this.btn_5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_5.Location = new System.Drawing.Point(78, 99);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(41, 29);
            this.btn_5.TabIndex = 5;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_6
            // 
            this.btn_6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_6.Location = new System.Drawing.Point(139, 99);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(41, 29);
            this.btn_6.TabIndex = 4;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_9
            // 
            this.btn_9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_9.Location = new System.Drawing.Point(139, 53);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(41, 29);
            this.btn_9.TabIndex = 3;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_8
            // 
            this.btn_8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_8.Location = new System.Drawing.Point(78, 53);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(41, 29);
            this.btn_8.TabIndex = 2;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_7
            // 
            this.btn_7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_7.Location = new System.Drawing.Point(17, 53);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(41, 29);
            this.btn_7.TabIndex = 1;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_4
            // 
            this.btn_4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_4.Location = new System.Drawing.Point(17, 99);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(41, 29);
            this.btn_4.TabIndex = 0;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 353);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txb_result;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_point;
    }
}

