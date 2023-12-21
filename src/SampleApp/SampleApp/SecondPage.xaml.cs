using CommunityToolkit.Maui.Core;

namespace SampleApp;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
	}

    private void OpenPopupBtn_Clicked(object sender, EventArgs e)
    {
		var ps = this.Handler.MauiContext.Services.GetRequiredService<IPopupService>();
		ps.ShowPopup<MyPopupViewModel>();
    }
}