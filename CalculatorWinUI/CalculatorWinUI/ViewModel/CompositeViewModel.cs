using CalculatorWinUI.Message;
using MvvmCross.Plugin.Messenger;
using MvvmCross.ViewModels;

namespace CalculatorWinUI.ViewModel
{
    public class CompositeViewModel : MvxViewModel
    {
        private CalcControlsViewModel _calcControlsViewModel;
        private CalcDisplayViewModel _calcDisplayViewModel;
        private MvxSubscriptionToken _tokenButtonsMessage;

        #region Constructor
        public CompositeViewModel(CalcControlsViewModel calcControlsViewModel, CalcDisplayViewModel calcDisplayViewModel, IMvxMessenger messenger)
        {
            CalcControlsViewModel = calcControlsViewModel;
            CalcDisplayViewModel = calcDisplayViewModel;
            _tokenButtonsMessage = messenger.Subscribe<ButtonsMessage>(msg => DisplayManager(msg));
        }

        private void DisplayManager(ButtonsMessage msg)
        {
            if (msg.Operation == "clear")
                CalcDisplayViewModel.Dislplay = string.Empty;
            else if (msg.Operation == "=")
                CalcDisplayViewModel.Dislplay = "4578847";
            else
                CalcDisplayViewModel.Dislplay += msg.Operation;
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