using JsonExtractorAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace JsonExtractorAPI.Controllers
{
    [Route("api/[controller]")]
    public class JsonExtractorController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<String>> GetJson()
        {
            try
            {
                HttpClient client = new HttpClient();
                string fileId = "1j9-QgtRySDQKsuxgggesU1CHkc97z7UF";
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
