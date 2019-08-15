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
    public partial class Agenda : ContentPage
    {
        public Agenda()
        {
            InitializeComponent();
        }

        async private void btnRetourClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}