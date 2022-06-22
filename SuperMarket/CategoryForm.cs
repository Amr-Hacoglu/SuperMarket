using System.Windows.Forms;
using System.Data.SqlClient; 
using System.Data; // define
using System;

namespace SuperMarket
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\90538\Desktop\C#\C# SuperMarket\SuperMarket\SuperMarket\Database1.mdf;Integrated Security=True");
        private void button4_Click(object sender, System.EventArgs e)
        {
            // INSERT the data
            try
            {
                con.Open();
                string query = "INSERT INTO CategoryTBL VALUES (" + CatIDTbl.Text + ",'" + CatNameTbl.Text + "','" + CatDescTbl.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Succesfully");
                con.Close();
                populate(); // to show the data after we insert it withot exit from the window
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void populate()
        {

            con.Open();
            string query = "SELECT * FROM CategoryTBL";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            CatDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            populate();
            // SHOW the data on the form 
        }

        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // to show the data on the left site when you click over it like (to change it)
            CatIDTbl.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            CatNameTbl.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            CatDescTbl.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // DELETE the data
            try
            {
                if(CatIDTbl.Text == "")
                {
                    MessageBox.Show("Select The Category To Delete");
                }
                else
                {
                    con.Open();
                    string query = "DELETE FROM CategoryTBL WHERE CatID = " + CatIDTbl.Text + "";
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    con.Close();
                    populate();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // UPDATE the data
            try
            {
                if (CatIDTbl.Text == "" || CatNameTbl.Text == "" || CatDescTbl.Text == "")
                {
                    MessageBox.Show("Missing Infromation");
                }
                else
                {
                    con.Open();
                    string query = "UPDATE CategoryTBL SET CatName = '" + CatNameTbl.Text + "',CatDesc='" + CatDescTbl.Text + "'WHERE CatID=" + CatIDTbl.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Successfully Updated");
                    con.Close();
                    populate();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
            prod.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SellerForm sell = new SellerForm();
            sell.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new Form1();
            login.Show();
        }
    }
}
