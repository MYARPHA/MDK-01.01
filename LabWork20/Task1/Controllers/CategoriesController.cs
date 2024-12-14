using Microsoft.AspNetCore.Mvc;
using Task1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        static List<Category> categories = new List<Category>
        {
            new Category{Id = 1, Name = "головоломка", Description = "описание жанра головоломка"},
            new Category{Id = 2, Name = "платформер", Description = "описание жанра платформер"},
            new Category{Id = 3, Name = "RPG", Description = "описание жанра RPG"},
            new Category{Id = 4, Name = "аркада", Description = "описание жанра аркада"},
            new Category{Id = 5, Name = "головоломкаrffrf", Description = "описание жанра головоломка"},
            new Category{Id = 6, Name = "платформерasdasd", Description = "описание жанра платформер"},
            new Category{Id = 7, Name = "mmoRPG", Description = "описание жанра RPG"},
            new Category{Id = 8, Name = "аркада2", Description = "описание жанра аркада"},

        };

        // GET: api/<CategoriesController>
        [HttpGet]
        public IEnumerable<Category> Get(int? limit, int? page)
        {
            if (limit != null && page != null)
                return categories.Skip((int)limit * ((int)page - 1)).Take((int)limit);
            return categories;
        }

        // GET api/<CategoriesController>/5
        [HttpGet("{id:int}")]
        public Category Get(int id)
        {
            return categories.FirstOrDefault(category => category.Id == id);
        }

        // GET api/<CategoriesController>/5
        [HttpGet("{name}")]
        public Category Get(string name)
        {
            return categories.FirstOrDefault(category => category.Name == name);
        }

        // POST api/<CategoriesController>
        //[HttpPost]
        //public Category Post([FromBody] Category category)
        //{
        //    category.Id = categories.Max(category => category.Id) + 1;
        //    categories.Add(category);
        //    return category;
        //}

        /// <summary>
        /// добавление категории
        /// </summary>
        /// <param name="category">категория</param>
        /// <response code="201">объект добавлен</response>>
        /// <response code="204">объект не добавлен</response>>
        /// <returns>созданный объект</returns>
        
        [HttpPost]
        public IActionResult Post([FromBody] Category category)
        {
            if (category.Name.Length < 3)
                return StatusCode(204);
            category.Id = categories.Max(category => category.Id) + 1;
            categories.Add(category);
            return StatusCode(201, category);
        }

        // PUT api/<CategoriesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Category category)
        {
        }

        // DELETE api/<CategoriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var category = categories.FirstOrDefault(category => category.Id == id);
            categories.Remove(category);
        }
    }
}
