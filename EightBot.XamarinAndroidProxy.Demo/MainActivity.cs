using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using BE.Shouldit.Proxy.Lib;

namespace EightBot.XamarinAndroidProxy.Demo
{
    [Activity(Label = "EightBot.XamarinAndroidProxy.Demo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);


            var setupResult = APL.Setup(ApplicationContext);
            
            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate
            {
                var outputString = string.Empty;
                if (count%2 == 0)
                {
                    APL.EnableWifi();

                    outputString = "Wifi Enabled";
                }
                else
                {
                    APL.DisableWifi();

                    outputString = "Wifi Disabled";
                }
                
                button.Text = outputString;

                count++;
            };
        }
    }
}

