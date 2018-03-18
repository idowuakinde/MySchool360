using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Webkit;

namespace MySchool360
{
	[Activity (Label = "MySchool360 - Welcome", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			TextView txtWelcome = FindViewById<TextView> (Resource.Id.main_txtWelcome);
			txtWelcome.Text = GetString (Resource.String.hello);

			// Get our gridview from the layout resource,
			// and attach an event to it		
			var gridview = FindViewById<GridView> (Resource.Id.main_gvLogos);
			gridview.Adapter = new ImageAdapter (this);
			gridview.ItemClick += delegate (object sender, Android.Widget.AdapterView.ItemClickEventArgs args) {
				//Toast.MakeText (this, args.Position.ToString (), ToastLength.Short).Show ();
				var t = args.Position;
				//Android.Widget.Toast.MakeText(this, t.ToString, ToastLength.Short).Show();
				switch (t)
				{
					case 0:       
						var moveToChildville = new Intent (this, typeof(SchoolPortalActivity));
						moveToChildville.PutExtra ("goTo", "http://childville.myschool360.info");
						StartActivity (moveToChildville);
						break;
					case 1:
						var moveToOxbridge = new Intent (this, typeof(SchoolPortalActivity));
						moveToOxbridge.PutExtra ("goTo", "http://oxbridge.myschool360.info");
						StartActivity (moveToOxbridge);
						break;
					case 2:
						var moveToInfantJesus = new Intent (this, typeof(SchoolPortalActivity));
						moveToInfantJesus.PutExtra ("goTo", "http://infantjesus.myschool360.info");
						StartActivity (moveToInfantJesus);
						break;
					case 3:
						var moveToEdgewood = new Intent (this, typeof(SchoolPortalActivity));
						moveToEdgewood.PutExtra ("goTo", "http://edgewood.myschool360.info");
						StartActivity (moveToEdgewood);
						break;
					case 4:
						var moveToCTC = new Intent (this, typeof(SchoolPortalActivity));
						moveToCTC.PutExtra ("goTo", "http://ctc.myschool360.info");
						StartActivity (moveToCTC);
						break;
					case 5:
						var moveToDowen = new Intent (this, typeof(SchoolPortalActivity));
						moveToDowen.PutExtra ("goTo", "http://dowen.myschool360.info");
						StartActivity (moveToDowen);
						break;
					case 6:
						var moveToTopGrade = new Intent (this, typeof(SchoolPortalActivity));
						moveToTopGrade.PutExtra ("goTo", "http://topgrade.myschool360.info");
						StartActivity (moveToTopGrade);
						break;
					case 7:
						var moveToDIvy = new Intent (this, typeof(SchoolPortalActivity));
						moveToDIvy.PutExtra ("goTo", "http://divy.myschool360.info");
						StartActivity (moveToDIvy);
						break;
					default:
						break;
				}
			};
		}
	}
	public class MySchool360WebViewClient : WebViewClient
	{
		public override bool ShouldOverrideUrlLoading (WebView view, string url)
		{
			view.LoadUrl (url);
			return true;
		}
	}
}
