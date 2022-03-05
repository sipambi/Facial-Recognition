using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using FaceRecognition;
using System.Data.SqlClient;
using System.IO;


namespace Facial_Recognition
{
    public partial class AttendanceCheck : Form
    {
        SqlConnection myConn = new SqlConnection(@"Data Source=DESKTOP-J62QRR0\TEW_SQLEXPRESS;Initial Catalog=Facial_Recognition;Integrated Security=True;Pooling=False");
        public SerialPort aSerialPort = new SerialPort(); // thisport is a reference of the serial port to be used in the program
        FaceRec faceRec = new FaceRec();
        SqlCommand cmd;
        public AttendanceCheck()
        {
            InitializeComponent();
            getAvailablePorts();
        }

        void getAvailablePorts()
        {
            string[] ports = SerialPort.GetPortNames(); // gets the available port names
            ports_comboBox.Items.AddRange(ports);  // populates the combobox with free ports
        }
        private void cnnt_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                aSerialPort.PortName = ports_comboBox.Text; // the open serial port from the machine
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "portname empty");
            }
            aSerialPort.BaudRate = 9600;  //baudrate of the serial communication system
            aSerialPort.DataBits = 8;
            aSerialPort.Parity = Parity.None;
            aSerialPort.StopBits = StopBits.One;
            aSerialPort.DataBits = 8;
            aSerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            try
            {
                if (!aSerialPort.IsOpen)
                {
                    aSerialPort.Open();
                    //connect_lbl.Text = "Connection Established";                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Serial Port Not Available");
            }
        }
        private void DataReceivedHandler(Object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sData = sender as SerialPort;
                string data = sData.ReadExisting();

                if (data != String.Empty)
                {
                    temp_lbl.Text = data;
                    //Invoke(new Action(() => temp_lbl.AppendText(w)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Serial Conflict");
            }
        }

        public void OpenConn()
        {
            if (myConn.State == ConnectionState.Closed)
            {
                myConn.Open();
            }
        }

        public void CloseConn()
        {
            if (myConn.State == ConnectionState.Open)
            {
                myConn.Close();
            }
        }
        public void executeQuery(string query)
        {
            int x;
            try
            {
                OpenConn();
                cmd = new SqlCommand(query, myConn);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    //x = cmd.ExecuteNonQuery();
                    MessageBox.Show("Data saved.");
                }
                else
                {
                    MessageBox.Show("Query Not Executed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConn();
            }
        }

        private void startcamera_bttn_Click(object sender, EventArgs e)
        {
            faceRec.openCamera(camera_picBox,trained_picBox);
        }

        private void recognize_bttn_Click(object sender, EventArgs e)
        {
            faceRec.isTrained = true;
        }

        private void back_bttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacialRecognition myMain = new FacialRecognition();
            myMain.Show();
        }

        private void submit_bttn_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO dbo.register (studentid, fullname, temperature, image) values('" + studentid_txtBox.Text + "' ,'" + fullname_txtBox.Text + "','" + temp_lbl.Text + "' ,@Pic)";
            MemoryStream stream = new MemoryStream();
            trained_picBox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] pic = stream.ToArray();
            cmd.Parameters.AddWithValue("@Pic", pic);
            executeQuery(query);
        }
    }
}
