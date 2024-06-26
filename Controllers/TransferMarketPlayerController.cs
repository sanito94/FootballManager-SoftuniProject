﻿using FootballManager_SoftuniProject.Core.Contracts.TransferMarket;
using FootballManager_SoftuniProject.Core.Extensions;
using FootballManager_SoftuniProject.Core.Models.Manager;
using FootballManager_SoftuniProject.Core.Models.Player;
using FootballManager_SoftuniProject.Core.Models.TransferMarketPlayer;
using FootballManager_SoftuniProject.Core.Services;
using FootballManager_SoftuniProject.Data;
using FootballManager_SoftuniProject.Infrastructure.Constants;
using FootballManager_SoftuniProject.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Globalization;
using System.Security.Claims;

namespace FootballManager_SoftuniProject.Controllers
{
    public class TransferMarketPlayerController : Controller
    {
        private readonly FootballManagerDbContext context;
        private readonly ITransferMarketService playerService;

        public TransferMarketPlayerController(FootballManagerDbContext _context, ITransferMarketService _playerService)
        {
            context = _context;
            playerService = _playerService;
        }

        [HttpGet]
        public async Task<IActionResult> AllSearch([FromQuery] AllPlayersQueryModel model)
        {
            var player = await playerService.AllAsync(
                model.SearchTerm,
                model.Sorting,
                model.CurrentPage,
                model.PlayersPerPage);

            model.TotalPlayersCount = player.TotalPlayersCount;
            model.Players = player.Players;

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AddPlayersToMarket(int id)
        {
            var model = await context.Players.Where(p => p.Id == id)
                .AsNoTracking()
                .Select(p => new TransferMarketPlayerAddViewModel()
                {
                    Name = p.Name,
                    Age = p.Age,
                    Country = p.Country,
                    Position = p.Position,
                    Price = p.Price,
                    PlayerId = id
                })
                .FirstOrDefaultAsync();


            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddPlayersToMarket(TransferMarketPlayerAddViewModel model, int id)
        {
            var player = await context.TranferMarketPlayers.FirstOrDefaultAsync(p => p.PlayerId == id);

            if (player != null)
            {
                return RedirectToAction("Error404PlayerExistOnMarket", "Error");
            }

            if (!ModelState.IsValid)
            {
                throw new ArgumentException("error with the ModelState");
            }

            var playerr = new TransferMarketPlayer()
            {
                Name = model.Name,
                Age = model.Age,
                Country = model.Country,
                FromUserId = GetUserId(),
                Position = model.Position,
                Price = model.Price,
                PlayerId = id
            };

            await context.TranferMarketPlayers.AddAsync(playerr);
            await context.SaveChangesAsync();

            return RedirectToAction("AllSearch", "TransferMarketPlayer");
        }



        [HttpPost]
        public async Task<IActionResult> BuyPlayer(int id)
        {
            var transferPlayer = await context.TranferMarketPlayers
                .Where(tp => tp.Id == id)
                .FirstOrDefaultAsync();

            if (transferPlayer == null)
            {
                throw new ArgumentException("Couldn't find Transfer Market Player");
            }

            var playerr = await context.Players
                .Where(p => p.Id == transferPlayer.PlayerId)
                .FirstOrDefaultAsync();

            var managerBuyer = await context.Managers
                .Where(m => m.UserId == GetUserId())
                .FirstOrDefaultAsync();

            if (managerBuyer == null)
            {
                throw new ArgumentException("Couldn't find the Manager");
            }

            var managerSeller = await context.Managers
                .Where(m => m.UserId == playerr.UserId)
                .FirstOrDefaultAsync();


            playerr.UserId = managerBuyer.UserId;
            playerr.ManagerId = managerBuyer.Id;
            playerr.TeamId = managerBuyer.TeamId;
            managerBuyer.StartingGold -= transferPlayer.Price;
            managerSeller.StartingGold += transferPlayer.Price;

            context.TranferMarketPlayers.Remove(transferPlayer);
            await context.SaveChangesAsync();

            return RedirectToAction(nameof(AllSearch));
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id, string information)
        {
            var managers = await context.Managers
                .ToArrayAsync();

            var player = await context.TranferMarketPlayers
                .Where(p => p.Id == id)
                .AsNoTracking()
                .Select(p => new TransferMarketPlayerDetailsViewModel()
                {
                    Name = p.Name,
                    Age = p.Age,
                    Country = p.Country,
                    Position = p.Position,
                    Price = p.Price,
                    FromUserId = p.FromUserId
                })
                .FirstOrDefaultAsync();

            if (player == null)
            {
                return BadRequest();
            }

            if (information != player.GetInformation())
            {
                return BadRequest();
            }

            foreach (var manager in managers)
            {
                if (manager.UserId == player.FromUserId)
                {
                    player.ManagerName = manager.Name;
                    break;
                }
            }

            return View(player);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var player = await context.TranferMarketPlayers
                .Where(p => p.Id == id)
                .AsNoTracking()
                .Select(p => new TransferMarketPlayerEditViewModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Age = p.Age,
                    Country = p.Country,
                    Position = p.Position,
                    Price = p.Price,
                })
                .FirstOrDefaultAsync();


            return View(player);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, TransferMarketPlayerEditViewModel model)
        {
            var player = await context.TranferMarketPlayers
                .FindAsync(id);

            if (player == null)
            {
                throw new ArgumentException("Error with the Edit Action");
            }

            if (!ModelState.IsValid)
            {
                throw new ArgumentException("Error with Edit Action");
            }

            if (player.FromUserId != GetUserId())
            {
                return Unauthorized();
            }

            player.Price = model.Price;

            await context.SaveChangesAsync();

            return RedirectToAction(nameof(AllSearch));
        }

        [HttpGet]
        public async Task<IActionResult> DeletePlayer(int id)
        {
            var player = await context.TranferMarketPlayers
                .Where(s => s.Id == id)
                .FirstOrDefaultAsync();

            if (player == null)
            {
                return BadRequest();
            }

            string currentUserId = GetUserId();

            if (currentUserId != player.FromUserId)
            {
                return Unauthorized();
            }

            var seminarToDelete = new DeletePlayerViewModel()
            {
                Id = id,
                Name = player.Name,
            };

            return View(seminarToDelete);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(DeletePlayerViewModel model)
        {
            var player = await context.TranferMarketPlayers
                .Where(s => s.Id == model.Id)
                .FirstOrDefaultAsync();

            if (player == null)
            {
                return BadRequest();
            }

            context.TranferMarketPlayers.Remove(player);
            await context.SaveChangesAsync();

            return RedirectToAction(nameof(AllSearch));

        }


        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
