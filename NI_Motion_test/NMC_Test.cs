using System;
using System.IO;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NIMotion;
using Ascan;

namespace NI_Motion_test
{
    public partial class NMC_Test : Form
    {
        SerialPort port;
        StreamWriter sw = new StreamWriter("D:\\data0308.txt", false, Encoding.Default);
        System.Timers.Timer PosTimer = new System.Timers.Timer();
        public NMC_Test()
        {
            InitializeComponent();
            PosTimer.Enabled = true;                                //初始化读取实时速度和位置的计时器，每20ms发送一次读取指令,读取速度和位置信息   
            PosTimer.AutoReset = true;                              
            PosTimer.Interval = 20;
            PosTimer.Elapsed += new System.Timers.ElapsedEventHandler(ReadPos_tick);
            InitCOM("COM3");
            OpenPort();
        }

        public void InitCOM(string PortName)
        {
            port = new SerialPort(PortName);
            port.Parity = Parity.None;//无奇偶校验位
            port.StopBits = StopBits.One;//两个停止位
            port.Handshake = Handshake.RequestToSend;//控制协议
            port.ReceivedBytesThreshold =11;//设置 DataReceived 事件发生前内部输入缓冲区中的字节数
            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);//DataReceived事件委托
        }

        //打开串口的方法
        public void OpenPort()
        {
            try
            {
                port.Open();
            }
            catch { }

            if (port.IsOpen)
            {
                Console.WriteLine("the port is opened!");
            }
            else
            {
                Console.WriteLine("failure to open the port!");
            }

        }

        //关闭串口的方法
        public void ClosePort()
        {
            port.Close();
            if (!port.IsOpen)
            {
                Console.WriteLine("the port is already closed!");
            }
        }

 
        //DataReceived事件委托方法
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int i = 0;
            int []data = new int [11];
            double force_data = 00.00;
            try
            {
                //循环接收数据
                while (port.BytesToRead > 0)
                {
                    int ch = port.ReadByte();
                //    sw.WriteLine(ch);
                //    Console.WriteLine(ch);
                    data[i] = ch;
                    if (data[0] != 254)
                    {
                        break;

                    }

                    if (i == 10)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (data[j + 0] == 254 && data[j + 1] == 1)
                            {
                                force_data = data[j + 7] + data[j + 6] * 256;
                                force_data = force_data / 100;
                           //     Console.WriteLine(data[j+7]);

                                break;
                            }
                        }

                        //    force_data = data[7] + data[6] * 256  ;
                        //      force_data = force_data / 100;
                  //      Console.WriteLine(data[0]);
                 //       Console.WriteLine(data[1]);
                       Console.WriteLine(data[6]);
                 //      Console.WriteLine(data[7]);
                //        Console.WriteLine(force_data);


                        forceCallback force = new forceCallback(forcetext);
                        try
                        {
                            this.Invoke(force, new object[] { Convert.ToString(force_data) });
                        }
                        catch { }

                    }

