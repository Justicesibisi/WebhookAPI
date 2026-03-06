namespace WebhookTask.Models
{
    public class WebhookResponse
    {
        public int Id { get; set; }

        public int Age { get; set; }

        public string[] Word { get; set; } = Array.Empty<string>();
    }
}
