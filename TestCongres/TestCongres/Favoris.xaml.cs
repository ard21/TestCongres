
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestCongres
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Favoris : ContentPage
    {
        public Favoris()
        {
            InitializeComponent();
        }

        private void btnFermerStack(object sender, System.EventArgs e)
        {
            stackWeb.IsVisible = false;
        }

        private void btnOuvrirWeb(object sender, System.EventArgs e)
        {
            stackWeb.IsVisible = true;

        }
    }
}