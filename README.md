# RotatingTextWrapper

Rotating text is an Android library that can be used to make text switching painless and beautiful, with the use of interpolators, typefaces and more customisations.

XML Layout

        <com.sdsmdg.harjot.rotatingtext.RotatingTextWrapper
           android:id="@+id/custom_switcher"
           android:layout_alignParentRight="true"
           android:layout_centerVertical="true"
           android:layout_width="wrap_content"
           android:layout_height="wrap_content" />  

IN CODE:

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


Binded from this library
https://github.com/sdsmdg/RotatingText
