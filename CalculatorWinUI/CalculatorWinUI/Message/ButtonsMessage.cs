namespace CalculatorWinUI.Message
{
    public class ButtonsMessage : MvvmCross.Plugin.Messenger.MvxMessage
    {
        public ButtonsMessage(object sender, string operation) : base(sender)
        {
            Operation = operation;
        }

        public string Operation { get; }
    }
}
