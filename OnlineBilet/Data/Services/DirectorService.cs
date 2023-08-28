using OnlineBilet.Data.Base;
using OnlineBilet.Models;

namespace OnlineBilet.Data.Services
{
    public class DirectorService: EntityBaseRepository<Director>, IDirectorsService
    {
        public DirectorService(AppDbContext context): base(context)
        { 
        }
    }
}
