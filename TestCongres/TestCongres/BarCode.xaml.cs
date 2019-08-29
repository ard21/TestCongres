using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace TestCongres
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarCode : ContentPage
    {
        public BarCode()
        {
            InitializeComponent();
            SizeChanged += OnSizeChanged;
        }
        async void OnSizeChanged(object sender, EventArgs e)
        {
            var orientation = DeviceDisplay.MainDisplayInfo.Orientation;

            if (orientation == DisplayOrientation.Landscape)
            {
                //await Navigation.PushModalAsync(new BarCode(), false);
            }
            else
            {
                await Navigation.PopModalAsync();
            }
        }
    }
}