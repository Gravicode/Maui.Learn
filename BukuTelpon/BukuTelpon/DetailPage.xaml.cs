using BukuTelpon.ViewModels;

namespace BukuTelpon;

public partial class DetailPage : ContentPage
{
	public DetailPage(KontakVM vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}