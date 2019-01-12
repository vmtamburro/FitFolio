using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Calligraphy.Xamarin;
using FitFolio.Assets.Helper;
using static Android.Views.View;

namespace FitFolio
{
    [Activity(Label = "CalculatorActivity")]
    public class CalculatorActivity : AppCompatActivity, IOnClickListener
    {
        Button btnSin, btnCos, btnTan, btnFactorial, btnPow;
        Button btnClear, btnBackSpace, btnOpen, btnClose, btnSqrt;
        Button btn7, btn8, btn9, btnDiv, btnMod;
        Button btn4, btn5, btn6, btnMulti, btnInverse;
        Button btn1, btn2, btn3, btnMinus, btnAdd, btnResult;
        Button btn0, btnDot, btnPi;

        TextView screenAns, screenMath;

        StringBuilder textMath = new StringBuilder("");
        StringBuilder textAns = new StringBuilder("");
        StringBuilder screenTextMath = new StringBuilder("");
        double num1 = 0.0, num2 = 0.0, ans = 0.0;

        int checkSubmit = 0;

        public void OnClick(View v)
        {
            string[] elementMath = null;

            if (v.Id == Resource.Id.btn0)
            {
                if (screenTextMath.Length < 48)
                {
                    if (checkSubmit == 1)
                    {
                        screenTextMath = new StringBuilder("");
                        textMath = new StringBuilder("");
                        checkSubmit = 0;
                    }
                    textMath.Append("0");
                    screenTextMath.Append("0");
                }
                screenMath.Text = screenTextMath.ToString();
            }
            else if (v.Id == Resource.Id.btn1)
            {
                if (screenTextMath.Length < 48)
                {
                    if (checkSubmit == 1)
                    {
                        screenTextMath = new StringBuilder("");
                        textMath = new StringBuilder("");
                        checkSubmit = 0;
                    }
                    textMath.Append("1");
                    screenTextMath.Append("1");
                }
                screenMath.Text = screenTextMath.ToString();
            }
            else if (v.Id == Resource.Id.btn2)
            {
                if (screenTextMath.Length < 48)
                {
                    if (checkSubmit == 1)
                    {
                        screenTextMath = new StringBuilder("");
                        textMath = new StringBuilder("");
                        checkSubmit = 0;
                    }
                    textMath.Append("2");
                    screenTextMath.Append("2");
                }
                screenMath.Text = screenTextMath.ToString();
            }
            else if (v.Id == Resource.Id.btn3)
            {
                if (screenTextMath.Length < 48)
                {
                    if (checkSubmit == 1)
                    {
                        screenTextMath = new StringBuilder("");
                        textMath = new StringBuilder("");
                        checkSubmit = 0;
                    }
                    textMath.Append("3");
                    screenTextMath.Append("3");
                }
                screenMath.Text = screenTextMath.ToString();
            }
            else if (v.Id == Resource.Id.btn4)
            {
                if (screenTextMath.Length < 48)
                {
                    if (checkSubmit == 1)
                    {
                        screenTextMath = new StringBuilder("");
                        textMath = new StringBuilder("");
                        checkSubmit = 0;
                    }
                    textMath.Append("4");
                    screenTextMath.Append("4");
                }
                screenMath.Text = screenTextMath.ToString();
            }
            else if (v.Id == Resource.Id.btn5)
            {
                if (screenTextMath.Length < 48)
                {
                    if (checkSubmit == 1)
                    {
                        screenTextMath = new StringBuilder("");
                        textMath = new StringBuilder("");
                        checkSubmit = 0;
                    }
                    textMath.Append("5");
                    screenTextMath.Append("5");
                }
                screenMath.Text = screenTextMath.ToString();
            }
            else if (v.Id == Resource.Id.btn6)
            {
                if (screenTextMath.Length < 48)
                {
                    if (checkSubmit == 1)
                    {
                        screenTextMath = new StringBuilder("");
                        textMath = new StringBuilder("");
                        checkSubmit = 0;
                    }
                    textMath.Append("6");
                    screenTextMath.Append("6");
                }
                screenMath.Text = screenTextMath.ToString();
            }
            else if (v.Id == Resource.Id.btn7)
            {
                if (screenTextMath.Length < 48)
                {
                    if (checkSubmit == 1)
                    {
                        screenTextMath = new StringBuilder("");
                        textMath = new StringBuilder("");
                        checkSubmit = 0;
                    }
                    textMath.Append("7");
                    screenTextMath.Append("7");
                }
                screenMath.Text = screenTextMath.ToString();
            }
            else if (v.Id == Resource.Id.btn8)
            {
                if (screenTextMath.Length < 48)
                {
                    if (checkSubmit == 1)
                    {
                        screenTextMath = new StringBuilder("");
                        textMath = new StringBuilder("");
                        checkSubmit = 0;
                    }
                    textMath.Append("8");
                    screenTextMath.Append("8");
                }
                screenMath.Text = screenTextMath.ToString();
            }
            else if (v.Id == Resource.Id.btn9)
            {
                if (screenTextMath.Length < 48)
                {
                    if (checkSubmit == 1)
                    {
                        screenTextMath = new StringBuilder("");
                        textMath = new StringBuilder("");
                        checkSubmit = 0;
                    }
                    textMath.Append("9");
                    screenTextMath.Append("9");
                }
                screenMath.Text = screenTextMath.ToString();
            }
            else if (v.Id == Resource.Id.btnDot)
            {
                if (screenTextMath.Length < 48)
                {
                    if (checkSubmit == 1)
                    {
                        screenTextMath = new StringBuilder("");
                        textMath = new StringBuilder("");
                        checkSubmit = 0;
                    }
                    textMath.Append(".");
                    screenTextMath.Append(".");
                }
                screenMath.Text = screenTextMath.ToString();
            }
            else if (v.Id == Resource.Id.btnPi)
            {
                if (screenTextMath.Length < 48)
                {
                    if (checkSubmit == 1)
                    {
                        screenTextMath = new StringBuilder("");
                        textMath = new StringBuilder("");
                        checkSubmit = 0;
                    }
                    textMath.Append("π");
                    screenTextMath.Append("π");
                }
                screenMath.Text = screenTextMath.ToString();
            }
            else if (v.Id == Resource.Id.btnAdd)
            {
                if (screenTextMath.Length < 48)
                {
                    if (checkSubmit == 1)
                    {
                        screenTextMath = new StringBuilder("");
                        textMath = new StringBuilder("");
                        checkSubmit = 0;
                    }
                    textMath.Append("+");
                    screenTextMath.Append("+");
                }
                screenMath.Text = screenTextMath.ToString();
            }
            else if (v.Id == Resource.Id.btnSub)
            {
                if (screenTextMath.Length < 48)
                {
                    if (checkSubmit == 1)
                    {
                        screenTextMath = new StringBuilder("");
                        textMath = new StringBuilder("");
                        checkSubmit = 0;
                    }
                    textMath.Append("-");
                    screenTextMath.Append("-");
                }
                screenMath.Text = screenTextMath.ToString();
            }
            else if (v.Id == Resource.Id.btnmulti)
            {
                if (screenTextMath.Length < 48)
                {
                    if (checkSubmit == 1)
                    {
                        screenTextMath = new StringBuilder("");
                        textMath = new StringBuilder("");
                        checkSubmit = 0;
                    }
                    textMath.Append("*");
                    screenTextMath.Append("*");
                }
                screenMath.Text = screenTextMath.ToString();
            }
            else if (v.Id == Resource.Id.btndiv)
            {
                if (screenTextMath.Length < 48)
                {
                    if (checkSubmit == 1)
                    {
                        screenTextMath = new StringBuilder("");
                        textMath = new StringBuilder("");
                        checkSubmit = 0;
                    }
                    textMath.Append("/"); screenTextMath.Append("/");
                }
                screenMath.Text = screenTextMath.ToString();
            }
            else if (v.Id == Resource.Id.btnPow)
            {
                if (screenTextMath.Length < 48)
                {
                    if (checkSubmit == 1)
                    {
                        screenTextMath = new StringBuilder("");
                        textMath = new StringBuilder("");
                        checkSubmit = 0;
                    }
                    textMath.Append("^");
                    screenTextMath.Append("^");
                }
                screenMath.Text = screenTextMath.ToString();
            }
            else if (v.Id == Resource.Id.btnSqrt)
            {
                if (screenTextMath.Length < 48)
                {
                    if (checkSubmit == 1)
                    {
                        screenTextMath = new StringBuilder("");
                        textMath = new StringBuilder("");
                        checkSubmit = 0;
                    }
                    textMath.Append("√"); //Alt+251
                    screenTextMath.Append("√");
                }
                screenMath.Text = screenTextMath.ToString();
            }
            else if (v.Id == Resource.Id.btnPow)
            {
                if (screenTextMath.Length < 48)
                {
                    if (checkSubmit == 1)
                    {
                        screenTextMath = new StringBuilder("");
                        textMath = new StringBuilder("");
                        checkSubmit = 0;
                    }
                    textMath.Append("^");
                    screenTextMath.Append("^");
                }
                screenMath.Text = screenTextMath.ToString();

            }
            else if (v.Id == Resource.Id.btnSin)
            {
                if (screenTextMath.Length < 48)
                {
                    if (checkSubmit == 1)
                    {
                        screenTextMath = new StringBuilder("");
                        textMath = new StringBuilder("");
                        checkSubmit = 0;
                    }
                    textMath.Append("s(");
                    screenTextMath.Append("Sin(");
                }
                screenMath.Text = screenTextMath.ToString();
            }
            else if (v.Id == Resource.Id.btnCos)
            {
                if (screenTextMath.Length < 48)
                {
                    if (checkSubmit == 1)
                    {
                        screenTextMath = new StringBuilder("");
                        textMath = new StringBuilder("");
                        checkSubmit = 0;
                    }
                    textMath.Append("c(");
                    screenTextMath.Append("Cos(");
                }
                screenMath.Text = screenTextMath.ToString();
            }
            else if (v.Id == Resource.Id.btnTan)
            {
                if (screenTextMath.Length < 48)
                {
                    if (checkSubmit == 1)
                    {
                        screenTextMath = new StringBuilder("");
                        textMath = new StringBuilder("");
                        checkSubmit = 0;
                    }
                    textMath.Append("t(");
                    screenTextMath.Append("Tan(");
                }
                screenMath.Text = screenTextMath.ToString();
            }
            else if (v.Id == Resource.Id.btnOpen)
            {
                if (screenTextMath.Length < 48)
                {
                    if (checkSubmit == 1)
                    {
                        screenTextMath = new StringBuilder("");
                        textMath = new StringBuilder("");
                        checkSubmit = 0;
                    }
                    textMath.Append("(");
                    screenTextMath.Append("(");
                }
                screenMath.Text = screenTextMath.ToString();
            }
            else if (v.Id == Resource.Id.btnClose)
            {
                if (screenTextMath.Length < 48)
                {
                    if (checkSubmit == 1)
                    {
                        screenTextMath = new StringBuilder("");
                        textMath = new StringBuilder("");
                        checkSubmit = 0;
                    }
                    textMath.Append(")");
                    screenTextMath.Append(")");
                }
                screenMath.Text = screenTextMath.ToString();
            }
            else if (v.Id == Resource.Id.btnSin)
            {
                if (screenTextMath.Length < 48)
                {
                    if (checkSubmit == 1)
                    {
                        screenTextMath = new StringBuilder("");
                        textMath = new StringBuilder("");
                        checkSubmit = 0;
                    }
                    textMath.Append("s(");
                    screenTextMath.Append("Sin(");
                }
                screenMath.Text = screenTextMath.ToString();
            }
            //-------------------------------------

            else if(v.Id==Resource.Id.btnMod)
            {
                if (screenTextMath.Length == 0)
                    screenTextMath = new StringBuilder("0");
                screenTextMath = new StringBuilder("(" + screenTextMath +")%");
                screenMath.Text = screenTextMath.ToString();
                if (checkSubmit == 0)
                    Submit(elementMath);
                textMath = new StringBuilder(textAns + "/100");
                Submit(elementMath);
            }
            else if (v.Id == Resource.Id.btnInverse)
            {
                if (screenTextMath.Length == 0)
                    screenTextMath = new StringBuilder("0");
                screenTextMath = new StringBuilder("1/("+screenTextMath+")");
                screenMath.Text = screenTextMath.ToString();
                if (checkSubmit == 0)
                    Submit(elementMath);
                textMath = new StringBuilder("1/"+textAns);
                Submit(elementMath);
            }
            else if (v.Id == Resource.Id.btnEqual)
            {
                Submit(elementMath);
            }
            else if (v.Id == Resource.Id.btnClear)
            {
                textMath = new StringBuilder("");
                screenTextMath = new StringBuilder("");
                textAns = new StringBuilder("0");
                screenAns.Text = textAns.ToString();
                screenMath.Text = "|";

            }

            else if (v.Id == Resource.Id.btnBackSpace)
            {
                if (screenTextMath.Length > 0)
                {
                    char c = textMath[textMath.Length - 1];
                    if(textMath.Length > 1 && c =='(' && textMath[textMath.Length-2] == '^')
                    {
                        screenTextMath = new StringBuilder(screenTextMath.ToString().Substring(0, screenTextMath.Length - 2));
                        textMath = new StringBuilder(textMath.ToString().Substring(0, textMath.Length - 2));
                    }
                    else if(textMath.Length > 1 && c=='(' && textMath[textMath.Length-2] == 's' || textMath[textMath.Length - 2] == 'c' || textMath[textMath.Length - 2] == 't')
                    {
                        textMath = new StringBuilder(textMath.ToString().Substring(0, screenTextMath.Length - 4));
                        screenTextMath = new StringBuilder(screenTextMath.ToString().Substring(0, screenTextMath.Length - 4));
                    }
                    else
                    {
                        textMath = new StringBuilder(textMath.ToString().Substring(0, screenTextMath.Length - 1));
                        screenTextMath = new StringBuilder(screenTextMath.ToString().Substring(0, screenTextMath.Length - 1));
                    }

                }
                screenMath.Text = screenTextMath.ToString();

            }
        }


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            CalligraphyConfig.InitDefault(new CalligraphyConfig.Builder()
                .SetDefaultFontPath("lato.ttf")
                .SetFontAttrId(Resource.Attribute.fontPath)
                .Build());

