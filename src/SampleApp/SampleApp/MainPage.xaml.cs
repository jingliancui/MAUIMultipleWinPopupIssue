﻿

namespace SampleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OpenSecondWinBtn_Clicked(object sender, EventArgs e)
        {
            var win = new Window(new SecondPage());
            Application.Current.OpenWindow(win);
        }
    }

}
