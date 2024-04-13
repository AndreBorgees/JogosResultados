using FluentValidation;
using JR.Core.Messages;
using MediatR;

namespace JR.NFL.Contract.NFL.Query
{
    public class ConsultaJogosQueryRequest: Command, IRequest<ConsultaJogosQueryResult>
    {
        public int MyProperty { get; set; }

        public override bool IsValid()
        {
            ValidationResult = new ConsultaJogosValidation().Validate(this);
            return ValidationResult.IsValid;
        }

        public class ConsultaJogosValidation : AbstractValidator<ConsultaJogosQueryRequest>
        {
            public ConsultaJogosValidation()
            {
               

                RuleFor(c => c.MyProperty)
                  .GreaterThan(0)
                  .WithMessage("Valor do pedido inválido");
            }
        }
    }
}
