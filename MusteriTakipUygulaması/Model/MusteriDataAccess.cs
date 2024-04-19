using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriTakipUygulaması.Model
{
    public class MusteriDataAccess
    {
        private const string connectionString = "Data Source=DESKTOP-OHVI9IG;Initial Catalog=Test;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection? con;
        SqlCommand? cmd;

        public void MusteriKaydet(Musteri musteri)
        {
            con = new SqlConnection(connectionString);
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Musteriler(MusteriAdi,MusteriSoyadi,MusteriTel,MusteriEposta)VALUES(@MusteriAdi,@MusteriSoyadi,@MusteriTel,@MusteriEposta)";
            cmd.Parameters.Add("@MusteriAdi", SqlDbType.VarChar).Value = musteri.MusteriAdi;
            cmd.Parameters.Add("@MusteriSoyadi", SqlDbType.VarChar).Value = musteri.MusteriSoyadi;
            cmd.Parameters.Add("@MusteriTel", SqlDbType.VarChar).Value = musteri.MusteriTel;
            cmd.Parameters.Add("@MusteriEposta", SqlDbType.VarChar).Value = musteri.MusteriEposta;
        }

        public void MusteriGetir()
        {
            con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand("Select * from Musteriler", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader["MusteriAdi"].ToString());
                Console.WriteLine(reader["MusteriSoyadi"].ToString());
                Console.WriteLine(reader["MusteriTel"].ToString());
                Console.WriteLine(reader["MusteriEposta"].ToString());
            }

            con.Close();
        }
    }
}

