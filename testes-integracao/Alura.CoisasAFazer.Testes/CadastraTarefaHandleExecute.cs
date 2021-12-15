using System;
using System.Linq;
using Xunit;
using Alura.CoisasAFazer.Core.Models;
using Alura.CoisasAFazer.Core.Commands;
using Alura.CoisasAFazer.Services.Handlers;

namespace Alura.CoisasAFazer.Testes
{
    public class CadastraTarefaHandleExecute
    {
        [Fact]
        public void DadaTarefaComInfoValidaSeDeveIncluirNoBD()
        {
            //arrange
            var cadastrarTarefa = new CadastraTarefa("Estudar Xunit", new Categoria("Estudo"), new DateTime(2019, 12, 31));
            var repositorioFake = new RepositorioFake();

            var repositorio = new CadastraTarefaHandler(repositorioFake);

            repositorio.Execute(cadastrarTarefa);

            var retornoDaTarefa = repositorioFake.ObtemTarefas(t => t.Titulo.Equals("Estudar Xunit")).FirstOrDefault();

            //act
            //assert

            Assert.NotNull(retornoDaTarefa);


        }
    }
}
