using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Disconnected1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
        SqlCommand cmd;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrunDoldur();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select CategoryID,CategoryName from Categories", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";
            comboBox1.DataSource = dt;
        }
        private void UrunDoldur()
        {
            listView1.Items.Clear();
          //string selectStr = "Select ProductName, UnitPrice, UnitsInStock, UnitPrice*UnitsInStock TotalValue from Products where CategoryID =" + comboBox1.SelectedValue;
            SqlDataAdapter da = new SqlDataAdapter("Select ProductName,UnitPrice,UnitsInStock,UnitPrice*UnitsInStock TotalValue from Products where CategoryID=@catid", con);
            da.SelectCommand.Parameters.AddWithValue("@catid", comboBox1.SelectedValue);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem kayit = new ListViewItem();
                kayit.Text = dt.Rows[i]["ProductName"].ToString();
                kayit.SubItems.Add(dt.Rows[i][1].ToString());
                kayit.SubItems.Add(dt.Rows[i][2].ToString());
                kayit.SubItems.Add(dt.Rows[i][3].ToString());
                listView1.Items.Add(kayit);
            }
            dataGridView1.DataSource = dt;
            //dataGridView1.Columns["CategoryID"].Visible = false;
        }
    }
}
