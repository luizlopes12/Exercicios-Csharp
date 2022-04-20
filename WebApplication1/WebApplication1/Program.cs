//configs do servidor
IWebHost host = new WebHostBuilder()
    .UseKestrel()
    //classe de configuração de req e res
    .UseStartup<Startup>()
    .Build();
//iniciando servidor
host.Run();