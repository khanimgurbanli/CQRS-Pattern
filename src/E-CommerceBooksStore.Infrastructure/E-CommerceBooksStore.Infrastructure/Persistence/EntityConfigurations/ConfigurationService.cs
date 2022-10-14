
using BookApi.Infrastructure.Repositories.Baskets;
using E_CommerceBooksStore.Application.Common.Interfaces;
using E_CommerceBooksStore.Application.Repositories.Addresses;
using E_CommerceBooksStore.Application.Repositories.Authors;
using E_CommerceBooksStore.Application.Repositories.Baskets;
using E_CommerceBooksStore.Application.Repositories.Books;
using E_CommerceBooksStore.Application.Repositories.Categories;
using E_CommerceBooksStore.Application.Repositories.Genres;
using E_CommerceBooksStore.Application.Repositories.Languages;
using E_CommerceBooksStore.Application.Repositories.Orders;
using E_CommerceBooksStore.Application.Repositories.Publishers;
using E_CommerceBooksStore.Domain.Identity;
using E_CommerceBooksStore.Infrastructure.Persistence.Contexts;
using E_CommerceBooksStore.Infrastructure.Persistence.Interceptor;
using E_CommerceBooksStore.Infrastructure.Repositories.Addresses;
using E_CommerceBooksStore.Infrastructure.Repositories.Authors;
using E_CommerceBooksStore.Infrastructure.Repositories.Books;
using E_CommerceBooksStore.Infrastructure.Repositories.Categories;
using E_CommerceBooksStore.Infrastructure.Repositories.Genres;
using E_CommerceBooksStore.Infrastructure.Repositories.Languages;
using E_CommerceBooksStore.Infrastructure.Repositories.Orders;
using E_CommerceBooksStore.Infrastructure.Repositories.Publishers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace E_CommerceBooksStore.Infrastructure.Persistence.EntityConfigurations
{
    public static class ConfigurationService
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddScoped<IApplicationDbContext, ApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());

            serviceCollection.AddDbContext<ApplicationDbContext>(options =>
                   options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                       builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            serviceCollection.AddScoped<AuditableEntitySaveChangesInterceptor>();
            serviceCollection.AddTransient<IApplicationDbContext, ApplicationDbContext>();
            serviceCollection.AddScoped<IBookWriteRepository, BookWriteRepository>();
            serviceCollection.AddScoped<IBookReadRepository, BookReadRepository>();
            serviceCollection.AddScoped<IOrderReadRepository, OrderReadRepository>();
            serviceCollection.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            serviceCollection.AddScoped<IAuthorWriteRepository, AuthorWriteRepository>();
            serviceCollection.AddScoped<IAuthorWriteRepository, AuthorWriteRepository>();
            serviceCollection.AddScoped<IAddressWriteRepository, AddressWriteRepository>();
            serviceCollection.AddScoped<IAddressReadRepository, AddressReadRepository>();
            serviceCollection.AddScoped<IBasketWritedRepository, BasketWriteRepository>();
            serviceCollection.AddScoped<IBasketReadRepository, BasketReadRepository>();
            serviceCollection.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();
            serviceCollection.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            serviceCollection.AddScoped<IGenreWriteRepository, GenreWriteRepository>();
            serviceCollection.AddScoped<ILanguageWriteRepository, LanguageWriteRepository>();
            serviceCollection.AddScoped<ILanguageReadRepository, LanguageReadRepository>();
            serviceCollection.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            serviceCollection.AddScoped<IOrderReadRepository, OrderReadRepository>();
            serviceCollection.AddScoped<IPublisherWriteRepository, PublisherWriteRepository>();
            serviceCollection.AddScoped<IPublisherReadRepository, PublisherReadRepository>();

            return serviceCollection;
        }
    }
}
