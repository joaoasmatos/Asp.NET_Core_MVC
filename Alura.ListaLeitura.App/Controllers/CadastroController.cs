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
