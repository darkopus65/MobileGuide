using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Foundation;
using UIKit;

using Microsoft.WindowsAzure.MobileServices;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace MobileGuide.iOS
{
	[Register ("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// Initialize Azure Mobile Apps
			//CurrentPlatform.Init();

			// Initialize Xamarin Forms
			//Forms.Init();
            global::Xamarin.Forms.Forms.Init();
			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}

