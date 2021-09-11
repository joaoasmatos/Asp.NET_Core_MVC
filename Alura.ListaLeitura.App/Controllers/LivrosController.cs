using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Alura.ListaLeitura.App.Controllers
{
    public class LivrosController : Controller
    {
        public IActionResult Detalhes(int id)
        {
            //var repo = new LivroRepositorioCSV();
            //var livro = repo.Todos.First(l => l.Id == id);
            //return livro.Detalhes();

            var repo = new LivroRepositorioCSV();
            var livro = repo.Todos.First(l => l.Id == id);
            ViewBag.Livro = livro;
            return View("livro");
        }

        public IActionResult ParaLer()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.ParaLer.Livros;
            return View("lista");
        }

        public IActionResult Lendo()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lendo.Livros;
            return View("lista");
        }

        public IActionResult Lidos()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lidos.Livros;
            return View("lista");
        }

        public string Teste()
        {
            return "Nova funcionalidade implementada.";
        }
    }
}
