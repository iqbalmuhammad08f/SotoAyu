using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using SotoAyu.model;

namespace SotoAyu.controller
{
    internal class MenuController
    {
        public static void tambahmenu(string nama, int harga, string kategori, byte[] gambar)
        {
            using(var conn = database.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO menu (nama, harga, kategori, image) VALUES (@nama, @harga, @kategori, @gambar)";
                using(var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@harga", harga);
                    cmd.Parameters.AddWithValue("@kategori", kategori);
                    cmd.Parameters.AddWithValue("@gambar", gambar);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static List<Menu> GetMenus()
        {
            var list_menu = new List<Menu>();
            using(var conn = database.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM menu";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Menu menu = new Menu
                        {
                            id_menu = reader.GetInt32(0),
                            Nama_menu = reader.GetString(1),
                            Kategori_Menu = reader.GetString(2),
                            Harga_menu = reader.GetInt32(3),
                            Ketersediaan = reader.GetBoolean(5),
                            status = reader.GetBoolean(6)

                        };

                        long size = reader.GetBytes(4, 0, null, 0, 0);
                        byte[] buffer = new byte[size];
                        reader.GetBytes(4, 0, buffer, 0, (int)size);
                        menu.Gambar_menu = buffer;

                        list_menu.Add(menu);
                    }
                }
                return list_menu;
            }
        }
    }
}
