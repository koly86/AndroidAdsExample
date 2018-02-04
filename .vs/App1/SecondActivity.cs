using Android.App;
using Android.OS;

namespace App1
{
    [Activity(Label = "@string/second_activity_title", ParentActivity = typeof(MainActivity))]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.second_activity);
        }
    }
}