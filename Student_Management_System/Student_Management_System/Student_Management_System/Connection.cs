﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    public class Connection
    {
        public static SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Downloads\6th\Student_Management_System\Student_Management_System\Student_Management_System\Database\ManagementData.mdf;Integrated Security=True;Connect Timeout=30");

        public static void OpenConection()
        {
            if (Connection.sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

        }

        public static void CloseConnection()
        {
            sqlCon.Close();
        }
    }
}
