﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facial_Recognition
{
    public partial class FacialRecognition : Form
    {
        public FacialRecognition()
        {
            InitializeComponent();
        }

        private void addUser_picBox_Click(object sender, EventArgs e)
        {

        }

        private void addStudent_picBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            addStudent newStudent = new addStudent();
            newStudent.Show();
        }

        private void checkattendance_picBox_Click(object sender, EventArgs e)
        {
            
        }

        private void register_picBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            attendanceRegister myRegister = new attendanceRegister();
            myRegister.Show();
        }
    }
}
