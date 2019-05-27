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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Validator
            if (!(txtRegPass.Text == txtRegConPass.Text))
            {
                MessageBox.Show("Please check Password");
                return;
            }
            if (!(txtRegEmail.Text.Contains("@")))
            {
                MessageBox.Show("Email is not Valid");
                return;
            }
            //Connection to DataBase
            int affectedRows = 0;
            string connectString = "Data Source=.;  Initial Catalog=FromAE; Integrated Security=SSPI";
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();

             
                    string query = "INSERT INTO Users(Name,Surname,Email,Password) VALUES(@p1,@p2,@p3,@p4)";
               

                    using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@p2", txtRegLName.Text);
                    command.Parameters.AddWithValue("@p1", txtName.Text);
                    command.Parameters.AddWithValue("@p3", txtRegEmail.Text);
                    command.Parameters.AddWithValue("@p4", txtRegPass.Text);

                    affectedRows = command.ExecuteNonQuery();
                }

            }

            if (affectedRows == 0)
            {
                MessageBox.Show("Query Failed");
            }
            else
            {
                MessageBox.Show("Register successful");
            }
        
        }

        private void Loginlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();

        }
    }
}

