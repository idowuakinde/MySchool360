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
	[Activity (Label = "MySchool360 - Please log in")]			
	public class SchoolPortalActivity : Activity
	{
		WebView _webview;
		string portalUrl;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.SchoolPortalLayout);

			portalUrl = Intent.GetStringExtra ("goTo");

			// display the URL at the top of this page for informational purposes
			TextView txtPortalUrl = FindViewById<TextView> (Resource.Id.sch_textView1);
			txtPortalUrl.Text = portalUrl;

			// animate the WebView control
			_webview = FindViewById<WebView> (Resource.Id.sch_webView1);
			_webview.SetWebViewClient (new MySchool360WebViewClient());
			// find a way to scale the page to fit
			_webview.Settings.LoadWithOverviewMode = true;
			_webview.Settings.UseWideViewPort = true;
			_webview.Settings.DefaultZoom = WebSettings.ZoomDensity.Far;
			_webview.Settings.SetSupportZoom(true);
			_webview.Settings.BuiltInZoomControls = true;
			// load the URL
			_webview.LoadUrl (portalUrl);
		}

		public override bool OnKeyDown(Android.Views.Keycode keyCode, Android.Views.KeyEvent e)
		{
			if (keyCode == Keycode.Back && _webview.CanGoBack ()) {
				_webview.GoBack ();
				return true;
			}
			return base.OnKeyDown (keyCode, e);
		}
	}
}
