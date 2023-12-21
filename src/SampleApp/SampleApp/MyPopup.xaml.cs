using CommunityToolkit.Maui.Views;

namespace SampleApp;

public partial class MyPopup : Popup
{
	public MyPopup()
	{
		InitializeComponent();

		BindingContext = new MyPopupViewModel();

    }
}