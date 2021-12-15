using Alura.CoisasAFazer.Core.Models;
using Alura.CoisasAFazer.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alura.CoisasAFazer.Testes
{
    class RepositorioFake : IRepositorioTarefas
    {
        private List<Tarefa> ListaDeTarefas = new List<Tarefa>();

        public void AtualizarTarefas(params Tarefa[] tarefas)
        {
            throw new NotImplementedException();
        }

        public void ExcluirTarefas(params Tarefa[] tarefas)
        {
            throw new NotImplementedException();
        }

        public void IncluirTarefas(params Tarefa[] tarefas)
        {
            ListaDeTarefas.AddRange(tarefas.ToList());
        }

        public Categoria ObtemCategoriaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tarefa> ObtemTarefas(Func<Tarefa, bool> filtro)
        {
            return ListaDeTarefas.Where(filtro).ToList();
        }
    }
}
