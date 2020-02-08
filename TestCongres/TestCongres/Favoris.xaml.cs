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
		//public IList<GroupedFavorisModel> grouped { get; private set; }
		public List<GroupedFavorisModel> favori { get; private set; } = new List<GroupedFavorisModel>();
		public Favoris()
        {
            InitializeComponent();

			favori.Add(new GroupedFavorisModel("Conférenciers", new List<FavorisModel>
				{
					new FavorisModel
					{
						Nom = "Johanne Lambert", 
						Comment = "Rédaction des fiducies de gel", 
						ImageURL = "Carolle DALLAIRE.png"
					},
					new FavorisModel
					{
						Nom = "Marc Tremblay", 
						Comment = "Assurance de personnes", 
						ImageURL = "André PLANTE.png"                   },
				}));

			favori.Add(new GroupedFavorisModel("Exposants", new List<FavorisModel>
				{
					new FavorisModel
					{
						Nom = "Atleon inc.", 
						Comment = "Technologie de votation",
						ImageURL = "LogoAtleonSeul@2x.png"
					},
					new FavorisModel
					{
						Nom = "Falcan Medical", 
						Comment = "Lits et fauteuils",
						ImageURL = "falcan.gif"
					},
					new FavorisModel
					{
						Nom = "MTM - Medical Tronik", 
						Comment = "Matériel médical de haute technologie",
						ImageURL = "mtm.png"
				}}));

			favori.Add(new GroupedFavorisModel("Sessions", new List<FavorisModel>
				{
					new FavorisModel
					{
						Nom = "Les dix recommandations du syndic", 
						Comment = "Local 210E, 8 h"
					},
					new FavorisModel
					{
						Nom = "Protection et sécurité de l'information", 
						Comment = "local 510, 9 h 30"
				}}));

			//var exposantsGroup = new GroupedFavorisModel() { LongName = "Exposants", ShortName = "e" };
			//var sessionsGroup = new GroupedFavorisModel() { LongName = "Sessions", ShortName = "s" };
			//exposantsGroup.Add(new FavorisModel() { Nom = "Atleon inc.", Comment = "Technologie de votation" });
			//exposantsGroup.Add(new FavorisModel() { Nom = "Falcan Medical", Comment = "Lits et fauteuils" });
			//exposantsGroup.Add(new FavorisModel() { Nom = "MTM - Medical Tronik", Comment = "Matériel médical de haute technologie" });
			//sessionsGroup.Add(new FavorisModel() { Nom = "Les dix recommandations du syndic", Comment = "Local 210E, 8 h" });
			//sessionsGroup.Add(new FavorisModel() { Nom = "Protection et sécurité de l'information", Comment = "local 510, 9 h 30" });

			//grouped.Add(conferencierGroup);
			//grouped.Add(exposantsGroup);
			//grouped.Add(sessionsGroup);

			BindingContext = this;

			//lvFavoris.ItemsSource = grouped;
			//lvFavoris.IsGroupingEnabled = true;
			//lvFavoris.GroupDisplayBinding = new Binding("LongName");
			//lvFavoris.GroupShortNameBinding = new Binding("ShortName");

			//lvFavoris.ItemTemplate = new DataTemplate(typeof(ViewCell));
			//lvFavoris.ItemTemplate.SetBinding(TextCell.TextProperty, "Nom");
			//lvFavoris.ItemTemplate.SetBinding (TextCell.DetailProperty, "Comment");

			//Content = lvFavoris;

		}
		async private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			await Navigation.PushModalAsync(new MessagesDetail(), false);
		}
	}
}