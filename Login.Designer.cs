namespace Facial_Recognition
{
    partial class Login
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
            this.username_txtBox = new System.Windows.Forms.TextBox();
            this.password_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_bttn = new System.Windows.Forms.Button();
            this.cancel_bttn = new System.Windows.Forms.Button();
            this.change_bttn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username_txtBox
            // 
            this.username_txtBox.Location = new System.Drawing.Point(263, 32);
            this.username_txtBox.Multiline = true;
            this.username_txtBox.Name = "username_txtBox";
            this.username_txtBox.Size = new System.Drawing.Size(213, 27);
            this.username_txtBox.TabIndex = 0;
            // 
            // password_txtBox
            // 
            this.password_txtBox.Location = new System.Drawing.Point(263, 81);
            this.password_txtBox.Multiline = true;
            this.password_txtBox.Name = "password_txtBox";
            this.password_txtBox.Size = new System.Drawing.Size(213, 27);
            this.password_txtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(260, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(262, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // login_bttn
            // 
            this.login_bttn.BackColor = System.Drawing.Color.Red;
            this.login_bttn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_bttn.ForeColor = System.Drawing.Color.Yellow;
            this.login_bttn.Location = new System.Drawing.Point(263, 114);
            this.login_bttn.Name = "login_bttn";
            this.login_bttn.Size = new System.Drawing.Size(90, 28);
            this.login_bttn.TabIndex = 4;
            this.login_bttn.Text = "Ok";
            this.login_bttn.UseVisualStyleBackColor = false;
            this.login_bttn.Click += new System.EventHandler(this.login_bttn_Click);
            // 
            // cancel_bttn
            // 
            this.cancel_bttn.BackColor = System.Drawing.Color.Red;
            this.cancel_bttn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_bttn.ForeColor = System.Drawing.Color.Yellow;
            this.cancel_bttn.Location = new System.Drawing.Point(386, 114);
            this.cancel_bttn.Name = "cancel_bttn";
            this.cancel_bttn.Size = new System.Drawing.Size(90, 28);
            this.cancel_bttn.TabIndex = 5;
            this.cancel_bttn.Text = "Cancel";
            this.cancel_bttn.UseVisualStyleBackColor = false;
            this.cancel_bttn.Click += new System.EventHandler(this.cancel_bttn_Click);
            // 
            // change_bttn
            // 
            this.change_bttn.BackColor = System.Drawing.Color.Red;
            this.change_bttn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_bttn.ForeColor = System.Drawing.Color.Yellow;
            this.change_bttn.Location = new System.Drawing.Point(307, 148);
            this.change_bttn.Name = "change_bttn";
            this.change_bttn.Size = new System.Drawing.Size(127, 28);
            this.change_bttn.TabIndex = 6;
            this.change_bttn.Text = "Change Password";
            this.change_bttn.UseVisualStyleBackColor = false;
            this.change_bttn.Click += new System.EventHandler(this.changepassword_bttn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Facial_Recognition.Properties.Resources.oglogo1;
            this.pictureBox1.Location = new System.Drawing.Point(29, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(505, 202);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.change_bttn);
            this.Controls.Add(this.cancel_bttn);
            this.Controls.Add(this.login_bttn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_txtBox);
            this.Controls.Add(this.username_txtBox);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_txtBox;
        private System.Windows.Forms.TextBox password_txtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login_bttn;
        private System.Windows.Forms.Button cancel_bttn;
        private System.Windows.Forms.Button change_bttn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

