using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Update_Delete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(Tools.ConnectionString);
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Categories SET CategoryName=@catName WHERE CategoryName=@name", cn);
                cmd.Parameters.AddWithValue("@catName", txtb1.Text);
                cmd.Parameters.AddWithValue("@name", cmb1.SelectedItem.ToString());

                int donenDeger = cmd.ExecuteNonQuery();
                KategoriDoldur();
                MessageBox.Show(donenDeger != 0 ? "İŞLEM BAŞARILI" : "İŞLEM BAŞARISIZ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Categories  WHERE CategoryName=@name", cn);
                cmd.Parameters.AddWithValue("@name", cmb1.SelectedItem.ToString());

                int donenDeger = cmd.ExecuteNonQuery();
                KategoriDoldur();
                MessageBox.Show(donenDeger != 0 ? "İŞLEM BAŞARILI" : "İŞLEM BAŞARISIZ");
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            if (cn.State==ConnectionState.Open)
            {
                cn.Close();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtb1.Text = cmb1.Text;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            KategoriDoldur();
        }
        private void KategoriDoldur()
        {
            SqlCommand cmd = new SqlCommand("Select CategoryName From Categories", cn);
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                cmb1.Items.Clear();
            }
            while (dr.Read())
            {
                cmb1.Items.Add(dr["CategoryName"].ToString());
            }
            cn.Close();
        }
        private void txtb1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
