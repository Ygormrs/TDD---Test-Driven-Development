# 👋 Olá!

## Introdução a TDD (Test Driven Development) com xUnit, NUnit, MSTest e suas principais diferenças.

## ⚙️ Tecnologias e Ferramentas

- C# / .NET
- xUnit, NUnit, MSTest

## 🧪 Testes Automatizados no .NET

No ecossistema .NET, temos três frameworks principais para testes unitários. Aqui vai um resumo das diferenças entre eles:

### xUnit
- Criado por desenvolvedores originais do NUnit.
- Projetado para ser mais moderno e alinhado com práticas de código limpo.
- Utiliza atributos como `[Fact]` (para testes simples) e `[Theory]` (para testes parametrizados).
- Não usa atributos como `[SetUp]` ou `[TearDown]`; em vez disso, utiliza construtores e `IDisposable`.

### NUnit
- Um dos frameworks mais antigos e populares no .NET.
- Rico em funcionalidades e suporte a diversas formas de parametrização de testes.
- Usa atributos como `[Test]`, `[SetUp]`, `[TearDown]`, e `[TestCase]`.
- Boa escolha para projetos legados ou que exigem flexibilidade.

### MSTest
- Framework oficial da Microsoft.
- Integração nativa com o Visual Studio.
- Utiliza `[TestMethod]`, `[TestInitialize]`, `[TestCleanup]`.
- Simples e direto, ideal para projetos menores ou onde a integração com o ecossistema Microsoft é prioridade.

🚀
