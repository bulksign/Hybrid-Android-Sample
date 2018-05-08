using Android.App;
using Android.OS;
using Android.Webkit;
using Android.Widget;

namespace Bulksign {
	[Activity (Label = "Bulksign", MainLauncher = true)]
	public class MainActivity : Activity {
		protected override void OnCreate (Bundle savedInstanceState) {
			base.OnCreate (savedInstanceState);

			//determine if we have a parameter
			string data = Intent?.Data?.EncodedAuthority;

			if (string.IsNullOrEmpty (data)) {
				SigningSettings.GoToUrl = SigningSettings.AccessCodeUrl;
			} else {
				SigningSettings.GoToUrl = data;
				SigningSettings.GoToUrl = SigningSettings.AccessCodeEnterUrl;
			}

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			WebView view = FindViewById<WebView> (Resource.Id.webView);

			view.LoadUrl (SigningSettings.GoToUrl);
		}
	}
}