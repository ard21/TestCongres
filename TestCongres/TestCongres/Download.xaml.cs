using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace TestCongres
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Download : ContentPage
    {
        public IList<Fichier> Fichiers { get; private set; }
        public Download()
        {
            InitializeComponent();
            SizeChanged += OnSizeChanged;

            Fichiers = new List<Fichier>();
            Fichiers.Add(new Fichier
            {
                Name = "Plus 1 – Rédaction des ﬁducies de gel",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg"

            });

            Fichiers.Add(new Fichier
            {
                Name = "Plus 2 – Aliénation ou utilisation d’un lot sans l’autorisation de la CPTAQ",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg"
            });

            Fichiers.Add(new Fichier
            {
                Name = "Plus 3 – Assurance de personnes",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg"
            });

            Fichiers.Add(new Fichier
            {
                Name = "Plus 4 – Types de séparation, enjeux ﬁscaux, régimes de retraite",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg"
            });

            Fichiers.Add(new Fichier
            {
                Name = "Les dix recommandations du syndic",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Golden_lion_tamarin_portrait3.jpg/220px-Golden_lion_tamarin_portrait3.jpg"
            });

            Fichiers.Add(new Fichier
            {
                Name = "Modiﬁcations législatives en matière de protection des personnes en situation de vulnérabilité",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Alouatta_guariba.jpg/200px-Alouatta_guariba.jpg"
            });

            Fichiers.Add(new Fichier
            {
                Name = "Protection et sécurité de l’information",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Macaca_fuscata_fuscata1.jpg/220px-Macaca_fuscata_fuscata1.jpg"
            });

            BindingContext = this;
        }
        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Fichier selectedItem = e.SelectedItem as Fichier;
            stackWeb.IsVisible = true;
            stackListView.IsVisible = false;
            boutonBack.IsVisible = true;
        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Fichier tappedItem = e.Item as Fichier;
        }
        private void btnBack(object sender, EventArgs e)
        {
            stackWeb.IsVisible = false;
            stackListView.IsVisible = true;
            boutonBack.IsVisible = false;
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

        private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Fichier selectedItem = e.CurrentSelection as Fichier;

            stackWeb.IsVisible = true;
            stackListView.IsVisible = false;
            boutonBack.IsVisible = true;
        }
    }
}