using System;

using UIKit;

namespace HexRGB
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            ConvertButton.TouchUpInside += ConvertButton_TouchUpInside;
        }

        void ConvertButton_TouchUpInside(object sender, EventArgs e)
        {
            string hexValue = HexValueTextField.Text;
            string RedHexValue = hexValue.Substring (0, 2);
            string GreenHexValue = hexValue.Substring (2, 2);
            string BlueHexValue = hexValue.Substring (4, 2);

            int RedValue = int.Parse(RedHexValue, System.Globalization.NumberStyles.HexNumber);
            int GreenValue = int.Parse(GreenHexValue, System.Globalization.NumberStyles.HexNumber);
            int BlueValue = int.Parse(BlueHexValue, System.Globalization.NumberStyles.HexNumber);

            RedValueLabel.Text = RedValue.ToString();
            GreenValueLabel.Text = GreenValue.ToString();
            BlueValueLabel.Text = BlueValue.ToString();

            ColourView.BackgroundColor = UIColor.FromRGB(RedValue, GreenValue, BlueValue);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
