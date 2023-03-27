using MvvmCross.ViewModels;

namespace CalculatorWinUI.ViewModel
{
    public class CalcDisplayViewModel : MvxViewModel
    {
        private string _display;

        public CalcDisplayViewModel()
        {
            Dislplay = string.Empty;
        }

        public string Dislplay
        {
            get => _display;
            set => SetProperty(ref _display, value);
        }
    }
}