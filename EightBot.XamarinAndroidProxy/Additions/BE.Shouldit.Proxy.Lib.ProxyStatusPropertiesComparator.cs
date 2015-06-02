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
using BE.Shouldit.Proxy.Lib.Enums;
using Object = Java.Lang.Object;

namespace BE.Shouldit.Proxy.Lib
{
    public partial class ProxyStatusPropertiesComparator
    {
        public int Compare(Object lhs, Object rhs)
        {
            return Compare((ProxyStatusProperties) lhs, (ProxyStatusProperties) rhs);
        }
    }
}