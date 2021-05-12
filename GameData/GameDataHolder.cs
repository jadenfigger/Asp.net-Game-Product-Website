using System;
using GameTemplate;
using System.Collections.Generic;

namespace GameData
{
    public class GameDataHolder
    {
		public readonly List<Game> Games;
		public GameDataHolder() {
			Games = new List<Game>()
			{
				new Game {Id = 1, Name = "Call of Duty: BO1", ReleaseDate = 2010, Genre = "FPS"},
				new Game {Id = 2, Name = "Call of Duty: BO2", ReleaseDate = 2012, Genre = "FPS"},
				new Game {Id = 3, Name = "Call of Duty: BO3", ReleaseDate = 2015, Genre = "FPS"},
				new Game {Id = 4, Name = "Call of Duty: BO4", ReleaseDate = 2018, Genre = "FPS"},
				new Game {Id = 5, Name = "The Last of Us", ReleaseDate = 2013, Genre = "Action-Adventure"},
				new Game {Id = 6, Name = "The Last of Us 2", ReleaseDate = 2020, Genre = "Action-Adventure"},
				new Game {Id = 7, Name = "Assassins Creed", ReleaseDate = 2007, Genre = "Adventure"},
				new Game {Id = 8, Name = "Assassins Creed 2", ReleaseDate = 2010, Genre = "Adventure"},
				new Game {Id = 9, Name = "Assassins Creed: Brotherhood", ReleaseDate = 2011, Genre = "Adventure"},
				new Game {Id = 10, Name = "Assassins Creed 3", ReleaseDate = 2012, Genre = "Adventure"},
				new Game {Id = 11, Name = "Assassins Creed: Valhayla", ReleaseDate = 2020, Genre = "Adventure"},
			};
		}
    }
}
