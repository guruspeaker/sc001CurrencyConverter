// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace sc001CurrencyConverter.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIButton Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblResults { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtDollar { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Button != null) {
                Button.Dispose ();
                Button = null;
            }

            if (lblResults != null) {
                lblResults.Dispose ();
                lblResults = null;
            }

            if (txtDollar != null) {
                txtDollar.Dispose ();
                txtDollar = null;
            }
        }
    }
}