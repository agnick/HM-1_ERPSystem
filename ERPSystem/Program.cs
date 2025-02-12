using System;
using Microsoft.Extensions.DependencyInjection;
using ERPSystem;
using ERPSystem.Interfaces;

namespace ERPSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Настройка DI‑контейнера.
            var service = new ServiceCollection();
            ConfigureServices(service);
            var serviceProvider = service.BuildServiceProvider();

            // Получаем главный класс приложения и запускаем его.
            var app = serviceProvider.GetService<ERPSystemApp>();
            app.Run();

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        /// <summary>
        /// Метод для регистрации зависимостей в DI-контейнере.
        /// </summary>
        /// <param name="services">Коллекция сервисов для регистрации.</param>
        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IVetClinic, VetClinic>();
            services.AddSingleton<Zoo>();

            // Регистрируем главный класс приложения ERPSystemApp как временную зависимость.
            services.AddTransient<ERPSystemApp>();
        }
    }
}

