using Hedgehog.Core.Contracts;
using Hedgehog.Core.Domain.Requests;
using Hedgehog.UI.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Hedgehog.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ITestService _test;
        private readonly IMediator _mediator;

        public HomeController(ILogger<HomeController> logger, ITestService test, IMediator mediator)
        {
            _logger = logger;
            _test = test;
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Message = _test.GetMessage() + (await _mediator.Send(new TestServiceRequest())).GetMessage();
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
