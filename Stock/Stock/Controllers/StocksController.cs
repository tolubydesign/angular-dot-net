using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


// Initial
// namespace Stock.Controllers
// {
//     [Route("[controller]")]

//     public class StocksController : Controller
//     {
//         private readonly ILogger<StocksController> _logger;

//         public StocksController(ILogger<StocksController> logger)
//         {
//             _logger = logger;
//         }

//         public IActionResult Index()
//         {
//             return View();
//         }

//         [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//         public IActionResult Error()
//         {
//             return View("Error!");
//         }
//     }
// }

namespace Stock.Controllers;

// [Route("[controller]")]
[ApiController]

public class StocksController : ControllerBase
{

    [HttpPost]
    public IActionResult CreateBreakfast(CreateStockRequest request)
    {
        return Ok();
    }


}