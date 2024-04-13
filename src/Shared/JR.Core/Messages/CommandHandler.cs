using FluentValidation.Results;
using JR.Core.Data;

namespace JR.Core.Messages
{
    public abstract class CommandHandler
    {
        protected ValidationResult ValidationResult;

        protected CommandHandler() 
        { 
            ValidationResult = new ValidationResult();
        }

        protected void AddError(string message)
        {
            ValidationResult.Errors.Add(new ValidationFailure(string.Empty, message));
        }

        protected async Task<ValidationResult> PersistData(IUnitOfWork unitOfWork)
        {
            if(!await unitOfWork.Commit()) AddError("Houve um erro ao persistir os dados");

            return ValidationResult;
        }
    }
}
