﻿/* adam 2017-01-30 SQLDriver.cs */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InsuranceApplication.Classes {
    class SQLDriver {
        /* auto property */
        private SqlConnection _conn;
        public SqlConnection conn {
            get {
                return new SqlConnection(
                    @"Server=tcp:insuranceclaim.database.windows.net,1433;
                    Initial Catalog=InsuranceClaim; 
                    Persist Security Info=False;
                    User ID=charlesroot;
                    Password=Ieamainsuranceclaim123;
                    MultipleActiveResultSets=False;
                    Encrypt=True;
                    TrustServerCertificate=False;
                    Connection Timeout=30;");
            }
            set {
                _conn = value;
            }
        }

        /* methods */
        //<summary>
        //update information in database
        //</summary>
        private object UpdateDB(string statement) {
            var resp;
            try {
                SqlCommand cmd = new SqlCommand(statement, conn);
                return resp;
            } catch (SqlException ex) {

            }
        }

        //<summary>
        //insert information in database
        //</summary>
        private object InsertDB(string statement) {
            var resp;
            try {
                SqlCommand cmd = new SqlCommand(statement, conn);
            }
        }
    }
}
