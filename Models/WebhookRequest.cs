using System.ComponentModel.DataAnnotations;

namespace WebhookTask.Models
{
    public class WebhookRequest
    {
        [Required]
        public string Data { get; set; } = string.Empty;
    }
}
