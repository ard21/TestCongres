﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace TestCongres
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Accueil : ContentPage
    {
        public Accueil()
        {
            InitializeComponent();
            SizeChanged += OnSizeChanged;
        }
        void OnSizeChanged(object sender, EventArgs e)
        {
            var orientation = DeviceDisplay.MainDisplayInfo.Orientation;

            if (orientation == DisplayOrientation.Landscape)
            {
                StackImage.IsVisible = false;
                StackBarCode.IsVisible = true;
                RenderBarcode();
            }
            else
            {
                StackImage.IsVisible = true;
                StackBarCode.IsVisible = false;
            }
        }
        public void RenderBarcode()
        {
            var codeBarMembre = "Alain";
            if (codeBarMembre != null)
            {
                // Render the image
            }
        }
        async private void btnAgendaClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Agenda(), false);
        }

        async private void btnDownloadClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Download(), false);
        }

        async private void btnExposantClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Exposant(), false);
        }

        async private void btnConferencierClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Exposant(), false);
        }

        async private void btnMapsClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Maps(), false);
        }

        async private void btnMyAgendaClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MyAgenda(), false);
        }
    }
}