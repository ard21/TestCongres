﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ExpanViewXam.Models;
using ExpanViewXam.ViewModels;
using Xamarin.Forms;

namespace ExpanViewXam.Views
{
    public partial class EmployeeDetailJob : ContentPage
    {
        private ObservableCollection<JobGroupViewModel> getContents;
        private ObservableCollection<JobGroupViewModel> _expandedContent;
        public EmployeeDetailJob()
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