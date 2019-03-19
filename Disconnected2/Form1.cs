using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Disconnected2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = WISSEN\MSSQLSRV; Initial Catalog = Northwind; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Products", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        } 
        private void btnIdUrunGetır_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From Products where ProductID=@pid", con);
            cmd.Parameters.AddWithValue("@pid", txtIdUrunGetir.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Products(ProductName,UnitsInStock,UnitPrice) VALUES (@ad,@stok,@fiyat)", con);
            cmd.Parameters.AddWithValue("@ad", txtAd.Text);
            cmd.Parameters.AddWithValue("@stok", txtStok.Text);
            cmd.Parameters.AddWithValue("@fiyat", txtIdUrunGetir.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
