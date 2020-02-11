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
    public partial class MessagesDetail : ContentPage
    {
        public MessagesDetail()
        {
            InitializeComponent();
            SizeChanged += OnSizeChanged;
        }
        async private void btnBack(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
        void OnSizeChanged(object sender, EventArgs e)
        {
            var orientation = DeviceDisplay.MainDisplayInfo.Orientation;
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;

            if (orientation == DisplayOrientation.Landscape)
            {
                back_header.Source = ImageSource.FromFile("back_popup_Card_land.png");
            }
            else
            {
                back_header.Source = ImageSource.FromFile("back_popup_Card.png");
            }
        }
    }
}