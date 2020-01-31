
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
        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Fichier selectedItem = e.SelectedItem as Fichier;

        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Fichier tappedItem = e.Item as Fichier;
        }

    }
}