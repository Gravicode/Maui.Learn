using BukuTelpon.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BukuTelpon.Services
{
    public class KontakService : ICrud<Kontak>
    {
        SQLiteConnection conn;
        public KontakService()
        {
            string filename = FileAccessHelper.GetLocalFilePath( "kontak.db3");
            conn = new SQLiteConnection(filename);
            conn.CreateTable<Kontak>();

        }
        public bool Delete(Kontak obj)
        {
            try
            {
                int result = 0;
                result = conn.Delete<Kontak>(obj.Id);
                return result==1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<Kontak> GetData()
        {
            try
            {
                var datas = conn.Table<Kontak>().ToList();
                return datas;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default;
            }
        }

        public bool Insert(Kontak obj)
        {
            try
            {
                int result = conn.Insert(obj);
                return result==1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Update(Kontak obj)
        {
            try
            {
                int result = 0;
                result = conn.Update(obj);
                return result==1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
