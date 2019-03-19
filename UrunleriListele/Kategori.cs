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

namespace UrunleriListele
{
    public partial class Kategori : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        public Kategori()
        {
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
            cmd = new SqlCommand("SELECT CategoryName,Description FROM Categories", conn);
        }

        private void Kategori_Load(object sender, EventArgs e)
        {
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                listBox1.Items.Add(rdr["CategoryName"] + "--" + rdr["Description"]);
            }
            conn.Close();
        }
    }
}
