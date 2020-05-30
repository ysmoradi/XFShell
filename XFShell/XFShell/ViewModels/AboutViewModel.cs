using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace XFShell.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => Device.OpenUri(new Uri("https://xamarin.com")));
        }

        public ICommand OpenWebCommand { get; }
    }
}