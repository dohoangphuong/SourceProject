using Android.Util;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace XamForm
{
    class MapDemoPage: ContentPage
    {
        public MapDemoPage()
        {
            Label header = new Label
            {
                Text = "Map",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            View view;

            if (Device.OS != TargetPlatform.Android)
            {
                view = new Label
                {
                    Text = "Android applications require API key " +
                           "to use the Google Map service.",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                    VerticalOptions = LayoutOptions.CenterAndExpand
                };
            }
            else
            {
                Map map = new Map();
                view = map;
                Log.Debug("haihamho", view.ToString());
                // Let's visit Xamarin HQ in San Francisco!
                Position position = new Position(37.79762, -122.40181);
                map.MoveToRegion(new MapSpan(position, 0.01, 0.01));
                map.Pins.Add(new Pin
                {
                    Label = "Xamarin",
                    Position = position
                });
            }

            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    view
                }
            };
        }
    }
}
