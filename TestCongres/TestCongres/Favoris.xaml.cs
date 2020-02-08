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
						Type = "C",
						ImageURL = "Carolle DALLAIRE.png"
					},
					new FavorisModel
					{
						Nom = "Marc Tremblay", 
						Comment = "Assurance de personnes",
						Type = "C",
						ImageURL = "André PLANTE.png"                   
				}}));

			favori.Add(new GroupedFavorisModel("Exposants", new List<FavorisModel>
				{
					new FavorisModel
					{
						Nom = "Atleon inc.", 
						Comment = "Technologie de votation",
						Type = "E",
						ImageURL = "LogoAtleonSeul@2x.png"
					},
					new FavorisModel
					{
						Nom = "Falcan Medical", 
						Comment = "Lits et fauteuils",
						Type = "E",
						ImageURL = "falcan.gif"
					},
					new FavorisModel
					{
						Nom = "MTM - Medical Tronik", 
						Comment = "Matériel médical de haute technologie",
						Type = "E",
						ImageURL = "mtm.png"
				}}));

			favori.Add(new GroupedFavorisModel("Sessions", new List<FavorisModel>
				{
					new FavorisModel
					{
						Nom = "Les dix recommandations du syndic",
						Type = "S",
						Comment = "Local 210E, 8 h",
						ImageURL = "OCQ_rond.png"
					},
					new FavorisModel
					{
						Nom = "Protection et sécurité de l'information",
						Type = "S",
						Comment = "local 510, 9 h 30",
						ImageURL = "OCQ_rond.png"
				}}));

			BindingContext = this;

		}
		async private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			string TypeChoisi= (e.CurrentSelection.FirstOrDefault() as FavorisModel)?.Type;

			switch (TypeChoisi)
			{
				case "C":
					await Navigation.PushModalAsync(new Conferenciers(), false);
					break;
				case "E":
					Console.WriteLine("Case 2");
					await Navigation.PushModalAsync(new ExposantDetail(), false);
					break;
				case "S":
					await Navigation.PushModalAsync(new Atelier(), false);
					break;
				default:
					break;
			}
		}
	}
}