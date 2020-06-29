using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace beispiel.ViewModels
{

    class MainViewModel : BaseViewModel
    {
        public Command NavigateCommand
        {
            get;
            set;
        }
        public MainViewModel()

        {
            NavigateCommand = new Command(ShowMessage);
            
        }
            
private void ShowMessage()
        {
            Application.Current.MainPage.DisplayAlert("Choose", "Which one", "Thanks");


        }

    }
}
