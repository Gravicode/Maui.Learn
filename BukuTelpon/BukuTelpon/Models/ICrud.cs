using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukuTelpon.Models
{
    public interface ICrud<T>
    {
        bool Insert(T obj);
        bool Update(T obj);
        bool Delete(T obj);
        List<T> GetData();
        
    }
}
