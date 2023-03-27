using MvvmCross.ViewModels;

namespace CalculatorWinUI.ViewModel
{
    public class CompositeViewModel : MvxViewModel
    {
        private CalcControlsViewModel _calcControlsViewModel;
        private CalcDisplayViewModel _calcDisplayViewModel;

        #region Constructor
        public CompositeViewModel(CalcControlsViewModel calcControlsViewModel, CalcDisplayViewModel calcDisplayViewModel)
        {
            CalcControlsViewModel = calcControlsViewModel;
            CalcDisplayViewModel = calcDisplayViewModel;
        }
        #endregion

        public CalcControlsViewModel CalcControlsViewModel
        {
            get => _calcControlsViewModel;
            set => SetProperty(ref _calcControlsViewModel, value);
        }

        public CalcDisplayViewModel CalcDisplayViewModel
        {
            get => _calcDisplayViewModel;
            set => SetProperty(ref _calcDisplayViewModel, value);
        }
    }
}