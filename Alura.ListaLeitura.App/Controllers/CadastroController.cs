using Alura.ListaLeitura.App.Models;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.ListaLeitura.App.Controllers
{
    public class CadastroController
    {
        public static Task ProcessaFormulario(HttpContext context)
        {
            var livro = new Livro()
            {
                Titulo = context.Request.Form["titulo"].First(),
                Autor = context.Request.Form["autor"].First(),
            };

            var repo = new LivroRepositorioCSV();
            repo.Incluir(livro);
            return context.Response.WriteAsync("O livro foi adicionado com sucesso.");
        }

        public IActionResult Formulario()
        {
            var html = new ViewResult { ViewName = "formulario" };
            return html;
        }

        public string Incluir(Livro livro)
        {
            var repo = new LivroRepositorioCSV();
            repo.Incluir(livro);
            return "O livro foi adicionado com sucesso.";

        }
    }
}
