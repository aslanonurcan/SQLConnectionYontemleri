﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_Connected
{
    class Tools
    {
        public static string ConnectionString
        {
            get
            {
                return "Data Source = WISSEN\\MSSQLSRV; Initial Catalog = Northwind; Integrated Security = True";
            }
        }
    }
}