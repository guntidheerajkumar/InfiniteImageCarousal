using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace InfiniteCarousal
{
	// @protocol SRInfiniteCarouselViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface SRInfiniteCarouselViewDelegate
	{
		// @optional -(void)infiniteCarouselViewDidTapImageAtIndex:(NSInteger)index;
		[Export("infiniteCarouselViewDidTapImageAtIndex:")]
		void InfiniteCarouselViewDidTapImageAtIndex(nint index);
	}

	// @interface SRInfiniteCarouselView : UIView
	[BaseType(typeof(UIView))]
	interface SRInfiniteCarouselView
	{
		// @property (assign, nonatomic) NSTimeInterval timeInterval;
		[Export("timeInterval")]
		double TimeInterval { get; set; }

		// @property (nonatomic, strong) UIColor * currentPageIndicatorTintColor;
		[Export("currentPageIndicatorTintColor", ArgumentSemantic.Strong)]
		UIColor CurrentPageIndicatorTintColor { get; set; }

		// @property (nonatomic, strong) UIColor * pageIndicatorTintColor;
		[Export("pageIndicatorTintColor", ArgumentSemantic.Strong)]
		UIColor PageIndicatorTintColor { get; set; }

		// @property (nonatomic, strong) UIImage * currentPageIndicatorImage;
		[Export("currentPageIndicatorImage", ArgumentSemantic.Strong)]
		UIImage CurrentPageIndicatorImage { get; set; }

		// @property (nonatomic, strong) UIImage * pageIndicatorImage;
		[Export("pageIndicatorImage", ArgumentSemantic.Strong)]
		UIImage PageIndicatorImage { get; set; }

		[Wrap("WeakDelegate")]
		SRInfiniteCarouselViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<SRInfiniteCarouselViewDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// +(instancetype)sr_infiniteCarouselViewWithImageArrary:(NSArray *)imageArrary;
		[Static]
		[Export("sr_infiniteCarouselViewWithImageArrary:")]
		SRInfiniteCarouselView Sr_infiniteCarouselViewWithImageArrary(NSObject[] imageArrary);

		// +(instancetype)sr_infiniteCarouselViewWithImageArrary:(NSArray *)imageArrary describeArray:(NSArray *)describeArray;
		[Static]
		[Export("sr_infiniteCarouselViewWithImageArrary:describeArray:")]
		SRInfiniteCarouselView Sr_infiniteCarouselViewWithImageArrary(NSObject[] imageArrary, NSObject[] describeArray);

		// +(instancetype)sr_infiniteCarouselViewWithImageArrary:(NSArray *)imageArrary describeArray:(NSArray *)describeArray placeholderImage:(UIImage *)placeholderImage;
		[Static]
		[Export("sr_infiniteCarouselViewWithImageArrary:describeArray:placeholderImage:")]
		SRInfiniteCarouselView Sr_infiniteCarouselViewWithImageArrary(NSObject[] imageArrary, NSObject[] describeArray, UIImage placeholderImage);

		// +(instancetype)sr_infiniteCarouselViewWithImageArrary:(NSArray *)imageArrary describeArray:(NSArray *)describeArray placeholderImage:(UIImage *)placeholderImage delegate:(id<SRInfiniteCarouselViewDelegate>)delegate;
		[Static]
		[Export("sr_infiniteCarouselViewWithImageArrary:describeArray:placeholderImage:delegate:")]
		SRInfiniteCarouselView Sr_infiniteCarouselViewWithImageArrary(NSObject[] imageArrary, NSObject[] describeArray, UIImage placeholderImage, SRInfiniteCarouselViewDelegate @delegate);

		// -(instancetype)initWithImageArrary:(NSArray *)imageArrary;
		[Export("initWithImageArrary:")]
		IntPtr Constructor(NSObject[] imageArrary);

		// -(instancetype)initWithImageArrary:(NSArray *)imageArrary describeArray:(NSArray *)describeArray;
		[Export("initWithImageArrary:describeArray:")]
		IntPtr Constructor(NSObject[] imageArrary, NSObject[] describeArray);

		// -(instancetype)initWithImageArrary:(NSArray *)imageArrary describeArray:(NSArray *)describeArray placeholderImage:(UIImage *)placeholderImage;
		[Export("initWithImageArrary:describeArray:placeholderImage:")]
		IntPtr Constructor(NSObject[] imageArrary, NSObject[] describeArray, UIImage placeholderImage);

		// -(instancetype)initWithImageArrary:(NSArray *)imageArrary describeArray:(NSArray *)describeArray placeholderImage:(UIImage *)placeholderImage delegate:(id<SRInfiniteCarouselViewDelegate>)delegate;
		[Export("initWithImageArrary:describeArray:placeholderImage:delegate:")]
		IntPtr Constructor(NSObject[] imageArrary, NSObject[] describeArray, UIImage placeholderImage, SRInfiniteCarouselViewDelegate @delegate);

		// -(void)clearImagesCache;
		[Export("clearImagesCache")]
		void ClearImagesCache();
	}
}
