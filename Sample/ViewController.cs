using System;
using InfiniteCarousal;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Sample
{
	public partial class ViewController : UIViewController, ISRInfiniteCarouselViewDelegate
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var imageArray = new UIImage[] { UIImage.FromBundle("coldplay01"), UIImage.FromBundle("coldplay02"),
				UIImage.FromBundle("coldplay03"), UIImage.FromBundle("coldplay04")};

			this.EdgesForExtendedLayout = UIRectEdge.None;

			var infiniteCarouselView = new SRInfiniteCarouselView(imageArray);

			infiniteCarouselView.Delegate = new ImageDelegate();
			infiniteCarouselView.TimeInterval = 3f;
			infiniteCarouselView.CurrentPageIndicatorTintColor = UIColor.Red;
			infiniteCarouselView.PageIndicatorTintColor = UIColor.Black;
			infiniteCarouselView.Frame = new CGRect(0, 0, this.View.Frame.Width, 200);
			this.View.AddSubview(infiniteCarouselView);

		}
	}

	public class ImageDelegate : SRInfiniteCarouselViewDelegate
	{
		public override void InfiniteCarouselViewDidTapImageAtIndex(nint index)
		{

		}
	}
}
