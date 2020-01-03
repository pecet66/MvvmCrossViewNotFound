using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using MvvmCross.Droid.Support.V4;

namespace MvvmCrossViewNotFound.Droid.Views.Main
{
    [Activity(Label = "", Theme = "@style/AppTheme", ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenLayout | ConfigChanges.ScreenSize | ConfigChanges.Keyboard | ConfigChanges.KeyboardHidden, WindowSoftInputMode = SoftInput.StateAlwaysHidden | SoftInput.AdjustPan)]
    public class TermsAndConditionsView : MvxFragmentActivity
    {
        private TermsAndConditionsViewModel _model;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            SetContentView(Resource.Layout.activity_main_container);

            base.OnCreate(savedInstanceState);
        }
        
        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
            _model = (TermsAndConditionsViewModel)ViewModel;
            
            var cvf = new TermsAndConditionsFragment
            {
                ViewModel = ViewModel
            };
            Show(cvf, true);
        }
        
        protected void Show(MvxFragment fragment, bool backStack)
        {
            var ft = SupportFragmentManager.BeginTransaction();
            ft.Replace(Resource.Id.content_frame, fragment);
            ft.AddToBackStack(null);
            ft.Commit();
        }

    }
}
