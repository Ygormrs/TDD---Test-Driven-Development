using Emprestimos.Core.Domain.Processor;
using Emprestimos.Core.Processor;

namespace Emprestimos.Core.Tests.Processor
{
    public class EmprestimosTests
    {
        EmprestimoProcessor _processor = new EmprestimoProcessor();
        public EmprestimosTests()
        {
            _processor = new EmprestimoProcessor();
        }

        [Fact]
        public void DeveRetornarDadosEmprestimosComValoresDaRequisicao()
        {
            //organizar requisição
            var req = new EmprestimoReq()
            {
                PrimeiroNome = "Ygor",
                UltimoNome = "Silva",
                Email = "teste@teste.com",
                Data = DateTime.Now,
            };

            //Processar requisição e retornar o resultado
            _processor = new EmprestimoProcessor();
            EmprestimoResult result = (EmprestimoResult)_processor.LerDados(req);

            //Afirmação
            Assert.NotNull(result);
            Assert.Equal(req.PrimeiroNome, result.PrimeiroNome);
            Assert.Equal(req.UltimoNome, result.UltimoNome);
            Assert.Equal(req.Email, result.Email);
            Assert.Equal(req.Data, result.Data);
        }

        [Fact]
        public void DeveRetornarUmaExceptionSeReqForNula()
        {
            _processor = new EmprestimoProcessor();
            var exception = Assert.Throws<ArgumentNullException>(() => _processor.LerDados(null));
            Assert.Equal("req", exception.ParamName);
        }
    }
}
