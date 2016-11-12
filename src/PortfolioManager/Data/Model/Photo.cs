using System.ComponentModel.DataAnnotations;

namespace PortfolioManager.Data.Model
{
    public class Photo
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [MaxLength(300)]
        public string Path { get; set; }

        public int AlbumId { get; set; }

        public bool Published { get; set; }

        public Album Album { get; set; }
    }
}
