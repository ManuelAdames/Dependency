using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prism.Services;

namespace Dependency.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public abstract string Title { get; set; }

        protected INavigationService NavigationService { get; }
        protected IPageDialogService AlertService { get; }

        protected BaseViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
        {
            NavigationService = navigationService;
            AlertService = pageDialogService;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}