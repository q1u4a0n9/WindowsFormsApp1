namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(140, 71);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(261, 22);
            this.txt_username.TabIndex = 2;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(140, 113);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(261, 22);
            this.txt_password.TabIndex = 3;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Login.Location = new System.Drawing.Point(186, 156);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(108, 35);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Student Management";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 230);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

