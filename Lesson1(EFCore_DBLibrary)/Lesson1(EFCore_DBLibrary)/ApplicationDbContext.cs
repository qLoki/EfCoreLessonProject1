using Microsoft.EntityFrameworkCore;
namespace Lesson1_EFCore_DBLibrary_
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext()
        {
                
        }
        public ApplicationDbContext( DbContextOptions options) : base(options)
        {
                            
        }
    }
}