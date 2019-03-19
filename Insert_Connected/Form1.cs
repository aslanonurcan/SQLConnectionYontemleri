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

namespace Insert_Connected
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection(Tools.ConnectionString);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            //' or 'a'='a sorgu bu şekilde sql injection'a açıktır. Bu aşamadabu vurgulanmalıdır.
            //SQL INJECTION MANTIĞI BURADA ANLATILACAK
            // SqlCommand cmd = new SqlCommand("INSERT INTO Categories (CategoryName,Description) values ('" + txtKategoriAdi.Text + "' , '" + txtAciklama.Text+"'),cn);
            //BURADA Drop DataBase , Drop Table gibi komutlar gösterilebilir.
            try
            {
                if (txtKategoriAdi.Text != " ")
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Categories(CategoryName, Description) values (@catName,@catDesc) SELECT CAST (scope_identity() AS int )", cn);

                    cmd.Parameters.AddWithValue("@catName", txtKategoriAdi.Text);
                    cmd.Parameters.AddWithValue("@catDesc", txtAciklama.Text);
                    int categoryID = (int)cmd.ExecuteScalar();
                    label4.Text = categoryID.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            //if (cn.State == ConnectionState.Closed)
            //    cn.Open();
            //cn.Close();
            //if (etkilenenSatirSayisi>0)
            //{
            //    MessageBox.Show("Kayıt başarı ile eklenmiştir.");
            //}
            //else
            //{
            //    MessageBox.Show("Kayıt eklenirken bir hata oluştu.");
            //}
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void btnInsertSp_Click(object sender, EventArgs e)
        {
            int donenDeger = 0;
            try
            {
                if (txtKategoriAdi.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("INSERTCAT", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@catName", txtKategoriAdi.Text);
                    cmd.Parameters.AddWithValue("@catDesc", txtAciklama.Text);
                    cn.Open();
                    donenDeger = cmd.ExecuteNonQuery();

                    MessageBox.Show(donenDeger != 0 ? "İŞLEM BAŞARILI" : "İŞLEM BAŞARISIZ");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("bir hata oluştu"+ ex.Message);
            }
                cn.Close();
        }
    }
}
