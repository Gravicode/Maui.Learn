using ShalatTime.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShalatTime.ViewModels
{
    public class SholatTime
    {
        public string Nama { get; set; }
        public string Jadwal { get; set; }
    }
    public class SholatVM
    {
        ShalatApi api;

        public DateTime CurrentDate { get; set; }
        public Command GetWaktuSholat { get; set; }

        public ObservableCollection<SholatTime> Shalats { get; set; }

        public SholatVM()
        {
            CurrentDate = DateTime.Now;
            api = new ShalatApi();
            Shalats = new ObservableCollection<SholatTime>();
            GetWaktuSholat = new Command(async() => {
                var jadwal = await api.GetShalatTime(CurrentDate);
                if (jadwal != null)
                {
                    Shalats.Clear();
                    Shalats.Add(new SholatTime() { Nama = nameof(jadwal.imsak).ToUpper(), Jadwal = jadwal.imsak });
                    Shalats.Add(new SholatTime() { Nama = nameof(jadwal.subuh).ToUpper(), Jadwal = jadwal.subuh });
                    Shalats.Add(new SholatTime() { Nama = nameof(jadwal.dzuhur).ToUpper(), Jadwal = jadwal.dzuhur });
                    Shalats.Add(new SholatTime() { Nama = nameof(jadwal.ashar).ToUpper(), Jadwal = jadwal.ashar });
                    Shalats.Add(new SholatTime() { Nama = nameof(jadwal.maghrib).ToUpper(), Jadwal = jadwal.maghrib });
                    Shalats.Add(new SholatTime() { Nama = nameof(jadwal.isya).ToUpper(), Jadwal = jadwal.isya });
                }
            });
        }
    }
}
