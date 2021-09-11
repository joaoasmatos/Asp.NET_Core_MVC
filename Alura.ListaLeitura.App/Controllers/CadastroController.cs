using Alura.ListaLeitura.App.Models;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Alura.ListaLeitura.App.Controllers
{
    public class CadastroController
    {
        public IActionResult Formulario()
        {
            var html = new ViewResult { ViewName = "formulario" };
            return html;
        }

        public IActionResult Incluir(Livro livro)
        {
            var repo = new LivroRepositorioCSV();
            repo.Incluir(livro);

            var html = new ViewResult { ViewName = "sucesso" };
            return html;
        }
    }
}
