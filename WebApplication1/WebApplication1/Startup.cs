public class Startup
{
    public void Configure(IApplicationBuilder app)
    {
        //chamando o metodo que mostra algo
        app.Run(MostrarAlgo);
    }
    //metodo que retorna algo
    public Task MostrarAlgo(HttpContext context)
    {
        return context.Response.WriteAsync("bomdia");
    }
}