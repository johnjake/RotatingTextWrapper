using Android.App;
using Android.Graphics;
using Android.OS;
using Com.Sdsmdg.Harjot.Rotatingtext.Models;


namespace RotatingTextWrapper
{
    [Activity(Label = "RotatingTextWrapper", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private Com.Sdsmdg.Harjot.Rotatingtext.RotatingTextWrapper _rotating;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);

            _rotating = FindViewById<Com.Sdsmdg.Harjot.Rotatingtext.RotatingTextWrapper>(Resource.Id.custom_switcher);
            _rotating.Size = 35;
            var rotatable = new Rotatable(Color.ParseColor("#FFA036"), 1000, "Coding", "Programming", "Exploring")
            {
                Size = 35,
                AnimationDuration = 500
            };
            

            _rotating.SetContent("I Love ?", rotatable);
        }
    }
}

