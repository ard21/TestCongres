using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestCongres
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exposants : ContentPage
    {
        public ObservableCollection<Supplier> ExposantsListe { get; private set; }
        public Exposants()
        {
            InitializeComponent();
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

    }
}