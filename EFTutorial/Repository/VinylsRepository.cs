using EFTutorial.Data;
using System.Collections.Generic;
using System.Linq;

namespace EFTutorial.Repository
{
    public class VinylsRepository : IVinylsRepository
    {
        private readonly MyDbContext _context;
        public VinylsRepository(MyDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Vinyl> GetVinyls()
        {
            return _context.Vinyl.ToList();
        }
    }
}