                    i++;
                    if (i == 11)
                    {
                        i = 0;
                    }

                }
                //在这里对接收到的数据进行处理
                //  currentline = new StringBuilder();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        delegate void forceCallback(string text);
        private void forcetext(string text)
        {
            force.Text = text;
        }

        delegate void SetTextCallback(string text);
        //这段程序里面用于实时的更新当前的位置信息
        //下面应该增加R轴的程序
        private void SetXposText(string text)
        {
            xPos.Text = text;
        }

        private void SetYposText(string text)
        {
            yPos.Text = text;
        }

        private void SetZposText(string text)
        {
            zPos.Text = text;
        }

        //R
        private void SetRposText(string text)
        {
            rPos.Text = text;
        }

        private void ReadPos_tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            double xPos = 0;
            double yPos = 0;
            double zPos = 0;
            double rPos = 0;
            NMC.HardwareGetCurPos((int)Axis.X,ref xPos);
            NMC.HardwareGetCurPos((int)Axis.Y, ref yPos);
            NMC.HardwareGetCurPos((int)Axis.Z, ref zPos);
            NMC.HardwareGetCurPos((int)Axis.R, ref rPos);
            NMC.HardwareChklimit();
            // xPos = Math.Round(xPos, 2);
            // yPos = Math.Round(yPos, 2);
            // zPos = Math.Round(zPos, 2);

            SetTextCallback xPosition = new SetTextCallback(SetXposText);
            try
            { 
                this.Invoke(xPosition, new object[] { Convert.ToString(xPos) });
            }
            catch { }
            
            SetTextCallback yPosition = new SetTextCallback(SetYposText);
            try
            {
                this.Invoke(yPosition, new object[] { Convert.ToString(yPos) });
            }
            catch { }

            SetTextCallback zPosition = new SetTextCallback(SetZposText); //用于动态的更改控件text的内容
            try
            {
                this.Invoke(zPosition, new object[] { Convert.ToString(zPos) });
            }
            catch { }

            SetTextCallback rPosition = new SetTextCallback(SetRposText); //用于动态的更改控件text的内容
            try
            {
                this.Invoke(rPosition, new object[] { Convert.ToString(rPos) });
            }
            catch { }
        }

        private void NMC_Test_Load(object sender, EventArgs e)
        {
            NMC.HardwareOpen();
        }

        //未连线，连线后单独进行测试
        //由于内置编码器，因此归零可另外设置
        private void btn_zero_Click(object sender, EventArgs e)
        {
            bool flag = false;
            flag = NMC.HardwareGoZero();
            if (!flag)
                MessageShow.show("Go zero failed, pls check!", "回零失败，请检查!");
        }

        //移动按钮
        //需要增加R轴的程序
        private void btn_move_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (xSpeed.Text == "" || xDistance.Text == "" || ySpeed.Text == "" || yDistance.Text == ""
                || zSpeed.Text == "" || zDistance.Text == "" || rSpeed.Text == "" || rDistance.Text == "" )
            {
                MessageShow.show("Warning:Inputting is null, please input!",
                    "警告：输入为空，请重新输入!");
                return;
            }

            int axis1 = 1;
            double speed1 = Convert.ToDouble(xSpeed.Value);
            double range1 = Convert.ToDouble(xDistance.Value);

            int axis2 = 2;
            double speed2 = Convert.ToDouble(ySpeed.Value);
            double range2 = Convert.ToDouble(yDistance.Value);

            int axis3 = 3;
            double speed3 = Convert.ToDouble(zSpeed.Value);
            double range3 = Convert.ToDouble(zDistance.Value);

            int axis4 = 4;
            double speed4 = Convert.ToDouble(rSpeed.Value);
            double range4 = Convert.ToDouble(rDistance.Value);

            flag = NMC.HardwareBGo(axis1, range1, speed1);

            flag |= NMC.HardwareBGo(axis2, range2, speed2);

            flag |= NMC.HardwareBGo(axis3, range3, speed3);

            flag |= NMC.HardwareBGo(axis4, range4, speed4);

            if (!flag)
                MessageShow.show("Move failed, pls check!", "运动失败，请检查!");
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            NMC.HardwareEKill();
        }

        private void Cscan_btn_Click(object sender, EventArgs e)
        {
            int axis = 0;
            double range =0;
            //NMC.HardwareSigStop2Hardware();
            bool flag = false;
            if (nudRange.Text == ""  || nudSpeed.Text == "" )
            {
                MessageShow.show("Warning:Inputting is null, please input!",
                   "警告：输入为空，请重新输入!");
                return;
            }

            double Range = Convert.ToDouble(nudRange.Value);
            double speed = Convert.ToDouble(nudSpeed.Value);

            if (cmbScanAxis.SelectedIndex == 0) //X轴为扫描轴
            {
                axis = 1;
                range = Range;           
            }
            if (cmbScanAxis.SelectedIndex == 1) //Y轴为扫描轴
            {
                axis = 2;
                range = Range;
            }
            if (cmbScanAxis.SelectedIndex == 2) //Z轴为扫描轴
            {
                axis = 3;
                range = Range;
            }
            if (cmbScanAxis.SelectedIndex == 3) //R轴为扫描轴
            {
                axis = 4;
                range = Range;
            }
           
            flag = NMC.HardwareBGo(axis, range ,speed);
            if (!flag)
            {
                MessageShow.show("Bscan move failed, pls check!", "B扫运动失败，请检查!");
                return;
            }
        }

        public enum Axis
        { 
            X=1,
            Y=2,
            Z=3,
            R=4
        }

        private void btn_halt_Click(object sender, EventArgs e)
        {
            NMC.HardwareEHalt();
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            bool err,error;
            err=NMC.HardwareContinue();
            error=err;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            int axis1 = 1;
            int axis2 = 2;
            int axis3 = 3;
            int axis4 = 4;
            NMC.HardwareReset(axis1,axis2,axis3,axis4);
        }

        private void xforward_MouseDown(object sender, MouseEventArgs e)
        {
            bool flag = false;
            int axis = 1;
            int speed = 10;
            int range = 100;
            flag = NMC.HardwareBGo(axis, range, speed);
        }

        private void xforward_MouseUp(object sender, MouseEventArgs e)
        {
            NMC.HardwareEStop();
        }

       
    }
}
