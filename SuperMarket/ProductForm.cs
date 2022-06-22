using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace SuperMarket
{
    public partial class ProductForm : Form
    {
        private void populate()
        {

            con.Open();
            string query = "SELECT * FROM ProductTBL";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        public ProductForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\90538\Desktop\C#\C# SuperMarket\SuperMarket\SuperMarket\Database1.mdf;Integrated Security=True");
        private void FillCombo()
        {
            // this method will bind the Combobox with the Database
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT CatName FROM CategoryTBL", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName",typeof(string));
            dt.Load(rdr);
            CatCbTbl.ValueMember = "CatName";
            CatCbTbl.DataSource = dt;
            con.Close();
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            FillCombo();
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // INSERT
            try
            {
                con.Open();
                string query = "INSERT INTO ProductTBL VALUES (" + ProdIDTbl.Text + ",'" + ProdNameTbl.Text + "'," + ProdQtyTbl.Text + "," + ProdPriceTbl.Text + ",'" + CatCbTbl.SelectedValue.ToString()+ "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Succesfully");
                con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdIDTbl.Text = ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProdNameTbl.Text = ProdDGV.SelectedRows[0].Cells[1].Value.ToString();
            ProdQtyTbl.Text = ProdDGV.SelectedRows[0].Cells[2].Value.ToString();
            ProdPriceTbl.Text = ProdDGV.SelectedRows[0].Cells[3].Value.ToString();
            CatCbTbl.SelectedValue = ProdDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdIDTbl.Text == "" || ProdNameTbl.Text == "" || ProdQtyTbl.Text == "" || ProdPriceTbl.Text == "")
                {
                    MessageBox.Show("Missing Infromation");
                }
                else
                {
                    con.Open();
                    string query = "UPDATE ProductTBL SET ProdName = '" + ProdNameTbl.Text + "',ProdQty='" + ProdQtyTbl.Text +"',ProdPrice='" + ProdPriceTbl.Text + "'WHERE ProdID=" + ProdIDTbl.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Successfully Updated");
                    con.Close();
                    populate();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // DELETE the data
            try
            {
                if (ProdIDTbl.Text == "")
                {
                    MessageBox.Show("Select The Category To Delete");
                }
                else
                {
                    con.Open();
                    string query = "DELETE FROM ProductTBL WHERE ProdID = " + ProdIDTbl.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
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
            SellerForm sell = new SellerForm();
            sell.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SellerForm sell = new SellerForm();
            sell.Show();
            this.Hide();
        }
    }
}
