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

namespace ConnecttedYontemleri
{
    public partial class Form1 : Form
    {
        private SqlConnection conn = new SqlConnection();
        int a = 1;

        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnApp_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
                 conn.ConnectionString=ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                MessageBox.Show("Bağlantı sonlandırıldı.");
            }
            else
            {
                conn.Open();
                MessageBox.Show("App.config ile bağlanıldı.");
            }
        }
        private void btnLocal_Click(object sender, EventArgs e)
        {
            SqlConnection conn1 = new SqlConnection("Data Source = WISSEN\\MSSQLSRV; Initial Catalog = Northwind; Integrated Security = True");
            if (a % 2 == 0 || conn.State == ConnectionState.Open)
            {
                conn1.Close();
                conn.Close();
                MessageBox.Show("Bağlantı sonlandırıldı.");
                a = 1;
            }
            else
            {
                conn1.Open();
                MessageBox.Show("Local ile bağlanıldı.");
                a++;
            }
        }

        private void btnGlobal_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
                conn.ConnectionString = ("Data Source = WISSEN\\MSSQLSRV; Initial Catalog = Northwind; Integrated Security = True");
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                MessageBox.Show("Bağlantı sonlandırıldı.");
            }
            else
            {
                conn.Open();
                MessageBox.Show("Global ile bağlanıldı.");
            }
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
                conn.ConnectionString = ConnectionString;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                MessageBox.Show("Bağlantı sonlandırıldı.");
            }
            else 
            {
                conn.Open();
                MessageBox.Show("Class ile bağlanıldı.");
            }
        }
        public static string ConnectionString
        {
            get
            {
                return "Data Source = WISSEN\\MSSQLSRV; Initial Catalog = Northwind; Integrated Security = True";
            }
        }
    }
}
