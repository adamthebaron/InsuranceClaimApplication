﻿/* adam 2017-01-30 libsql.cs */
using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Windows.Forms;

namespace InsuranceApplication.Classes {
    class libsql {
        /* properties */
        private readonly SqlConnection _conn = new SqlConnection(
            @"Server=tcp:insuranceclaim.database.windows.net,1433;
            Initial Catalog=InsuranceClaim;
            Persist Security Info=False;
            User ID=charlesroot;
            Password=Ieamainsuranceclaim123;
            MultipleActiveResultSets=False;
            Encrypt=True;
            TrustServerCertificate=False;
            Connection Timeout=30;");

        public SqlConnection conn {
            get {
                return _conn;
            } private set {
                conn = value;
            }
        }

        private bool CheckField(string table, string column, string data) {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select " + column + " from " + table + " where " + column + " = @field";
            cmd.Parameters.AddWithValue("@field", data);
            try {
                conn.Open();
                if (data.Equals((string)cmd.ExecuteScalar()))
                    return false;
            } catch (Exception ex) {
                return false;
            } finally {
                conn.Close();
            }
            return true;
        }

        private bool UserDB(string firstname, string lastname,
                           string username, string password,
                           string birthday, string phonenumber,
                           bool register) {
            string query = string.Empty;
            if (register) {
                query = @"insert into users (firstname, lastname, username, password, birthday, phonenumber)
                        values(@firstname, @lastname, @username, @password, @birthday, @phonenumber);";
                if (!CheckUsername(username))
                    return false;
            } else {
                query = @"update users set firstname = @firstname, lastname = @lastname, 
                          username = @username, password = @password, birthday = @birthday, 
                          phonenumber = @phonenumber Where username = @username;";
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@firstname", firstname);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@birthday", birthday);
            cmd.Parameters.AddWithValue("@phonenumber", phonenumber);
            try {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) {
                return false;
            } finally {
                conn.Close();
            }
            return true;
        }

        private bool CheckUsername(string username) {
            return CheckField("users", "username", username);
        }

        private bool CheckPassword(string password) {
            return CheckField("users", "password", password);
        }

        public bool RegisterUser(string firstname, string lastname,
                                 string username, string password,
                                 string birthday, string phonenumber) {
            return UserDB(firstname, lastname, username, password, birthday, phonenumber, true);
        }

        public bool UpdateUser(string firstname, string lastname, 
                               string username, string password,
                               string birthday, string phonenumber) {
            return UserDB(firstname, lastname, username, password, birthday, phonenumber, false);
        }

        public bool SendClaim(string username, string date, string status, string claim) {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"insert into claims (username, date, status, claim) 
                                values(@username, @date, @status, @claim);";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@claim", claim);
            try {
                conn.Open();
                cmd.ExecuteNonQuery();
            } catch (Exception ex) {
                return false;
            } finally {
                conn.Close();
            }
            return true;
        }

        public bool SendMessage(string to, string from, string date, 
                                string subject, string message) {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"insert into messages ([to], [from], date, subject, message)
                                values(@to, @from, @date, @subject, @message);";
            cmd.Parameters.AddWithValue("@to", to);
            cmd.Parameters.AddWithValue("@from", from);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@subject", subject);
            cmd.Parameters.AddWithValue("@message", message);
            try {
                conn.Open();
                cmd.ExecuteNonQuery();
            } catch (Exception ex) {
                return false;
            } finally {
                conn.Close();
            }
            return true;
        }

        public bool ValidateUser(string username, string password) {
            return (CheckUsername(username) && CheckPassword(password));
        }
    }
}
