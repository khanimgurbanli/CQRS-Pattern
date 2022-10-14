using BookApi.Domain.Entities;
using E_CommerceBooksStore.Application.Common.Interfaces;
using E_CommerceBooksStore.Domain.Entities;
using E_CommerceBooksStore.Domain.Identity;
using E_CommerceBooksStore.Infrastructure.Persistence.Interceptor;
using MediatR;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace E_CommerceBooksStore.Infrastructure.Persistence.Contexts
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
       // private readonly IMediator _mediator;
        private readonly AuditableEntitySaveChangesInterceptor _auditableEntitySaveChangesInterceptor;

        
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options,
            AuditableEntitySaveChangesInterceptor auditableEntitySaveChangesInterceptor)
            : base(options)
        {
           // _mediator = mediator;
            _auditableEntitySaveChangesInterceptor = auditableEntitySaveChangesInterceptor;
        }


        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Book> Books => Set<Book>();
        public DbSet<Order> Orders => Set<Order>();

        public DbSet<Address> Addresses => Set<Address>();

        public DbSet<Author> Authors => Set<Author>();

        public DbSet<BasketItem> BasketItems => Set<BasketItem>();

        public DbSet<Domain.Entities.File> Files => Set<Domain.Entities.File>();

        public DbSet<Language> Languages => Set<Language>();

        public DbSet<Publisher> Publishers => Set<Publisher>();

        public DbSet<Sale> Sales => Set<Sale>();

        public DbSet<WishListItem> WishListItems => Set<WishListItem>();

        public DbSet<Genre> Genres => Set<Genre>();

        public DbSet<BookLanguage> BookLanguages => Set<BookLanguage>();

        public DbSet<BookFormat> BookFormats => Set<BookFormat>();  

        public DbSet<BookPrice> BookPrices => Set<BookPrice>(); 

        public DbSet<Discount> Discounts =>Set<Discount>(); 

        public DbSet<Format> Formats => Set<Format>();  

        public DbSet<Review> Reviews => Set<Review>();  

        public DbSet<Vendor> Vendor => Set<Vendor>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.AddInterceptors(_auditableEntitySaveChangesInterceptor);
        }

        //public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        //{
        //    await _mediator.DispatchDomainEvents(this);

        //    return await base.SaveChangesAsync(cancellationToken);
        //}

    }
}
