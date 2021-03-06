using System;

namespace Air
{
    public class Command : CommandBase
    {
        private readonly Action? action;
        private readonly Func<bool>? canAction;

        public Command(Action action,Func<bool>? canAction = null)
        {
            this.action = action;
            this.canAction = canAction;
        }
        
        public override bool CanExecute(object? parameter)
        {
            return canAction?.Invoke() != false;
        }
        

        public override void Execute(object? parameter)
        {
            action?.Invoke();
        }
    }
}