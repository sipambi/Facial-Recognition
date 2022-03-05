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
    public partial class ShowRegister : Form
    {
        SqlConnection myConn = new SqlConnection(@"Data Source=DESKTOP-J62QRR0\TEW_SQLEXPRESS;Initial Catalog=Facial_Recognition;Integrated Security=True;Pooling=False");
        SqlCommand cmd;
        public ShowRegister()
        {
            InitializeComponent();
        }

        private void back_bttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacialRecognition myMain = new FacialRecognition();
            myMain.Show();
        }

        private void ShowRegister_Load(object sender, EventArgs e)
        {
            populateGDV();
        }
        public void populateGDV()
        {
            //populate the datagridview
            string selectQuery = "SELECT * FROM dbo.register";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, myConn);
            adapter.Fill(dt);
            attendance_data.DataSource = dt;
        }
    }
}
