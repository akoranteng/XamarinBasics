using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LayOutSamples
{
    public class BasicSlidewithCode : ContentPage
    {
        public BasicSlidewithCode()
        {
            Title = "SliderCode Page - C#";
            Label rotationLabel = new Label
            {
                Text = "ROTATING TEXT",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Label displayLabel = new Label
            {
                Text = "(uninitialized)",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Slider slider = new Slider
            {
                Maximum = 360
            };
            slider.ValueChanged += (sender, args) =>
            {
                rotationLabel.Rotation = slider.Value;
                displayLabel.Text = String.Format("The Slider value is {0}", args.NewValue);
            };

            Title = "Basic Slider Code";
            Padding = new Thickness(10, 0);
            Content = new StackLayout
            {
                Children =
            {
                rotationLabel,
                slider,
                displayLabel
            }
            };
        }
    }
}