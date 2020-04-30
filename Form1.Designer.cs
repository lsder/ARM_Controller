namespace ARM
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.com_list = new System.Windows.Forms.ComboBox();
            this.btn_conn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Z = new System.Windows.Forms.Button();
            this.qian = new System.Windows.Forms.Button();
            this.S = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.Y = new System.Windows.Forms.Button();
            this.O = new System.Windows.Forms.Button();
            this.hou = new System.Windows.Forms.Button();
            this.ting = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // com_list
            // 
            this.com_list.FormattingEnabled = true;
            this.com_list.Location = new System.Drawing.Point(82, 40);
            this.com_list.Name = "com_list";
            this.com_list.Size = new System.Drawing.Size(121, 33);
            this.com_list.TabIndex = 0;
            // 
            // btn_conn
            // 
            this.btn_conn.Location = new System.Drawing.Point(221, 30);
            this.btn_conn.Name = "btn_conn";
            this.btn_conn.Size = new System.Drawing.Size(151, 51);
            this.btn_conn.TabIndex = 1;
            this.btn_conn.Text = "连接";
            this.btn_conn.UseVisualStyleBackColor = true;
            this.btn_conn.Click += new System.EventHandler(this.btn_conn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 32);
            this.textBox1.TabIndex = 2;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(294, 87);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(78, 45);
            this.send.TabIndex = 3;
            this.send.Text = "发射";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(12, 172);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(374, 284);
            this.textBox2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_conn);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.send);
            this.groupBox1.Controls.Add(this.com_list);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 474);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "数据接收区：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "串口：";
            // 
            // Z
            // 
            this.Z.Location = new System.Drawing.Point(42, 100);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(43, 43);
            this.Z.TabIndex = 8;
            this.Z.Text = "<";
            this.Z.UseVisualStyleBackColor = true;
            this.Z.Click += new System.EventHandler(this.Z_Click);
            // 
            // qian
            // 
            this.qian.Location = new System.Drawing.Point(111, 30);
            this.qian.Name = "qian";
            this.qian.Size = new System.Drawing.Size(43, 43);
            this.qian.TabIndex = 9;
            this.qian.Text = "^";
            this.qian.UseVisualStyleBackColor = true;
            this.qian.Click += new System.EventHandler(this.qian_Click);
            // 
            // S
            // 
            this.S.Location = new System.Drawing.Point(285, 30);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(43, 43);
            this.S.TabIndex = 10;
            this.S.Text = "^";
            this.S.UseVisualStyleBackColor = true;
            this.S.Click += new System.EventHandler(this.S_Click);
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(285, 170);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(43, 43);
            this.X.TabIndex = 11;
            this.X.Text = "∨";
            this.X.UseVisualStyleBackColor = true;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(178, 100);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(43, 43);
            this.Y.TabIndex = 12;
            this.Y.Text = ">";
            this.Y.UseVisualStyleBackColor = true;
            this.Y.Click += new System.EventHandler(this.Y_Click);
            // 
            // O
            // 
            this.O.Location = new System.Drawing.Point(111, 100);
            this.O.Name = "O";
            this.O.Size = new System.Drawing.Size(43, 43);
            this.O.TabIndex = 13;
            this.O.Text = "O";
            this.O.UseVisualStyleBackColor = true;
            this.O.Click += new System.EventHandler(this.O_Click);
            // 
            // hou
            // 
            this.hou.Location = new System.Drawing.Point(111, 170);
            this.hou.Name = "hou";
            this.hou.Size = new System.Drawing.Size(43, 43);
            this.hou.TabIndex = 14;
            this.hou.Text = "∨";
            this.hou.UseVisualStyleBackColor = true;
            this.hou.Click += new System.EventHandler(this.hou_Click);
            // 
            // ting
            // 
            this.ting.Location = new System.Drawing.Point(285, 100);
            this.ting.Name = "ting";
            this.ting.Size = new System.Drawing.Size(43, 43);
            this.ting.TabIndex = 15;
            this.ting.Text = "X";
            this.ting.UseVisualStyleBackColor = true;
            this.ting.Click += new System.EventHandler(this.ting_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.O);
            this.groupBox2.Controls.Add(this.ting);
            this.groupBox2.Controls.Add(this.Z);
            this.groupBox2.Controls.Add(this.hou);
            this.groupBox2.Controls.Add(this.qian);
            this.groupBox2.Controls.Add(this.S);
            this.groupBox2.Controls.Add(this.Y);
            this.groupBox2.Controls.Add(this.X);
            this.groupBox2.Location = new System.Drawing.Point(459, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 224);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 504);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "AUTO ARM  机械臂控制器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox com_list;
        private System.Windows.Forms.Button btn_conn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Z;
        private System.Windows.Forms.Button qian;
        private System.Windows.Forms.Button S;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Button Y;
        private System.Windows.Forms.Button O;
        private System.Windows.Forms.Button hou;
        private System.Windows.Forms.Button ting;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

