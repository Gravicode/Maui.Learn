namespace HelloWorld;

public partial class Dadu : ContentPage
{
	
	public Dadu()
	{
		InitializeComponent();
	}
    int BilAcak = 1;
    Random rnd = new Random(Environment.TickCount);
    bool IsAcak = false;
    
    private void AcakDadu(object sender, EventArgs e)
    {
        IsAcak = !IsAcak;
        BtnAcak.Text = IsAcak ? "Stop" : "Start";
        if (IsAcak)
        {
            Device.StartTimer(TimeSpan.FromMilliseconds(200), () =>
            {
            // Do something
                BilAcak = rnd.Next(1, 6);
                Device.BeginInvokeOnMainThread(() =>
                {
                    TxtDadu.Text = BilAcak.ToString();
                });
                return IsAcak; // True = Repeat again, False = Stop the timer
            });
        }
    }
}