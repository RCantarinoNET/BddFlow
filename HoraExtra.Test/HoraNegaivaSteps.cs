using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace HoraExtra.Test
{
    [Binding]
    public class UpdateHoraMensalFuncionarioCasoEleSeAtraseSteps
    {
        private Application.Funcionario funcionario;
        private int quantidade;
        private int valor;
        private int esperado = 152;

        [Given(@"que estou consumindo o metodo AtualizaHorasColaborador")]
        public void DadoQueEstouConsumindoOMetodoAtualizaHorasColaborador()
        {
            funcionario = new Application.Funcionario();
        }

        [Given(@"preencho o campo quantidade com (.*)")]
        public void DadoPreenchoOCampoQuantidadeCom(int p0)
        {
            quantidade = p0;
        }

        [When(@"executo a aplicacao")]
        public void QuandoExecutoAAplicacao()
        {
            valor = funcionario.AtualizaHorasMensaisNegtivas(quantidade);
        }

        [Then(@"o retorno  '(.*)'")]
        public void EntaoORetorno(int p0)
        {
            Assert.AreEqual(esperado, valor);
        }
    }
}