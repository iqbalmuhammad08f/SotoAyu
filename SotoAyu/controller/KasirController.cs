using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using SotoAyu.model;

namespace SotoAyu.controller
{
    internal class KasirController
    {
        public static bool Create(string username, string password)
        {
            using (var conn = database.GetConnection())
            {

                conn.Open();
                string query = "INSERT INTO kasir(username,password) VALUES (@username,@password)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public static Kasir Read()
        {
            using (var conn = database.GetConnection())
            {

                conn.Open();
                string query = "SELECT * FROM kasir LIMIT 1";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using var reader = cmd.ExecuteReader();
                    if (reader.Read()) 
                    {
                        return new Kasir
                        {
                            id = reader.GetInt32(0),
                            username = reader.GetString(1),
                            password = reader.GetString(2),
                            role = reader.GetString(3),
                            status = reader.GetBoolean(4)
                        };
                    }
                    return null;
                }
            }
        }
        public static bool Update(string username, string password)
        {
            using (var conn = database.GetConnection())
            {

                conn.Open();
                string query = "UPDATE kasir SET username = @username, password = @password WHERE id_kasir = 1";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
