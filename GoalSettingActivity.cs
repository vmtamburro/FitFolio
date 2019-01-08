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
    [Activity(Label = "GoalSettingActivity")]
    public class GoalSettingActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.goal_setting_activity);
            var mbtnGoalBack = FindViewById<Button>(Resource.Id.btnGoalBack);

            mbtnGoalBack.Click += delegate
            {
                this.Finish();
            };
        }
    }
}