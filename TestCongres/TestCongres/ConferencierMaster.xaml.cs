using System;
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
    public partial class ConferencierMaster : ContentPage
    {
        public ListView ListView;

        public ConferencierMaster()
        {
            InitializeComponent();

            BindingContext = new ConferencierMasterViewModel();
            ListView = MenuItemsListView;
        }

        class ConferencierMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<ConferencierMasterMenuItem> MenuItems { get; set; }

            public ConferencierMasterViewModel()
            {
                MenuItems = new ObservableCollection<ConferencierMasterMenuItem>(new[]
                {
                    new ConferencierMasterMenuItem { Id = 0, Title = "Page 1" },
                    new ConferencierMasterMenuItem { Id = 1, Title = "Page 2" },
                    new ConferencierMasterMenuItem { Id = 2, Title = "Page 3" },
                    new ConferencierMasterMenuItem { Id = 3, Title = "Page 4" },
                    new ConferencierMasterMenuItem { Id = 4, Title = "Page 5" },
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