using EFTutorial.Data;
using EFTutorial.Dtos;

namespace EFTutorial
{
    public static class Extensions
    {
        public static VinylDto AsDto(this Vinyl vinyl)
        {
            return new VinylDto
            {
                Title = vinyl.Title,
                Artist = vinyl.ArtistId
            };
        }
    }
}
