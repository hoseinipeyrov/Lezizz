﻿using Lezizz.Core.ApplicationService.Foods.Commands;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Lezizz.Presentation.Web.Controllers
{
    public class FoodsController : ApiController
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateFoodCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}