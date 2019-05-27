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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection("Data Source=.;  Initial Catalog=FromAE; Integrated Security=SSPI"))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select Name, Price, Path from Product.Product", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    
                    conn.Close();

                    string query = "select Name, Price, Path from Product.Product";
                    SqlDataAdapter data = new SqlDataAdapter(query, conn);
                    conn.Open();

                    DataGridViewImageColumn dgvImageColumn = new DataGridViewImageColumn();
                    // set header text to the column
                    dgvImageColumn.HeaderText = "Image";
                    // display the entire image
                    dgvImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

                    // create Datagridview text column
                    DataGridViewTextBoxColumn dgvNameColumn = new DataGridViewTextBoxColumn();
                    dgvNameColumn.HeaderText = "Name";

                    DataGridViewTextBoxColumn dgvPriceColumn = new DataGridViewTextBoxColumn();
                    dgvPriceColumn.HeaderText = "Price";
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dataGridView1.RowTemplate.Height = 130;

                    dataGridView1.AllowUserToAddRows = false;

                    dataGridView1.Columns.Add(dgvNameColumn);
                    dataGridView1.Columns.Add(dgvPriceColumn);
                    dataGridView1.Columns.Add(dgvImageColumn);

                    // create and add images to the dataGridView

                    foreach (DataRow dr in dt.Rows)
                    {
                        Image img1;
                        img1 = Image.FromFile(@"C:\Users\Mina Farzali\Desktop\FromAe\FromAe\FromAe\bin\Debug\photo\"+dr[2]+"");
                        dataGridView1.Rows.Add(dr[0],dr[1],img1);
                    }

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dataGridView1.RowTemplate.Height = 130;

                    dataGridView1.AllowUserToAddRows = false;

                }

                catch (Exception)
                {
                    MessageBox.Show("Error occured!");
                }
            }

        }
    }
}
