using System;
using Xamarin.Forms;

namespace LayoutSamples
{
    public partial class BasicButtonClickPage : ContentPage
    {
        public BasicButtonClickPage()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            await label.RelRotateTo(360, 1000);
        }
    }
}
