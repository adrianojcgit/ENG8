using ENG8.Application.Interfaces;
using ENG8.Application.Mappings;
using ENG8.Application.Services;
using ENG8.Domain.Interfaces;
using ENG8_Infra_Data.Context;
using ENG8_Infra_Data.Identity;
using ENG8_Infra_Data.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG8.Infra.IoC
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddInfraStructure(this IServiceCollection services,
															IConfiguration configuration)
		{
			services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
				b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            //string myConnection = configuration.GetConnectionString("ConnectionMySql");
            //services.AddDbContext<ApplicationDbContext>(options =>
            //	options.UseMySql(myConnection
            //	, ServerVersion.AutoDetect(myConnection)));
            #region Identity
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options =>
                     options.AccessDeniedPath = "/Account/Login");

            #endregion

            services.AddScoped<IClienteRepository, ClienteRepository>();
			//services.AddScoped<IEnderecoRepository, EnderecoRepository>();
			services.AddScoped<ICLienteService, ClienteService>();
			//services.AddScoped<IEnderecoService, EnderecoService>();
			services.AddAutoMapper(typeof(DomaintToDTOMappingProfile));

            services.AddScoped<IAuthenticate, AuthenticateService>();
            services.AddScoped<ISeedUserRoleInitial, SeedUserRoleInitial>();

            return services;
		}
	}
}
