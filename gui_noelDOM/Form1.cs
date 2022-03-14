using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui_noelDOM
{
    public partial class GUI : Form
    {
        private SerialPort _serialPort;
        private delegate void SetTextDeleg(string text);
        string motor_direction = "0";
        string motor_pwm = "0";

        public GUI()
        {
            InitializeComponent();
        }

   

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Text = "115200"; /* Default Baudrate */
            Label_pos.Text = "0";
            Btn_conect.Enabled = false;
            Track_Bar_Motor_Pwm.Enabled = false;
            Btn_left.Enabled = false;
            Btn_Right.Enabled = false;
        }

        private void Btn_load_porst_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear(); 
            string[] serial_ports = SerialPort.GetPortNames(); 

            foreach (string port in serial_ports)
            {
                comboBox1.Items.Add(port);
                comboBox1.Text = port;
            }
            Btn_conect.Enabled = true;
        }

        private void Btn_conect_Click(object sender, EventArgs e)
        {
            if (Btn_conect.Text == "Connect")
            {
                Btn_conect.Text = "Disconnect";
                _serialPort = new SerialPort(comboBox1.Text, Convert.ToInt32(comboBox2.Text), Parity.None, 8, StopBits.One);
                _serialPort.Handshake = Handshake.None;
                _serialPort.DataReceived += new SerialDataReceivedEventHandler(Serial_data);
                _serialPort.ReadTimeout = 500;
                _serialPort.WriteTimeout = 10;
                try
                {
                    _serialPort.Open();
                    Track_Bar_Motor_Pwm.Enabled = true;
                    Btn_left.Enabled = true;
                    Btn_Right.Enabled = true;

                }
                catch (Exception)
                {
                    Btn_conect.Text = "Connect";
                    Track_Bar_Motor_Pwm.Enabled = false;
                    Btn_left.Enabled = false;
                    Btn_Right.Enabled = false;
                    MessageBox.Show("Error: " + comboBox1.Text + " (Port busy)");
                 
                }

            }
            else if (Btn_conect.Text == "Disconnect")
            {
                Btn_conect.Text = "Connect";
                Track_Bar_Motor_Pwm.Enabled = false;
                Btn_left.Enabled = false;
                _serialPort.Close();
            }
        }

        private void Serial_data(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(1);

            try
            {

             
                string data = _serialPort.ReadLine();
                this.BeginInvoke(new SetTextDeleg(Gui_data), new object[] { data });

            }

            catch (Exception) /* Serial error handler */
            {

            }
        }

        private void Gui_data(string data)
        {
            Console.Write(data);
      
        }

        private void btn_send_data_Click(object sender, EventArgs e)
        {
            motor_direction = "1";
            Serial_update_motor_parameters(motor_pwm, motor_direction);
        }

        private void Track_Bar_Servo_ValueChanged(object sender, EventArgs e)
        {
            Label_pos.Text = Track_Bar_Motor_Pwm.Value.ToString();
            motor_pwm = Track_Bar_Motor_Pwm.Value.ToString();
            Serial_update_motor_parameters(motor_pwm, motor_direction);

        }

        private void Serial_update_motor_parameters(string pwm, string dir)
        {
           _serialPort.WriteLine(pwm + "," + dir);
        }

        private void Btn_Right_Click(object sender, EventArgs e)
        {
            motor_direction = "0";
            Serial_update_motor_parameters(motor_pwm, motor_direction);
        }

        private void Btn_stop_Click(object sender, EventArgs e)
        {
            motor_direction = "3";
            Track_Bar_Motor_Pwm.Value = 0;
            Serial_update_motor_parameters(motor_pwm, motor_direction);
        }
    }
}
