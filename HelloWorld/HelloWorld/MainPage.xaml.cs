namespace HelloWorld;

public partial class MainPage : ContentPage
{
	int count = 5;

	public MainPage()
	{
		InitializeComponent();
		LblUtama.Text = "Selamat Datang Cuii !!";
	}

	private void TombolDitekan(object sender, EventArgs e)
	{
		count = count + 2;


		CounterBtn.Text = $"Dipijit {count} kali";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