            SetContentView(Resource.Layout.calculator_);

            // Control
            screenAns = FindViewById<TextView>(Resource.Id.txtResult);
            screenMath = FindViewById<TextView>(Resource.Id.txtCal);

            btn0 = FindViewById<Button>(Resource.Id.btn0);
            btn0.SetOnClickListener(this);

            btn1 = FindViewById<Button>(Resource.Id.btn1);
            btn1.SetOnClickListener(this);

            btn2 = FindViewById<Button>(Resource.Id.btn2);
            btn2.SetOnClickListener(this);

            btn3 = FindViewById<Button>(Resource.Id.btn3);
            btn3.SetOnClickListener(this);

            btn4 = FindViewById<Button>(Resource.Id.btn4);
            btn4.SetOnClickListener(this);

            btn5 = FindViewById<Button>(Resource.Id.btn5);
            btn5.SetOnClickListener(this);

            btn6 = FindViewById<Button>(Resource.Id.btn6);
            btn6.SetOnClickListener(this);

            btn7 = FindViewById<Button>(Resource.Id.btn7);
            btn7.SetOnClickListener(this);

            btn8 = FindViewById<Button>(Resource.Id.btn8);
            btn8.SetOnClickListener(this);

            btn9 = FindViewById<Button>(Resource.Id.btn9);
            btn9.SetOnClickListener(this);

