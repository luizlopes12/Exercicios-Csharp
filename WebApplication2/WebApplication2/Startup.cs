namespace WebApplication2
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            //chamando o metodo que mostra algo
            app.Run(Roteamento);

        }
        public Task Roteamento(HttpContext context)
        {   
            var caminhos = new Dictionary<string, RequestDelegate>{
                { "/livros/paraler", MostrarAlgo},
                { "/livros/lendo",  MostrarAlgo2},
                { "/livros/lidos", MostrarAlgo3}
            };
            if (caminhos.ContainsKey(context.Request.Path)){
                var metodo = caminhos[context.Request.Path];
                return metodo.Invoke(context);
            }
            context.Response.StatusCode = 404;
            return context.Response.WriteAsync("Caminho não encontrado");
                
        }
        //metodo que retorna algo
        public Task MostrarAlgo(HttpContext context)
        {
            return context.Response.WriteAsync("Hello World 1");
        }
        public Task MostrarAlgo2(HttpContext context)
        {
            return context.Response.WriteAsync("Hello World 2");
        }
        public Task MostrarAlgo3(HttpContext context)
        {
            return context.Response.WriteAsync("Hello World 3");
        }
    }
}
