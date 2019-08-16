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
                    new ExposantMasterMenuItem { Id = 0, Title = "Atleon inc." },
                    new ExposantMasterMenuItem { Id = 1, Title = "innovision+ inc." },
                    new ExposantMasterMenuItem { Id = 2, Title = "APE inc." },
                    new ExposantMasterMenuItem { Id = 3, Title = "IPÉ inc." },
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