            btnSin = FindViewById<Button>(Resource.Id.btnSin);
            btnSin.SetOnClickListener(this);

            btnCos = FindViewById<Button>(Resource.Id.btnCos);
            btnCos.SetOnClickListener(this);

            btnTan = FindViewById<Button>(Resource.Id.btnTan);
            btnTan.SetOnClickListener(this);

            btnFactorial = FindViewById<Button>(Resource.Id.btnFactorial);
            btnFactorial.SetOnClickListener(this);

            btnPow = FindViewById<Button>(Resource.Id.btnPow);
            btnPow.SetOnClickListener(this);

            btnClear = FindViewById<Button>(Resource.Id.btnClear);
            btnClear.SetOnClickListener(this);

            btnBackSpace = FindViewById<Button>(Resource.Id.btnBackSpace);
            btnBackSpace.SetOnClickListener(this);

            btnOpen = FindViewById<Button>(Resource.Id.btnOpen);
            btnOpen.SetOnClickListener(this);


            btnClose = FindViewById<Button>(Resource.Id.btnClose);
            btnClose.SetOnClickListener(this);

            btnSqrt = FindViewById<Button>(Resource.Id.btnSqrt);
            btnSqrt.SetOnClickListener(this);

            btnMod = FindViewById<Button>(Resource.Id.btnMod);
            btnMod.SetOnClickListener(this);

