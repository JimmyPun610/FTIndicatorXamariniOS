# FTIndicatorXamariniOS
This is FTIndicator for Xamarin iOS, only implemented Toast and in app notification

Based on FTIndicator :
https://github.com/liufengting/FTIndicator

Compile file:
Toast : https://github.com/JimmyPun610/FTIndicatorXamariniOS/blob/master/FTToastIndicatorLib/FTToastIndicatorLib.dll


In app notification : https://github.com/JimmyPun610/FTIndicatorXamariniOS/blob/master/FTNotifcationLibrary/FTNotifcationLibrary.dll

Usage:
1. Toast

```C#
FTToastIndicator.SetToastIndicatorStyle(UIBlurEffectStyle.Dark); //Change to Android style
FTToastIndicator.ShowToastMessage(message); //Show the message
```

2. In app notification
```C#
    FTNotificationIndicator.ShowNotificationWithImage(new UIImage("ImageName.png"), "Title", "Message", new FTNotificationTapHandler(()=>
                {
                    //Action when user tapped the notification
                }));
```
