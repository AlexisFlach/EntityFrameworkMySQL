namespace EFTutorial.Data
{
    public class Vinyl
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int ArtistId { get; set; }  
        public Artist Artist { get; set; }
      
    }
}
