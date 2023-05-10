namespace SearchMovie.Models
{
    public class MovieModel
    {
        // ------> GET SEARCH MOVIE

        public class SearchResponse
        {
            public List<MovieBySearch> Search { get; set; }
            public string totalResults { get; set; }
            public string Response { get; set; }
        }

        public class MovieBySearch
        {
            public string Title { get; set; }
            public string Year { get; set; }
            public string imdbID { get; set; }
            public string Type { get; set; }
            public string Poster { get; set; }
        }

        // ----> GET MOVIE

        public class Rating
        {
            public string Source { get; set; }
            public string Value { get; set; }
        }

        public class Movie
        {
            public string Title { get; set; }
            public string Year { get; set; }
            public string Rated { get; set; }
            public string Released { get; set; }
            public string Runtime { get; set; }
            public string Genre { get; set; }
            public string Director { get; set; }
            public string Writer { get; set; }
            public string Actors { get; set; }
            public string Plot { get; set; }
            public string Language { get; set; }
            public string Country { get; set; }
            public string Awards { get; set; }
            public string Poster { get; set; }
            public List<Rating> Ratings { get; set; }
            public string Metascore { get; set; }
            public string imdbRating { get; set; }
            public string imdbVotes { get; set; }
            public string imdbID { get; set; }
            public string Type { get; set; }
            public string DVD { get; set; }
            public string BoxOffice { get; set; }
            public string Production { get; set; }
            public string Website { get; set; }
            public string Response { get; set; }
        }

        // -------> CASTED MOVIES

        public class CastMovies
        {
            public Movie[] castMovies { get; set; }
            public Movie SpiderMan { get; set; }
            public Movie JohnWick { get; set; }
            public Movie DoctorStrange { get; set; }
            public Movie Orphan { get; set; }

            public CastMovies()
            {
                castMovies = new Movie[]
                {
                    JohnWick = new Movie()
                    {
                        Title = "John Wick",
                        Plot = "An ex-hit-man comes out of retirement to track down the gangsters that killed his dog and took his car.",
                        Year = "2014",
                        Genre = "Action, Crime, Thriller",
                        Actors = "Keanu Reeves, Michael Nyqvist, Alfie Allen",
                        Poster = "https://m.media-amazon.com/images/M/MV5BMTU2NjA1ODgzMF5BMl5BanBnXkFtZTgwMTM2MTI4MjE@._V1_SX300.jpg"
                    },
                    SpiderMan = new Movie()
                    {
                        Title = "Spider - Man",
                        Plot = "After being bitten by a genetically-modified spider, a shy teenager gains spider-like abilities that he uses to fight injustice as a masked superhero and face a vengeful enemy.",
                        Year = "2002",
                        Genre = "Action, Adventure, Sci-Fi",
                        Actors = "Tobey Maguire, Kirsten Dunst, Willem Dafoe",
                        Poster = "https://m.media-amazon.com/images/M/MV5BZDEyN2NhMjgtMjdhNi00MmNlLWE5YTgtZGE4MzNjMTRlMGEwXkEyXkFqcGdeQXVyNDUyOTg3Njg@._V1_SX300.jpg"
                    },
                    DoctorStrange = new Movie()
                    {
                        Title = "Doctor Strange: Multiversal Madness",
                        Plot = "Doctor Strange embarks on a multiversal journey with Brother Voodoo to stop Wanda before its too late.",
                        Year = "2022",
                        Genre = "Action, Mystery, Sci-Fi",
                        Actors = "Richard Croxford, Amelia Forsyth-Smith, James",
                        Poster = "https://m.media-amazon.com/images/M/MV5BMWE0Nzk4MTAtOTgzNC00NGQ1LTg0NzQtYjAyMTEwMTYxMmM5XkEyXkFqcGdeQXVyMTI1MDg1NjU3._V1_SX300.jpg"
                    },
                    Orphan = new Movie()
                    {
                        Title = "Orphan",
                        Plot = "A husband and wife who recently lost their baby adopt a 9-year-old girl who is not nearly as innocent as she appears.",
                        Year = "2009",
                        Genre = "Horror, Mystery, Thriller",
                        Actors = "Vera Farmiga, Peter Sarsgaard, Isabelle Fuhrman",
                        Poster = "https://m.media-amazon.com/images/M/MV5BMTBjMjY0ODEtZGVkMy00MjUyLTlkMjAtNDBmNzVjOTk0NzQyXkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_SX300.jpg"
                    }
                };
            }
        }
    }
}
