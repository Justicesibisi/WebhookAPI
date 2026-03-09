using Microsoft.AspNetCore.Mvc;
using WebhookTask.Models;

namespace WebhookTask.Controllers
{
    [ApiController]
    [Route("api/webhook")]
    public class WebhookController : ControllerBase
    {
        [HttpPost]
        public ActionResult<WebhookResponse> SortCharacters([FromBody] WebhookRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Data))
            {
                return BadRequest(new { error = "Data field is required" });
            }

            char[] characters = request.Data.ToCharArray();

            Array.Sort(characters);

            string[] sortedCharacters = characters
                .Select(c => c.ToString())
                .ToArray();

            var response = new WebhookResponse
            {
                Word = sortedCharacters
            };

            return Ok(response);
        }
    }
}
