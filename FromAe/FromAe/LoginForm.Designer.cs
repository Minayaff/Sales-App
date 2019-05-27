namespace FromAe
{
    partial class LoginForm
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
            this.pnlAddStudent = new System.Windows.Forms.Panel();
            this.rdrUser = new System.Windows.Forms.RadioButton();
            this.rdrAdmin = new System.Windows.Forms.RadioButton();
            this.txtLogPass = new System.Windows.Forms.TextBox();
            this.lblGroupID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLogEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAddStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddStudent
            // 
            this.pnlAddStudent.Controls.Add(this.rdrUser);
            this.pnlAddStudent.Controls.Add(this.rdrAdmin);
            this.pnlAddStudent.Controls.Add(this.txtLogPass);
            this.pnlAddStudent.Controls.Add(this.lblGroupID);
            this.pnlAddStudent.Controls.Add(this.label5);
            this.pnlAddStudent.Controls.Add(this.btnLogin);
            this.pnlAddStudent.Controls.Add(this.txtLogEmail);
            this.pnlAddStudent.Controls.Add(this.label4);
            this.pnlAddStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddStudent.Location = new System.Drawing.Point(0, 60);
            this.pnlAddStudent.Name = "pnlAddStudent";
            this.pnlAddStudent.Size = new System.Drawing.Size(391, 615);
            this.pnlAddStudent.TabIndex = 9;
            // 
            // rdrUser
            // 
            this.rdrUser.AutoSize = true;
            this.rdrUser.Location = new System.Drawing.Point(170, 177);
            this.rdrUser.Name = "rdrUser";
            this.rdrUser.Size = new System.Drawing.Size(47, 17);
            this.rdrUser.TabIndex = 19;
            this.rdrUser.TabStop = true;
            this.rdrUser.Text = "User";
            this.rdrUser.UseVisualStyleBackColor = true;
            // 
            // rdrAdmin
            // 
            this.rdrAdmin.AutoSize = true;
            this.rdrAdmin.Location = new System.Drawing.Point(97, 177);
            this.rdrAdmin.Name = "rdrAdmin";
            this.rdrAdmin.Size = new System.Drawing.Size(54, 17);
            this.rdrAdmin.TabIndex = 18;
            this.rdrAdmin.TabStop = true;
            this.rdrAdmin.Text = "Admin";
            this.rdrAdmin.UseVisualStyleBackColor = true;
            // 
            // txtLogPass
            // 
            this.txtLogPass.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogPass.Location = new System.Drawing.Point(34, 129);
            this.txtLogPass.Name = "txtLogPass";
            this.txtLogPass.Size = new System.Drawing.Size(331, 33);
            this.txtLogPass.TabIndex = 10;
            // 
            // lblGroupID
            // 
            this.lblGroupID.AutoSize = true;
            this.lblGroupID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupID.Location = new System.Drawing.Point(42, 554);
            this.lblGroupID.Name = "lblGroupID";
            this.lblGroupID.Size = new System.Drawing.Size(0, 22);
            this.lblGroupID.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Maroon;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(45, 222);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 44);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLogEmail
            // 
            this.txtLogEmail.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogEmail.Location = new System.Drawing.Point(34, 51);
            this.txtLogEmail.Name = "txtLogEmail";
            this.txtLogEmail.Size = new System.Drawing.Size(331, 33);
            this.txtLogEmail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 60);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 390);
            this.Controls.Add(this.pnlAddStudent);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.pnlAddStudent.ResumeLayout(false);
            this.pnlAddStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddStudent;
        private System.Windows.Forms.RadioButton rdrUser;
        private System.Windows.Forms.RadioButton rdrAdmin;
        private System.Windows.Forms.TextBox txtLogPass;
        private System.Windows.Forms.Label lblGroupID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLogEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}