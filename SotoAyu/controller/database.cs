using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace SotoAyu.controller
{
    internal class database
    {
        private static string connString = "Host=localhost;Username=postgres;Password=123;Database=soto_ayu";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connString);
        }
    }
}
