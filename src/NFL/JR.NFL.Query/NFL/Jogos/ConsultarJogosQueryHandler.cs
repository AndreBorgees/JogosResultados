using JR.Core.Messages;
using JR.NFL.Contract.NFL.Query;
using MediatR;

namespace JR.NFL.Query.NFL.Jogos
{
    public class ConsultarJogosQueryHandler : CommandHandler, IRequestHandler<ConsultaJogosQueryRequest, ConsultaJogosQueryResult>
    {
        public async Task<ConsultaJogosQueryResult> Handle(ConsultaJogosQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
