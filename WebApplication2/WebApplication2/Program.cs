//configs do servidor
using WebApplication2;

IWebHost host = new WebHostBuilder()
    .UseKestrel()
    //classe de configura��o de req e res
    .UseStartup<Startup>()
    .Build();
//iniciando servidor
host.Run();