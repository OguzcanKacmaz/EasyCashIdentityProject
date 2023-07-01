using EasyCash.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EasyCash.DataAccessLayer.Concrete;

public class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, int>
{
    public const string ConnectionName = "EasyCashCs";
    public DbSet<CustomerAccount> CustomerAccounts => Set<CustomerAccount>();
    public DbSet<CustomerAccountProcess> CustomerAccountProcesses => Set<CustomerAccountProcess>();
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
}
