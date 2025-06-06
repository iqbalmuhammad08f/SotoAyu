using System;
using System.Collections.Generic;
using System.Drawing.Imaging.Effects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using SotoAyu.model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                string query = "SELECT t.id_transaksi,t.tanggal,k.nama,t.total,t.metode_pembayaran FROM transaksi t JOIN karyawan k ON t.nama_operator = k.id_karyawan  WHERE id_transaksi = @id";
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
                            Nama_operator = reader.GetString(2),
                            Total_transaksi = reader.GetInt32(3),
                            Metode_pembayaran = reader.GetString(4)
                        };

                    }
                    return null;
                }
            }
        }
        public static List<Transaksi> GetAllTransaksis()
        {
            List<Transaksi> List_transaksis = new List<Transaksi>();
            using (var conn = database.GetConnection())
            {
                conn.Open();
                string query = "SELECT t.id_transaksi,t.tanggal,k.nama,t.total,t.metode_pembayaran FROM transaksi t JOIN karyawan k ON t.nama_operator = k.id_karyawan ORDER BY t.tanggal DESC";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Transaksi transaksi = new Transaksi
                        {
                            id_transaksi = reader.GetInt32(0),
                            Tanggal = reader.GetDateTime(1),
                            Nama_operator = reader.GetString(2),
                            Total_transaksi = reader.GetInt32(3),
                            Metode_pembayaran = reader.GetString(4)
                        };
                        List_transaksis.Add(transaksi);
                    }
                }
            }
            return List_transaksis;
        }
        public static List<Transaksi> GetFromToTransaksi(DateTime from, DateTime to)
        {
            List<Transaksi> List_transaksis = new List<Transaksi>();
            using (var conn = database.GetConnection())
            {
                conn.Open();
                string query = "SELECT t.id_transaksi,t.tanggal,k.nama,t.total,t.metode_pembayaran FROM transaksi t JOIN karyawan k ON t.nama_operator = k.id_karyawan WHERE t.tanggal BETWEEN @from AND @to ORDER BY t.tanggal ASC";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@from", from);
                    cmd.Parameters.AddWithValue("@to", to.Date.AddDays(1));
                    using var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Transaksi transaksi = new Transaksi
                        {
                            id_transaksi = reader.GetInt32(0),
                            Tanggal = reader.GetDateTime(1),
                            Nama_operator = reader.GetString(2),
                            Total_transaksi = reader.GetInt32(3),
                            Metode_pembayaran = reader.GetString(4)
                        };
                        List_transaksis.Add(transaksi);
                    }
                }
            }
            return List_transaksis;
        }
        public static List<Transaksi> GetNowTransaksi()
        {
            List<Transaksi> List_transaksis = new List<Transaksi>();
            using (var conn = database.GetConnection())
            {
                conn.Open();
                string query = "SELECT t.id_transaksi,t.tanggal,k.nama,t.total,t.metode_pembayaran FROM transaksi t JOIN karyawan k ON t.nama_operator = k.id_karyawan WHERE DATE(t.tanggal) = CURRENT_DATE";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Transaksi transaksi = new Transaksi
                        {
                            id_transaksi = reader.GetInt32(0),
                            Tanggal = reader.GetDateTime(1),
                            Nama_operator = reader.GetString(2),
                            Total_transaksi = reader.GetInt32(3),
                            Metode_pembayaran = reader.GetString(4)
                        };
                        List_transaksis.Add(transaksi);
                    }
                }
            }
            return List_transaksis;
        }
        public static List<MenuOrder> InfoDetailTransaksi(int id)
        {
            var listmenuOrder = new List<MenuOrder>();

            using (var conn = database.GetConnection())
            {
                conn.Open();
                string query = "SELECT td.jumlah, m.id_menu, m.nama, m.harga FROM transaksi_detail td JOIN menu m ON td.id_menu = m.id_menu WHERE td.id_transaksi = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var menu = new model.Menu
                            {
                                id_menu = reader.GetInt32(reader.GetOrdinal("id_menu")),
                                Nama_menu = reader.GetString(reader.GetOrdinal("nama")),
                                Harga_menu = reader.GetInt32(reader.GetOrdinal("harga"))
                            };

                            var menuOrder = new MenuOrder
                            {
                                menu = menu,
                                qty = reader.GetInt32(reader.GetOrdinal("jumlah"))
                            };

                            listmenuOrder.Add(menuOrder);
                        }
                    }
                }
            }

            return listmenuOrder;
        }

    }
}
