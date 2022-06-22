using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\90538\Desktop\C#\C# SuperMarket\SuperMarket\SuperMarket\Database1.mdf;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        public static String SellerName = "";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PassTb.Text = "";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(UnameTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Enter The UserName And Password");
            }
            else
            {
                if(RoleCb.SelectedIndex > -1) {
                    if (RoleCb.SelectedItem.ToString() == "Admin")
                    {
                        if (UnameTb.Text == "Admin" && PassTb.Text == "Admin")
                        {
                            ProductForm prod = new ProductForm();
                            prod.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If You are the Admin, Enter the correct Id and Password");
                        }
                    }
                    else
                    {
                        //MessageBox.Show("You Are In The Seller Section");
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("SELECT count(8) FROM SellerTBL WHERE SellerName = '"+UnameTb.Text+"' and SellerPass ='"+PassTb.Text+"'",con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            SellerName = UnameTb.Text;
                            SellingForm sell = new SellingForm();
                            sell.Show();
                            this.Hide();
                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wrong UserName or Password");
                        }
                        con.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Select A Role");
                }
            }
        }
    }
}
