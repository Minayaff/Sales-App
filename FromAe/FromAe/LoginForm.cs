using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromAe
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            RadioButton rb = null;
            if (rdrAdmin.Checked == true)
            {
                rb = rdrAdmin;
                string Password = txtLogPass.Text.Trim();
                string Email = txtLogEmail.Text.Trim();
                string DefaultEmail = "admin@code.edu.az";
                string DefaultPass = "admin123";

                if (string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Email) || Password != DefaultPass ||
                    Email != DefaultEmail)
                {
                    MessageBox.Show("Password is wrong.");
                    return;
                }
                else
                {
                    MessageBox.Show("Admin Login successful");
                    AdminForm adminForm = new AdminForm();
                    this.Hide();
                    adminForm.ShowDialog();
                }

            }


            if (rdrUser.Checked == true)
            {
                rb = rdrUser;
                string connectString = "Data Source=.;  Initial Catalog=FromAE; Integrated Security=SSPI";
                using (SqlConnection connection = new SqlConnection(connectString))
                {
                    connection.Open();


                    string query = "select * from Users where Email = @email and Password = @password";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@email", txtLogEmail.Text);
                        command.Parameters.AddWithValue("@password", txtLogPass.Text);
                        
                        object user = command.ExecuteScalar();
                        if (user == null)
                        {
                            MessageBox.Show("Failed");
                        }
                        else
                        {
                            MessageBox.Show("Login successful");
                            UserForm userForm = new UserForm();
                            this.Hide();
                            userForm.ShowDialog();

                        }

                    }

                }
            }
        }
    }
}
