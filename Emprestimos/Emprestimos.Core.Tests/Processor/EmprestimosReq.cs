
namespace Emprestimos.Core.Tests.Processor
{
    internal class EmprestimosReq
    {
        public EmprestimosReq()
        {
        }

        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Email { get; set; }
        public DateTime Data { get; set; }
    }
}