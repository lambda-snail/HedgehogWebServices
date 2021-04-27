using Hedgehog.Core.Contracts;
using Hedgehog.Core.Domain.Requests;
using Hedgehog.UI.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Hedgehog.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ITestService _test;
        private readonly IMediator _mediator;

        public IHttpContextAccessor HttpContextAccessor { get; }

        public HomeController(ILogger<HomeController> logger, ITestService test, IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _test = test;
            _mediator = mediator;
            HttpContextAccessor = httpContextAccessor;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var x = HttpContextAccessor.HttpContext;
            var y = x.User;
            var userId = y.FindFirst(ClaimTypes.Email).Value;
            ViewBag.Message = "User Id: " + userId;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
