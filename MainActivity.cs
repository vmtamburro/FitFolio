using Android.App;
using Android.OS;C:\Users\Tori's PC\Desktop\FitFolio\FitFolioDemo\MainActivity.cs
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace FitFolio
{
    [Activity(Label = "FitFolio", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
        }
    }
}