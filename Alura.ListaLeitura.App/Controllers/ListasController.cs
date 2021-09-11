using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.ListaLeitura.App.Controllers
{
    public class ListasController
    {
        public IActionResult Selecionar()
        {
            var html = new ViewResult { ViewName = "index" };
            return html;
        }
    }
}
