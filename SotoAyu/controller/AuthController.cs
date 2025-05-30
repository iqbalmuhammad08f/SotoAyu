using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using SotoAyu.model;

namespace SotoAyu.controller
{
    internal class AuthController
    {
        public static string login(string username, string password)
        {
            using (var conn = database.GetConnection())
            {
                conn.Open();
                string queryAdmin = "SELECT username, nama FROM admin WHERE username = @user AND password = @pass";
                using (var cmd = new NpgsqlCommand(queryAdmin, conn))
                {
                    cmd.Parameters.AddWithValue("user", username);
                    cmd.Parameters.AddWithValue("pass", password);
                    using var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return "admin";
                    }
                }
                string queryKasir = "SELECT username, password FROM kasir WHERE username = @user AND password = @pass";
                using (var cmd = new NpgsqlCommand(queryKasir, conn))
                {
                    cmd.Parameters.AddWithValue("user", username);
                    cmd.Parameters.AddWithValue("pass", password);
                    using var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return "kasir";
                    }
                }
                return null;
            }

        }
    }
}
