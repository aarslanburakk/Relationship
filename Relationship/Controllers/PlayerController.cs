using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Releationship.DbConnection;
using Releationship.DTOs;
using Releationship.Models;

namespace Releationship.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {


        private readonly ReleationDbContext _context;
        public PlayerController(ReleationDbContext context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<IActionResult> CreatePlayer(CreatePlayerDTO data)
        {
            var player = new Player
            {
                Id = Guid.NewGuid(),
                Email = data.email,
                Password = data.password,

            };
            var playerStat = new PlayerStat();
            playerStat.PlayerId = player.Id;
            playerStat.Player = player;
            player.PlayerStat = playerStat;
            await _context.Players.AddAsync(player);
            await _context.SaveChangesAsync();
            return Ok(await _context.Players.Include(x => x.PlayerStat).ToListAsync());

        }

        [HttpGet]
        public async Task<IActionResult> GetPlayer(string id)
        {
            var player = await _context.Players
                .Include(p => p.PlayerItems)
                .Include(p => p.PlayerStat)
                .FirstOrDefaultAsync(x => x.Id.Equals(Guid.Parse(id)));

            return Ok(player);
        }
    }
}
