using CalculatorWinUI.Model;
using CalculatorWinUI.ViewModel;
using MvvmCross.Base;
using MvvmCross.IoC;
using MvvmCross.Plugin.Messenger;



namespace CalculatorWinUI
{
    public static class ServiceRegistration
    {
        private static bool _isInitialized = false;
        public static IMvxIoCProvider IoCProvider { get; private set; }

        public static void RegisterServices()
        {
            if (_isInitialized)
                return;

            IoCProvider = MvxIoCProvider.Initialize();
            IoCProvider.ConstructAndRegisterSingleton<IMvxMessenger, MvxMessengerHub>();
            IoCProvider.ConstructAndRegisterSingleton<CalcControlsViewModel, CalcControlsViewModel>();
            IoCProvider.ConstructAndRegisterSingleton<CalcDisplayViewModel, CalcDisplayViewModel>();
            IoCProvider.ConstructAndRegisterSingleton<CompositeViewModel, CompositeViewModel>();
            IoCProvider.ConstructAndRegisterSingleton<ICalculator, Calculator>();

            _isInitialized = true;
        }

        public static void UnregisterServices()
        {
            if (!_isInitialized)
                return;

            IoCProvider.DisposeIfDisposable();

            _isInitialized = false;
        }
    }
}
