using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using SotoAyu.model;

namespace SotoAyu.controller
{
    internal class KaryawanController
    {
        public static bool Create(string nama, string jabatan)
        {
            using (var conn = database.GetConnection())
            {

                conn.Open();
                string query = "INSERT INTO karyawan(nama,jabatan,status) VALUES (@nama,@jabatan,true)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("nama", nama);
                    cmd.Parameters.AddWithValue("jabatan", jabatan);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public static List<Karyawan> GetKaryawans()
        {
            var list_karyawan = new List<Karyawan>();
            using (var conn = database.GetConnection())
            {

                conn.Open();
                string query = "SELECT * FROM karyawan";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Karyawan karyawan = new Karyawan
                        {
                            id_karywan = reader.GetInt32(0),
                            nama = reader.GetString(1),
                            role = reader.GetString(2),
                            status = reader.GetBoolean(3)
                        };
                        list_karyawan.Add(karyawan);
                    }
                }
                return list_karyawan;
            }
        }
        public static void DelKaryawan(int id)
        {
            using (var conn = database.GetConnection())
            {

                conn.Open();
                string query = "UPDATE karyawan SET status = false WHERE id_karyawan = @id";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
