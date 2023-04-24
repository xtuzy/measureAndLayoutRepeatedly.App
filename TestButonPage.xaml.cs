using static System.Net.Mime.MediaTypeNames;

namespace measureAndLayoutRepeatedly;

public partial class TestButonPage : ContentPage
{
	public TestButonPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		if (button.Text.Contains("Clicked"))
		{
			button.Text = "Click Change Button Text";
		}
		else
		{
            button.Text = "Clicked, Again";
        }
    }
}