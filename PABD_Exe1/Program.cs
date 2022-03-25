using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PABD_Exe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Program().InsertData();
        }
        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source = LAPTOP-4BKVT6FE; database = PABDExe1; Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand
                    ("Insert into pegawai (IDPegawai, NamaPegawai, Email, NoTelp, JenisKelamin) values ('202001401', 'Yoga', 'yoga@mail.com', '085156410000', 'L')" +
                    "Insert into pegawai (IDPegawai, NamaPegawai, Email, NoTelp, JenisKelamin) values ('202001402', 'Alam', 'alam@mail.com', '085156410001', 'L')" +
                    "Insert into pegawai (IDPegawai, NamaPegawai, Email, NoTelp, JenisKelamin) values ('202001403', 'Fatika', 'fatika@mail.com', '085156410002', 'P')" +
                    "Insert into pegawai (IDPegawai, NamaPegawai, Email, NoTelp, JenisKelamin) values ('202001404', 'Lala', 'lala@mail.com', '085156410003', 'P')" +
                    "Insert into pegawai (IDPegawai, NamaPegawai, Email, NoTelp, JenisKelamin) values ('202001405', 'Rafi', 'rafi@mail.com', '085156410004',L')" +
                    "Insert into roti(IDRoti, NamaRoti, Harga, TglKedaluarsa) values ('KER2020', 'Kering Abon', '5000', '2022-05-22)" +
                    "Insert into roti(IDRoti, NamaRoti, Harga, TglKedaluarsa) values ('KER1402', 'Kering Cokelat','5000', '20022-05-22')" +
                    "Insert into roti(IDRoti, NamaRoti, Harga, TglKedaluarsa) values ('BSH2014', 'Basan Ambon', '6000', '2022-09-20')" +
                    "Insert into roti(IDRoti, NamaRoti, Harga, TglKedaluarsa) values ('BSH2001', 'Basah Brown', '6000','2022-09-20)" +
                    "Insert into roti(IDRoti, NamaRoti, Harga, TglKedaluarsa) values ('CAK2015', 'Cake Strawberry', '10000', '2022-04-22')"+
                    "insert into pembeli(IDPembeli, NamaPembeli, Email) values ('1234567','Anggi','anggi@mail.com')" + 
                    "insert into pembeli(IDPembeli, NamaPembeli, Email) values('1234568', 'Ican', 'ican@mail.com')" +
                    "insert into pembeli(IDPembeli, NamaPembeli, Email) values('1234569', 'Fifi', 'fifi@mail.com')" +
                    "insert into pembeli(IDPembeli, NamaPembeli, Email) values('1234570', 'Aldy', 'aldy@mail.com')" +
                    "insert into pembeli(IDPembeli, NamaPembeli, Email) values('1234571', 'Belinda', 'belinda@mail.com')" +
                    "insert into transaksi(IDTransaksi, TglTransaksi, HargaTotal, IDPegawai, IDPembeli) values ('JUAL123','20-03-2022','10000','202001401','1234567')" +
                    "insert into transaksi(IDTransaksi, TglTransaksi, HargaTotal, IDPegawai, IDPembeli) values('JUAL125', '20-03-2022', '24000', '202001403', '1234568')"+
                    "insert into transaksi(IDTransaksi, TglTransaksi, HargaTotal, IDPegawai, IDPembeli) values('JUAL128', '20-03-2022', '16000', '202001405', '1234569')"+
                    "insert into transaksi(IDTransaksi, TglTransaksi, HargaTotal, IDPegawai, IDPembeli) values('JUAL129', '20-03-2022', '15000', '202001404', '1234570')"+
                    "insert into transaksi(IDTransaksi, TglTransaksi, HargaTotal, IDPegawai, IDPembeli) values('JUAL132', '20-03-2022', '26000', '202001401', '1234571')", con);

                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("gagal menambahkan data!" + e);
            }
            finally
            {
                con.Close();
            }
        }

    }
}
