using JsonExtractorAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace JsonExtractorAPI.Controllers
{
    [Route("api/[controller]")]
    public class JsonExtractorController : ControllerBase
    {

        [HttpGet("{fileId}")]
        public async Task<ActionResult<String>> GetJson(string fileId)
        {
            try
            {
                HttpClient client = new HttpClient();
                string downloadUrl = $"https://drive.google.com/uc?id={fileId}&export=download";

                var response = await client.GetAsync(downloadUrl);
                response.EnsureSuccessStatusCode();
                string content = await response.Content.ReadAsStringAsync();

                return Ok($"{content}");
            }
            catch (Exception ex)
            {
                //Log the error i.e., ex.Message
                return NotFound($"File not found {ex.Message}");
            }
        }
    }
}
