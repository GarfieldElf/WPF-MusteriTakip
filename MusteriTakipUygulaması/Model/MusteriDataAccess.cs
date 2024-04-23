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

        public List<Musteri> mda { get; set; }
        public MusteriDataAccess()
        {
            mda = MusteriGetir();
        }

        public void MusteriKaydet(Musteri musteri)
        {
            con = new SqlConnection(connectionString);
            cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "INSERT INTO Musteriler(MusteriAdi,MusteriSoyadi,MusteriTel,MusteriEposta)VALUES(@MusteriAdi,@MusteriSoyadi,@MusteriTel,@MusteriEposta)";
            cmd.Parameters.Add("@MusteriAdi", SqlDbType.VarChar).Value = musteri.MusteriAdi;
            cmd.Parameters.Add("@MusteriSoyadi", SqlDbType.VarChar).Value = musteri.MusteriSoyadi;
            cmd.Parameters.Add("@MusteriTel", SqlDbType.VarChar).Value = musteri.MusteriTel;
            cmd.Parameters.Add("@MusteriEposta", SqlDbType.VarChar).Value = musteri.MusteriEposta;

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<Musteri> MusteriGetir()
        {
            List<Musteri> listOfMusteriler = new List<Musteri>();
            con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand("Select * from Musteriler", con);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            con.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                Musteri m = new Musteri();
                m.MusteriAdi = row["MusteriAdi"].ToString() ?? string.Empty;
                m.MusteriSoyadi = row["MusteriSoyadi"].ToString() ?? string.Empty;
                m.MusteriTel = row["MusteriTel"].ToString() ?? string.Empty;
                m.MusteriEposta = row["MusteriEposta"].ToString() ?? string.Empty;

                listOfMusteriler.Add(m);
            }
            return listOfMusteriler;
        }
    }
}

