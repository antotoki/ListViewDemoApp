using ListViewDemoApp.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ListViewDemoApp.Factory
{
    public static class PlayersFactory
    {
        public static IList<Player> Players { get; set; }

        static PlayersFactory()
        {
            Players = new ObservableCollection<Player>() {
                new Player
                {
                    Name = "Kobe Bryant",
                    Position = "Shooting guard",
                    Team = "Los Angeles Lakers"
                },
                new Player
                {
                    Name = "LeBron James",
                    Position = "Power forward",
                    Team = "Cleveland Cavaliers"
                },
                new Player{
                    Name ="Michael Jordan",

                    Position = "Shooting guard",
                    Team ="Chicago Bulls"
                },
                new Player
                {
                    Name ="Magic Johnson",
                    Position = "Point guard",
                    Team = "Los Angeles Lakers",
                },
                new Player
                {
                    Name = "Drazen Petrovic",

                    Position = "Shooting guard",
                    Team = "New Yersey nets"
                },
                new Player
                {
                    Name = "Karl Malone",
                    Position = "Power forward",
                    Team = "Utah Jazz"
                },
                new Player
                {
                    Name = "John Stockton",

                    Position = "Point guard",
                    Team = "Utah Jazz"
                },
                new Player
                {
                    Name = "Kevin Durant",
                    Position = "Power forward",
                    Team = "Golden State Warriros"
                },
                new Player
                {
                    Name = "Paul George",
                    Position = "Small forward",
                    Team = "Oklahoma City Thunder"
                },
                new Player
                {
                    Name = "James Harden",
                    Position = "Shooting guard",
                    Team = "Houston Rockets"
                },
                new Player
                {
                    Name = "DeAndre Jordan",
                    Position = "Center",
                    Team = "Los Angeles Clippers"
                },
                new Player
                {
                    Name = "Dirk Nowitzki",
                    Position = "Center",
                    Team = "Dallas Mavericks"
                },
                new Player
                {
                    Name = "Dwyane Wade",
                    Position = "Shooting guard",
                    Team = "Chicago Bulls"
                },
                new Player
                {
                    Name = "Klay Thompson",
                    Position = "Shooting guard",
                    Team = "Golden State Warriors"
                },
                new Player
                {
                    Name = "Serge Ibaka",
                    Position = "Power forward",
                    Team = "Toronto Raptors"
                },
                new Player
                {
                    Name = "Kawhi Leonard",
                    Position = "Small forward",
                    Team = "San Antonio Spurs"
                },
                new Player
                {
                    Name = "Carmelo Anthony",
                    Position = "Small forward",
                    Team = "New York Knicks"
                },
                new Player
                {
                    Name = "Rudy Gobert",
                    Position = "Center",
                    Team = "Utah Jazz"
                },
                new Player
                {
                    Name = "Nikola Jokic",
                    Position = "Center",
                    Team = "Denver Nuggets"
                },
                new Player
                {
                    Name = "Kyrie Irving",
                    Position = "Point guard",
                    Team = "Boston Celtics"
                },
                new Player
                {
                    Name = "Bojan Bogdanovic",
                    Position = "Shooting guard / Small forward",
                    Team = "Indiana Pacers"
                }
            };
        }
    }
}