
using Android.Support.V4.App;
using Android.OS;
using Android.Views;

namespace TobCardScanner.Droid
{
    public class MainFragment : Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View rootView = inflater.Inflate(Resource.Layout.fragment_main, container, false);
            InitInstance(rootView);
            return rootView;
        }

        private void InitInstance(View rootView)
        {
            // init instance with rootView.findViewById here
        }

        public static MainFragment NewInstance(int someVar)
        {
            MainFragment fragment = new MainFragment();
            Bundle args = new Bundle();
            args.PutInt("someVar", someVar);
            fragment.Arguments = args;
            return fragment;
        }

        private int _someVar;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            _someVar = Arguments.GetInt("someVar");
        }
    }
}