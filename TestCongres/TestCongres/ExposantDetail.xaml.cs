using System;

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
        async private void btnBack(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
        private void btnFavoris(object sender, EventArgs e)
        {
            DisplayAlert("Favoris", "Ajout de favoris", "OK");
        }

    }
}