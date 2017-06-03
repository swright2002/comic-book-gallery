namespace ComicBookGallery.Models
{
    public class Artist
    {
        public string Name { get; set; }
        public string Role { get; set; }


        public override string ToString()
        {
            return Role + ": " + Name;
        }

    }


}