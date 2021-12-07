namespace EFTutorial.Dtos
{
    public static class Extensions
    {
        public static VinylDto AsDto(this Vinyl vinyl)
        {
            return new VinylDto
            {
                Id = vinyl.Id,
                Title = vinyl.Title,
                Artist = vinyl.Artist
            };
        }
    }
}
