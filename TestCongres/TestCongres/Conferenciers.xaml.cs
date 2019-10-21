using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestCongres
{
    [XamlCompilation(XamlCompilationOptions.Compile)] 
    public partial class Conferenciers : ContentPage
    {
        private ObservableCollection<ConferencierGroup> _allGroups;
        private ObservableCollection<ConferencierGroup> _expandedGroups;

        public Conferenciers()
        {
            InitializeComponent();
            _allGroups = ConferencierGroup.All;
            UpdateListContent();
        }

        private void HeaderTapped(object sender, EventArgs args)
        {
            int selectedIndex = _expandedGroups.IndexOf(
                ((ConferencierGroup)((Button)sender).CommandParameter));
            _allGroups[selectedIndex].Expanded = !_allGroups[selectedIndex].Expanded;
            UpdateListContent();
        }

        private void UpdateListContent()
        {
            _expandedGroups = new ObservableCollection<ConferencierGroup>();
            foreach (ConferencierGroup group in _allGroups)
            {
                ConferencierGroup newGroup = new ConferencierGroup(group.Categorie, group.TitreSommaire, group.Expanded);
                newGroup.CategorieDecompte = group.Count;
                if (group.Expanded)
                {
                    foreach (Conferencier gars in group)
                    {
                        newGroup.Add(gars);
                    }
                }
                _expandedGroups.Add(newGroup);
            }
            GroupedView.ItemsSource = _expandedGroups;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        private void searchDone(object sender, TextChangedEventArgs e)
        {
            //GroupedView.ItemsSource = RempliTableExposants(e.NewTextValue);

        }

        async private void btnMenuClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
