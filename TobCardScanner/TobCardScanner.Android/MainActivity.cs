using Android.App;
using Android.Views;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V4.Widget;
using Android.Content.Res;
using Android.Support.V7.Widget;

namespace TobCardScanner.Droid
{
    [Activity(Label = "TobCardScanner.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : AppCompatActivity
    {
        private DrawerLayout _drawerLayout;
        private ActionBarDrawerToggle _actionBar;
        private Toolbar _toolbar;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            InitInstance();

            if (bundle == null)
            {
                SupportFragmentManager.BeginTransaction()
                    .Add(Resource.Id.contentContainer, MainFragment.NewInstance(0))
                    .Commit();
            }
        }

        private void InitInstance()
        {
            _toolbar = FindViewById<Toolbar>(Resource.Id.actionBar);
            SetSupportActionBar(_toolbar);

            _drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawerLayout);
            _actionBar = new ActionBarDrawerToggle(this, _drawerLayout, Resource.String.open_drawer, Resource.String.close_drawer);
            _drawerLayout.AddDrawerListener(_actionBar);
            SupportActionBar.SetHomeButtonEnabled(true);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
        }

        protected override void OnPostCreate(Bundle savedInstanceState)
        {
            base.OnPostCreate(savedInstanceState);
            _actionBar.SyncState();
        }

        public override void OnConfigurationChanged(Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);
            _actionBar.OnConfigurationChanged(newConfig);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (_actionBar.OnOptionsItemSelected(item))
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }
    }
}


