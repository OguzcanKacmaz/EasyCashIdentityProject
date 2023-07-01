using Microsoft.AspNetCore.Identity;

namespace EasyCash.EntityLayer.Concrete;

public class AppUser : IdentityUser<int>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string District { get; set; }
    public string City { get; set; }
    public string ImageUrl { get; set; }
    public ICollection<CustomerAccount> CustomerAccounts { get; set; }
}
