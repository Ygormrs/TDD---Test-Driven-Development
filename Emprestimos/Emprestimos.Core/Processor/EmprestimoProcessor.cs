
using Emprestimos.Core.Domain.Processor;

namespace Emprestimos.Core.Processor
{
    public class EmprestimoProcessor
    {
        public object LerDados(EmprestimoReq req)
        {
            if (req == null)
            {
                throw new ArgumentNullException(nameof(req));
            }
            return new EmprestimoResult
            {
                Data = req.Data,
                Email = req.Email,
                PrimeiroNome = req.PrimeiroNome,
                UltimoNome = req.UltimoNome,
            };
        }
    }
}