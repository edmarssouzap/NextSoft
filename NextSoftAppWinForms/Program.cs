using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace NextSoftAppWinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Configuracao da injecao de dependencia
            //
            // Cria um conteiner ou colecao de servicos
            var serviceCollection = new ServiceCollection();
            
            // Configura nossas classes na colecao de servicos
            ConfigureServices(serviceCollection);

            // Compila nossa colecao de servicos que foi adicionado em serviceCollection
            using (var serviceProvider = serviceCollection.BuildServiceProvider())
            {
                // Solicita uma instancia da classe "Form1" que está compilado em serviceProvider
                var form1 = serviceProvider.GetRequiredService<Form1>();
                Application.Run(form1);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            // Adiciona a interface IHttpClientFactory para o conteiner ou servicos (ServiceCollection)
            services.AddHttpClient();
            // Adiciona o Form1 dentro do Conteiner, ou seja, dentro do ServiceCollection
            services.AddScoped<Form1>();
            // Referencia que ao usar a interface abstrata, a implementacao da classe concreta seja chamada
            //services.AddScoped<IClasse, Classe>();
        }
    }
}
