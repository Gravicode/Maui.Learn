namespace HelloWorld;

public partial class Senter : ContentPage
{
	public Senter()
	{
		InitializeComponent();
	}
	bool IsOn = false;
    private async Task SenterClickedAsync(object sender, EventArgs e)
    {
		
    }

    private async void SenterClicked(object sender, EventArgs e)
    {
        IsOn = !IsOn;
        if (IsOn)
        {
            await Flashlight.TurnOnAsync();
            BtnSenter.Source = ImageSource.FromFile("on.png");
        }
        else
        {
            await Flashlight.TurnOffAsync();
            BtnSenter.Source = ImageSource.FromFile("off.png");
        }
    }
}