using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioManager.Contract;
using PortfolioManager.Data;

namespace PortfolioManager.Controllers
{
    public class AlbumController : Controller
    {
        private readonly PortfolioDbContext _dbContext;
        public AlbumController(PortfolioDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<AlbumInfo> GetAllPublic()
        {
            return
                _dbContext.Albums.Include(t => t.Photos)
                    .Where(t => !t.IsPrivate && t.Published)
                    .OrderBy(t => t.Order)
                    .Select(t => new AlbumInfo
                    {
                        Id = t.Id,
                        Name = t.Name,
                        PhotoUrls = t.Photos.Where(x => x.Published).OrderBy(x => x.Order).Select(x => x.Path)
                    });
        }
    }
}
