using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARM
{
    public partial class Form1 : Form
    {
        String serialPortName;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();//获取电脑上可用串口号
            com_list.Items.AddRange(ports);//给comboBox1添加数据
            com_list.SelectedIndex = com_list.Items.Count > 0 ? 0 : -1;//如果里面有数据,显示第0个
        }

        private void btn_conn_Click(object sender, EventArgs e)
        {
            if (btn_conn.Text == "打开串口")
            {//如果按钮显示的是打开
                try
                {//防止意外错误
                    serialPort1.PortName = com_list.Text;//获取comboBox1要打开的串口号
                    serialPortName = com_list.Text;
                    serialPort1.BaudRate = 115200;//获取comboBox2选择的波特率
                    serialPort1.DataBits = 8;//设置数据位
                    serialPort1.StopBits = StopBits.One; 
                    serialPort1.Parity = Parity.None;
                    
                    serialPort1.Open();//打开串口
                    btn_conn.Text = "关闭串口";//按钮显示关闭串口
                }
                catch (Exception err)
                {
                    MessageBox.Show("打开失败" + err.ToString(), "提示!");//对话框显示打开失败
                }
            }
            else
            {//要关闭串口
                try
                {//防止意外错误
                    serialPort1.Close();//关闭串口
                }
                catch (Exception) { }
                btn_conn.Text = "打开串口";//按钮显示打开
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            String Str = textBox1.Text.ToString();//获取发送文本框里面的数据
            try
            {
                if (Str.Length > 0)
                {
                        serialPort1.Write(Str+"\n");//串口发送数据
                }
            }
            catch (Exception) { }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int len = serialPort1.BytesToRead;//获取可以读取的字节数
            byte[] buff = new byte[len];//创建缓存数据数组
            serialPort1.Read(buff, 0, len);//把数据读取到buff数组

            Invoke((new Action(() => {//C# 3.0以后代替委托的新方法
                
                    textBox2.AppendText(Encoding.Default.GetString(buff));//对话框追加显示数据
             
            })));
        }
    }
}
