﻿using Livraria.Application.Livro.Services.Interfaces;
using Livraria.Application.Livros.Services;
using Livraria.Domain.Core.Bus;
using Livraria.Domain.Core.Notifications;
using Livraria.Domain.Interfaces;
using Livraria.Domain.Livros.CommandHandlers;
using Livraria.Domain.Livros.Commands;
using Livraria.Domain.Livros.Interfaces.Repository;
using Livraria.Infra.Data.Context;
using Livraria.Infra.Data.Livros.Repository;
using Livraria.Infra.Data.UoW;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Livraria.CrossCutting
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            DomainBus(services);
            AppService(services);
            DomainCommand(services);
            DomainEvents(services);
            InfraData(services);
        }

        private static void DomainEvents(IServiceCollection services)
        {
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
        }

        private static void InfraData(IServiceCollection services)
        {
            services.AddScoped<ILivroRepository, LivroRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<LivrariaContext>();
        }

        private static void DomainCommand(IServiceCollection services)
        {
            services.AddScoped<IRequestHandler<NovoLivroCommand>, LivroCommandHandler>();
            services.AddScoped<IRequestHandler<AtualizarLivroCommand>, LivroCommandHandler>();
            services.AddScoped<IRequestHandler<RemoverLivroCommand>, LivroCommandHandler>();
        }

        private static void AppService(IServiceCollection services)
        {
            services.AddScoped<ILivroAppService, LivroAppService>();
        }

        private static void DomainBus(IServiceCollection services)
        {
            services.AddScoped<IMediatorHandler, InMemoryBus>();
        }
    }
}
