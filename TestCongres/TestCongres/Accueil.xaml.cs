using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                StackImage1.IsVisible = false;
                StackImage2.IsVisible = false;
                StackBarCode.IsVisible = true;
                //await Navigation.PushModalAsync(new BarCode(), false);
            }
            else
            {
                StackImage1.IsVisible = true;
                StackImage2.IsVisible = true;
                StackBarCode.IsVisible = false;
                //await Navigation.PopModalAsync();
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
    }
}