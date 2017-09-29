using Rafty.FiniteStateMachine;

namespace Rafty.IntegrationTests
{
    public class FakeCommand : ICommand
    {
        public FakeCommand(string value)
        {
            this.Value = value;

        }
        public string Value { get; private set; }
    }
}
