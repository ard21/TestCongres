using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestCongres
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExposantMaster : ContentPage
    {
        public ListView ListView;

        public ExposantMaster()
        {
            InitializeComponent();

            BindingContext = new ExposantMasterViewModel();
            ListView = MenuItemsListView;
        }

        class ExposantMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<ExposantMasterMenuItem> MenuItems { get; set; }

            public ExposantMasterViewModel()
            {
                MenuItems = new ObservableCollection<ExposantMasterMenuItem>(RempliTableExposants(null));
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }

        private void searchDone(object sender, TextChangedEventArgs e)
        {
            MenuItemsListView.ItemsSource = RempliTableExposants(e.NewTextValue);
        }

        private static IEnumerable<ExposantMasterMenuItem> RempliTableExposants(string searchText = null)
        {
            var ExposantsSearch = new ObservableCollection<ExposantMasterMenuItem>(new[]
                {
                    new ExposantMasterMenuItem { Id = 0, Title = "3JNA Solutions Inc.", ShortTitle = "3" },
                    new ExposantMasterMenuItem { Id = 1, Title = "ACCEO Solutions ", ShortTitle = "A" },
                    new ExposantMasterMenuItem { Id = 2, Title = "AdVitam", ShortTitle = "A" },
                    new ExposantMasterMenuItem { Id = 3, Title = "Atleon inc.", ShortTitle = "A" },
                    new ExposantMasterMenuItem { Id = 4, Title = "Amalgama", ShortTitle = "A" },
                    new ExposantMasterMenuItem { Id = 5, Title = "Calen-Droit", ShortTitle = "C" },
                    new ExposantMasterMenuItem { Id = 6, Title = "CAP - Association canadienne des parajuristes", ShortTitle = "C" },
                    new ExposantMasterMenuItem { Id = 7, Title = "Centres de justice de proximité du Québec", ShortTitle = "C" },
                    new ExposantMasterMenuItem { Id = 8, Title = "Compagnie d'assurances titres Stewart", ShortTitle = "C" },
                    new ExposantMasterMenuItem { Id = 9, Title = "Conservation de la nature", ShortTitle = "C" },
                    new ExposantMasterMenuItem { Id = 10, Title = "Éditions juridiques FD inc.", ShortTitle = "E" },
                    new ExposantMasterMenuItem { Id = 11, Title = "Éditions Yvon Blais", ShortTitle = "E" },
                    new ExposantMasterMenuItem { Id = 12, Title = "Educaloi", ShortTitle = "E" },
                    new ExposantMasterMenuItem { Id = 13, Title = "Encans Forand", ShortTitle = "E" },
                    new ExposantMasterMenuItem { Id = 14, Title = "Étude généalogique Savary", ShortTitle = "E" },
                    new ExposantMasterMenuItem { Id = 15, Title = "Évolia Transition inc.", ShortTitle = "E" },
                    new ExposantMasterMenuItem { Id = 16, Title = "Notaires Jurisconseil", ShortTitle = "N" },
                });

            if (String.IsNullOrWhiteSpace(searchText))
                return ExposantsSearch;

            return ExposantsSearch.Where(x => x.Title.StartsWith(searchText));
        }
    }
}