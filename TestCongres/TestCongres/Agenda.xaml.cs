using System;

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