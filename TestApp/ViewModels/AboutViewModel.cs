using System;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TestApp.ViewModels
{
    [INotifyPropertyChanged]
    public class AboutViewModel
    {
        private string _title;

        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}
