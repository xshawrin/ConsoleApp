using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasic
{
     class Game
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public double Rating { get; set; }
        public int Price { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*“Do I need to filter?” → Where
“Do I need to pick a value?” → Select
“Do I need one result?” → First, Max
“Do I need order?” → OrderBy*/
            //List<int>numbers = new List<int> { 1,2,3,4,5,6};
            //var result = numbers.Where(n => n % 2 == 0).ToList();
            //var list = numbers.Where(n => n > 2).ToList();
            //Console.WriteLine(string.Join(", ", result));
            //Console.WriteLine(string.Join(", ", list));
            var games = new List<Game>
            {
                new Game{ Title = "The legend of Zelda", Genre = "Adventure", ReleaseYear = 1986, Rating = 5.0, Price = 60},
                new Game{ Title = "Super Mario Boss", Genre = "Platformer", ReleaseYear = 1985, Rating = 9.2, Price = 50},
                new Game{ Title = "Elden Ring", Genre = "Adventure", ReleaseYear = 2022, Rating = 9.8, Price = 50},
                new Game{ Title = "Stardew Valley", Genre = "Simulation", ReleaseYear = 2016, Rating = 7.0, Price = 15},
                new Game{ Title = "Tetris", Genre = "Puzzle", ReleaseYear = 1984, Rating = 8.9, Price = 10},
            };
            /* foreach (var game in games) //Traditional way
             {
                 Console.WriteLine(game.Title);
             }*/
            // var allgames = games.Select(g  => g.Title);
            //var AdvenGames = games.Where(game => game.Genre == "Adventure");//filter
            // foreach (var game in AdvenGames)
            // Console.WriteLine(game.Title);
            // var modernGamesExist = games.Any(g => g.ReleaseYear > 2025);//validation
            // Console.WriteLine($"Are there modern games? {modernGamesExist}");//validation
            /* var sortByYear = games.OrderBy(g => g.ReleaseYear);//sorting
              foreach (var game in sortByYear)
              {
                  Console.WriteLine($"{game.Title}: {game.ReleaseYear}");
        }*/
            // var SortByRating = games.OrderByDescending(g => g.Rating).First();//high to low
            //foreach (var game in SortByRating)

            //Console.WriteLine($"{SortByRating.Title}: {SortByRating.Rating}");

            /* var AveragePrice = games.Average(g =>  g.Price);//overall average
                Console.WriteLine($"Average game price: {AveragePrice}");*/
            /*var highRating = games.Max(game => game.Rating);
            var bestGame = games.First(g => g.Rating == highRating);
            Console.WriteLine($"Highest Rated Game: {bestGame.Title}: {bestGame.Rating}");*/

             var groupByGenre = games.GroupBy(g => g.Genre);
             foreach(var group in groupByGenre)
             {
                 Console.WriteLine($"Genre: {group.Key}");
                 foreach(var game in group)
                 {
                     Console.WriteLine($"Title: {game.Title}");
                 }
             }
            /* var budgetAdventureGames = games
                  .Where(g => g.Genre == "Adventure" && g.Price <= 60)
                  .OrderBy(g => g.Rating)
                  .Select(g => $"{g.Title} - {g.Price}");
             foreach( var game in budgetAdventureGames)
             {
                 Console.WriteLine(game);
             }*/
            /* var skipGames = games.Skip(2).Take(2);
              foreach (var game in skipGames)
                  Console.WriteLine(game.Title);*/

            //Get all games with rating greater than 8...

            /* var topRatingGames = games.Where(g => g.Rating > 9)
                 .Select(g=> g.Title);
             foreach (var game in topRatingGames)
                 Console.WriteLine(game);*/

            //Get games with rating below 5...
            /* var lowRatingGames = games.Where(g => g.Rating < 8)
                 .Select(g => g.Title);
             foreach (var game in lowRatingGames)
                 Console.WriteLine(game);*/

            //Get the first game with rating above 9...
            /* var SortByRating = games.OrderByDescending(g => g.Rating).First();
              Console.WriteLine($"{SortByRating.Title}: {SortByRating.Rating}");*/

            //Exercise 5 — Highest rated game (two ways)A) Using Max +First
            //         B) Using OrderByDescending +First
            /* var HighRatedGame = games.Max(g=> g.Rating);
             var bestGames = games.First(g=> g.Rating == HighRatedGame);
             Console.WriteLine($"Highest Rated Game: {bestGames.Title}: {bestGames.Rating}");*/

            // How many games have rating >= 7...
            /* var Totalgames = games.Count(g => g.Rating <= 7);
              Console.WriteLine(Totalgames);
              //Get titles of games with rating <=9, sorted alphabetically
              var titleGames = games.Where(g=> g.Rating <=9)
              .OrderBy(g => g.Title);      
              foreach(Game game in titleGames)
              Console.WriteLine(game.Title);*/

            //Get the top 3 highest-rated game titles...
            /* var highestRated = games.OrderByDescending(g => g.Rating)
                 .Take(3);
                 //.Select(g => g.Title);
                 foreach (Game game in highestRated)
                 Console.WriteLine(game.Title);*/
            //Are there ANY games with rating below 5? result true or false..
            /*bool hasBadGames = games.Any(g => g.Rating <= 5);
            Console.WriteLine(hasBadGames);*/

            //Check if all items match. means all games are over 6 rating. result true or false...
            /* bool allGood = games.All(g => g.Rating > 6);
             Console.WriteLine(allGood);*/

            //Adds all ratings together...
            var totalRating = games.Sum(game => game.Rating);
            Console.WriteLine(totalRating);

            //Average values...
            var averageRating = games.Average(game => game.Rating);
            Console.WriteLine(averageRating);
             //Lowest Rating...
             var lowestRating = games.Min(game => game.Rating);
            Console.WriteLine(lowestRating);

            //Higest Rating...
            var highestRating = games.Max(game => game.Rating);
            Console.WriteLine(highestRating);

            //Group by category...
          /*  var groupByGenre = games.GroupBy(g => g.Genre);
            Console.WriteLine(groupByGenre);*/


        }
    }
}
