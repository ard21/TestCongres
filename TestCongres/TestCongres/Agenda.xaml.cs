using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestCongres
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Agenda : ContentPage
    {
        private bool flagHoraireConferencier;

        public ObservableCollection<Calendrier> Calendriers { get; private set; }

        public Agenda()
        {
            InitializeComponent();

            flagHoraireConferencier = true;
            //Calendriers = new List<Calendrier>();
            Calendriers = new ObservableCollection<Calendrier>();
            horaire();
        }
        private void horaire ()
        {
            Calendriers.Add(new Calendrier
            {
                Name = "Plus 1 – Rédaction des ﬁducies de gel",
                Location = "Local 510",
                Hour = "9 h 30",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
            });

            Calendriers.Add(new Calendrier
            {
                Name = "Plus 2 – Aliénation ou utilisation d’un lot sans l’autorisation de la CPTAQ",
                Location = "Local 511",
                Hour = "10 h 30",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
            });

            Calendriers.Add(new Calendrier
            {
                Name = "Plus 3 – Assurance de personnes",
                Location = "Local 510",
                Hour = "13 h",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
            });

            Calendriers.Add(new Calendrier
            {
                Name = "Plus 4 – Types de séparation, enjeux ﬁscaux, régimes de retraite",
                Location = "Local 511",
                Hour = "15 h",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg"
            });

            Calendriers.Add(new Calendrier
            {
                Name = "Les dix recommandations du syndic",
                Location = "Local 210AE",
                Hour = "8 h",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Golden_lion_tamarin_portrait3.jpg/220px-Golden_lion_tamarin_portrait3.jpg"
            });

            Calendriers.Add(new Calendrier
            {
                Name = "Modiﬁcations législatives en matière de protection des personnes en situation de vulnérabilité",
                Location = "Local 210AE",
                Hour = "9 h 30",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Alouatta_guariba.jpg/200px-Alouatta_guariba.jpg"
            });

            Calendriers.Add(new Calendrier
            {
                Name = "Protection et sécurité de l’information",
                Location = "Local 510",
                Hour = "9 h 30",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Macaca_fuscata_fuscata1.jpg/220px-Macaca_fuscata_fuscata1.jpg"
            });

            Calendriers.Add(new Calendrier
            {
                Name = "Succession transfrontalière",
                Location = "Local 210A",
                Hour = "11 h",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Mandrill_at_san_francisco_zoo.jpg/220px-Mandrill_at_san_francisco_zoo.jpg"
            });

            Calendriers.Add(new Calendrier
            {
                Name = "Milieux humides et hydriques",
                Location = "Local 210E",
                Hour = "13 h",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Proboscis_Monkey_in_Borneo.jpg/250px-Proboscis_Monkey_in_Borneo.jpg"
            });

            Calendriers.Add(new Calendrier
            {
                Name = "Pas le temps…de gagner du temps?",
                Location = "Local 510",
                Hour = "13 h",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Portrait_of_a_Douc.jpg/159px-Portrait_of_a_Douc.jpg"
            });

            Calendriers.Add(new Calendrier
            {
                Name = "Renonciation à une succession : administration des biens",
                Location = "Local 210A",
                Hour = "15 h 30",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0b/Cuc.Phuong.Primate.Rehab.center.jpg/320px-Cuc.Phuong.Primate.Rehab.center.jpg"
            });

            Calendriers.Add(new Calendrier
            {
                Name = "Opérations de prête-nom",
                Location = "Local 210E",
                Hour = "15 h 30",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg/165px-Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg"
            });

            Calendriers.Add(new Calendrier
            {
                Name = "Danser avec la réalité",
                Location = "Local 510",
                Hour = "8 h 30",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/RhinopitecusBieti.jpg/320px-RhinopitecusBieti.jpg"
            });

            Calendriers.Add(new Calendrier
            {
                Name = "Le droit de la famille à l’heure des choix",
                Location = "Local 210E",
                Hour = "8 h 30",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Tonkin_snub-nosed_monkeys_%28Rhinopithecus_avunculus%29.jpg/320px-Tonkin_snub-nosed_monkeys_%28Rhinopithecus_avunculus%29.jpg"
            });

            Calendriers.Add(new Calendrier
            {
                Name = "Fonds de prévoyance en copropriété divise",
                Location = "210A",
                Hour = "10 h 30",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Thomas%27s_langur_Presbytis_thomasi.jpg/142px-Thomas%27s_langur_Presbytis_thomasi.jpg"
            });

            Calendriers.Add(new Calendrier
            {
                Name = "Coopérative d’habitation à capitalisation individuelle",
                Location = "Local 510",
                Hour = "10 h 30",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/02/Semnopithèque_blanchâtre_mâle.JPG/192px-Semnopithèque_blanchâtre_mâle.JPG"
            });

            Calendriers.Add(new Calendrier
            {
                Name = "Le langage clair pour remplir son devoir de conseil",
                Location = "Local 210A",
                Hour = "13 h",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/Gelada-Pavian.jpg/320px-Gelada-Pavian.jpg"
            });
            BindingContext = this;

        }
        private void conferencier()
        {
            Calendriers.Add(new Calendrier
            {
                Name = "Alain  Robillard",
                Location = "**Appel au calme**",
                ImageUrl = "Alain DÉCOSTE.png"
            });

            BindingContext = this;

        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Calendrier selectedItem = e.SelectedItem as Calendrier;

            //string str = "La conférence choisie est " + selectedItem.Name;
            //DisplayAlert("Sélection des conférences", str, "OK");
            await Navigation.PushModalAsync(new Atelier(), false);
        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Calendrier tappedItem = e.Item as Calendrier;
        }
        private void btnFavoris(object sender, EventArgs e)
        {
            DisplayAlert("Favoris", "Ajout de favoris", "OK");
        }

        async private void btnBack(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private void btnHoraire(object sender, EventArgs e)
        {
            if (flagHoraireConferencier == false) {
                flagHoraireConferencier = true;
                if (Calendriers.Count > 0)
                {
                    Calendriers.Clear();
                }
                horaire();
            }
        }

        private void btnConferencier(object sender, EventArgs e)

        {
            if (flagHoraireConferencier == true)
            {
                flagHoraireConferencier = false;
                if (Calendriers.Count > 0)
                {
                    Calendriers.Clear();
                }
                conferencier();
            }
        }
    }
}