using Microsoft.AspNet.Identity.EntityFramework;
using TaskManagment.Models;

namespace TaskManagment.Data
{
    public class TMDbContext : IdentityDbContext<User>
    {
        public TMDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static TMDbContext Create()
        {
            return new TMDbContext();
        }
    }
}