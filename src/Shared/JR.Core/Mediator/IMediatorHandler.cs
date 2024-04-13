using FluentValidation.Results;
using JR.Core.Messages;

namespace JR.Core.Mediator
{
    public interface IMediatorHandler
    {
        Task PublishEvent<T>(T message) where T : Event;
        Task<ValidationResult> SendCommand<T>(T command) where T: Command;
    }
}
