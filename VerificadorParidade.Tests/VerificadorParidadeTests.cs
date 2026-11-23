using Xunit;
using VerificadorParidade.App;
namespace VerificadorParidade.Tests;
public class VerificadorParidadeTests
{
[Theory]
[InlineData(0, true)]
[InlineData(2, true)]
[InlineData(-4, true)]
[InlineData(3, false)]
[InlineData(-7, false)]
public void Paridade_ClassificaCorretamente(int numero, bool esperado)
{
var servico = new VerificadorParidade.App.VerificadorParidade();
Assert.Equal(esperado, servico.EhPar(numero));
}
}