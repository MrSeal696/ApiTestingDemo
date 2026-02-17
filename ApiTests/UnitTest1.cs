using NUnit.Framework;
using RestSharp;

namespace ApiTests
{
    public class Tests
    {
        private RestClient client;

        [SetUp]
        public void Setup()
        {
            client = new RestClient("https://localhost:7216");
        }

        [Test]
        public void GetUsers_ShouldReturn200()
        {
            var request = new RestRequest("/api/users", Method.Get);

            var response = client.Execute(request);

            Assert.That((int)response.StatusCode, Is.EqualTo(200));
        }

        [Test]
        public void CreateUser_ShouldReturn200()
        {
            var request = new RestRequest("/api/users", Method.Post);

            request.AddJsonBody(new
            {
                name = "TestUser",
                age = 20
            });

            var response = client.Execute(request);

            Assert.That((int)response.StatusCode, Is.EqualTo(200));
        }

        [Test]
        public void UpdateUser_ShouldReturn200()
        {
            var request = new RestRequest("/api/users/1", Method.Put);

            request.AddJsonBody(new
            {
                name = "Updated",
                age = 40
            });

            var response = client.Execute(request);

            Assert.That((int)response.StatusCode, Is.EqualTo(200));
        }

        [Test]
        public void DeleteUser_ShouldReturn200()
        {
            var request = new RestRequest("/api/users/1", Method.Delete);

            var response = client.Execute(request);

            Assert.That((int)response.StatusCode, Is.EqualTo(200));
        }
    }
}
