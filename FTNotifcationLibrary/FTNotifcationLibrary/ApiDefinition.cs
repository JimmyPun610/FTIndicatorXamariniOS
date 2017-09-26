using CoreGraphics;
using Foundation;
using UIKit;


namespace FTNotificationLibrary
{
	// typedef void (^FTNotificationTapHandler)();
	delegate void FTNotificationTapHandler();

	// typedef void (^FTNotificationCompletion)();
	delegate void FTNotificationCompletion();

	// @interface FTNotificationIndicator : NSObject
	[BaseType(typeof(NSObject))]
	interface FTNotificationIndicator
	{
		// +(void)setNotificationIndicatorStyleToDefaultStyle;
		[Static]
		[Export("setNotificationIndicatorStyleToDefaultStyle")]
		void SetNotificationIndicatorStyleToDefaultStyle();

		// +(void)setNotificationIndicatorStyle:(UIBlurEffectStyle)style;
		[Static]
		[Export("setNotificationIndicatorStyle:")]
		void SetNotificationIndicatorStyle(UIBlurEffectStyle style);

		// +(void)showNotificationWithTitle:(NSString *)title message:(NSString *)message;
		[Static]
		[Export("showNotificationWithTitle:message:")]
		void ShowNotificationWithTitle(string title, string message);

		// +(void)showNotificationWithTitle:(NSString *)title message:(NSString *)message tapHandler:(FTNotificationTapHandler)tapHandler;
		[Static]
		[Export("showNotificationWithTitle:message:tapHandler:")]
		void ShowNotificationWithTitle(string title, string message, FTNotificationTapHandler tapHandler);

		// +(void)showNotificationWithTitle:(NSString *)title message:(NSString *)message tapHandler:(FTNotificationTapHandler)tapHandler completion:(FTNotificationCompletion)completion;
		[Static]
		[Export("showNotificationWithTitle:message:tapHandler:completion:")]
		void ShowNotificationWithTitle(string title, string message, FTNotificationTapHandler tapHandler, FTNotificationCompletion completion);

		// +(void)showNotificationWithImage:(UIImage *)image title:(NSString *)title message:(NSString *)message;
		[Static]
		[Export("showNotificationWithImage:title:message:")]
		void ShowNotificationWithImage(UIImage image, string title, string message);

		// +(void)showNotificationWithImage:(UIImage *)image title:(NSString *)title message:(NSString *)message tapHandler:(FTNotificationTapHandler)tapHandler;
		[Static]
		[Export("showNotificationWithImage:title:message:tapHandler:")]
		void ShowNotificationWithImage(UIImage image, string title, string message, FTNotificationTapHandler tapHandler);

		// +(void)showNotificationWithImage:(UIImage *)image title:(NSString *)title message:(NSString *)message tapHandler:(FTNotificationTapHandler)tapHandler completion:(FTNotificationCompletion)completion;
		[Static]
		[Export("showNotificationWithImage:title:message:tapHandler:completion:")]
		void ShowNotificationWithImage(UIImage image, string title, string message, FTNotificationTapHandler tapHandler, FTNotificationCompletion completion);

		// +(void)showNotificationWithImage:(UIImage *)image title:(NSString *)title message:(NSString *)message autoDismiss:(BOOL)autoDismiss tapHandler:(FTNotificationTapHandler)tapHandler completion:(FTNotificationCompletion)completion;
		[Static]
		[Export("showNotificationWithImage:title:message:autoDismiss:tapHandler:completion:")]
		void ShowNotificationWithImage(UIImage image, string title, string message, bool autoDismiss, FTNotificationTapHandler tapHandler, FTNotificationCompletion completion);

		// +(void)dismiss;
		[Static]
		[Export("dismiss")]
		void Dismiss();
	}

	// @interface FTNotificationIndicatorView : UIVisualEffectView
	[BaseType(typeof(UIVisualEffectView))]
	interface FTNotificationIndicatorView
	{
		// -(void)showWithImage:(UIImage *)image title:(NSString *)title message:(NSString *)message style:(UIBlurEffectStyle)style;
		[Export("showWithImage:title:message:style:")]
		void ShowWithImage(UIImage image, string title, string message, UIBlurEffectStyle style);

		// -(CGSize)getFrameForNotificationViewWithImage:(UIImage *)image message:(NSString *)notificationMessage;
		[Export("getFrameForNotificationViewWithImage:message:")]
		CGSize GetFrameForNotificationViewWithImage(UIImage image, string notificationMessage);
	}
}



