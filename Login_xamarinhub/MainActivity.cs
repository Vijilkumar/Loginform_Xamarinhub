using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Threading;
using Android.Graphics;

namespace Login_xamarinhub
{
    
    [Activity(Label = "Login_xamarinhub", MainLauncher = true, Icon = "@drawable/icon",Theme = "@android:style/Theme.Material.Light")]
    public class MainActivity : Activity
    {

        private Button btnsignin;
        
        private EditText edtemail, edtnumber;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            btnsignin = (Button)FindViewById(Resource.Id.btnsign);
            edtemail = (EditText)FindViewById(Resource.Id.txtemail);
            edtnumber = (EditText)FindViewById(Resource.Id.txtnumber);
            // Get our button from the layout resource,
            // and attach an event to it
            edtemail.TextChanged += Edtemail_TextChanged;
            edtnumber.TextChanged += Edtnumber_TextChanged;
            btnsignin.Click += Btnsignin_Click1;


        }

        private void Edtnumber_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            if (edtnumber.Text.Length <= 0)
            {
                RunOnUiThread(() => {
                    edtnumber.Hint = "Required...";

                });
            }
        }

        private void Edtemail_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            if (edtemail.Text.Length <= 0)
            {
                RunOnUiThread(() => {
                    edtemail.Hint = "Required...";

                });
            }
        }

        private void Btnsignin_Click1(object sender, EventArgs e)
        {
            if((edtemail.Text.Length !=0 )&&(edtnumber.Text.Length !=0))
            { 
            Toast.MakeText(this, "Login Success", ToastLength.Long).Show();
            }
        }

        
    }
}

