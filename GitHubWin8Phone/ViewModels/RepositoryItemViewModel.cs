﻿using Octokit;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace GitHubWin8Phone.ViewModels
{
    public class RepositoryItemViewModel : INotifyPropertyChanged
    {
        public RepositoryItemViewModel(Repository repository)
        {
            this.Repository = repository;
            this.LineOne = repository.Name;
            this.LineTwo = repository.Description;
            this.LineThree = repository.GitUrl;

        }

        private Repository repository;
        public Repository Repository
        {
            get
            {
                return repository;
            }
            set
            {
                repository = value;
                NotifyPropertyChanged("Repository");
            }
        }

        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        private string lineOne;
        public string LineOne
        {
            get
            {
                return lineOne;
            }
            set
            {
                if (value != lineOne)
                {
                    lineOne = value;
                    NotifyPropertyChanged("LineOne");
                }
            }
        }

        private string lineTwo;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string LineTwo
        {
            get
            {
                return lineTwo;
            }
            set
            {
                if (value != lineTwo)
                {
                    lineTwo = value;
                    NotifyPropertyChanged("LineTwo");
                }
            }
        }
        
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        private string lineThree;
        public string LineThree
        {
            get
            {
                return lineThree;
            }
            set
            {
                if (value != lineThree)
                {
                    lineThree = value;
                    NotifyPropertyChanged("LineThree");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}