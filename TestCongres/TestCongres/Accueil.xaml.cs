using System;
using Xamarin.Essentials;
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
            SizeChanged += OnSizeChanged;
        }
        // resize the image to be contained within a maximum width and height, keeping aspect ratio
        void OnSizeChanged(object sender, EventArgs e)
        {
            var orientation = DeviceDisplay.MainDisplayInfo.Orientation;

            if (orientation == DisplayOrientation.Landscape)
            {
                StackImage.IsVisible = false;
                StackBarCode.IsVisible = true;
                this.BackgroundImageSource = null;
                RenderBarcode();
            }
            else
            {
                StackImage.IsVisible = true;
                StackBarCode.IsVisible = false;
                this.BackgroundImageSource = ImageSource.FromFile("back_body.png");
            }
        }
        public void RenderBarcode()
        {
            var codeBarMembre = "Alain";
            if (codeBarMembre != null)
            {
                // Render the image
            }
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
            await Navigation.PushModalAsync(new Exposants(), false);
        }

        async private void btnConferencierClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Conferenciers(), false);
        }

        async private void btnMapsClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Maps(), false);
        }

        async private void btnMyAgendaClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MyAgenda(), false);
        }

        async private void btnProfil(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MyProfile(), false);
        }
    }
}