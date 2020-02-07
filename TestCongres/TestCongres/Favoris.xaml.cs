using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace TestCongres
{
	[XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Favoris : ContentPage
    {
		public IList<GroupedFavorisModel> grouped { get; private set; }
		public Favoris()
        {
            InitializeComponent();

			grouped = new List<GroupedFavorisModel>();
			var conferencierGroup = new GroupedFavorisModel() { LongName = "Conférenciers", ShortName = "c" };
			var exposantsGroup = new GroupedFavorisModel() { LongName = "Exposants", ShortName = "e" };
			var sessionsGroup = new GroupedFavorisModel() { LongName = "Sessions", ShortName = "s" };
			conferencierGroup.Add(new FavorisModel() { Nom = "Johanne Lambert", Comment = "Rédaction des fiducies de gel", ImageURL = "Carolle DALLAIRE.png" });
			conferencierGroup.Add(new FavorisModel() { Nom = "Marc Tremblay", Comment = "Assurance de personnes", ImageURL = "André PLANTE.png" });
			exposantsGroup.Add(new FavorisModel() { Nom = "Atleon inc.", Comment = "Technologie de votation" });
			exposantsGroup.Add(new FavorisModel() { Nom = "Falcan Medical", Comment = "Lits et fauteuils" });
			exposantsGroup.Add(new FavorisModel() { Nom = "MTM - Medical Tronik", Comment = "Matériel médical de haute technologie" });
			sessionsGroup.Add(new FavorisModel() { Nom = "Les dix recommandations du syndic", Comment = "Local 210E, 8 h" });
			sessionsGroup.Add(new FavorisModel() { Nom = "Protection et sécurité de l'information", Comment = "local 510, 9 h 30" });

			grouped.Add(conferencierGroup);
			grouped.Add(exposantsGroup);
			grouped.Add(sessionsGroup);

			BindingContext = this;

			//lstView.ItemsSource = grouped;
			//lstView.IsGroupingEnabled = true;
			//lstView.GroupDisplayBinding = new Binding("LongName");
			//lstView.GroupShortNameBinding = new Binding("ShortName");

			//lstView.ItemTemplate = new DataTemplate(typeof(TextCell));
			//lstView.ItemTemplate.SetBinding(TextCell.TextProperty, "Nom");
			//			lstView.ItemTemplate.SetBinding (TextCell.DetailProperty, "Comment");

			//Content = lstView;

		}
		async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			Fichier selectedItem = e.SelectedItem as Fichier;
			await Navigation.PushModalAsync(new MessagesDetail(), false);

		}

		void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
		{
			Fichier tappedItem = e.Item as Fichier;
		}

	}
}