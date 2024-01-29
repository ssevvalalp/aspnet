namespace basics_FilmsApp.Models
{
    public class Film
    {
        public int FilmId { get; set; }
        public string? FilmName { get; set;}
        public string? FilmDescription { get; set; }

        public string? Image {  get; set; }

        public bool isActive { get; set; }



    }
}
