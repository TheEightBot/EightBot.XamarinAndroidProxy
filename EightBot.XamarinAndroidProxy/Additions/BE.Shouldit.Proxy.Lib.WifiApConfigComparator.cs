using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
    public partial class WifiApConfigComparator
    {
        public int Compare(Object lhs, Object rhs)
        {
            return Compare((WiFiApConfig)lhs, (WiFiApConfig)rhs);
        }
    }
}