using System.ComponentModel.DataAnnotations;

public class Url
{
    public string ID { get; set; }
    [Required]
    [Url]
    [Display(Name = "URL")]
    public string LongURL { get; set; }
    public string ShortenedURL
    {
        get; set;
    }
}