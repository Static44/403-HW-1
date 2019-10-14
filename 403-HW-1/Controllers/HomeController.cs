using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _403_HW_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<SoccerTeam> loTeamList = new List<SoccerTeam>();

            loTeamList.Add(new SoccerTeam("RSL", 35, "http://content.sportslogos.net/logos/9/394/thumbs/39441222010.gif"));
            loTeamList.Add(new SoccerTeam("Colorado", 24, "http://content.sportslogos.net/logos/9/328/thumbs/rkjf0o1eifa47lh6uhy4oj5qy.gif"));
            loTeamList.Add(new SoccerTeam("FC Dallas", 42, "http://content.sportslogos.net/logos/9/329/thumbs/97yz6vcggd25lhyswy2fgvhfz.gif"));
            loTeamList.Add(new SoccerTeam("Sporting KC", 39, "http://content.sportslogos.net/logos/9/2834/thumbs/hzgsk662crxwpeffygd9vazda.gif"));
            loTeamList.Add(new SoccerTeam("San Jose", 16, "http://content.sportslogos.net/logos/9/332/thumbs/33279522014.gif"));
            loTeamList.Add(new SoccerTeam("Houston", 27, "http://content.sportslogos.net/logos/9/1482/thumbs/h8ga63uac257c37js2m47hqke.gif"));
            loTeamList.Add(new SoccerTeam("Seattle", 32, "http://content.sportslogos.net/logos/9/2760/thumbs/2xkgg8fsj5zgywdhx5in779ed.gif"));
            loTeamList.Add(new SoccerTeam("Vancouver", 33, "http://content.sportslogos.net/logos/9/2835/thumbs/vk6eh75qeug9nejz5g4k1evlo.gif"));
            loTeamList.Add(new SoccerTeam("Minnesota", 29, "http://content.sportslogos.net/logos/9/6288/thumbs/628827592017.gif"));
            loTeamList.Add(new SoccerTeam("Portland", 37, "http://content.sportslogos.net/logos/9/2836/thumbs/283698422015.gif"));
            loTeamList.Add(new SoccerTeam("LA Galaxy", 37, "http://content.sportslogos.net/logos/9/331/thumbs/wcwwzw1ysgmdcgkguwof.gif"));
            loTeamList.Add(new SoccerTeam("LAFC", 39, "http://content.sportslogos.net/logos/9/5480/thumbs/548055242018.gif"));


            List<SoccerTeam> loTeamSorted = loTeamList.OrderByDescending(x => x.Points).ToList();
            int iRanking = 0;

            ViewBag.Output = "<table>";
            ViewBag.Output += "<tr>";
            ViewBag.Output += "<th>Ranking</th>";
            ViewBag.Output += "<th>Logo</th>";
            ViewBag.Output += "<th>Team Name</th>";
            ViewBag.Output += "<th>Points</th>";
            ViewBag.Output += "</tr>";
            foreach (SoccerTeam oTeam in loTeamSorted)
            {
                ViewBag.Output = ViewBag.Output + "<tr>";
                ViewBag.Output = ViewBag.Output + "<td>" + ++iRanking + "</td>";
                ViewBag.Output = ViewBag.Output + "<td>" + "<img src=" + oTeam.LogoImgLocation + ">" + "</td>";
                ViewBag.Output = ViewBag.Output + "<td>" + oTeam.Name + "</td>";
                ViewBag.Output = ViewBag.Output + "<td>" + oTeam.Points + "</td>";
                ViewBag.Output = ViewBag.Output + "</tr>";

            }
            ViewBag.Output += "</table>";

            return View();
        }
    }

    public class Team
    {
        public string Name { get; set; }
        public string LogoImgLocation { get; set; }
        public int Wins { get; set; }
        public int Loss { get; set; }
    }

    public class SoccerTeam : Team
    {
        //empty constructor
        public SoccerTeam()
        {

        }
        //constructor with name and points
        public SoccerTeam(string teamName, int teamPoints, string teamLogoLink)
        {
            base.Name = teamName;
            base.LogoImgLocation = teamLogoLink;
            this.Points = teamPoints;
        }

        public int Draw { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        public int Differential { get; set; }
        public int Points { get; set; }
    }
} 