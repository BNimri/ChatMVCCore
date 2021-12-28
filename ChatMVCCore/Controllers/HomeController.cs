using ChatMVCCore.Data;
using ChatMVCCore.Hubs;
using ChatMVCCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ChatMVCCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly MessageContext _messageContext;
        public HomeController(MessageContext context)
        {
            _messageContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index([Bind("Sender,Receiver,MessageDetails")] MessageModel msgModel)
        {
            if (ModelState.IsValid)
            {
                _messageContext.Add(msgModel);
                await _messageContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(msgModel);
        }


        [HttpGet]
        public async Task<IActionResult> GetAllMesasges()
        {
            return PartialView(await _messageContext.Messages.ToListAsync());
        }

   
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
