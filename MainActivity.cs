using Android.App;
using System;
using Android.Content;
using Android.Views;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Views.InputMethods;

namespace FitFolio
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //var name = FindViewById<EditText>(Resource.Id.editTextName);
            //var email = FindViewById<EditText>(Resource.Id.editTextEmail);
            var btnBMI = FindViewById<Button>(Resource.Id.btnBMI);
            var btnProfile = FindViewById<Button>(Resource.Id.btnProfile);

            btnBMI.Click += (s, e) =>
            {
                Intent BMIActivity = new Intent(this, typeof(BMIActivity));
                //secondActivity.PutExtra("name", editTextName);
                //secondActivity.PutExtra("email", editTextEmail.Text);
                StartActivity(BMIActivity);
            };

            btnProfile.Click += (s, e) =>
            {
                Intent ProfileActivity = new Intent(this, typeof(ProfileActivity));
                StartActivity(ProfileActivity);
            };
        }
    }
}