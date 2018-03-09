using System;
using System.ComponentModel;
using Foundation;
using UIKit;
using CoreGraphics;

namespace PetraDemo
{
    [Register("XamarinView")]
    public class XamarinView : UIView
    {
        ArtboardXamarin xamarinArtboard;
        public XamarinView(IntPtr handle) : base(handle)
        {
            Setup();
        }
        public XamarinView()
        {
            Setup();
        }

        private void Setup()
        {
            xamarinArtboard = new ArtboardXamarin();
        }

        public override void TouchesEnded(NSSet touches, UIEvent evt)
        {
            base.TouchesEnded(touches, evt);
            xamarinArtboard.Active = !xamarinArtboard.Active;
            this.SetNeedsDisplay();
        }

        public override void Draw(CGRect rect)
        {
            base.Draw(rect);
            xamarinArtboard.DrawArtboardXamarin(rect, ArtboardXamarin.ArtboardXamarinFillMode.ArtboardXamarinFit);
        }
    }
}
