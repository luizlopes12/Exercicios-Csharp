//configs do servidor
IWebHost host = new WebHostBuilder()
    .UseKestrel()
    //classe de configura��o de req e res
    .UseStartup<Startup>()
    .Build();
//iniciando servidor
host.Run();