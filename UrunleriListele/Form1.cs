﻿using System;
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
    public partial class Form1 : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
            cmd= new SqlCommand("SELECT ProductName,UnitPrice,UnitsInStock FROM Products",conn);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                listBox1.Items.Add(rdr["ProductName"]+"--"+ rdr["UnitPrice"]+"--"+ rdr["UnitsInStock"]);
            }
            conn.Close();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            Kategori ktg = new Kategori();
            ktg.Show();
        }
    }
}
