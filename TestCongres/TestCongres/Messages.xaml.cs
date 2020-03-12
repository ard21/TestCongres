
using Xamarin.Essentials;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestCongres
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Messages : ContentPage
    {
        public IList<MessageGlobal> MessagesGlobaux{ get; private set; }

        public Messages()
        {
            InitializeComponent();
            //SizeChanged += OnSizeChanged;

            MessagesGlobaux = new List<MessageGlobal>();
            MessagesGlobaux.Add(new MessageGlobal
            {
                DeQui = "Administration Congrès",
                Sujet = "Le congrès s'ouvre avec le gala ce soir à 17 h 30",
                Date = "2020-01-27",
                ImageUrl = "Josée NÉRON.png"
            });

            MessagesGlobaux.Add(new MessageGlobal
            {
                DeQui = "Atleon inc.",
                Sujet = "Le cocktail sera offert par Atleon inc.",
                Date = "2020-01-28",
                ImageUrl = "Carol TREMBLAY.png"
            });

            BindingContext = this;
        }
        //void OnSizeChanged(object sender, EventArgs e)
        //{
        //    var orientation = DeviceDisplay.MainDisplayInfo.Orientation;
        //    var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;

        //    if (orientation == DisplayOrientation.Landscape)
        //    {
        //        back_header.Source = ImageSource.FromFile("back_header_Menu_land.png");
        //        //rltLayout.WidthRequest = mainDisplayInfo.Width;
        //        //stackListView.WidthRequest = mainDisplayInfo.Width-200;
        //    }
        //    else
        //    {
        //        back_header.Source = ImageSource.FromFile("back_header_Menu.png");
        //        //rltLayout.WidthRequest = mainDisplayInfo.Width;
        //        //stackListView.WidthRequest = mainDisplayInfo.Width-200;
        //    }
        //}

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Fichier selectedItem = e.SelectedItem as Fichier;
            await Navigation.PushModalAsync(new MessagesDetail(), false);

        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Fichier tappedItem = e.Item as Fichier;
        }

        async private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            await Navigation.PushModalAsync(new MessagesDetail(), false);
        }
    }
}