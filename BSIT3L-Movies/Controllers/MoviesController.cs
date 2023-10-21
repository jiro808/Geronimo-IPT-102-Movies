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
		new MovieViewModel { Id = 1, Name = "Breaking Bad", Rating = "9.4", ReleaseYear = 2018, Genre = "Action", ytid="HhesaQXLuRY", ImageUrl ="/images/breakingbad.jpg", MovieDetails="Set in Albuquerque, New Mexico, between 2008 and 2010, Breaking Bad follows Walter White, a struggling, frustrated high school chemistry teacher who transforms into a ruthless kingpin in the local methamphetamine drug trade, driven to provide for his family financially after being diagnosed with inoperable lung cancer." },
		new MovieViewModel { Id = 2, Name = "Stranger Things", Rating = "8.7", ReleaseYear = 2001, ytid="mnd7sFt5c3A", Genre = "ScienceFiction/Horror", ImageUrl ="/images/strangerthings.jpg", MovieDetails="Stranger Things is set in the fictional rural town of Hawkins, Indiana, in the 1980s. The nearby Hawkins National Laboratory ostensibly performs scientific research for the United States Department of Energy but secretly experiments with the paranormal and supernatural, sometimes with human test subjects." },
		new MovieViewModel { Id = 3, Name = "Gladiator", Rating = "8.5", ReleaseYear = 2017, Genre = "Action/Adventure/Drama",ytid="P5ieIbInFpg", ImageUrl ="/images/gladiator.jpg",MovieDetails="Set in Roman times, the story of a once-powerful general forced to become a common gladiator. The emperor's son is enraged when he is passed over as heir in favour of his father's favourite general. He kills his father and arranges the murder of the general's family, and the general is sold into slavery to be trained as a gladiator - but his subsequent popularity in the arena threatens the throne." },
		 new MovieViewModel { Id = 4, Name = "Inception", Rating = "8.8", ReleaseYear = 2009, Genre = "Action/Adventure/Sci-Fi", ytid="YoHD9XEInc0", ImageUrl ="/images/inception.jpg", MovieDetails="Cobb (Leonardo DiCaprio) is a corporate raider of the highest order. He infiltrates the minds of other men to steal their ideas. Now he is hired by a powerful billionaire to do the opposite: To introduce an idea into a rival's mind, and do it so well he believes it is his own." },
		new MovieViewModel { Id = 5, Name = "Forrest Gump", Rating = "8.8", ReleaseYear = 2013, Genre = "Romantic Comedy/Drama", ytid="bLvqoHBptjg", ImageUrl ="/images/forrestgump.jpg", MovieDetails="Slow-witted Forrest Gump (Tom Hanks) has never thought of himself as disadvantaged, and thanks to his supportive mother (Sally Field), he leads anything but a restricted life. Whether dominating on the gridiron as a college football star, fighting in Vietnam or captaining a shrimp boat, Forrest inspires people with his childlike optimism. But one person Forrest cares about most may be the most difficult to save -- his childhood love, the sweet but troubled Jenny (Robin Wright)." },
		new MovieViewModel { Id = 6, Name = "The Lord of the Rings: The Fellowship of the Ring", Rating = "8.8", ReleaseYear = 2004, Genre = "Action/Adventure/Sci-Fi",ytid="V75dMMIW2B4", ImageUrl ="/images/lordoftherings.jpg", MovieDetails="The future of civilization rests in the fate of the One Ring, which has been lost for centuries. Powerful forces are unrelenting in their search for it. But fate has placed it in the hands of a young Hobbit named Frodo Baggins (Elijah Wood), who inherits the Ring and steps into legend. A daunting task lies ahead for Frodo when he becomes the Ringbearer - to destroy the One Ring in the fires of Mount Doom where it was forged." },
		new MovieViewModel { Id = 7, Name = "Pulp Fiction", Rating = "8.9", ReleaseYear = 2001, Genre = "Crime/Drama", ytid="s7EdQ4FqbhY",ImageUrl ="/images/pulpfiction.jpg", MovieDetails="Pulp Fiction is a 1994 American crime film written and directed by Quentin Tarantino from a story he conceived with Roger Avary. It tells four intertwining tales of crime and violence in Los Angeles, California. The film stars John Travolta, Samuel L. Jackson, Bruce Willis, Tim Roth, Ving Rhames, and Uma Thurman." },
		 new MovieViewModel { Id = 8, Name = "Game of Thrones", Rating = "9.3", ReleaseYear = 1989, Genre = "Action/Adventure/Drama", ytid = "bjqEWgDVPe0", ImageUrl ="/images/gameofthrones.jpg", MovieDetails="A Game of Thrones takes place over the course of one year on or near the fictional continent of Westeros. The story begins when King Robert visits the northern castle Winterfell to ask Ned Stark to be his right-hand assistant, or Hand of the King. The previous Hand, Jon Arryn, died under suspicious circumstances." },
		new MovieViewModel { Id = 9, Name = "Friends", Rating = "8.5", ReleaseYear = 2014, Genre = "Comedy/Romance", ytid = "IEEbUzffzrk", ImageUrl ="/images/friends.jpg", MovieDetails="Friends is a 90's Comedy TV show, based in Manhattan, about 6 friends who go through just about every life experience imaginable together; love, marriage, divorce, children, heartbreaks, fights, new jobs and job losses and all sorts of drama." },
		new MovieViewModel { Id = 10, Name = "The Green Mile", Rating = "8.6", ReleaseYear = 2014, Genre = "Drama/Fantasy", ytid = "Ki4haFrqSrw", ImageUrl ="/images/greenmile.jpg", MovieDetails="Paul Edgecomb (Tom Hanks) walked the mile with a variety of cons. He had never encountered someone like John Coffey (Michael Clarke Duncan), a massive black man convicted of brutally killing a pair of young sisters. Coffey had the size and strength to kill anyone, but not the demeanor. Beyond his simple, naive nature and a deathly fear of the dark, Coffey seemed to possess a prodigious, supernatural gift. Paul began to question whether Coffey was truly guilty of murdering the two girls." },
		new MovieViewModel { Id = 11, Name = "The Silence of the Lambs", Rating = "8.1", ReleaseYear = 2014, Genre = "Crime/Thriller", ytid = "W6Mm8Sbe__o", ImageUrl ="/images/silenceofthelambs.jpg", MovieDetails="Jodie Foster stars as Clarice Starling, a top student at the FBI's training academy. Jack Crawford (Scott Glenn) wants Clarice to interview Dr. Hannibal Lecter (Anthony Hopkins), a brilliant psychiatrist who is also a violent psychopath, serving life behind bars for various acts of murder and cannibalism. Crawford believes that Lecter may have insight into a case and that Starling, as an attractive young woman, may be just the bait to draw him out." },
		new MovieViewModel { Id = 12, Name = "The Good, the Bad and the Ugly", Rating = "8.8", ReleaseYear = 2009, Genre = "Western", ytid = "WCN5JJY_wiA", ImageUrl ="/images/thegood.jpg", MovieDetails="n the Southwest during the Civil War, a mysterious stranger, Joe (Clint Eastwood), and a Mexican outlaw, Tuco (Eli Wallach), form an uneasy partnership -- Joe turns in the bandit for the reward money, then rescues him just as he is being hanged. When Joe's shot at the noose goes awry during one escapade, a furious Tuco tries to have him murdered. The men re-team abruptly, however, to beat out a sadistic criminal and the Union army and find $20,000 that a soldier has buried in the desert." },
		new MovieViewModel { Id = 13, Name = "The Pianist", Rating = "8.5", ReleaseYear = 2015, Genre = "Biography/Drama", ytid = "BFwGqLa_oAo", ImageUrl ="/images/pianist.jpg", MovieDetails="In this adaptation of the autobiography \"The Pianist: The Extraordinary True Story of One Man's Survival in Warsaw, 1939-1945,\" Wladyslaw Szpilman (Adrien Brody), a Polish Jewish radio station pianist, sees Warsaw change gradually as World War II begins. Szpilman is forced into the Warsaw Ghetto, but is later separated from his family during Operation Reinhard. From this time until the concentration camp prisoners are released, Szpilman hides in various locations among the ruins of Warsaw." },
 new MovieViewModel { Id = 14, Name = "The Departed", Rating = "8.5", ReleaseYear = 1996, Genre = "Crime/Thriller", ytid = "iojhqm0JTW4", ImageUrl ="/images/departed.jpg", MovieDetails="South Boston cop Billy Costigan (Leonardo DiCaprio) goes under cover to infiltrate the organization of gangland chief Frank Costello (Jack Nicholson). As Billy gains the mobster's trust, a career criminal named Colin Sullivan (Matt Damon) infiltrates the police department and reports on its activities to his syndicate bosses. When both organizations learn they have a mole in their midst, Billy and Colin must figure out each other's identities to save their own lives." },
		new MovieViewModel { Id = 15, Name = "The Grand Budapest Hotel", Rating = "8.5", ReleaseYear = 2017, Genre = "Comedy/Crime", ytid = "1Fg5iWmQjwk", ImageUrl ="/images/budapest.jpg", MovieDetails="In the 1930s, the Grand Budapest Hotel is a popular European ski resort, presided over by concierge Gustave H. (Ralph Fiennes). Zero, a junior lobby boy, becomes Gustave's friend and protege. Gustave prides himself on providing first-class service to the hotel's guests, including satisfying the sexual needs of the many elderly women who stay there. When one of Gustave's lovers dies mysteriously, Gustave finds himself the recipient of a priceless painting and the chief suspect in her murder." },
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

