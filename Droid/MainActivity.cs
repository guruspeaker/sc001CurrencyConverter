using Android.App;
using Android.Widget;
using Android.OS;

namespace sc001CurrencyConverter.Droid
{
    [Activity(Label = "sc001CurrencyConverter", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        //int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);
            txtDollar value = FindViewById<EditText>(Resources.Id.txtDollar);
            lblResults result = FindViewByID<TextView>(Resource.Id.lblResults);

            button.Click += delegate 
            { 
                /*
                if (txtDollar.Text.Length < 1)
                    return;
                else
                {
                    try
                    {
                        var results = Convert.ToDouble(txtDollar.Text) * 0.86;
                        lblResults.Text = "$" + txtDollar.Text + " = $eu" + results.ToString();
                    }
                    catch (Exception e)
                    {
                        //var alert = UIAlertController.Create("Warning!", "Please enter a dollar amount!", UIAlertControllerStyle.Alert);
                        //alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Cancel, null));
                        //PresentViewController(alert, animated: true, completionHandler: null);
                        //Console.WriteLine("Error in conversion" + e.Message);

                        Toast.makeText(this, "Please enter a number!", ToastLength.Long).Show();
                        txtDollar.Text = "";
                        lblResults.Text = "";
                        Console.WriteLine("Error in conversion" + e.Message);

                    }*/

                    var convert = new CommonCurrencyConverter(txtDollar.Text);
                    var result = convert.ConvertCurrency();
                    lblResults.Text = result;

                    //button.Text = $"{count++} clicks!"; 
            
            
            };
        }
    }
}

