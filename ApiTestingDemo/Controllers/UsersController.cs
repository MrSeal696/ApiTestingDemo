using Microsoft.AspNetCore.Mvc;

namespace ApiTestingDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private static List<User> users = new List<User>()
        {
            new User { Id = 1, Name = "Ivan", Age = 25 },
            new User { Id = 2, Name = "Maria", Age = 30 }
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = users.FirstOrDefault(x => x.Id == id);
            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            user.Id = users.Max(x => x.Id) + 1;
            users.Add(user);
            return Ok(user);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, User updatedUser)
        {
            var user = users.FirstOrDefault(x => x.Id == id);
            if (user == null)
                return NotFound();

            user.Name = updatedUser.Name;
            user.Age = updatedUser.Age;

            return Ok(user);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = users.FirstOrDefault(x => x.Id == id);
            if (user == null)
                return NotFound();

            users.Remove(user);
            return Ok();
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
