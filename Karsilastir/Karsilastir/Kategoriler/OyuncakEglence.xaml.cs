﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Karsilastir.Kategoriler
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OyuncakEglence : ContentPage
    {
        public OyuncakEglence()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (btn.BackgroundColor == Color.Transparent)
            {
                btn.BackgroundColor = Color.Black;
            }
            else if (btn.BackgroundColor == Color.Black)
            {
                btn.BackgroundColor = Color.Transparent;

            }
        }
    }
}