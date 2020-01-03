using System;
using System.Collections.Generic;
using MvvmCross;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Views;
using MvvmCrossViewNotFound.Core;
using MvvmCrossViewNotFound.Droid.Views.Main;

namespace MvvmCrossViewNotFound.Droid
{
    public class Setup : MvxAppCompatSetup<App>
    {
        protected override IDictionary<Type, Type> InitializeLookupDictionary()
        {
            return new Dictionary<Type, Type>{
                { typeof(TermsAndConditionsViewModel), typeof(TermsAndConditionsView) }
            };
        }

/*
        protected override IMvxViewsContainer InitializeViewLookup(IDictionary<Type, Type> viewModelViewLookup)
        {
            var lookup = new Dictionary<Type, Type>{
                { typeof(TermsAndConditionsViewModel), typeof(TermsAndConditionsView) }
            };

            var container = Mvx.IoCProvider.Resolve<IMvxViewsContainer>();
            container.AddAll(lookup);
            return container;
        }
*/
    }
}
