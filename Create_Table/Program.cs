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
            new Program().CreateTable();
        }

        public void CreateTable()
        {

            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-8MKEQ456; database=ProdiTI; Integrated Security=True; User ID=sa;Password=mentepermaib20");
                con.Open();

                SqlCommand cm = new SqlCommand("create table Mahasiswa_Coba (NIM char(12) not null primary key, Nama varchar(50), Alamat varchar(255), Jenis_Kelamin char(1))", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Table Berhasil dibuat");
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine("Ops, Sepertinya ada yang salah");
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
