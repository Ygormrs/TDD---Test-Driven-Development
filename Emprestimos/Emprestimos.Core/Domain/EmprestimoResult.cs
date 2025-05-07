namespace Emprestimos.Core.Domain.Processor
{
    public class EmprestimoResult
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Email { get; set; }
        public DateTime Data { get; set; }
    }
}