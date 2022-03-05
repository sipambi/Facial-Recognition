using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Facial_Recognition
{
    public partial class Login : Form
    {
        SqlConnection myConn = new SqlConnection(@"Data Source=DESKTOP-J62QRR0\TEW_SQLEXPRESS;Initial Catalog=Facial_Recognition;Integrated Security=True;Pooling=False");
        int i;
        public Login()
        {
            InitializeComponent();
        }

        private void changepassword_bttn_Click(object sender, EventArgs e)
        {

        }

        private void login_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                i = 0;
                myConn.Open();
                string query = "SELECT * FROM dbo.Login WHERE username = '" + username_txtBox.Text + "' and password='" + password_txtBox.Text + "'"; //creates a connection to the database
                DataTable dt = new DataTable();
                SqlDataAdapter myDataAdapter = new SqlDataAdapter(query, myConn);
                myDataAdapter.Fill(dt);
                //status = dt.Rows[0]["designation"].ToString();
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                if (i == 0)
                {
                    MessageBox.Show("You have entered wrong Credentials");
                }
                else
                {
                    this.Hide();
                    FacialRecognition myMain = new FacialRecognition();
                    myMain.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You have entered wrong Credentials");
                //MessageBox.Show(ex.Message);
            }
            myConn.Close();
        }

        private void cancel_bttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
