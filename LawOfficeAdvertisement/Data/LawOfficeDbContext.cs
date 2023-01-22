using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LawOfficeAdvertisement.Data
{
    public class LawOfficeDbContext : IdentityDbContext
    {
        public LawOfficeDbContext(DbContextOptions<LawOfficeDbContext> options)
            : base(options)
        {
        }
    }
}