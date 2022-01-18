using System.Net.Mime;

namespace DevCart_MVC.Models
{
    public class Articel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public Articel(long id, string name, string description, string image)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
        }
    }
}