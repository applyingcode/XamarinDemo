// +----------------------------------------------------+
// | Petra Plugin For Sketch                            |
// | Copyright(c) 2016 www.applyingcode.com             |
// +----------------------------------------------------+
// | Xamarin C# code for iOS                            |
// +----------------------------------------------------+
//   2/17/18 9:36:23 PM

using System;
using Foundation;
using UIKit;
using CoreGraphics;

namespace PetraDemo
{
    [Register("ArtboardXamarin")]
    public class ArtboardXamarin : NSObject
    {
        public bool Active
        {
            get;
            set;
        }

        public enum ArtboardXamarinFillMode
        {
            ArtboardXamarinFit,
            ArtboardXamarinFill,
            ArtboardXamarinStretch,
            ArtboardXamarinOriginal
        };

        ArtboardXamarinFillMode artboardXamarinFillMode;
        double artboardXamarinHeight;
        double artboardXamarinWidth;
        CGRect newArtboardSize;
        CGSize resizedScale;
        CGAffineTransform baseTransform;

        // Initialize defaults
        public ArtboardXamarin()
        {
            artboardXamarinWidth = 80.000000;
            artboardXamarinHeight = 80.000000;
            artboardXamarinFillMode = ArtboardXamarinFillMode.ArtboardXamarinFit;
            Active = true;
        }

        //
        // ArtboardXamarin
        //
        public void DrawArtboardXamarin(CGRect bounds, ArtboardXamarinFillMode fillMode)
        {
            CGContext context;

            // Get CGContext instance
            context = UIGraphics.GetCurrentContext();

            // Affine Transform
            baseTransform = CoreGraphics.CGAffineTransform.CGAffineTransformInvert(context.GetUserSpaceToDeviceSpaceTransform());

            // Save initial context state
            context.SaveState();

            // Initialize and set new artboard size (scaled)
            newArtboardSize = GetNewArtboardSize(fillMode, new CGRect(0.0, 0.0, 80.000000, 80.000000), new CGRect(bounds.Left, bounds.Top, bounds.Width, bounds.Height));
            context.TranslateCTM(newArtboardSize.X, newArtboardSize.Y);
            resizedScale = new CGSize(newArtboardSize.Width / 80.000000, newArtboardSize.Height / 80.000000);
            context.ScaleCTM(resizedScale.Width, resizedScale.Height);

            // Drawing procedures

            DrawShapeObjectLogo(context);

            // Restore initial context state
            context.RestoreState();

        }

