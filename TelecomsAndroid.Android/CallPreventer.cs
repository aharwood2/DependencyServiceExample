﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Telecom;
using Android.Views;
using Android.Widget;

namespace TelecomsAndroid.Droid
{
    class CallPreventer : InCallService
    {
        public override void OnCallAdded(Call call)
        {
            call.Disconnect();
            base.OnCallAdded(call);
        }
    }
}