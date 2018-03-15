using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MVCProject.Models
{
   public enum AccountType
    {
        Donor,
        Charity
    }
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public AccountType Account_Type { get; set; }
        public string Address { get; set; }
        public string Member_Name { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base(@"Data Source=AHMEDHKHALIFA;Initial Catalog=WasltKherSystem;Integrated Security=True", throwIfV1Schema: false)
        {
        }
        public virtual DbSet<Post> posts { get; set; }
        public virtual DbSet<ApplyProposal> ApplyProposals { get; set; }
        public virtual DbSet<Deal> Deals { get; set; }
        public virtual DbSet<Images> Images { get; set; }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}