using Android.App;
using Android.OS;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;

namespace gmaps_tutorial
{
    [Activity(Label = "gmaps_tutorial", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity, IOnMapReadyCallback
    {
        private GoogleMap mMap;
        protected MapFragment _myMapFragment;
        public void OnMapReady(GoogleMap googleMap)
        {
            mMap = googleMap;
            // Add a marker in Sydney and move the camera
            LatLng sydney = new LatLng(-34, 151);
            mMap.AddMarker(new MarkerOptions().SetPosition(sydney).SetTitle("Marker in Sydney"));
            mMap.MoveCamera(CameraUpdateFactory.NewLatLng(sydney));
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);


            MapFragment mapFragment = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.map);
            mapFragment.GetMapAsync(this);
            SetUpMap();

            //GoogleMapOptions mapOptions = new GoogleMapOptions()
            //    .InvokeMapType(GoogleMap.MapTypeSatellite)
            //    .InvokeZoomControlsEnabled(false)
            //    .InvokeCompassEnabled(true);

            //FragmentTransaction tx = FragmentManager.BeginTransaction();
            //_myMapFragment = MapFragment.NewInstance(mapOptions);
            //tx.Add(Resource.Id.map, _myMapFragment, "map");
            //tx.Commit();

            //MapFragment mapFrag = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.map);
            //GoogleMap map = mapFrag.Map;
            //if (map != null)
            //{
            //    map.UiSettings.ZoomControlsEnabled = true;
            //    map.UiSettings.CompassEnabled = true;
            //}
        }

        private void SetUpMap()
        {
            if (mMap == null)
            {
                FragmentManager.FindFragmentById<MapFragment>(Resource.Id.map).GetMapAsync(this);
            }
        }
    }
}

