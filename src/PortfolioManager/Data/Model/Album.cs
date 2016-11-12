using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PortfolioManager.Data.Model
{
    public class Album
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public bool IsPrivate { get; set; }

        public string PassCode { get; set; }

        public ICollection<Photo> Photos { get; set; }
    }
}
