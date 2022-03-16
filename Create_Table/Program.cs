using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //Memanggil method CreateTable
            new Program().CreateTable();
        }


        //Membuat Method untuk membuat table
        public void CreateTable()
        {

            SqlConnection con = null;
            try
            {

                //Menyambungkan dengan SQL Server
                con = new SqlConnection("data source=LAPTOP-8MKEQ456; database=ProdiTI; Integrated Security=True; User ID=sa;Password=mentepermaib20");
                //Membuka koneksi
                con.Open();

                //Syntax untuk membuat table pada SQL Server
                SqlCommand cm = new SqlCommand("create table Mahasiswa_Coba (NIM char(12) not null primary key, Nama varchar(50), Alamat varchar(255), Jenis_Kelamin char(1))", con);
                
                //Untuk mengeksikusi Syntax diatas
                cm.ExecuteNonQuery();

                //Jika berhasil maka muncul tulisan dibawah
                Console.WriteLine("Table Berhasil dibuat");
                Console.ReadKey();
            }
            catch(Exception e)
            {
                //Jika gagal maka akan muncul tulisan seperti dibawah
                Console.WriteLine("Ops, Sepertinya ada yang salah");
                Console.ReadKey();
            }
            finally
            {
                //Menutup koneksi
                con.Close();
            }
        }
    }
}
