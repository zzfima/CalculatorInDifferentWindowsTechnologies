using CalculatorWinUI.Message;
using MvvmCross.Commands;
using MvvmCross.Plugin.Messenger;
using MvvmCross.ViewModels;

namespace CalculatorWinUI.ViewModel
{
    public class CalcControlsViewModel : MvxViewModel
    {
        private readonly IMvxMessenger _messenger;
        public IMvxCommand ClearEntityCommand { get; set; }
        public IMvxCommand Press0Command { get; set; }
        public IMvxCommand Press1Command { get; set; }
        public IMvxCommand Press2Command { get; set; }
        public IMvxCommand Press3Command { get; set; }
        public IMvxCommand Press4Command { get; set; }
        public IMvxCommand Press5Command { get; set; }
        public IMvxCommand Press6Command { get; set; }
        public IMvxCommand Press7Command { get; set; }
        public IMvxCommand Press8Command { get; set; }
        public IMvxCommand Press9Command { get; set; }
        public IMvxCommand PressDotCommand { get; set; }
        public IMvxCommand PressEqualCommand { get; set; }
        public IMvxCommand PressPlusCommand { get; set; }
        public IMvxCommand PressMinusCommand { get; set; }
        public IMvxCommand PressMultiplyCommand { get; set; }
        public IMvxCommand PressDevideCommand { get; set; }

        public CalcControlsViewModel(IMvxMessenger messenger)
        {
            ClearEntityCommand = new MvxCommand(ExecuteClearEntity);

            Press0Command = new MvxCommand(ExecutePress0Number);
            Press1Command = new MvxCommand(ExecutePress1Number);
            Press2Command = new MvxCommand(ExecutePress2Number);
            Press3Command = new MvxCommand(ExecutePress3Number);
            Press4Command = new MvxCommand(ExecutePress4Number);
            Press5Command = new MvxCommand(ExecutePress5Number);
            Press6Command = new MvxCommand(ExecutePress6Number);
            Press7Command = new MvxCommand(ExecutePress7Number);
            Press8Command = new MvxCommand(ExecutePress8Number);
            Press9Command = new MvxCommand(ExecutePress9Number);

            PressDotCommand = new MvxCommand(ExecutePressDotCommand);
            PressEqualCommand = new MvxCommand(ExecutePressEqualCommand);
            PressPlusCommand = new MvxCommand(ExecutePressPlusCommand);
            PressMinusCommand = new MvxCommand(ExecutePressMinusCommand);
            PressMultiplyCommand = new MvxCommand(ExecutePressMultiplyCommand);
            PressDevideCommand = new MvxCommand(ExecutePressDevideCommand);

            _messenger = messenger;
        }

        private void ExecutePressDevideCommand() => _messenger.Publish<ButtonsMessage>(new(this, "/"));
        private void ExecutePressMultiplyCommand() => _messenger.Publish<ButtonsMessage>(new(this, "*"));
        private void ExecutePressMinusCommand() => _messenger.Publish<ButtonsMessage>(new(this, "-"));
        private void ExecutePressPlusCommand() => _messenger.Publish<ButtonsMessage>(new(this, "+"));
        private void ExecutePressEqualCommand() => _messenger.Publish<ButtonsMessage>(new(this, "="));
        private void ExecutePressDotCommand() => _messenger.Publish<ButtonsMessage>(new(this, "."));
        private void ExecutePress9Number() => _messenger.Publish<ButtonsMessage>(new(this, "9"));
        private void ExecutePress8Number() => _messenger.Publish<ButtonsMessage>(new(this, "8"));
        private void ExecutePress7Number() => _messenger.Publish<ButtonsMessage>(new(this, "7"));
        private void ExecutePress6Number() => _messenger.Publish<ButtonsMessage>(new(this, "6"));
        private void ExecutePress5Number() => _messenger.Publish<ButtonsMessage>(new(this, "5"));
        private void ExecutePress4Number() => _messenger.Publish<ButtonsMessage>(new(this, "4"));
        private void ExecutePress3Number() => _messenger.Publish<ButtonsMessage>(new(this, "3"));
        private void ExecutePress2Number() => _messenger.Publish<ButtonsMessage>(new(this, "2"));
        private void ExecutePress1Number() => _messenger.Publish<ButtonsMessage>(new(this, "1"));
        private void ExecutePress0Number() => _messenger.Publish<ButtonsMessage>(new(this, "0"));
        private void ExecuteClearEntity() => _messenger.Publish<ButtonsMessage>(new(this, "clear"));
    }
}
