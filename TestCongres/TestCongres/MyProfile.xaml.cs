using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Essentials;
using Xamarin.Forms.Xaml;

namespace TestCongres
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyProfile : ContentPage
    {
        public MyProfile()
        {
            InitializeComponent();
            SizeChanged += OnSizeChanged;
        }

        async private void btnBack(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private void swap_GaucheDroite(object sender, ScrolledEventArgs e)
        {
        }
        void OnSizeChanged(object sender, EventArgs e)
        {
            var orientation = DeviceDisplay.MainDisplayInfo.Orientation;
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;

            if (orientation == DisplayOrientation.Landscape)
            {
                this.BackgroundImageSource = "background_generic_land.png";
            }
            else
            {
                this.BackgroundImageSource = "background_generic.png";
            }
        }

    }
}