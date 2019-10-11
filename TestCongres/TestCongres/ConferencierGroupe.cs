using System.Collections.ObjectModel;
using System.ComponentModel;

namespace TestCongres
{
    public class ConferencierGroup : ObservableCollection<Conferencier>, INotifyPropertyChanged
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
        public int ConferencierCount { get; set; }
        public string StateIcon
        {
            get { return Expanded ? "expanded_blue.png" : "collapsed_blue.png"; }
        }
        public int CategorieDecompte { get; set; }
        public ConferencierGroup(string categorie, string titreSommaire, bool expanded = true)
        {
            Categorie = categorie;
            TitreSommaire = titreSommaire;
            Expanded = expanded;
        }
    
        public static ObservableCollection<ConferencierGroup> All { private set; get; }

        static ConferencierGroup()
        {
            ObservableCollection<ConferencierGroup> Groups = new ObservableCollection<ConferencierGroup>{
                    new ConferencierGroup("Avocats","A"){
                        new Conferencier { Nom = "Alain Tremblay", Titre = "Raymnond Chabot",  Photo="Alain DÉCOSTE.png" },
                        new Conferencier { Nom = "Jocelyne Roberge", Titre = "KSA avocats et notaires", Photo="Brigitte BERGERON.png" },
                        new Conferencier { Nom = "Lucie Allaire", Titre = "Lajoie & Pearson Avocats", Photo="Carolle DALLAIRE.png" },
                        new Conferencier { Nom = "Josée Paquet", Titre = "Cabinet Guy Bertrand", Photo="Hélène JENKINS.png" },
                    },
                    new ConferencierGroup("Compagnies d'assurances","C"){
                        new Conferencier { Nom = "Isabelle Dufour", Titre = "Promutuel Assurance", Photo="Hélène TREMBLAY.png"},
                        new Conferencier { Nom = "Yanick Julien", Titre = "AccèsConseil", Photo="André PLANTE.png"},
                        new Conferencier { Nom = "Pierre Morris", Titre = "L'Unique assurances générales", Photo="Arthur GOBEIL.png"},
                        new Conferencier { Nom = "Yolande Gaudreau", Titre = "Great-West Compagnie D'assurance-Vie", Photo="Josée NÉRON.png"},
                    },
                    new ConferencierGroup("Droit des affaires","D"){
                        new Conferencier { Nom = "André Plourde", Titre = "", Photo="Carol TREMBLAY.png"},
                        new Conferencier { Nom = "François Thiboutot", Titre = "", Photo="Christian SIMARD.png"},
                        new Conferencier { Nom = "Julie Soucy", Titre = "", Photo="Kathleen BOULANGER.png"},
                    },
                    new ConferencierGroup("Notaires","N"){
                        new Conferencier { Nom = "Jacques Laberge", Titre = "Bureau Du Notaire Lord", Photo="Denis GILBERT.png"},
                        new Conferencier { Nom = "Marie Doucet", Titre = "Larochelle & Associés, notaires", Photo="Valérie TREMBLAY.png"},
                        new Conferencier { Nom = "Léo Fortier", Titre = "Aubin & Desbiens Notaires", Photo="Serge DESROSIERS.png"},

                    } };
            All = Groups;
        }
    }
}
