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
using Calligraphy.Xamarin;

namespace FitFolio
{
    [Activity(Label = "BMIActivity", Theme = "@style/AppTheme")]
    public class BMIActivity : Android.Support.V7.App.AppCompatActivity
    {
        protected override void AttachBaseContext(Context @base)
        {
            base.AttachBaseContext(CalligraphyContextWrapper.Wrap(@base));
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.bmi_activity);

            //***** To get Login Information*******
            /*string name = Intent.getStringExtra("name"??"Not Recieved");
            string name = Intent.getStringExtra("email"??"Not Recieved");
         
            var txtName = FindViewById<TextView>(Resource.Id.editTextName);
            var txtEmail = FindViewById<TextView>(Resource.Id.editTextEmail);
            txtName.Text = name;
            txtEmail.Text = email;
            */



            //**** To Get Spinnner Information******
            var spinner = FindViewById<Spinner>(Resource.Id.spinner1);
            spinner.Prompt = "Choose your conversion";
            spinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(Spinner_ItemSelected);
            var adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.dropdown_arrays, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner.Adapter = adapter;

            //1/9/19 Adapted above to the other available spinners. 
            var spinner2 = FindViewById<Spinner>(Resource.Id.spinner2);
            spinner2.Prompt = "Choose your conversion";
            spinner2.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(Spinner_ItemSelected);
            var adapter2 = ArrayAdapter.CreateFromResource(this, Resource.Array.height_dropdown, Android.Resource.Layout.SimpleSpinnerItem);
            spinner2.Adapter = adapter2;

            var spinner3 = FindViewById<Spinner>(Resource.Id.spinner3);
            spinner3.Prompt = "Choose your conversion";
            spinner3.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(Spinner_ItemSelected);
            var adapter3 = ArrayAdapter.CreateFromResource(this, Resource.Array.height_sub_dropdown, Android.Resource.Layout.SimpleSpinnerItem);
            spinner3.Adapter = adapter3;

            /*spinner.ItemSelected += (s, e) =>
            {
                string firstItem = spinner.SelectedItem.ToString();
                if (firstItem.Equals(spinner.SelectedItem.ToString()))
                {
                    //To do when first item is Selected
                }
                else
                {
                    Toast.MakeText(this, "You have selected: " + e.Parent.GetItemIdAtPosition(e.Position).ToString(), ToastLength.Short).Show();
                }
            };*/


            //****For Back Button******
            var mbtnBack = FindViewById<Button>(Resource.Id.btnBack);
            mbtnBack.Click += delegate
            {
                this.Finish();
            };

            //****For Submit Button****
            var mbtnSubmit = FindViewById<Button>(Resource.Id.btnSubmit);
            var mTextViewResult = FindViewById<TextView>(Resource.Id.textViewResult);

            //var mEditTextHeightFeet = FindViewById<EditText>(Resource.Id.editTextHeightFeet);
            //string heightValue = mEditTextHeightFeet.Text.ToString();
            EditText mEditTextHeightFeet = FindViewById<EditText>(Resource.Id.editTextHeightFeet);
            


            var mEditTextHeightInches = FindViewById<EditText>(Resource.Id.editTextHeightInches);
            var mEditTextWeightLbs = FindViewById<EditText>(Resource.Id.editTextWeightLbs);
            mbtnSubmit.Click += delegate
            {
                double userHeightFeet = double.Parse(mEditTextHeightFeet.Text.ToString());
                double userHeightInches = double.Parse(mEditTextHeightInches.Text.ToString());
                double userWeightLbs = double.Parse(mEditTextWeightLbs.Text.ToString());
                double userHeightTotalInches = (userHeightFeet * 12) + userHeightInches;
                double bmi = (userWeightLbs * 703) / (userHeightTotalInches * userHeightTotalInches);



                mTextViewResult.Text = "BMI: " + Math.Round(bmi, 1, MidpointRounding.AwayFromZero);
            };
        }

        //***** Spinner Function to Display Choice
        private void Spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {

            var spinner = sender as Spinner;
            //Toast.MakeText(this, "You chose: " + spinner.GetItemAtPosition(e.Position), ToastLength.Short).Show();
        }
    }
}