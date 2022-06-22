using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class SellerForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\90538\Desktop\C#\C# SuperMarket\SuperMarket\SuperMarket\Database1.mdf;Integrated Security=True");

        public SellerForm()
        {
            InitializeComponent();
        }

        private void populate()
        {

            con.Open();
            string query = "SELECT * FROM SellerTBL";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            SellDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            // INSERT
            try
            {
                con.Open();
                string query = "INSERT INTO SellerTBL VALUES (" + SellIDTbl.Text + ",'" + SellNameTbl.Text + "'," + SellAgeTbl.Text + "," + SellPhoneTbl.Text + ",'" + SellPassTbl + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Added Succesfully");
                con.Close();
                populate();
                SellIDTbl.Text = "";
                SellNameTbl.Text = "";
                SellAgeTbl.Text = "";
                SellPhoneTbl.Text = "";
                SellPassTbl.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // UPDATE
            try
            {
                if (/*SellIDTbl.Text == "" || */SellNameTbl.Text == "" || SellAgeTbl.Text == "" || SellPhoneTbl.Text == "" || SellPassTbl.Text == "")
                {
                    MessageBox.Show("Missing Infromation");
                }
                else
                {
                    con.Open();
                    string query = "UPDATE SellerTBL SET SellerName = '" + SellNameTbl.Text + "',SellerAge='" + SellAgeTbl.Text + "',SellerPhone='" + SellPhoneTbl.Text + "',SellerPass='" + SellPassTbl.Text + "'WHERE SellerID=" + SellIDTbl.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Successfully Updated");
                    con.Close();
                    populate();
                    SellIDTbl.Text = "";
                    SellNameTbl.Text = "";
                    SellAgeTbl.Text = "";
                    SellPhoneTbl.Text = "";
                    SellPassTbl.Text = "";

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
                if (SellIDTbl.Text == "")
                {
                    MessageBox.Show("Select The Seller To Delete");
                }
                else
                {
                    con.Open();
                    string query = "DELETE FROM SellerTBL WHERE SellerID = " + SellIDTbl.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully");
                    con.Close();
                    populate();
                    SellIDTbl.Text = "";
                    SellNameTbl.Text = "";
                    SellAgeTbl.Text = "";
                    SellPhoneTbl.Text = "";
                    SellPassTbl.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SellDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SellIDTbl.Text = SellDGV.SelectedRows[0].Cells[0].Value.ToString();
            SellNameTbl.Text = SellDGV.SelectedRows[0].Cells[1].Value.ToString();
            SellAgeTbl.Text = SellDGV.SelectedRows[0].Cells[2].Value.ToString();
            SellPhoneTbl.Text = SellDGV.SelectedRows[0].Cells[3].Value.ToString();
            SellPassTbl.Text = SellDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
            prod.Show();
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
