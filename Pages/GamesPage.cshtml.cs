using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using GameData;

namespace GameWebsite.Pages
{
    public class GamesPageModel : PageModel
    {
		public readonly GameDataHolder games;
		private readonly ILogger<GamesPageModel> _logger;

        public GamesPageModel(ILogger<GamesPageModel> logger)
        {
            _logger = logger;
			games = new GameDataHolder();
		}

        public void OnGet()
        {
        }
    }
}
