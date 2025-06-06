using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using SotoAyu.model;

namespace SotoAyu.controller
{
    internal class LaporanController
    {
        public static List<Laporan> GetFromToLaporan(DateTime from, DateTime to)
        {
            List<Laporan> List_Laporan = new List<Laporan>();
            using (var conn = database.GetConnection())
            {
                conn.Open();
                string query = "SELECT DATE(tanggal), sum(total) FROM transaksi WHERE tanggal BETWEEN @from AND @to GROUP BY DATE(tanggal) ORDER BY DATE(tanggal) ASC";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@from", from);
                    cmd.Parameters.AddWithValue("@to", to.AddDays(1));
                    using var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Laporan laporan = new Laporan
                        {
                            Tanggal = reader.GetDateTime(0),
                            Total = reader.GetInt32(1)
                        };
                        List_Laporan.Add(laporan);
                    }
                }
            }
            return List_Laporan;
        }
        public static List<Laporan> GetOverallLaporan()
        {
            List<Laporan> List_Laporan = new List<Laporan>();
            using (var conn = database.GetConnection())
            {
                conn.Open();
                string query = "SELECT DATE(tanggal), sum(total) FROM transaksi GROUP BY DATE(tanggal) ORDER BY DATE(tanggal) DESC";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Laporan laporan = new Laporan
                        {
                            Tanggal = reader.GetDateTime(0),
                            Total = reader.GetInt32(1)
                        };
                        List_Laporan.Add(laporan);
                    }
                }
            }
            return List_Laporan;
        }
    }
}
