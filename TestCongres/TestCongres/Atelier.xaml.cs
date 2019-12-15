using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestCongres
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Atelier : ContentPage
    {
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public Atelier()
        {
            InitializeComponent();
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
            wvTexte.WidthRequest = mainDisplayInfo.Width - 400;
            SizeChanged += OnSizeChanged;

        }
        void OnSizeChanged(object sender, EventArgs e)
        {
            var orientation = DeviceDisplay.MainDisplayInfo.Orientation;
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
            wvTexte.WidthRequest = mainDisplayInfo.Width - 400;
            //backImage.WidthRequest = mainDisplayInfo.Width;

            //if (orientation == DisplayOrientation.Landscape)
            //{
            //    this.BackgroundImageSource = ImageSource.FromFile("back_body - land.png");
            //}
            //else
            //{
            //    this.BackgroundImageSource = ImageSource.FromFile("back_body.png");
            //}
        }

        async private void btnBack(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
        private void btnFavoris(object sender, EventArgs e)
        {
            DisplayAlert("Favoris", "Ajout de favoris", "OK");
        }

        private void swap_HautBas(object sender, ScrolledEventArgs e)
        {

        }
    }
}