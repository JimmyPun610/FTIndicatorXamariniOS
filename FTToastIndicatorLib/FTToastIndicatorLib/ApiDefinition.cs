using CoreGraphics;
using Foundation;
using UIKit;

namespace FTToastIndicatorLib
{
	// @interface FTToastIndicator : NSObject
	[BaseType(typeof(NSObject))]
	interface FTToastIndicator
	{
		// +(void)setToastIndicatorStyleToDefaultStyle;
		[Static]
		[Export("setToastIndicatorStyleToDefaultStyle")]
		void SetToastIndicatorStyleToDefaultStyle();

		// +(void)setToastIndicatorStyle:(UIBlurEffectStyle)style;
		[Static]
		[Export("setToastIndicatorStyle:")]
		void SetToastIndicatorStyle(UIBlurEffectStyle style);

		// +(void)showToastMessage:(NSString *)toastMessage;
		[Static]
		[Export("showToastMessage:")]
		void ShowToastMessage(string toastMessage);

		// +(void)dismiss;
		[Static]
		[Export("dismiss")]
		void Dismiss();
	}

	// @interface FTToastIndicatorView : UIVisualEffectView
	[BaseType(typeof(UIVisualEffectView))]
	interface FTToastIndicatorView
	{
		// -(void)showToastMessage:(NSString *)toastMessage withStyle:(UIBlurEffectStyle)style;
		[Export("showToastMessage:withStyle:")]
		void ShowToastMessage(string toastMessage, UIBlurEffectStyle style);

		// -(CGSize)getFrameForToastViewWithMessage:(NSString *)toastMessage;
		[Export("getFrameForToastViewWithMessage:")]
		CGSize GetFrameForToastViewWithMessage(string toastMessage);
	}
}
