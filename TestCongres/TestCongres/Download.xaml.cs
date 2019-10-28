using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestCongres
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Download : ContentPage
    {
        public IList<Fichier> Fichiers { get; private set; }
        public Download()
        {
            InitializeComponent();

            Fichiers = new List<Fichier>();
            Fichiers.Add(new Fichier
            {
                Name = "Plus 1 – Rédaction des ﬁducies de gel",
                Location = "510",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
            });

            Fichiers.Add(new Fichier
            {
                Name = "Plus 2 – Aliénation ou utilisation d’un lot sans l’autorisation de la CPTAQ",
                Location = "511",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
            });

            Fichiers.Add(new Fichier
            {
                Name = "Plus 3 – Assurance de personnes",
                Location = "510",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
            });

            Fichiers.Add(new Fichier
            {
                Name = "Plus 4 – Types de séparation, enjeux ﬁscaux, régimes de retraite",
                Location = "511",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg"
            });

            Fichiers.Add(new Fichier
            {
                Name = "Les dix recommandations du syndic",
                Location = "210AE",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Golden_lion_tamarin_portrait3.jpg/220px-Golden_lion_tamarin_portrait3.jpg"
            });

            Fichiers.Add(new Fichier
            {
                Name = "Modiﬁcations législatives en matière de protection des personnes en situation de vulnérabilité",
                Location = "210AE",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Alouatta_guariba.jpg/200px-Alouatta_guariba.jpg"
            });

            Fichiers.Add(new Fichier
            {
                Name = "Protection et sécurité de l’information",
                Location = "510",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Macaca_fuscata_fuscata1.jpg/220px-Macaca_fuscata_fuscata1.jpg"
            });

            Fichiers.Add(new Fichier
            {
                Name = "Succession transfrontalière",
                Location = "210A",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Mandrill_at_san_francisco_zoo.jpg/220px-Mandrill_at_san_francisco_zoo.jpg"
            });

            Fichiers.Add(new Fichier
            {
                Name = "Milieux humides et hydriques",
                Location = "210E",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Proboscis_Monkey_in_Borneo.jpg/250px-Proboscis_Monkey_in_Borneo.jpg"
            });

            Fichiers.Add(new Fichier
            {
                Name = "Pas le temps…de gagner du temps?",
                Location = "510",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Portrait_of_a_Douc.jpg/159px-Portrait_of_a_Douc.jpg"
            });

            Fichiers.Add(new Fichier
            {
                Name = "Renonciation à une succession : administration des biens",
                Location = "210A",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0b/Cuc.Phuong.Primate.Rehab.center.jpg/320px-Cuc.Phuong.Primate.Rehab.center.jpg"
            });

            Fichiers.Add(new Fichier
            {
                Name = "Opérations de prête-nom",
                Location = "210E",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg/165px-Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg"
            });

            Fichiers.Add(new Fichier
            {
                Name = "Danser avec la réalité ",
                Location = "510",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/RhinopitecusBieti.jpg/320px-RhinopitecusBieti.jpg"
            });

            Fichiers.Add(new Fichier
            {
                Name = "Le droit de la famille à l’heure des choix ",
                Location = "210E",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Tonkin_snub-nosed_monkeys_%28Rhinopithecus_avunculus%29.jpg/320px-Tonkin_snub-nosed_monkeys_%28Rhinopithecus_avunculus%29.jpg"
            });

            Fichiers.Add(new Fichier
            {
                Name = "Fonds de prévoyance en copropriété divise ",
                Location = "210A",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Thomas%27s_langur_Presbytis_thomasi.jpg/142px-Thomas%27s_langur_Presbytis_thomasi.jpg"
            });

            Fichiers.Add(new Fichier
            {
                Name = "Coopérative d’habitation à capitalisation individuelle ",
                Location = "510",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/02/Semnopithèque_blanchâtre_mâle.JPG/192px-Semnopithèque_blanchâtre_mâle.JPG"
            });

            Fichiers.Add(new Fichier
            {
                Name = "Le langage clair pour remplir son devoir de conseil ",
                Location = "210A",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/Gelada-Pavian.jpg/320px-Gelada-Pavian.jpg"
            });
            BindingContext = this;
        }
        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Fichier selectedItem = e.SelectedItem as Fichier;
        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Fichier tappedItem = e.Item as Fichier;
        }
        async private void btnBack(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}