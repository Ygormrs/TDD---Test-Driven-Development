using Emprestimos.Core.Domain.Processor;
using Emprestimos.Core.Processor;

namespace Emprestimos.Core.Tests_nUnit.Processor
{
    public class EmprestimosTests
    {
        EmprestimoProcessor _processor;

        [SetUp]
        public void Setup()
        {
            _processor = new EmprestimoProcessor();
        }

        [Test]
        public void DeveRetornarDadosEmprestimosComValoresDaRequisicao()
        {
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
            Assert.IsNotNull(result);
            Assert.AreEqual(req.PrimeiroNome, result.PrimeiroNome);
            Assert.AreEqual(req.UltimoNome, result.UltimoNome);
            Assert.AreEqual(req.Email, result.Email);
            Assert.AreEqual(req.Data, result.Data);
        }

        [Test]
        public void DeveRetornarUmaExceptionSeReqForNula()
        {
            _processor = new EmprestimoProcessor();
            var exception = Assert.Throws<ArgumentNullException>(() => _processor.LerDados(null));
            Assert.AreEqual("req", exception.ParamName);
        }
    }
}
