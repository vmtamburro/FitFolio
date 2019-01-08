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

namespace FitFolio
{
    [Activity(Label = "BMIActivity")]
    public class BMIActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.bmi_activity);

            //string name = Intent.getStringExtra("name"??"Not Recieved");
            //string name = Intent.getStringExtra("email"??"Not Recieved");

            //var txtName = FindViewById<TextView>(Resource.Id.editTextName);
            //var txtEmail = FindViewById<TextView>(Resource.Id.editTextEmail);
            var btnBack = FindViewById<Button>(Resource.Id.btnBack);

            //txtName.Text = name;
            //txtEmail.Text = email;
            btnBack.Click += delegate
            {
                this.Finish();
            };
        }
    }
}