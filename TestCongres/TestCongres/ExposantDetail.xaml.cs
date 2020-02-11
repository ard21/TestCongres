using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;


namespace TestCongres
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExposantDetail : ContentPage
    {
        public ExposantDetail()
        {
            InitializeComponent();
            SizeChanged += OnSizeChanged;
        }

        async private void btnMaps(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Maps(), false);
        }
        async private void btnBack(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
        private void btnFavoris(object sender, EventArgs e)
        {
            DisplayAlert("Favoris", "Ajout de favoris", "OK");
        }
        void OnSizeChanged(object sender, EventArgs e)
        {
            var orientation = DeviceDisplay.MainDisplayInfo.Orientation;
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;

            if (orientation == DisplayOrientation.Landscape)
            {
                back_header.Source = ImageSource.FromFile("back_popup_Card_land.png");
            }
            else
            {
                back_header.Source = ImageSource.FromFile("back_popup_Card.png");
            }
        }

    }
}