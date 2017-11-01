using System;

using UIKit;

namespace sc001CurrencyConverter.iOS
{
    public partial class ViewController : UIViewController
    {
        

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib

            Button.AccessibilityIdentifier = "myButton";
            Button.TouchUpInside += delegate
            {



                // if anything entered, do something else do nothing
                /*     if (txtDollar.Text.Length < 1)
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
                             var alert = UIAlertController.Create("Warning!", "Please enter a dollar amount!", UIAlertControllerStyle.Alert);
                             alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Cancel, null));
                             PresentViewController(alert, animated: true, completionHandler: null);
                             Console.WriteLine("Error in conversion" + e.Message);
                         }




                     }

                     // var title = string.Format("{0} clicks!", count++);
                     // Button.SetTitle(title, UIControlState.Normal);
                 */
                var convert = new CommonCurrencyConverter(txtDollar.Text);
                var result = convert.ConvertCurrency();
                lblResults.Text = result;
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }
    }
}
