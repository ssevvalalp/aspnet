namespace basics_FilmsApp.Models
{
    public class Repository
    {
        private static readonly List<Film> _films = new List<Film>();

        //constructor
        static Repository()
        {
            _films = new List<Film>()
            {
                new Film()
                {
                    FilmId = 1,
                    FilmName = "Foo",
                    FilmDescription = "Bar",
                    Image = "1.jpg",
                    isActive = true
                },
                 new Film()
                {
                    FilmId = 1,
                    FilmName = "Foo",
                    FilmDescription = "Bar",
                    Image = "2.jpg",
                    isActive = true
                },
                  new Film()
                {
                    FilmId = 1,
                    FilmName = "Foo",
                    FilmDescription = "Bar",
                    Image = "3.jpg",
                    isActive = true
                }
            }; 
        }

        //public
        public static List<Film> Film { get {  return _films; } }

        //routing

        public static Film? GetById(int? id)
        {
            return _films.FirstOrDefault(x => x.FilmId == id);
        }
    }
}
