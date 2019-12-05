using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestCongres
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Atelier : ContentPage
    {
        public Atelier()
        {
            InitializeComponent();
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