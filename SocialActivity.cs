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
    [Activity(Label = "SocialActivity")]
    public class SocialActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.social_activity);
            var mbtnBackSocial = FindViewById<Button>(Resource.Id.btnSocialBack);

            mbtnBackSocial.Click += delegate
            {
                this.Finish();
            };
        }
    }
}