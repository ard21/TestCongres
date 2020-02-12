
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
            webViewVote.Source = "https://secure.innovision.qc.ca/demo/Membres/login.aspx?param1=2125&param2=827CCB0EEA8A706C4C34A16891F84E7B";
        }
        async private void btnBack(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}