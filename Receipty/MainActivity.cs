using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Plugin.Media;
using Plugin.CurrentActivity;
using Plugin.Permissions;

namespace Receipty
{
    [Activity(Label = "SimpleCameraApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            FragmentManager.BeginTransaction()
               .Replace(Resource.Id.content_frame, new CameraFragment())
               .Commit();
        }
    }
    /* [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
     public class MainActivity : AppCompatActivity
     {
         protected override void OnCreate(Bundle savedInstanceState)
         {

             base.OnCreate(savedInstanceState);

             // Set our view from the "main" layout resource
             CrossMedia.Current.Initialize();
             SetContentView(Resource.Layout.activity_main);

             Button button = FindViewById<Button>(Resource.Id.CameraButton);
             Button testButton = FindViewById<Button>(Resource.Id.TestForCamera);
             ImageView Image = FindViewById<ImageView>(Resource.Id.Image);



             testButton.Click += (sender, e) =>
             {
                 if (CrossMedia.Current.IsCameraAvailable && CrossMedia.Current.IsTakePhotoSupported)
                 {
                     testButton.Text = "Yes";


                 }
                 else
                 {
                     testButton.Text = "No";
                 }
             };

             button.Click += async (sender, e) =>
             {
                 if (CrossMedia.Current.IsCameraAvailable && CrossMedia.Current.IsTakePhotoSupported)
                 {
                     var mediaOptions = new Plugin.Media.Abstractions.StoreCameraMediaOptions
                     {
                         Directory = "CameraTests",
                         Name = "test.jpg",
                         SaveToAlbum = true
                     };

                     var file = await CrossMedia.Current.TakePhotoAsync(mediaOptions);
                     string path = file.Path;
                     Intent intent = new Intent(this, typeof(DrawActivity));
                     StartActivity(intent);
                 }
             };

        }
    }*/
}