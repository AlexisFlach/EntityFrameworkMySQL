using EFTutorial.Data;
using System.Collections.Generic;

namespace EFTutorial.Repository
{
    public interface IVinylsRepository
    {
        IEnumerable<Vinyl> GetVinyls();

        Vinyl GetVinyl(int id);

        bool AddVinyl(Vinyl v);

        bool UpdateVinyl(Vinyl v);

        bool DeleteVinyl(int id);
    }
}
