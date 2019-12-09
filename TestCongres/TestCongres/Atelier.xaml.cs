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
            //var htmlSource = new HtmlWebViewSource();
            //htmlSource.Html = @"<html><body>
            //    <h1>SEVGI KELCI<br>
            //        Notaire<br> 
            //        ANTOINE GUILMAIN<br>
            //        Avocat, docteur en droit<br>
            //        FASKEN </h1>
            //    <p>La protection et la sécurité de l'information personnelle ou confidentielle de ses clients sont particulièrement préoccupantes pour le notaire d'aujourd'hui. Un accès non autorisé ou une perte des données de clients découlant d'une atteinte aux mesures de sécurité peut mettre en péril le devoir de secret professionnel incombant à tout notaire, nuire à la bonne réputation de la profession et à son aptitude à servir l'intérêt public, tout en causant des préjudices graves aux clients.</p>
            //    <p>Dans ce contexte, le notaire doit assurer la sécurité des renseignements de ses clients, une obligation reconnue aujourd'hui, tout en évaluant s'il doit déclarer dans certaines circonstances la survenance d'un incident de sécurité aux clients et autorités concernés, une pratique méconnue pour le moment.</p>
            //    <p>Les conférenciers font la lumière sur les obligations du notaire en matière de protection des renseignements personnels, et le conseillent sur les bonnes pratiques à instaurer pour une utilisation responsable des technologies de l'information dans l'exercice de sa profession.</p>
            //  </body></html>";
            //leTexte.Source = htmlSource;

            //var browser = new WebView();
            //var htmlSource = new HtmlWebViewSource();
            //htmlSource.Html = @"<html><body>
            //    <h1>Xamarin.Forms</h1>
            //    <p>Welcome to WebView.</p>
            //    </body></html>";
            //browser.Source = htmlSource;
            //leTexte.Source = htmlSource;
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