using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using SotoAyu.model;

namespace SotoAyu.controller
{
    internal class TransaksiController
    {
        public static int InsertTransaksi(int idKaryawan, int total, string metode)
        {
            int idTransaksi = 0;
            using (var conn = database.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO transaksi (nama_operator, total, metode_pembayaran) VALUES (@idKaryawan, @total, @metode) RETURNING id_transaksi", conn))
                {
                    cmd.Parameters.AddWithValue("@idKaryawan", idKaryawan);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@metode", metode);
                    idTransaksi = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return idTransaksi;
        }
        public static void InsertTransaksiDetail(int idTransaksi, int idMenu, int jumlah, int subtotal)
        {
            using (var conn = database.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO transaksi_detail (id_transaksi, id_menu, jumlah, subtotal) VALUES (@idTransaksi, @idMenu, @jumlah, @subtotal)", conn))
                {
                    cmd.Parameters.AddWithValue("@idTransaksi", idTransaksi);
                    cmd.Parameters.AddWithValue("@idMenu", idMenu);
                    cmd.Parameters.AddWithValue("@jumlah", jumlah);
                    cmd.Parameters.AddWithValue("@subtotal", subtotal);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static Transaksi GetTransaksis(int id)
        {
            using (var conn = database.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM transaksi WHERE id_transaksi = @id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new Transaksi
                        {
                            id_transaksi = reader.GetInt32(0),
                            Tanggal = reader.GetDateTime(1),
                            Nama_operator = reader.GetInt32(2),
                            Total_transaksi = reader.GetInt32(3),
                            Metode_pembayaran = reader.GetString(4)
                        };

                    }
                    return null;
                }
            }
        }
    }
}
