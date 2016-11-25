using System.Collections.Generic;

namespace PortfolioManager.Contract
{
    public class AlbumInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<string> PhotoUrls { get; set; }
    }
}