            btnDiv = FindViewById<Button>(Resource.Id.btndiv);
            btnDiv.SetOnClickListener(this);

            btnMulti = FindViewById<Button>(Resource.Id.btnmulti);
            btnMulti.SetOnClickListener(this);

            btnPi = FindViewById<Button>(Resource.Id.btnPi);
            btnPi.SetOnClickListener(this);

            btnInverse = FindViewById<Button>(Resource.Id.btnInverse);
            btnInverse.SetOnClickListener(this);

            btnMinus = FindViewById<Button>(Resource.Id.btnSub);
            btnMinus.SetOnClickListener(this);

            btnMinus = FindViewById<Button>(Resource.Id.btnSin);
            btnSin.SetOnClickListener(this);

            btnAdd = FindViewById<Button>(Resource.Id.btnAdd);
            btnAdd.SetOnClickListener(this);

            btnResult = FindViewById<Button>(Resource.Id.btnEqual);
            btnResult.SetOnClickListener(this);

        }

        public void Error()
        {
            screenAns.Text = "Math Error !";
            textAns = new StringBuilder("");
            textMath = new StringBuilder("");
            screenTextMath = new StringBuilder("");

        }

        public void Submit(string[] elementMath)
        {
            InfixToPostfix ITP = new InfixToPostfix();
            if (textMath.Length > 0)
            {
                try
                {
                    if (!ITP.check_error)
                        elementMath = ITP.ProcessString(textMath.ToString());
                    if (!ITP.check_error)
                        elementMath = ITP.PostFix(elementMath);
                    if (!ITP.check_error)
                        textAns = new StringBuilder(ITP.ValueMath(elementMath));
                    screenAns.Text = textAns.ToString();
                    screenTextMath = new StringBuilder();
                    textMath = new StringBuilder();
                    checkSubmit = 1;
                }
                catch (Exception ex)
                {
                    Error();
                }
                if (ITP.check_error)
                    Error();


            }
        }


    }
}

