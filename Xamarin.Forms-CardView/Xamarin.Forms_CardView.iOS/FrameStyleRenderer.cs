//using System;
//using UIKit;
//using CoreGraphics;
//using Xamarin.Forms;
//using Xamarin.Forms.Platform.iOS;
//using Xamarin.Forms_CardView;
//using Xamarin.Forms_CardView.iOS;

//[assembly: ExportRendererAttribute(typeof(Xamarin.Forms_CardView.RoundedFrame), typeof(FrameStyleRenderer))]

//namespace Xamarin.Forms_CardView.iOS
//{
//    public class FrameStyleRenderer : FrameRenderer
//    {
//        public FrameStyleRenderer()
//        {
//        }

//        public override void Draw(CGRect rect)
//        {
//            RoundedFrame rf = (RoundedFrame)this.Model;

//            using (var context = UIGraphics.GetCurrentContext())
//            {
//                context.SetFillColor(rf.Color.ToCGColor());
//                context.SetStrokeColor(rf.OutlineColor.ToCGColor());
//                context.SetLineWidth(5);

//                var rc = this.Bounds.Inset(5,5);

//                double radius = (double)rf.CornerRadius;
//                radius = Math.Max(0, Math.Min(radius, Math.Max(rc.Height / 2, rc.Width / 2)));

//                var path = CGPath.FromRoundedRect(rc, radius, radius);
//                context.AddPath(path);
//                context.DrawPath(CGPathDrawingMode.FillStroke);
//            }
//        }
//    }
//}
