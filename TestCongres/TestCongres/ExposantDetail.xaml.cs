﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestCongres
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExposantDetail : ContentPage
    {
        public ExposantDetail()
        {
            InitializeComponent();
        }

        async private void btnMaps(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Maps(), false);
        }
    }
}