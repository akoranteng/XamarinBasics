using System;
using System.Collections.Generic;
using System.Globalization;
using Xamarin.Forms;

namespace LayoutSamples
{
    public partial class BasicSliderCodePage : ContentPage
    {
        public BasicSliderCodePage()
        {
            InitializeComponent();
        }

        private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            ValueLabel.Text = Math.Round(e.NewValue).ToString(CultureInfo.InvariantCulture);

        }
    }
}
