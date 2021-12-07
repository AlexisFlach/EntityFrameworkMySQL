using EFTutorial.Data;
using System.Collections.Generic;

namespace EFTutorial.Repository
{
    public interface IVinylsRepository
    {
        IEnumerable<Vinyl> GetVinyls();
    }
}
