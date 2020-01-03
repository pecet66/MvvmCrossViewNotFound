using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MvvmCrossViewNotFound.Droid.Views.Main;

namespace MvvmCrossViewNotFound.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<TermsAndConditionsViewModel>();
        }
    }
}
