// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace HexRGB
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel BlueValueLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ColourView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ConvertButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel GreenValueLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField HexValueTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel RedValueLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (BlueValueLabel != null) {
                BlueValueLabel.Dispose ();
                BlueValueLabel = null;
            }

            if (ColourView != null) {
                ColourView.Dispose ();
                ColourView = null;
            }

            if (ConvertButton != null) {
                ConvertButton.Dispose ();
                ConvertButton = null;
            }

            if (GreenValueLabel != null) {
                GreenValueLabel.Dispose ();
                GreenValueLabel = null;
            }

            if (HexValueTextField != null) {
                HexValueTextField.Dispose ();
                HexValueTextField = null;
            }

            if (RedValueLabel != null) {
                RedValueLabel.Dispose ();
                RedValueLabel = null;
            }
        }
    }
}