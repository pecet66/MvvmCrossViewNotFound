using System;
using Android.OS;
using Android.Views;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Platforms.Android.Binding.BindingContext;

namespace MvvmCrossViewNotFound.Droid.Views.Main
{
    public class TermsAndConditionsFragment : MvxFragment
    {
        private TermsAndConditionsViewModel _model;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            // Set the layout
            return this.BindingInflate(Resource.Layout.terms_and_conditions_layout, null);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            _model = (TermsAndConditionsViewModel) ViewModel;
        }
    }
}