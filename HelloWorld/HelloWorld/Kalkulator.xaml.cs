using System.Data;
//using Z.Expressions;

namespace HelloWorld;

public partial class Kalkulator : ContentPage
{
    DataTable dt = new DataTable();
    string LastOpr = string.Empty;
	public Kalkulator()
	{
		InitializeComponent();
	}

    private void DoAction(object sender, EventArgs e)
    {
		var btn = sender as Button;
        LastOpr =btn.CommandParameter.ToString();
        switch (btn.CommandParameter.ToString()){
            case "par":
            case "number":
                var num = btn.Text;
                TxtHasil.Text += num;
                break;
            case "op":
                if (btn.Text == "=")
                {
                    if (string.IsNullOrEmpty(btn.Text)) return;
                  
                   
                    var v = dt.Compute(TxtHasil.Text, "");
                    //var result = Eval.Execute<double>(TxtHasil.Text);
                    TxtHasil.Text = v.ToString();
                }else if(btn.Text == "AC")
                {
                    TxtHasil.Text = String.Empty;
                }
                else
                {
                    var opr = btn.Text;
                    TxtHasil.Text += opr;
                }
                break;
        }

    }
}