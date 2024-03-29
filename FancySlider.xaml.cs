﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LayoutSamples
{
    //public partial class FancySlider : ContentPage
    //{
    public partial class FancySlider : ContentPage
    {
        private int _index = 0;
        private string[] _quotes = {
            "Life is like riding a bicycle. To keep your balance, you must keep moving.",
            "You can't blame gravity for falling in love.",
            "Look deep into nature, and then you will understand everything better."
        };

        public FancySlider()
        {
            InitializeComponent();
            currentQuote.Text = _quotes[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes.Length)
                _index = 0;

            currentQuote.Text = _quotes[_index];
        }
    }
}
