
namespace Facial_Recognition
{
    partial class AttendanceCheck
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.recognize_bttn = new System.Windows.Forms.Button();
            this.submit_bttn = new System.Windows.Forms.Button();
            this.back_bttn = new System.Windows.Forms.Button();
            this.trained_picBox = new System.Windows.Forms.PictureBox();
            this.temp_lbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.program_txtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gender_txtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.address_txtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.phonenumber_txtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fullname_txtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.studentid_txtBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.startcamera_bttn = new System.Windows.Forms.Button();
            this.camera_picBox = new System.Windows.Forms.PictureBox();
            this.ports_comboBox = new System.Windows.Forms.ComboBox();
            this.cnnt_bttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trained_picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camera_picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Check Attendance";
            // 
            // recognize_bttn
            // 
            this.recognize_bttn.BackColor = System.Drawing.Color.Red;
            this.recognize_bttn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recognize_bttn.Location = new System.Drawing.Point(393, 223);
            this.recognize_bttn.Name = "recognize_bttn";
            this.recognize_bttn.Size = new System.Drawing.Size(83, 66);
            this.recognize_bttn.TabIndex = 5;
            this.recognize_bttn.Text = "Recognise";
            this.recognize_bttn.UseVisualStyleBackColor = false;
            this.recognize_bttn.Click += new System.EventHandler(this.recognize_bttn_Click);
            // 
            // submit_bttn
            // 
            this.submit_bttn.BackColor = System.Drawing.Color.Red;
            this.submit_bttn.Location = new System.Drawing.Point(728, 301);
            this.submit_bttn.Name = "submit_bttn";
            this.submit_bttn.Size = new System.Drawing.Size(96, 41);
            this.submit_bttn.TabIndex = 16;
            this.submit_bttn.Text = "Submit";
            this.submit_bttn.UseVisualStyleBackColor = false;
            this.submit_bttn.Click += new System.EventHandler(this.submit_bttn_Click);
            // 
            // back_bttn
            // 
            this.back_bttn.BackColor = System.Drawing.Color.Red;
            this.back_bttn.Location = new System.Drawing.Point(382, 298);
            this.back_bttn.Name = "back_bttn";
            this.back_bttn.Size = new System.Drawing.Size(96, 41);
            this.back_bttn.TabIndex = 17;
            this.back_bttn.Text = "Back";
            this.back_bttn.UseVisualStyleBackColor = false;
            this.back_bttn.Click += new System.EventHandler(this.back_bttn_Click);
            // 
            // trained_picBox
            // 
            this.trained_picBox.BackColor = System.Drawing.Color.White;
            this.trained_picBox.Location = new System.Drawing.Point(297, 73);
            this.trained_picBox.Margin = new System.Windows.Forms.Padding(4);
            this.trained_picBox.Name = "trained_picBox";
            this.trained_picBox.Size = new System.Drawing.Size(179, 136);
            this.trained_picBox.TabIndex = 1;
            this.trained_picBox.TabStop = false;
            // 
            // temp_lbl
            // 
            this.temp_lbl.AutoSize = true;
            this.temp_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.temp_lbl.ForeColor = System.Drawing.Color.Yellow;
            this.temp_lbl.Location = new System.Drawing.Point(753, 15);
            this.temp_lbl.Name = "temp_lbl";
            this.temp_lbl.Size = new System.Drawing.Size(43, 18);
            this.temp_lbl.TabIndex = 18;
            this.temp_lbl.Text = "32.7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(644, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Temperature:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(793, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "*C";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(626, 269);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 23);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(508, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "D.O.B";
            // 
            // program_txtBox
            // 
            this.program_txtBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.program_txtBox.Location = new System.Drawing.Point(626, 124);
            this.program_txtBox.Name = "program_txtBox";
            this.program_txtBox.Size = new System.Drawing.Size(182, 27);
            this.program_txtBox.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(508, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Program:";
            // 
            // gender_txtBox
            // 
            this.gender_txtBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_txtBox.Location = new System.Drawing.Point(626, 298);
            this.gender_txtBox.Name = "gender_txtBox";
            this.gender_txtBox.Size = new System.Drawing.Size(83, 27);
            this.gender_txtBox.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(508, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "Gender:";
            // 
            // address_txtBox
            // 
            this.address_txtBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_txtBox.Location = new System.Drawing.Point(626, 201);
            this.address_txtBox.Multiline = true;
            this.address_txtBox.Name = "address_txtBox";
            this.address_txtBox.Size = new System.Drawing.Size(182, 60);
            this.address_txtBox.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(508, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 32;
            this.label6.Text = "Address:";
            // 
            // phonenumber_txtBox
            // 
            this.phonenumber_txtBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumber_txtBox.Location = new System.Drawing.Point(626, 162);
            this.phonenumber_txtBox.Name = "phonenumber_txtBox";
            this.phonenumber_txtBox.Size = new System.Drawing.Size(182, 27);
            this.phonenumber_txtBox.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(508, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "Phone Number:";
            // 
            // fullname_txtBox
            // 
            this.fullname_txtBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname_txtBox.Location = new System.Drawing.Point(626, 88);
            this.fullname_txtBox.Name = "fullname_txtBox";
            this.fullname_txtBox.Size = new System.Drawing.Size(182, 27);
            this.fullname_txtBox.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(508, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 18);
            this.label10.TabIndex = 28;
            this.label10.Text = "Full Name:";
            // 
            // studentid_txtBox
            // 
            this.studentid_txtBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentid_txtBox.Location = new System.Drawing.Point(626, 52);
            this.studentid_txtBox.Name = "studentid_txtBox";
            this.studentid_txtBox.Size = new System.Drawing.Size(182, 27);
            this.studentid_txtBox.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label11.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(508, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 18);
            this.label11.TabIndex = 26;
            this.label11.Text = "Student ID #:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Yellow;
            this.label12.Location = new System.Drawing.Point(0, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 18);
            this.label12.TabIndex = 42;
            this.label12.Text = "Camera";
            // 
            // startcamera_bttn
            // 
            this.startcamera_bttn.BackColor = System.Drawing.Color.Red;
            this.startcamera_bttn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startcamera_bttn.ForeColor = System.Drawing.Color.Yellow;
            this.startcamera_bttn.Location = new System.Drawing.Point(297, 223);
            this.startcamera_bttn.Name = "startcamera_bttn";
            this.startcamera_bttn.Size = new System.Drawing.Size(83, 66);
            this.startcamera_bttn.TabIndex = 41;
            this.startcamera_bttn.Text = "Start Camera";
            this.startcamera_bttn.UseVisualStyleBackColor = false;
            this.startcamera_bttn.Click += new System.EventHandler(this.startcamera_bttn_Click);
            // 
            // camera_picBox
            // 
            this.camera_picBox.BackColor = System.Drawing.Color.White;
            this.camera_picBox.Location = new System.Drawing.Point(3, 73);
            this.camera_picBox.Name = "camera_picBox";
            this.camera_picBox.Size = new System.Drawing.Size(282, 252);
            this.camera_picBox.TabIndex = 40;
            this.camera_picBox.TabStop = false;
            // 
            // ports_comboBox
            // 
            this.ports_comboBox.AllowDrop = true;
            this.ports_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ports_comboBox.FormattingEnabled = true;
            this.ports_comboBox.Location = new System.Drawing.Point(164, 8);
            this.ports_comboBox.Name = "ports_comboBox";
            this.ports_comboBox.Size = new System.Drawing.Size(130, 26);
            this.ports_comboBox.TabIndex = 43;
            // 
            // cnnt_bttn
            // 
            this.cnnt_bttn.BackColor = System.Drawing.Color.Red;
            this.cnnt_bttn.Location = new System.Drawing.Point(3, 2);
            this.cnnt_bttn.Name = "cnnt_bttn";
            this.cnnt_bttn.Size = new System.Drawing.Size(155, 38);
            this.cnnt_bttn.TabIndex = 45;
            this.cnnt_bttn.Text = "Connect Sensor";
            this.cnnt_bttn.UseVisualStyleBackColor = false;
            this.cnnt_bttn.Click += new System.EventHandler(this.cnnt_bttn_Click);
            // 
            // AttendanceCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(836, 353);
            this.Controls.Add(this.cnnt_bttn);
            this.Controls.Add(this.ports_comboBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.startcamera_bttn);
            this.Controls.Add(this.camera_picBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.program_txtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gender_txtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.address_txtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phonenumber_txtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fullname_txtBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.studentid_txtBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.temp_lbl);
            this.Controls.Add(this.back_bttn);
            this.Controls.Add(this.submit_bttn);
            this.Controls.Add(this.recognize_bttn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trained_picBox);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AttendanceCheck";
            this.Text = "Attendance Checker";
            ((System.ComponentModel.ISupportInitialize)(this.trained_picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camera_picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox trained_picBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button recognize_bttn;
        private System.Windows.Forms.Button submit_bttn;
        private System.Windows.Forms.Button back_bttn;
        private System.Windows.Forms.Label temp_lbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox program_txtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gender_txtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox address_txtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phonenumber_txtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fullname_txtBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox studentid_txtBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button startcamera_bttn;
        private System.Windows.Forms.PictureBox camera_picBox;
        private System.Windows.Forms.ComboBox ports_comboBox;
        private System.Windows.Forms.Button cnnt_bttn;
    }
}