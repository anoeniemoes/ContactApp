using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Foundation;
using UIKit;

namespace ContactApp.iOS
{

    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            string fileName = "contacts_db.sqlite";
            string fileLocation = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "..", "Library");
            string full_path = Path.Combine(fileLocation, fileName);

            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App(full_path));

            return base.FinishedLaunching(app, options);
        }
    }
}
