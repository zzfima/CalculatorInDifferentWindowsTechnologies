using MvvmCross;

namespace CalculatorWinUI.ViewModel
{
    public sealed class CompositeViewModelLocator
    {
        public CompositeViewModelLocator()
        {
            MainViewModel = Mvx.IoCProvider.Resolve<CompositeViewModel>();
        }

        public CompositeViewModel MainViewModel { get; }
    }
}