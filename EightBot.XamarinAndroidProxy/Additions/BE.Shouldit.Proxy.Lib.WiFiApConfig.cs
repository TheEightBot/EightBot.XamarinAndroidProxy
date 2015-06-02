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
using Object = Java.Lang.Object;

namespace BE.Shouldit.Proxy.Lib
{
    public partial class WiFiApConfig
    {
        public int CompareTo(Object another)
        {
            return CompareTo((WiFiApConfig) another);
        }
    }
}