using CommunityToolkit.Mvvm.ComponentModel;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukuTelpon.Models
{
    [Table("kontak")]

    public partial class Kontak  : ObservableObject
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        [ObservableProperty]
        string nama;
        [ObservableProperty]
        string keterangan;
        [ObservableProperty]
        string telpon;
    }
}
