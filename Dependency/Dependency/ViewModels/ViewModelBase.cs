using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using Dependency.Services;
using System.Windows.Input;
using Prism.Services;


namespace Dependency.ViewModels
{
    public class ViewModelBase : BaseViewModel
    {
        public override string Title { get; set; } = Config.Title;
        public string Orientation { get; set; }
        public string Text { get; set; }
        public ICommand GetDeviceOrientation { get; }
        private IOrientationService _OrientationService;

        public ViewModelBase(INavigationService navigationService, IPageDialogService pageDialogService,
           IOrientationService OrientationService) : base(navigationService, pageDialogService)
        {
            _OrientationService = OrientationService;
            GetDeviceOrientation = new DelegateCommand(GetOrientation);
        }

        public void GetOrientation()
        {
            var orientation = _OrientationService.GetOrientation();
            Orientation = orientation.ToString();
        }
    }
}
