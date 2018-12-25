using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using StoreFront.Models;
using StoreFront.DataAccess;

namespace StoreFront.Controllers
{
    public class PlayersController : Controller
    {
        // GET: Players
        public async Task<ActionResult> Index()
        {
            DAPlayers daPlayers = new DAPlayers();

            IEnumerable<Player> players = await daPlayers.GetPlayers();


           
            return View(players);
        }

        public async Task<ActionResult> Details(int? PlayerID)
        {
            DAPlayers daPlayers = new DAPlayers();

            IEnumerable<Player> players = await daPlayers.GetPlayers();

            Player player = players.SingleOrDefault(p => p.PlayerID == PlayerID);

            return View(player);


        }
    }
}