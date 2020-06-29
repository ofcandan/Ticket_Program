using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Util;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace beispiel.Droid
{
    [Service]
    [IntentFilter(new[] { "com.google.firebase.INSTANCE_ID_EVENT" })]
    [IntentFilter(new[] { "com.google.firebase.MESSAGING_EVENT" })]

    public class FirebaseService
    {

    }
}