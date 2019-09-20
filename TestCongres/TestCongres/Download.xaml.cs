using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestCongres
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Download : ContentPage
    {
        public Download()
        {
            InitializeComponent();
        }

        async private void btnBack(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}