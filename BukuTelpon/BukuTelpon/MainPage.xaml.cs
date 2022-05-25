using BukuTelpon.ViewModels;

namespace BukuTelpon;

public partial class MainPage : ContentPage
{

	public MainPage(KontakVM VM)
	{
		InitializeComponent();
		this.BindingContext = VM;
	}
}

