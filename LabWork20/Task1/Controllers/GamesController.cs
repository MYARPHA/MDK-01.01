using Microsoft.AspNetCore.Mvc;
using Task1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        static List<Game> games = new List<Game>
        {
            new Game{Id = 1, Name = "Tetris", Category = "головоломка", Price = 150},
            new Game{Id = 2, Name = "Flappy Bird", Description = "игра про летучую птицу", Category = "платформер", Price = 10},
            new Game{Id = 3, Name = "Pac-man", Description = "игра про колобка", Category = "аркада", Price = 300},
            new Game{Id = 4, Name = "Arkanoid", Category = "аркада", Price = 400},
            new Game{Id = 5, Name = "Mario", Description = "игра про Марио", Category = "платформер", Price = 1000},
            new Game{Id = 6, Name = "Tetris2", Category = "головоломка", Price = 150},
            new Game{Id = 7, Name = "Flappy Bird2", Description = "игра про летучую птицу", Category = "платформер", Price = 10},
            new Game{Id = 8, Name = "Pac-man2", Description = "игра про колобка", Category = "аркада", Price = 300},
            new Game{Id = 9, Name = "Arkanoid2", Category = "аркада", Price = 400},
            new Game{Id = 10, Name = "Mario2", Description = "игра про Марио", Category = "платформер", Price = 1000},
        };

        //GET: api/<GamesController>
        [HttpGet]
        public IEnumerable<Game> Get(int? limit, int? page)
        {
            if (limit != null && page != null)
                return games.Skip((int)limit * ((int)page - 1)).Take((int)limit);
            return games;
        }

        // GET api/<GamesController>/5
        [HttpGet("{id:int}")]
        public Game Get(int id)
        {
            return games.FirstOrDefault(game => game.Id == id);
        }

        [HttpGet("{category}")]
        public IEnumerable<Game> Get(string category)
        {
            return games.Where(game => game.Category == category);
        }

        //POST api/<GamesController>
        [HttpPost]
        public void Post([FromBody] Game value)
        {

        }

        // PUT api/<GamesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Game value)
        {
        }

        // DELETE api/<GamesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var game = games.FirstOrDefault(category => category.Id == id);
            games.Remove(game);
        }
    }
}
