using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LayoutSamples
{
    public partial class BasicStepperXAMLPage : ContentPage
    {
        public BasicStepperXAMLPage()
        {
            InitializeComponent();
        }

        void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            _rotatingLabel.Rotation = value;
            displayLabel.Text = string.Format("The Stepper value is {0}", value);
        }
    }
}
