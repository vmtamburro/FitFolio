﻿using System;
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
    [Activity(Label = "ProfileActivity")]
    public class ProfileActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.profile_activity);
            var mbtnBackProfile = FindViewById<Button>(Resource.Id.btnBackProfile);
           
            mbtnBackProfile.Click += delegate
             {
                 this.Finish();
             };

           
        }
    }
}