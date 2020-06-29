using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using beispiel.Droid;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using beispiel.Services;

[assembly:Dependency(typeof(NotificationServices))]


namespace beispiel.Droid
{
    public class NotificationServices : INotificationServices
    {
        public void ShowNotifications(string title, string description)
        {
            
        }
    }
}