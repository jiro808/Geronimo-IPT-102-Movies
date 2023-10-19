using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace BSIT3L_Movies.Controllers
{
	public class MoviesController : Controller
	{
		private List<MovieViewModel> _movies;
		public MoviesController()
		{
			// Sample movie data
			_movies = new List<MovieViewModel>
			{
		new MovieViewModel { Id = 1, Name = "Breaking Bad", Rating = "9.4", ReleaseYear = 2018, Genre = "Action", ytid="HhesaQXLuRY", ImageUrl ="/images/breakingbad.jpg" },
		new MovieViewModel { Id = 2, Name = "Stranger Things", Rating = "8.7", ReleaseYear = 2001, ytid="mnd7sFt5c3A", Genre = "ScienceFiction/Horror", ImageUrl ="/images/strangerthings.jpg" },
		new MovieViewModel { Id = 3, Name = "Gladiator", Rating = "8.5", ReleaseYear = 2017, Genre = "Action/Adventure/Drama",ytid="P5ieIbInFpg", ImageUrl ="/images/gladiator.jpg" },
		 new MovieViewModel { Id = 4, Name = "Inception", Rating = "8.8", ReleaseYear = 2009, Genre = "Action/Adventure/Sci-Fi", ytid="YoHD9XEInc0", ImageUrl ="/images/inception.jpg" },
		new MovieViewModel { Id = 5, Name = "Forrest Gump", Rating = "8.8", ReleaseYear = 2013, Genre = "Romantic Comedy/Drama", ytid="bLvqoHBptjg", ImageUrl ="/images/forrestgump.jpg" },
		new MovieViewModel { Id = 6, Name = "The Lord of the Rings: The Fellowship of the Ring", Rating = "8.8", ReleaseYear = 2004, Genre = "Action/Adventure/Sci-Fi",ytid="V75dMMIW2B4", ImageUrl ="/images/lordoftherings.jpg" },
		new MovieViewModel { Id = 7, Name = "Pulp Fiction", Rating = "8.9", ReleaseYear = 2001, Genre = "Crime/Drama", ytid="s7EdQ4FqbhY",ImageUrl ="/images/pulpfiction.jpg" },
		 new MovieViewModel { Id = 8, Name = "Game of Thrones", Rating = "9.3", ReleaseYear = 1989, Genre = "Action/Adventure/Drama", ytid = "bjqEWgDVPe0", ImageUrl ="/images/gameofthrones.jpg" },
		new MovieViewModel { Id = 9, Name = "Friends", Rating = "8.5", ReleaseYear = 2014, Genre = "Comedy/Romance", ytid = "IEEbUzffzrk", ImageUrl ="/images/friends.jpg" },
		new MovieViewModel { Id = 10, Name = "The Green Mile", Rating = "8.6", ReleaseYear = 2014, Genre = "Drama/Fantasy", ytid = "Ki4haFrqSrw", ImageUrl ="/images/greenmile.jpg" },
		new MovieViewModel { Id = 11, Name = "The Silence of the Lambs", Rating = "8.1", ReleaseYear = 2014, Genre = "Crime/Thriller", ytid = "W6Mm8Sbe__o", ImageUrl ="/images/silenceofthelambs.jpg" },
		new MovieViewModel { Id = 12, Name = "The Good, the Bad and the Ugly", Rating = "8.8", ReleaseYear = 2009, Genre = "Western", ytid = "WCN5JJY_wiA", ImageUrl ="/images/thegood.jpg" },
		new MovieViewModel { Id = 13, Name = "The Pianist", Rating = "8.5", ReleaseYear = 2015, Genre = "Biography/Drama", ytid = "BFwGqLa_oAo", ImageUrl ="/images/pianist.jpg" },
 new MovieViewModel { Id = 14, Name = "The Departed", Rating = "8.5", ReleaseYear = 1996, Genre = "Crime/Thriller", ytid = "iojhqm0JTW4", ImageUrl ="/images/departed.jpg" },
		new MovieViewModel { Id = 15, Name = "The Grand Budapest Hotel", Rating = "8.5", ReleaseYear = 2017, Genre = "Comedy/Crime", ytid = "1Fg5iWmQjwk", ImageUrl ="/images/budapest.jpg" },
	 };
        }
        public IActionResult Index()
        {
            return View(_movies);
        }
        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Avatar", Rating = "5" };
            return View(movie);
        }
        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return View(movie);

        }

    }
}

