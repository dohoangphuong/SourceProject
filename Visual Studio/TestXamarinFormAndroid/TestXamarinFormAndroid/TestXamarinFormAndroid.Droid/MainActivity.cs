using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace TestXamarinFormAndroid.Droid
{
    [Activity(Label = "TestXamarinFormAndroid", Icon = "@drawable/icon", Theme = "@style/MainTheme", NoHistory = true, MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : Activity//global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            //TabLayoutResource = Resource.Layout.Tabbar;
            //ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            //global::Xamarin.Forms.Forms.Init(this, bundle);
            //LoadApplication(new Page2());
           // MainPage = new TestXamarinFormAndroid.MainPage();
            SetContentView(Resource.Layout.Page2);

            Button button1 = FindViewById<Button>(Resource.Id.button1);
            button1.Click += (sender,e)=>
             {
                
                 var intent = new Intent(this, typeof(Activity1));
                 // intent.PutStringArrayListExtra("phone_numbers", phoneNumbers);
               
                 StartActivity(intent);
                // StartActivity(typeof(Activity1));
                 // StartActivity(new Intent(this, typeof(Activity1)));
             };
            //button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, object e)
        {
            StartActivity(typeof(Activity1));
        }
    }
}

