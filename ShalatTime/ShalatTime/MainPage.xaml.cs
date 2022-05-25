using ShalatTime.ViewModels;

namespace ShalatTime;

public partial class MainPage : ContentPage
{
    public SholatVM VM { get; set; }

    public MainPage()
	{
		VM = new SholatVM();
		InitializeComponent();
		this.BindingContext = VM;
	}

	
}

