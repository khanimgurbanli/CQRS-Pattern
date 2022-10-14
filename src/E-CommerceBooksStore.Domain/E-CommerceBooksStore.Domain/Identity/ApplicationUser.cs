
namespace E_CommerceBooksStore.Domain.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string Fullname { get; set; } = null!;
        public ICollection<Address> Addresses { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
