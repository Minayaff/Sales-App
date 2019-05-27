using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromAe
{
    public partial class AdminForm : Form
    {

        public AdminForm()
        {
            InitializeComponent();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            int affectedRows = 0;

            FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);
            string Path = Environment.CurrentDirectory + "/photo/" + fileInfo.Name;
            File.Copy(openFileDialog1.FileName, Path);

            string connectString = "Data Source=.;  Initial Catalog=FromAE; Integrated Security=SSPI";
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();


                string query = "INSERT INTO Product.Product(Name,Price,Path,CategoryId) VALUES(@p1,@p2,@p3,@p4)";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@p1", txtName.Text);
                    command.Parameters.AddWithValue("@p2", txtPrice.Text);
                    command.Parameters.AddWithValue("@p3", fileInfo.Name);
                    command.Parameters.AddWithValue("@p4",comboBox1.SelectedValue);

                    affectedRows = command.ExecuteNonQuery();
                }

            }

            if (affectedRows == 0)
            {
                MessageBox.Show("Query Failed");
            }
            else
            {
                MessageBox.Show("You create Advertisement");
            }

        }



        private void AdminForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.;  Initial Catalog=FromAE; Integrated Security=SSPI"))
            {
                try
                {
                    string query = "select * from Product.Categories";
                    SqlDataAdapter data = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    data.Fill(ds, "Product.Categories");
                    comboBox1.DisplayMember = "Name";
                    comboBox1.ValueMember = "Id";
                    comboBox1.DataSource = ds.Tables["Product.Categories"];
                }

                catch (Exception)
                {
                    MessageBox.Show("Error occured!");
                }
            }
        }
    }
}
