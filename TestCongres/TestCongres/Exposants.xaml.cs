using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;


namespace TestCongres
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exposants : ContentPage
    {
        public ObservableCollection<Supplier> ExposantsListe { get; private set; }
        public Exposants()
        {
            InitializeComponent();
            SizeChanged += OnSizeChanged;

            ExposantsListe = new ObservableCollection<Supplier>();

            chargerExposant();
        }
        private void chargerExposant()
        {
            ExposantsListe.Add(new Supplier
            {
                Nom = "Falcan Médical",
                Titre = "Claire Falardeau",
                Photo = "falcan.gif"
            });

            ExposantsListe.Add(new Supplier
            {
                Nom = "MTM - Médical Tronik",
                Titre = "Christian Gardner",
                Photo = "mtm.png"
            });

            BindingContext = this;

        }
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Supplier selectedItem = e.SelectedItem as Supplier;

            await Navigation.PushModalAsync(new ExposantDetail(), false);
        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Supplier tappedItem = e.Item as Supplier;
        }
        private void btnFavoris(object sender, EventArgs e)
        {
            DisplayAlert("Favoris", "Ajout de favoris", "OK");
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
                back_header.Source = ImageSource.FromFile("back_header_Menu_land.png");
            }
            else
            {
                back_header.Source = ImageSource.FromFile("back_header_Menu.png");
            }
        }

        async private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Supplier TypeChoisi = (e.CurrentSelection as Supplier);

            await Navigation.PushModalAsync(new ExposantDetail(), false);

        }
    }
}