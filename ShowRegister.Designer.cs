
namespace Facial_Recognition
{
    partial class ShowRegister
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.attendance_data = new System.Windows.Forms.DataGridView();
            this.back_bttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_data)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Red;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(-1, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(935, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Attendance Register";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // attendance_data
            // 
            this.attendance_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendance_data.Location = new System.Drawing.Point(12, 29);
            this.attendance_data.Name = "attendance_data";
            this.attendance_data.Size = new System.Drawing.Size(909, 448);
            this.attendance_data.TabIndex = 1;
            // 
            // back_bttn
            // 
            this.back_bttn.BackColor = System.Drawing.Color.Red;
            this.back_bttn.Location = new System.Drawing.Point(825, 501);
            this.back_bttn.Name = "back_bttn";
            this.back_bttn.Size = new System.Drawing.Size(96, 41);
            this.back_bttn.TabIndex = 18;
            this.back_bttn.Text = "Back";
            this.back_bttn.UseVisualStyleBackColor = false;
            this.back_bttn.Click += new System.EventHandler(this.back_bttn_Click);
            // 
            // ShowRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.back_bttn);
            this.Controls.Add(this.attendance_data);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ShowRegister";
            this.Text = "attendanceRegister";
            this.Load += new System.EventHandler(this.ShowRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendance_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView attendance_data;
        private System.Windows.Forms.Button back_bttn;
    }
}