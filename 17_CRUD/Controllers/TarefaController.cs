using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using _17_CRUD.Models;

namespace _17_CRUD.Controllers
{
    //Criando a classe TarefaController e herdando seus métodos de Controller
    public class TarefaController : Controller
    {
        //Criando um objeto_tarefas que armazenará uma lista de tarefas
        private static List<Tarefa> _tarefas = new List<Tarefa>();
                public IActionResult Index()
        {
            return View(_tarefas);
        }
        //Criando o método GET para carregar a tela de Adicionar nova tarefa
        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(Tarefa novaTarefa)
        {
            //Verificando o total de tarefas da lista e somando mais 1 para o ID
            novaTarefa.Id = _tarefas.Count + 1;
            //Adiconando minha nova tarefa à minha lista
            _tarefas.Add(novaTarefa);
            //Redirecionar para a página coma a lista de tarefas
            return RedirectToAction("Index");
        }
        public IActionResult Editar(int Id)
        {
            //Estou buscando na minha lista a tarefa que desejo alterar
            Tarefa tarefaBD = _tarefas.FirstOrDefault(t => t.Id == Id);
            //Verificando se encontrou a tarefa, se ela não é null
            if (tarefaBD == null)
            return NotFound();
            //Enviando para a View a tarefa encontrada que queremos alterar
            return View(tarefaBD);
        }
        [HttpPost]
        public IActionResult Editar(Tarefa tarefaEditando)
        {
            //Buscando tarefa da lista
            Tarefa tarefaBD = _tarefas.Find(t => t.Id == tarefaEditando.Id);
            //Verificando se encontrou ela
            if (tarefaBD == null)
            return NotFound();

            //Atualizando os dados da tarefa que já está na lista
            tarefaBD.Descricao = tarefaEditando.Descricao;
            tarefaBD.Concluida = tarefaEditando.Concluida;
            //Redirecionando para a lista de tarefas
            return RedirectToAction("Index");
        }
        public IActionResult Deletar(int Id)
        {
            Tarefa tarefaBD = _tarefas.FirstOrDefault(t => t.Id == Id);
            if (tarefaBD == null)
            return NotFound();
            return View(tarefaBD);
        }
        [HttpPost]
        public IActionResult Deletar(Tarefa tarefaDeletando)
        {
            Tarefa tarefaBD = _tarefas.Find(t => t.Id == tarefaDeletando.Id);
            if (tarefaBD == null)
            return NotFound();

            _tarefas.Remove(tarefaBD);
            return RedirectToAction("Index");
        }

    }
}