        //
        // ShapeObjectLogo
        //
        private void DrawShapeObjectLogo(CGContext context)
        {
            UIBezierPath ShapeObjectLogo;

            // Shape Path
            ShapeObjectLogo = new UIBezierPath();
            ShapeObjectLogo.MoveTo(new CGPoint(21.640106, 0.000000));
            ShapeObjectLogo.AddCurveToPoint(new CGPoint(16.612139, 2.920175), new CGPoint(19.615119, 0.005031), new CGPoint(17.632132, 1.159215));
            ShapeObjectLogo.AddLineTo(new CGPoint(0.752245, 30.580328));
            ShapeObjectLogo.AddCurveToPoint(new CGPoint(0.752245, 36.419672), new CGPoint(-0.250748, 32.346320), new CGPoint(-0.250748, 34.654687));
            ShapeObjectLogo.AddLineTo(new CGPoint(16.612139, 64.080831));
            ShapeObjectLogo.AddCurveToPoint(new CGPoint(21.641106, 67.000000), new CGPoint(17.632132, 65.841791), new CGPoint(19.615119, 66.995975));
            ShapeObjectLogo.AddLineTo(new CGPoint(53.359894, 67.000000));
            ShapeObjectLogo.AddCurveToPoint(new CGPoint(58.387861, 64.080831), new CGPoint(55.384881, 66.995975), new CGPoint(57.367868, 65.841791));
            ShapeObjectLogo.AddLineTo(new CGPoint(74.247755, 36.419672));
            ShapeObjectLogo.AddCurveToPoint(new CGPoint(74.247755, 30.580328), new CGPoint(75.250748, 34.654687), new CGPoint(75.250748, 32.346320));
            ShapeObjectLogo.AddLineTo(new CGPoint(58.386861, 2.920175));
            ShapeObjectLogo.AddCurveToPoint(new CGPoint(53.359894, 0.000000), new CGPoint(57.367868, 1.159215), new CGPoint(55.384881, 0.004025));
            ShapeObjectLogo.AddLineTo(new CGPoint(21.640106, 0.000000));
            ShapeObjectLogo.ClosePath();
            ShapeObjectLogo.MoveTo(new CGPoint(21.640106, 0.000000));
            ShapeObjectLogo.MoveTo(new CGPoint(21.928104, 16.181713));
            ShapeObjectLogo.AddCurveToPoint(new CGPoint(22.061103, 16.181713), new CGPoint(21.972313, 16.176991), new CGPoint(22.016894, 16.176991));
            ShapeObjectLogo.AddLineTo(new CGPoint(27.532066, 16.181713));
            ShapeObjectLogo.AddCurveToPoint(new CGPoint(28.130062, 16.537930), new CGPoint(27.778919, 16.189389), new CGPoint(28.004637, 16.323845));
            ShapeObjectLogo.AddLineTo(new CGPoint(37.411001, 33.143280));
            ShapeObjectLogo.AddCurveToPoint(new CGPoint(37.500000, 33.410946), new CGPoint(37.458060, 33.225659), new CGPoint(37.488317, 33.316656));
            ShapeObjectLogo.AddCurveToPoint(new CGPoint(37.587999, 33.143280), new CGPoint(37.511374, 33.316728), new CGPoint(37.541289, 33.225734));
            ShapeObjectLogo.AddLineTo(new CGPoint(46.846938, 16.537930));
            ShapeObjectLogo.AddCurveToPoint(new CGPoint(47.466934, 16.181713), new CGPoint(46.977011, 16.317781), new CGPoint(47.212411, 16.182533));
            ShapeObjectLogo.AddLineTo(new CGPoint(52.936897, 16.181713));
            ShapeObjectLogo.AddCurveToPoint(new CGPoint(53.557893, 17.229233), new CGPoint(53.421894, 16.186744), new CGPoint(53.784891, 16.798552));
            ShapeObjectLogo.AddLineTo(new CGPoint(44.497953, 33.500503));
            ShapeObjectLogo.AddLineTo(new CGPoint(53.557893, 49.748630));
            ShapeObjectLogo.AddCurveToPoint(new CGPoint(52.937897, 50.818287), new CGPoint(53.806891, 50.181323), new CGPoint(53.434894, 50.823318));
            ShapeObjectLogo.AddLineTo(new CGPoint(47.466934, 50.818287));
            ShapeObjectLogo.AddCurveToPoint(new CGPoint(46.846938, 50.439932), new CGPoint(47.207875, 50.812898), new CGPoint(46.971429, 50.668606));
            ShapeObjectLogo.AddLineTo(new CGPoint(37.586999, 33.834582));
            ShapeObjectLogo.AddCurveToPoint(new CGPoint(37.500000, 33.566916), new CGPoint(37.540639, 33.752052), new CGPoint(37.511064, 33.661063));
            ShapeObjectLogo.AddCurveToPoint(new CGPoint(37.411001, 33.834582), new CGPoint(37.488317, 33.661206), new CGPoint(37.458060, 33.752204));
            ShapeObjectLogo.AddLineTo(new CGPoint(28.131062, 50.439932));
            ShapeObjectLogo.AddCurveToPoint(new CGPoint(27.532066, 50.818287), new CGPoint(28.010506, 50.662417), new CGPoint(27.783589, 50.805749));
            ShapeObjectLogo.AddLineTo(new CGPoint(22.062103, 50.818287));
            ShapeObjectLogo.AddCurveToPoint(new CGPoint(21.442107, 49.748630), new CGPoint(21.564106, 50.823318), new CGPoint(21.192109, 50.182329));
            ShapeObjectLogo.AddLineTo(new CGPoint(30.500047, 33.500503));
            ShapeObjectLogo.AddLineTo(new CGPoint(21.440107, 17.229233));
            ShapeObjectLogo.AddCurveToPoint(new CGPoint(21.927104, 16.181713), new CGPoint(21.223109, 16.836790), new CGPoint(21.488107, 16.265233));
            ShapeObjectLogo.AddLineTo(new CGPoint(21.928104, 16.181713));
            ShapeObjectLogo.ClosePath();
            ShapeObjectLogo.MoveTo(new CGPoint(21.928104, 16.181713));

            context.SaveState();
            context.TranslateCTM(3.000000f, 7.000000f);

            // Shape Outer Shadow
            context.SaveState();
            context.BeginPath();
            context.AddPath(ShapeObjectLogo.CGPath);
            context.AddRect(RectangleFExtensions.Inset(ShapeObjectLogo.Bounds, -1f, -2f));
            context.EOClip();
            context.TranslateCTM(-77f, 0f);
            GenerateShapeShadow(context, ShapeObjectLogo, 77f, 1f, 77f, 0, UIColor.FromHSBA(0.000000f, 0.000000f, 0.000000f, 0.500000f), 0f, 0, 0f, 0f);
            context.RestoreState();

            // Shape Fill
            context.SaveState();
            if (Active)
            {
                UIColor.FromHSBA(0.530476f, 0.849515f, 0.807843f, 1.000000f).SetFill();
            }
            else
            {
                UIColor.FromRGB(137, 137, 137).SetFill();
            }

            ShapeObjectLogo.Fill();
            context.RestoreState();

            context.RestoreState();

        }

