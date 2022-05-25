using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShalatTime.Models
{

    public class BaseObj
    {
        public bool status { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public string id { get; set; }
        public string lokasi { get; set; }
        public string daerah { get; set; }
        public Koordinat koordinat { get; set; }
        public Jadwal jadwal { get; set; }
    }

    public class Koordinat
    {
        public float lat { get; set; }
        public float lon { get; set; }
        public string lintang { get; set; }
        public string bujur { get; set; }
    }

    public class Jadwal
    {
        public string tanggal { get; set; }
        public string imsak { get; set; }
        public string subuh { get; set; }
        public string terbit { get; set; }
        public string dhuha { get; set; }
        public string dzuhur { get; set; }
        public string ashar { get; set; }
        public string maghrib { get; set; }
        public string isya { get; set; }
        public string date { get; set; }
    }

}
