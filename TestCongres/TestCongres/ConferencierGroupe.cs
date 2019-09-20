using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace TestCongres
{
    class ConferencierGroupe : ObservableCollection<Conferencier>, INotifyPropertyChanged
    {
        private bool _expanded;
        public string Categorie { get; set; }
        public string CategorieNbItem
        {
            get { return string.Format("{0} ({1})", Categorie, CategorieDecompte); }
        }
        public string TitreSommaire { get; set; }
        public bool Expanded
        {
            get { return _expanded; }
            set { if (_expanded != value)
                {
                    _expanded = value;
                    //OnPropertyChanged("Expanded");
                    //OnPropertyChanged("StateIcon");
                }
            }
        }
        public string StateIcon
        {
            get { return Expanded ? "expanded_blue.png" : "collapsed_blue.png"; }
        }
        public int CategorieDecompte { get; set; }
        public ConferencierGroupe(string categorie, string titreSommaire, bool expanded = true)
        {
            Categorie = categorie;
            TitreSommaire = titreSommaire;
            Expanded = expanded;
        }
    }
}
