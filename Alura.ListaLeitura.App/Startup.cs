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
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvcWithDefaultRoute();
            //var routeBuilder = new RouteBuilder(app);
            //routeBuilder.MapRoute("Livros/ParaLer", LivrosController.LivrosParaLer);
            //routeBuilder.MapRoute("Livros/Lendo", LivrosController.LivrosLendo);
            //routeBuilder.MapRoute("Livros/Lidos", LivrosController.LivrosLidos);
            //routeBuilder.MapRoute("Livros/Detalhes/{id:int}", LivrosController.ExibeDetalhes);
            //routeBuilder.MapRoute("Cadastro/NovoLivro", CadastroLogica.ExibeFormulario);
            //routeBuilder.MapRoute("Cadastro/Incluir", CadastroLogica.ProcessaFormulario);
            //routeBuilder.MapRoute("Cadastro/NovoLivro/{nome}/{autor}", CadastroLogica.NovoLivroParaLer);
            
            //var rotas = routeBuilder.Build();

            //app.UseRouter(rotas);
        }
    }
}