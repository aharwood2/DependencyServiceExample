using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using TelecomsAndroid.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(CallServiceImpl))]
namespace TelecomsAndroid.Droid
{
    class CallServiceImpl : ICallService
    {
        public void SomeMethod()
        {
            var callPreventer = new CallPreventer();
            var callService = new MyCallService();

            // TODO: Interface with your call service on Android here...
        }
    }
}