using Prism;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssetKita.ViewModels
{
    public class ViewModelChild : ViewModelBase, IActiveAware
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        private bool _isActive;
        public bool IsActive
        {
            get { return _isActive; }
            set { SetProperty(ref _isActive, value, () => System.Diagnostics.Debug.WriteLine($"{Title} IsActive Changed: {value}")); }
        }

        public event EventHandler IsActiveChanged;

        public ViewModelChild()
        {
            IsActiveChanged += (sender, e) => System.Diagnostics.Debug.WriteLine($"{Title} IsActive: {IsActive}");
        }

        public override void OnNavigatingTo(NavigationParameters parameters)
        {
            System.Diagnostics.Debug.WriteLine($"{Title} is executing OnNavigatingTo");
            var message = parameters.GetValue<string>("message");
            Message = $"{Title} Initialized by OnNavigatingTo: {message}";
        }

        public override void Destroy()
        {
            System.Diagnostics.Debug.WriteLine($"{Title} is being Destroyed!");
        }
    }
}
