using CommandMemo_Mvc.CS.Json;
using CommandMemo_Mvc.CS.Json.Logic;
using CommandMemo_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CommandMemo_Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Index画面
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            var home = new HomeModel();
            var commands = await GetCommands();

            if(commands.Any())
            {
                home.Titles = commands.Select(x => x.Title).ToList();
                home.Commands = commands[0].Contents;
                home.SelectedTitleIndex = 0;
            }
            return View(home);
        }

        /// <summary>
        /// Index画面 コマンド指定
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Index/{id?}")]
        public async Task<IActionResult> Index(int? id)
        {
            var home = new HomeModel();
            var commands = await GetCommands();

            if (commands.Any() && commands.Length > id)
            {
                home.Titles = commands.Select(x => x.Title).ToList();
                home.Commands = commands[id.Value].Contents;
                home.SelectedTitleIndex = id;
            }
            return View(home);
        }

        /// <summary>
        /// コマンド集を取得
        /// </summary>
        /// <returns></returns>
        private async Task<CommandJsonModel[]> GetCommands()
        {
            var jsonBase = new JsonBase();
            var filePaths = jsonBase.GetJsonFilePaths();
            return await Task.WhenAll(filePaths.Select(async filePath => await jsonBase.ReadCommandJson(filePath)));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
