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
    public partial class Accueil : ContentPage
    {
        public Accueil()
        {
            InitializeComponent();
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