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

namespace Select
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
        SqlConnection conn = new SqlConnection(Tools.ConnectionString);
        private void btnGetir_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select FirstName,LastName,BirthDate From EMPLOYEES", conn);
            if (conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            #region Execute Seçenekleri
            /*
             * EXECUTE TÜRLERİ
             * 1- ExecuteNonQuery --> Etkilenen satır sayınısını döndürür
             * 2- ExecuteScalar   --> ResultSet'in 1.Sutunun 1.Satırını geriye döndürür.(Tek değer döndürür)
             * 3- ExecuteReader   --> Resultsetin tamamını geriye döndürür.
             */
            #endregion
            while (dr.Read())//Connection açık olması lazım
            {
                listBox1.Items.Add(dr["FirstName"].ToString() + "--" + dr["LastName"].ToString() + "--" + dr["BirthDate"].ToString());
            }
            conn.Close();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
