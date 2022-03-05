using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;
using System.Data.SqlClient;

namespace Facial_Recognition
{
    public partial class addStudent : Form
    {
        SqlConnection myConn = new SqlConnection(@"Data Source=DESKTOP-J62QRR0\TEW_SQLEXPRESS;Initial Catalog=Facial_Recognition;Integrated Security=True;Pooling=False");
        FaceRec faceRec = new FaceRec();
        SqlCommand cmd;
        public addStudent()
        {
            InitializeComponent();
        }

        private void back_bttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacialRecognition myMain = new FacialRecognition();
            myMain.Show();
        }

        private void captureFace_bttn_Click(object sender, EventArgs e)
        {
            faceRec.Save_IMAGE(fullname_txtBox.Text);
            MessageBox.Show(fullname_txtBox.Text + " added Successfully");
        }

        private void startRecognize_bttn_Click(object sender, EventArgs e)
        {
            faceRec.openCamera(camera_picBox, trained_picBox);
        }

        private void close_bttn_Click(object sender, EventArgs e)
        {
//            faceRec.isTrained = true;
        }

        private void submit_bttn_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO dbo.students (,) values ()";
            executeQuery(query);
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
                    x = cmd.ExecuteNonQuery();
                    MessageBox.Show(x.ToString() + "record(s) saved.");
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
    }
}
