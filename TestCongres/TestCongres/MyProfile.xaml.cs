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
    public partial class MyProfile : ContentPage
    {
        public MyProfile()
        {
            InitializeComponent();
        }

        async private void btnBack(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private void swap_GaucheDroite(object sender, ScrolledEventArgs e)
        {
            
        }
    }
}