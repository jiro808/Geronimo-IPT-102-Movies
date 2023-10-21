using System;
namespace BSIT3L_Movies.Models
{

	public class MovieViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Rating { get; set; }
		public int ReleaseYear { get; set; }
		public string Genre { get; set; }

		public string ImageUrl { get; set; }

		public string ytid { get; set; }

		public string MovieDetails { get; set; }

	}
}