        //
        // UIImage export
        //
        public UIImage GenerateArtboardXamarinBitmap()
        {
            UIGraphics.BeginImageContextWithOptions(new CGSize(artboardXamarinWidth, artboardXamarinHeight), false, 0);
            DrawArtboardXamarin(new CGRect(new CGPoint(0, 0), new CGSize(artboardXamarinWidth, artboardXamarinHeight)), artboardXamarinFillMode);
            UIImage nativeImage = UIGraphics.GetImageFromCurrentImageContext();
            UIGraphics.EndImageContext();

            return nativeImage;
        }

        //
        // Resizing logic for ArtboardXamarin
        //
        private CGRect GetNewArtboardSize(ArtboardXamarinFillMode fillMode, CGRect sourceRect, CGRect targetRect)
        {
            CGSize scales = new CGSize(0, 0);
            CGSize sizeZero = new CGSize(0, 0);
            CGRect rectZero = new CGRect(0, 0, 0, 0);


            if (sourceRect == targetRect || targetRect == rectZero)
            {
                return sourceRect;
            }
            else
            {
                scales = sizeZero;
                scales.Width = (nfloat)Math.Abs(targetRect.Width / sourceRect.Width);
                scales.Height = (nfloat)Math.Abs(targetRect.Height / sourceRect.Height);

                if (fillMode == ArtboardXamarinFillMode.ArtboardXamarinFit)
                {
                    scales.Width = (nfloat)Math.Min(scales.Width, scales.Height);
                    scales.Height = (nfloat)scales.Width;
                }
                else if (fillMode == ArtboardXamarinFillMode.ArtboardXamarinFill)
                {
                    scales.Width = (nfloat)Math.Max(scales.Width, scales.Height);
                    scales.Height = scales.Width;
                }
                else if (fillMode == ArtboardXamarinFillMode.ArtboardXamarinOriginal)
                {
                    scales.Width = 1;
                    scales.Height = 1;
                }

                if (sourceRect.Width < 0)
                {
                    sourceRect.X = sourceRect.X + sourceRect.Width;
                    sourceRect.Width = (nfloat)Math.Abs(sourceRect.Width);
                }
                if (sourceRect.Height < 0)
                {
                    sourceRect.Y = sourceRect.Y + sourceRect.Height;
                    sourceRect.Height = (nfloat)Math.Abs(sourceRect.Height);
                }

                nfloat newWidth = sourceRect.Width * scales.Width;
                nfloat newHeight = sourceRect.Height * scales.Height;
                nfloat newLeft = targetRect.X + (targetRect.Width - newWidth) / 2;
                nfloat newTop = targetRect.Y + (targetRect.Height - newHeight) / 2;

                return new CGRect(newLeft, newTop, newWidth, newHeight);
            }
        }

        //
        // Helper function to generate shadow
        //
        private void GenerateShapeShadow(CGContext context, UIBezierPath shapeObject, nfloat xOffset, nfloat yOffset, nfloat blurValue, CGBlendMode blendingMode, UIColor shadowColor, nfloat borderWidth, int borderPosition, nfloat iWidth, nfloat iHeight)
        {
            CGPoint basePoint;
            CGPoint offsetPoint;
            CGSize calculatedShadowOffset;
            nfloat calculatedShadowBlur;
            CGPoint constPointZero;

            constPointZero = new CGPoint(0, 0);

            basePoint = baseTransform.TransformPoint(context.PointToDeviceSpace(constPointZero));
            offsetPoint = baseTransform.TransformPoint(context.PointToDeviceSpace(new CGPoint(xOffset, yOffset)));
            calculatedShadowOffset = new CGSize(offsetPoint.X - basePoint.X, offsetPoint.Y - basePoint.Y);
            if (blurValue == 0)
            {
                calculatedShadowBlur = 0;
            }
            else
            {
                calculatedShadowBlur = Hypot(calculatedShadowOffset.Width, calculatedShadowOffset.Height) / blurValue;
            }
            context.SetShadow(calculatedShadowOffset, calculatedShadowBlur, shadowColor.CGColor);
            context.SetBlendMode(blendingMode);

            context.BeginTransparencyLayer(null);

            UIColor.Black.SetFill();
            shapeObject.Fill();

            if (borderWidth > 0)
            {
                if (borderPosition == 0)
                {
                    context.SaveState();
                    shapeObject.LineWidth = borderWidth;
                    UIColor.Black.SetStroke();
                    shapeObject.Stroke();
                    context.RestoreState();
                }

                if (borderPosition == 1)
                {
                    context.BeginPath();
                    context.AddPath(shapeObject.CGPath);
                    context.EOClip();
                }

                if (borderPosition == 2)
                {
                    context.BeginPath();
                    context.AddPath(shapeObject.CGPath);
                    context.AddRect(RectangleFExtensions.Inset(shapeObject.Bounds, iWidth, iHeight));
                    context.EOClip();
                }
            }

            context.EndTransparencyLayer();
        }

        //
        // Helper function to compute hypotenuse
        //
        private nfloat Hypot(nfloat a, nfloat b)
        {
            return (nfloat)Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }

    }
}
