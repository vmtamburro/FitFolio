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
    [Activity(Label = "NutritionActivity")]
    public class NutritionActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.nutrition_activity);
            var mbtnBackProfile = FindViewById<Button>(Resource.Id.btnNutBack);

            mbtnBackProfile.Click += delegate
            {
                this.Finish();
            };
        }
    }
}