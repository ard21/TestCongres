
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
                Sujet = "Bla bla bla",
                Date = "2020-01-27",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg"

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

}