using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace SotoAyu.controller
{
    internal class KaryawanController
    {
        public static bool Create(string nama, string jabatan)
        {
            using var conn = database.GetConnection();
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
}
