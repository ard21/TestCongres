﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
                MenuItems = new ObservableCollection<ExposantMasterMenuItem>(new[]
                {
                    new ExposantMasterMenuItem { Id = 0, Title = "3JNA Solutions Inc.", ShortTitle = "3" },
                    new ExposantMasterMenuItem { Id = 1, Title = "AdVitam", ShortTitle = "A" },
                    new ExposantMasterMenuItem { Id = 1, Title = "Atleon inc.", ShortTitle = "A" },
                    new ExposantMasterMenuItem { Id = 2, Title = "Compagnie d'assurances titres Stewart", ShortTitle = "C" },
                    new ExposantMasterMenuItem { Id = 3, Title = "Notaires Jurisconseil", ShortTitle = "N" },
                });
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
    }
}