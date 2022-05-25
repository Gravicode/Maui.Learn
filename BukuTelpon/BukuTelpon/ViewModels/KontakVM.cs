using BukuTelpon.Models;
using BukuTelpon.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukuTelpon.ViewModels
{
   
    public partial class KontakVM : ObservableObject
    {
        KontakService service;
        public KontakVM()
        {
            service = new KontakService();
            Items = new ObservableCollection<Kontak>();
            Refresh();
            
        }

        void Refresh()
        {
            Items.Clear();
            var items = service.GetData();
            foreach (var item in items)
                Items.Add(item);
        }

        [ObservableProperty]
        ObservableCollection<Kontak> items;

        [ObservableProperty]
        Kontak kontak;

        [ICommand]
        async Task CreateNew()
        {
            kontak = new Kontak() { Id = 0 };
            var navigationParameter = new Dictionary<string, object>
            {
                { "kontak", kontak }
            };
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}", navigationParameter);
        }

        [ICommand]
        async Task Add()
        {
            if (kontak == null || string.IsNullOrEmpty(kontak.Nama) || string.IsNullOrEmpty(kontak.Telpon))
            {
                return;
            }

            var res = service.Insert(kontak);
            if (res)
            {
                Items.Add(kontak);
                
            }
            await Shell.Current.GoToAsync("..");
        }

        [ICommand]
        void Delete(Kontak s)
        {
            var res = service.Delete(s);
            if (res && Items.Contains(s))
            {
                Items.Remove(s);
            }
        }

        [ICommand]
        async Task Tap(Kontak s)
        {
            var navigationParameter = new Dictionary<string, object>
            {
                { "kontak", s }
            };
            kontak = s;
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}",navigationParameter);
        }
        [ICommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
