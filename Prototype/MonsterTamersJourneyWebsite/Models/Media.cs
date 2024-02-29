namespace MonsterTamersJourneyWebsite.Models
{
    public class Media
    {
        public int MediaId { get; set; }

        public int Order { get; set; }
        public string Title { get; set; }
        public bool isImage { get; set; } // "Video" or "Image"
        public string VideoUrl { get; set; }
        public string ImageUrl { get; set; }
    }
}
