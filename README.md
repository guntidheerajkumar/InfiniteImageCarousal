#Infinite Image Carousal

###Usage
```
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
```

###Image Delegate
```
public class ImageDelegate : SRInfiniteCarouselViewDelegate
{
	public override void InfiniteCarouselViewDidTapImageAtIndex(nint index)
	{

	}
}
```

###Output
![](https://github.com/guntidheerajkumar/InfiniteImageCarousal/blob/master/Output.gif)
