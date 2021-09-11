using Alura.ListaLeitura.App.Logica;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace Alura.ListaLeitura.App
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }

        public void Configure(IApplicationBuilder app)
        {
            var routeBuilder = new RouteBuilder(app);
            routeBuilder.MapRoute("Livros/ParaLer", LivrosLogica.LivrosParaLer);
            routeBuilder.MapRoute("Livros/Lendo", LivrosLogica.LivrosLendo);
            routeBuilder.MapRoute("Livros/Lidos", LivrosLogica.LivrosLidos);
            routeBuilder.MapRoute("Livros/Detalhes/{id:int}", LivrosLogica.ExibeDetalhes);
            routeBuilder.MapRoute("Cadastro/NovoLivro", CadastroLogica.ExibeFormulario);
            routeBuilder.MapRoute("Cadastro/Incluir", CadastroLogica.ProcessaFormulario);
            routeBuilder.MapRoute("Cadastro/NovoLivro/{nome}/{autor}", CadastroLogica.NovoLivroParaLer);
            
            var rotas = routeBuilder.Build();

            app.UseRouter(rotas);
        }
    }
}