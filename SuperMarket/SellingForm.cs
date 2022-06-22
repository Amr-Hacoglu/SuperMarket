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


namespace SuperMarket
{
    public partial class SellingForm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\90538\Desktop\C#\C# SuperMarket\SuperMarket\SuperMarket\Database1.mdf;Integrated Security=True");
        private void populate()
        {

            con.Open();
            string query = "SELECT ProdName,ProdPrice FROM ProductTBL";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            SellProdDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void populateBills()
        {
            con.Open();
            string query = "SELECT * FROM BillTBL";
            //string query = "SELECT ProdName,ProdPrice FROM ProductTBL";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            BillsDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        public SellingForm()
        {
            InitializeComponent();
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
            populateBills();
        }

        int flag = 0;

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SellProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // To fill the data on up
            SellProdNameTbl.Text = SellProdDGV.SelectedRows[0].Cells[0].Value.ToString();
            SellProdPriceTbl.Text = SellProdDGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SellDateTbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        //double GrdTotal = 0 , n = 0;
        int GrdTotal = 0 , n = 0;
        private void button11_Click(object sender, EventArgs e)
        {
            
            if(SellProdNameTbl.Text=="" || SellProdQtyTbl.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else {
                //double total = Convert.ToDouble(SellProdPriceTbl.Text) * Convert.ToDouble(SellProdQtyTbl.Text);
                int total = Convert.ToInt32(SellProdPriceTbl.Text) * Convert.ToInt32(SellProdQtyTbl.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(OrderDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = SellProdNameTbl.Text;
                newRow.Cells[2].Value = SellProdPriceTbl.Text;
                newRow.Cells[3].Value = SellProdQtyTbl.Text;
                newRow.Cells[4].Value = Convert.ToDouble(SellProdPriceTbl.Text) * Convert.ToDouble(SellProdQtyTbl.Text);
                OrderDGV.Rows.Add(newRow);
                n++;
                GrdTotal = GrdTotal + total;
                AmtPriceTbl.Text = ""+GrdTotal;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // INSERT
            if(BillIdTbl.Text == "") 
            {
                MessageBox.Show("Missing Bill Id");
            }
            else { 
                try
                {
                    con.Open();
                    string query = "INSERT INTO BillTBL VALUES (" + BillIdTbl.Text + ",'" + SellerNameTbl.Text + "','" + SellDateTbl.Text + "'," + AmtPriceTbl.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added Succesfully");
                    con.Close();
                    populateBills();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void BillsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("AMRSUPERMARKET" , new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Bill ID : " + BillsDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100,70));
            e.Graphics.DrawString("Seller Name : " + BillsDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 100));
            e.Graphics.DrawString("Date : " + BillsDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 130));
            e.Graphics.DrawString("Total Amount  : " + BillsDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 160));
            e.Graphics.DrawString("CodeSpace", new Font("Century Gothic", 20, FontStyle.Italic), Brushes.Red, new Point(270,230));
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
