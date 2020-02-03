using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestCongres
{
    private ObservableCollection<JobGroupViewModel> getContents;
    private ObservableCollection<JobGroupViewModel> _expandedContent;

    public partial class FavorisDetail : ContentPage
    {
        public FavorisDetail()
        {
            InitializeComponent();
            getContents = JobGroupViewModel.Contents;
            UpdateListContent();
        }
        private void HeaderTapped(object sender, EventArgs args)
        {
            int ListselectedIndex = _expandedContent.IndexOf(
                ((JobGroupViewModel)((Button)sender).CommandParameter));
            getContents[ListselectedIndex].Expanded = !getContents[ListselectedIndex].Expanded;
            UpdateListContent();
        }
        private void UpdateListContent()
        {
            _expandedContent = new ObservableCollection<JobGroupViewModel>();
            foreach (JobGroupViewModel group in getContents)
            {
                JobGroupViewModel jobs = new JobGroupViewModel(group.Title, group.Expanded);
                jobs.JobItems = group.Count;
                if (group.Expanded)
                {
                    foreach (JobClassModel job in group)
                    {
                        jobs.Add(job);
                    }
                }
                _expandedContent.Add(jobs);
            }
            MyListView.ItemsSource = _expandedContent;
        }
    }
}