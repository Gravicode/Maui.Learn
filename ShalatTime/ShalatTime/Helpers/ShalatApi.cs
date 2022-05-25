using Newtonsoft.Json;
using ShalatTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShalatTime.Helpers
{
    public class ShalatApi
    {
        HttpClient client;
        const string BaseUrl = @"https://api.myquran.com/v1/sholat/jadwal/1609/";
        public ShalatApi()
        {
            if (client == null) client = new HttpClient();
        }

        public async Task<Jadwal> GetShalatTime(DateTime now)
        {
            var url = $"{BaseUrl}/{now.Year}/{now.Month}/{now.Day}";
            var json = await client.GetStringAsync(url);
            if (!string.IsNullOrEmpty(json))
            {
                var obj = JsonConvert.DeserializeObject<BaseObj>(json);
                return obj.data.jadwal;
            }
            return default;
        }
    }

}
