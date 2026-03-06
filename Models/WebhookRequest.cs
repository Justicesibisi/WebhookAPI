using System.ComponentModel.DataAnnotations;

namespace WebhookTask.Models
{
    public class WebhookRequest
    {
        [Required]
        public string Data { get; set; } = string.Empty;

        public int Id { get; set; }

        public int Age { get; set; }
    }
}
