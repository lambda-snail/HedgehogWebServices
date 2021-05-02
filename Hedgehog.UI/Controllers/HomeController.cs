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
    /// <summary>
    /// The controlelr that manages the default screen presented when navigating to the base url.
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;

        public IHttpContextAccessor HttpContextAccessor { get; }

        public HomeController(ILogger<HomeController> logger, IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _mediator = mediator;
            HttpContextAccessor = httpContextAccessor;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
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
