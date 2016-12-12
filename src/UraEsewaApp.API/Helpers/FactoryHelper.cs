using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UraEsewaApp.Abstract.Services;
using UraEsewaApp.Repository.Abstract;
using UraEsewaApp.Repository.Impl;
using UraEsewaApp.Repository.Infrastructure;
using UraEsewaApp.Services;
using UraEsewaApp.Services.Abstract;
using UraEsewaApp.Services.Impl;

namespace UraEsewaApp.API.Helpers
{
    public class FactoryHelper
    {
        public static void Create(IServiceCollection services)
        {
            // Add application services.

            CreateServices(services);
            CreateRepositories(services);
        }


        public static void CreateServices(IServiceCollection services)
        {
            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<IGLTranMastService, GLTranMastService>();
            services.AddTransient<IRequestService, RequestService>();
            services.AddTransient<IRequestStatusService, RequestStatusService>();
            services.AddTransient<IRoleTypeService, RoleTypeService>();
        }
        public static void CreateRepositories(IServiceCollection services)
        {
            services.AddScoped<IDatabaseFactory, DatabaseFactory>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IConfigurationRoot, ConfigurationRoot>();
            services.AddTransient<IRoleTypeRepository, RoleTypeRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IGeneralLedgerRepository, GeneralLedgerRepository>();
            services.AddTransient<IGLTranMastRepository, GLTranMastRepository>();
            services.AddTransient<IGLTranDetailRepository, GLTranDetailRepository>();
            services.AddTransient<IRequestRepository, RequestRepository>();
            services.AddTransient<IRequestStatusRepository, RequestStatusRepository>();

        }
    }
}
