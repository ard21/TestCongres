
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;

namespace TestCongres
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Participants : ContentPage
    {
        public Participants()
        {
            InitializeComponent();
        }
        async private void btnBack(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}